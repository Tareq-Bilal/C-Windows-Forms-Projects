using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enLevel { Easy = 1 , Meduim  , Hard , Mix }
        enum enOperation { Plus = 1 , Subtraction , Multiplication , Division , Mix }

        int CorrectAnswer = 0;
        private struct stGmaInfo{

            public int NumberOfQuestions;
            public string Level;
            public string Operation;
            public int CorrectAnswers;
            public int WrongAnswers;
            public int Remaining;
            public int Time;
            public int TimeCounter1;
            public int TimeCounter2;


        }
        stGmaInfo info = new stGmaInfo();
        private void Form1_Load(object sender, EventArgs e)
        {
           PanelCorrectAndWrong.Visible = false;
            PanelQuestionsShow.Visible = false;
            PanelMainMenu.Location = new Point(438, 116);
            lblTitle.Location = new Point(430, 9);
            btnNext.Visible = false;
            lblTime1.Visible = false;
            lblTime2.Visible = false;
            lblColoun.Visible = false;
            //1313, 713
            this.Size = new Size(1000 , 600);
            lblTitle.Location = new Point(300 , 20);
            PanelMainMenu.Location = new Point(330, 100);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            info.NumberOfQuestions = (int)numericUpDown1.Value;
        }

        private void cbQuestionsLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.Level = cbQuestionsLevel.SelectedItem.ToString();
        }

        private void cbOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.Operation = cbOperationType.SelectedItem.ToString();
        }

        private void ShiftTheQuestionPanel()
        {

            PanelQuestionsShow.Location = new Point(280, 116);
        }

        private void ShowTimer()
        {

            info.Time = (int)numericTime.Value;
            lblTime1.Visible = true;
            lblTime2.Visible = true;
            lblColoun.Visible = true;
            lblTime1.Text = Convert.ToString(info.TimeCounter1);
            timer1.Start();

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //1313, 713
            this.Size = new Size(1313, 713);
            //570, 20
            lblTitle.Location = new Point(500, 20);
            lblCurrentRemaining.Text = info.NumberOfQuestions.ToString();
            lblCurrentOperation.Text = info.Operation;
            lblCurrentLevel.Text = info.Level;
            PanelMainMenu.Hide();
            ShiftTheQuestionPanel();
            PanelCorrectAndWrong.Visible = true;
            PanelQuestionsShow.Visible = true;
            info.Remaining = (int)numericUpDown1.Value;
            lblCurrentRemaining.Text = Convert.ToString(info.NumberOfQuestions);
            ShowTimer();
            GenerateQuestion(info.Level , info.Operation);

    

        }
        bool IsTimerEnd()
        {

            return (info.TimeCounter2 == info.Time ? true : false) ;

        }
        int GetRandomOperation()
        {
            int op  = 0;


            //Random rnd = new Random();
            var rnd = new Random(DateTime.Now.Millisecond);
            op = rnd.Next((int)enOperation.Plus, (int)enOperation.Mix);

            return op;
        }
        char GetTheOperation(enOperation Operation)
        {
            char op = ' ';

            switch (Operation)
            {

                case enOperation.Plus:
                    op =  '+';
                    break;

                case enOperation.Subtraction:
                    op =  '-';
                    break;

                case enOperation.Multiplication:
                    op = '*';
                    break;

                case enOperation.Division:
                    op = '/';
                    break;

                case enOperation.Mix:
                    {
                        int O = GetRandomOperation();
                        op = GetTheOperation((enOperation)O);
                        break;

                    }
                 

            }

            return op;
        }
        enOperation ConvertFromStringToenOperation(string sOperation)
        {

            enOperation op = enOperation.Plus;

            switch (sOperation)
            {
                case "Plus":
                    op = enOperation.Plus;
                    break;
                case "Subtraction":
                    op = enOperation.Subtraction;
                    break;
                case "Multiplication":
                    op = enOperation.Multiplication;
                    break;
                case "Division":
                    op = enOperation.Division;
                    break;
                case "Mix":
                    op = enOperation.Mix;
                    break;

            }

            return op;
        }
        enLevel ConvertFromStringToenLevel(string sLevel)
        {

            enLevel level = enLevel.Easy;

            switch (sLevel)
            {
                case "Easy":
                    level = enLevel.Easy;
                    break;
                case "Meduim":
                    level = enLevel.Meduim;
                    break;
                case "Hard":
                    level = enLevel.Hard;
                    break;
                case "Mix":
                    level = enLevel.Mix;
                    break;

            }

            return level;
        }
        int GeneratePart(enLevel Level)
        {
            int Part = 0;
            var rnd = new Random(DateTime.Now.Millisecond);
           // Random rnd  = new Random();
            switch (Level)
            {

               case enLevel.Easy:
               Part = rnd.Next(1, 100);
               break;

               case enLevel.Meduim:
               Part = rnd.Next(100, 200);
               break;

               case enLevel.Hard:
               Part = rnd.Next(200, 2000);
               break;

               case enLevel.Mix:
               Part = rnd.Next(GeneratePart(enLevel.Easy),GeneratePart(enLevel.Hard));
               break;

            }

            return Part;
        }
        bool CheckAnswer(int PlayerAnswer)
        {

            return (PlayerAnswer == CorrectAnswer ? true : false);

        }

        int SolveQuestion(int Part1, int Part2, char Op)
        {

            switch(Op)
            {

                case '+':
                    return (Part1 + Part2);
                case '-':
                    return (Part1 - Part2);
                case '*':
                    return (Part1 * Part2);
                case '/':
                    return (Part1 / Part2);
            }
            return 0;
        }

        void GenerateWrongAnswers(int TrueAnsewrPlace, enLevel Level)
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            Button[] ArrayOfButtons = { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };

            for (int i = 0; i < 4; i++)
            {

                if ((i + 1) != TrueAnsewrPlace)
                {
                    ArrayOfButtons[i].Text = Convert.ToString(rnd.Next(0 , 1000));
                }

            }

        }

        void GenerateQuestion(string Level , string Operation)
        {
            int Part1 = GeneratePart(ConvertFromStringToenLevel(Level));
            int Part2 = GeneratePart(ConvertFromStringToenLevel(Level));
            char Op = GetTheOperation(ConvertFromStringToenOperation(Operation));
            while (Part1 == Part2)
            {
                Part2 = GeneratePart(ConvertFromStringToenLevel(Level));
            }

            if (Operation == "Division" && Part1 < Part2)
            {
                Random random = new Random();
                Part1 = ((Part1 + GeneratePart(ConvertFromStringToenLevel(Level)) * GeneratePart(ConvertFromStringToenLevel(Level))));

            }

            lblPart1.Text = Convert.ToString(Part1);
            lblOperation.Text = Convert.ToString(Op);
            lblPart2.Text = Convert.ToString(Part2);
            CorrectAnswer = SolveQuestion(Part1, Part2, Op);
            int TrueAnserPlace = PutTheCorrectAnwser(CorrectAnswer);
            GenerateWrongAnswers(TrueAnserPlace, ConvertFromStringToenLevel(Level));

        }

        int PutTheCorrectAnwser(int CorrectAnwser)
        {

            var rnd = new Random(DateTime.Now.Millisecond);
            int Place  = rnd.Next(1 , 4);

           switch(Place)
            {

               case 1:
                    {
                        btnAnswer1.Text = Convert.ToString(CorrectAnwser);
                        btnAnswer1.Tag = Convert.ToString(CorrectAnwser);
                        break;

                    }
                case 2:
                    {
                        btnAnswer2.Text = Convert.ToString(CorrectAnwser);
                        btnAnswer2.Tag = Convert.ToString(CorrectAnwser);
                        break;

                    }
                case 3:
                    {
                        btnAnswer3.Text = Convert.ToString(CorrectAnwser);
                        btnAnswer3.Tag = Convert.ToString(CorrectAnwser);
                        break;

                    }
                case 4:
                    {
                        btnAnswer4.Text = Convert.ToString(CorrectAnwser);
                        btnAnswer4.Tag = Convert.ToString(CorrectAnwser);
                        break;

                    }
            }
            return Place;

        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(Convert.ToInt32(btnAnswer3.Tag))){

                btnAnswer3.BackColor = Color.Green;
                info.CorrectAnswers++;
                info.Remaining--;
                lblCurrentRemaining.Text = Convert.ToString(info.Remaining);
                lblCorrect.Text = Convert.ToString(info.CorrectAnswers);
                NextOrGameOver();
                return;

            }

            else
            {

                btnAnswer3.BackColor = Color.Red;
                info.WrongAnswers++;
                info.Remaining--;
                lblCurrentRemaining.Text = Convert.ToString(info.Remaining);
                lblWrong.Text = Convert.ToString(info.WrongAnswers);
                NextOrGameOver();
                return;

            }
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(Convert.ToInt32(btnAnswer2.Tag)))
            {

                btnAnswer2.BackColor = Color.Green;
                info.CorrectAnswers++;
                info.Remaining--;
                lblCurrentRemaining.Text = Convert.ToString(info.Remaining);
                lblCorrect.Text = Convert.ToString(info.CorrectAnswers);
                NextOrGameOver();
                return;

            }

            else
            {

                btnAnswer2.BackColor = Color.Red;
                info.WrongAnswers++;
                info.Remaining--;
                lblCurrentRemaining.Text = Convert.ToString(info.Remaining);
                lblWrong.Text = Convert.ToString(info.WrongAnswers);
                NextOrGameOver();
                return;

            }
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(Convert.ToInt32(btnAnswer1.Tag)))
            {

                btnAnswer1.BackColor = Color.Green;
                info.CorrectAnswers++;
                info.Remaining--;
                lblCurrentRemaining.Text = Convert.ToString(info.Remaining);
                lblCorrect.Text = Convert.ToString(info.CorrectAnswers);
                NextOrGameOver();
                return;

            }

            else
            {

                btnAnswer1.BackColor = Color.Red;
                info.WrongAnswers++;
                info.Remaining--;
                lblCurrentRemaining.Text = Convert.ToString(info.Remaining);
                lblWrong.Text = Convert.ToString(info.WrongAnswers);
                NextOrGameOver();
                return;

            }


        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(Convert.ToInt32(btnAnswer4.Tag)))
            {

                btnAnswer4.BackColor = Color.Green;
                info.CorrectAnswers++;
                info.Remaining--;
                lblCurrentRemaining.Text = Convert.ToString(info.Remaining);
                lblCorrect.Text = Convert.ToString(info.CorrectAnswers);
                NextOrGameOver();
                return;

            }

            else
            {

                btnAnswer4.BackColor = Color.Red;
                info.WrongAnswers++;
                info.Remaining--;
                lblCurrentRemaining.Text = Convert.ToString(info.Remaining);
                lblWrong.Text = Convert.ToString(info.WrongAnswers);
                NextOrGameOver();
                return;

            }


        }

        void NextOrGameOver()
        {
            PanelButtons.Enabled = false;

            if (info.Remaining != 0)
                btnNext.Visible = true;

            else if (info.Remaining == 0)
            {
                ShowGameOver();
                timer1.Stop();  
            }
        }
        void RestButtonsColor()
        {

            foreach(Button button in PanelButtons.Controls)
            {

                button.BackColor = Color.DarkGray;

            }


        }

        void ShowGameOver()
        {
            DialogResult = MessageBox.Show(
    "\n---------- Game Over ----------\n"
    + "\nNumber Of Questions : " + info.NumberOfQuestions
    + "\nCorrect Answer(s) : " + info.CorrectAnswers
    + "\nWrong   Answer(s) : " + info.WrongAnswers
    + "\n-----------------------------\n"
    , "Game Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

            switch (DialogResult)
            {
                case DialogResult.Retry:
                    {
                        Application.ExitThread();
                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                        break;

                    }

                case DialogResult.Cancel:
                    {
                        this.Close();
                        break;

                    }

            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (info.Remaining != 0)
            {
                GenerateQuestion(info.Level, info.Operation);
                PanelButtons.Enabled = true;
                RestButtonsColor();
            }

            else
            {

                btnNext.Visible = false;
                ShowGameOver();

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            info.TimeCounter1++;
            if(info.TimeCounter1 == 60) {
                info.TimeCounter2++;
                info.TimeCounter1 = 0;
                lblTime2.Text = info.TimeCounter2.ToString();

            }
            lblTime1.Text = info.TimeCounter1.ToString();

            if (IsTimerEnd())
            {
                timer1.Stop();
                ShowGameOver();

            }
        }


    }
}
