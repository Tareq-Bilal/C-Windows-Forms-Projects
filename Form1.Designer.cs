namespace Math_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.cbQuestionsLevel = new System.Windows.Forms.ComboBox();
            this.lblQuestionLevel = new System.Windows.Forms.Label();
            this.lblOperationType = new System.Windows.Forms.Label();
            this.cbOperationType = new System.Windows.Forms.ComboBox();
            this.PanelMainMenu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericTime = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.PanelQuestionsShow = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelCorrectAndWrong = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblCurrentOperation = new System.Windows.Forms.Label();
            this.lblCurrentLevel = new System.Windows.Forms.Label();
            this.lblCurrentRemaining = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPart2 = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblPart1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblQuestionRemaining = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblColoun = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.PanelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTime)).BeginInit();
            this.PanelQuestionsShow.SuspendLayout();
            this.PanelButtons.SuspendLayout();
            this.PanelCorrectAndWrong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Felix Titling", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(570, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(432, 74);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Math Game";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(271, 28);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 33);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfQuestions.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(3, 35);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(262, 23);
            this.lblNumberOfQuestions.TabIndex = 2;
            this.lblNumberOfQuestions.Text = "Number Of Questions :";
            // 
            // cbQuestionsLevel
            // 
            this.cbQuestionsLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuestionsLevel.Font = new System.Drawing.Font("Unispace", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestionsLevel.FormattingEnabled = true;
            this.cbQuestionsLevel.Items.AddRange(new object[] {
            "Easy",
            "Meduim",
            "Hard",
            "Mix"});
            this.cbQuestionsLevel.Location = new System.Drawing.Point(235, 102);
            this.cbQuestionsLevel.Name = "cbQuestionsLevel";
            this.cbQuestionsLevel.Size = new System.Drawing.Size(177, 28);
            this.cbQuestionsLevel.TabIndex = 3;
            this.cbQuestionsLevel.SelectedIndexChanged += new System.EventHandler(this.cbQuestionsLevel_SelectedIndexChanged);
            // 
            // lblQuestionLevel
            // 
            this.lblQuestionLevel.AutoSize = true;
            this.lblQuestionLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionLevel.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionLevel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuestionLevel.Location = new System.Drawing.Point(3, 107);
            this.lblQuestionLevel.Name = "lblQuestionLevel";
            this.lblQuestionLevel.Size = new System.Drawing.Size(226, 23);
            this.lblQuestionLevel.TabIndex = 4;
            this.lblQuestionLevel.Text = "Questions  Level :";
            // 
            // lblOperationType
            // 
            this.lblOperationType.AutoSize = true;
            this.lblOperationType.BackColor = System.Drawing.Color.Transparent;
            this.lblOperationType.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOperationType.Location = new System.Drawing.Point(3, 179);
            this.lblOperationType.Name = "lblOperationType";
            this.lblOperationType.Size = new System.Drawing.Size(226, 23);
            this.lblOperationType.TabIndex = 6;
            this.lblOperationType.Text = "Operation Type   :";
            // 
            // cbOperationType
            // 
            this.cbOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperationType.Font = new System.Drawing.Font("Unispace", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperationType.FormattingEnabled = true;
            this.cbOperationType.Items.AddRange(new object[] {
            "Plus",
            "Subtraction",
            "Multiplication",
            "Division",
            "Mix"});
            this.cbOperationType.Location = new System.Drawing.Point(235, 178);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(177, 28);
            this.cbOperationType.TabIndex = 5;
            this.cbOperationType.SelectedIndexChanged += new System.EventHandler(this.cbOperationType_SelectedIndexChanged);
            // 
            // PanelMainMenu
            // 
            this.PanelMainMenu.Controls.Add(this.label5);
            this.PanelMainMenu.Controls.Add(this.numericTime);
            this.PanelMainMenu.Controls.Add(this.btnStart);
            this.PanelMainMenu.Controls.Add(this.lblOperationType);
            this.PanelMainMenu.Controls.Add(this.cbOperationType);
            this.PanelMainMenu.Controls.Add(this.lblNumberOfQuestions);
            this.PanelMainMenu.Controls.Add(this.numericUpDown1);
            this.PanelMainMenu.Controls.Add(this.lblQuestionLevel);
            this.PanelMainMenu.Controls.Add(this.cbQuestionsLevel);
            this.PanelMainMenu.Location = new System.Drawing.Point(12, 209);
            this.PanelMainMenu.Name = "PanelMainMenu";
            this.PanelMainMenu.Size = new System.Drawing.Size(420, 434);
            this.PanelMainMenu.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(13, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Time in Minutes :";
            // 
            // numericTime
            // 
            this.numericTime.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTime.Location = new System.Drawing.Point(244, 249);
            this.numericTime.Name = "numericTime";
            this.numericTime.Size = new System.Drawing.Size(87, 33);
            this.numericTime.TabIndex = 9;
            this.numericTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(137, 351);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 58);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PanelQuestionsShow
            // 
            this.PanelQuestionsShow.Controls.Add(this.btnNext);
            this.PanelQuestionsShow.Controls.Add(this.PanelButtons);
            this.PanelQuestionsShow.Controls.Add(this.label4);
            this.PanelQuestionsShow.Controls.Add(this.label3);
            this.PanelQuestionsShow.Controls.Add(this.PanelCorrectAndWrong);
            this.PanelQuestionsShow.Controls.Add(this.lblCurrentOperation);
            this.PanelQuestionsShow.Controls.Add(this.lblCurrentLevel);
            this.PanelQuestionsShow.Controls.Add(this.lblCurrentRemaining);
            this.PanelQuestionsShow.Controls.Add(this.label2);
            this.PanelQuestionsShow.Controls.Add(this.lblPart2);
            this.PanelQuestionsShow.Controls.Add(this.lblOperation);
            this.PanelQuestionsShow.Controls.Add(this.lblPart1);
            this.PanelQuestionsShow.Controls.Add(this.label1);
            this.PanelQuestionsShow.Controls.Add(this.lblLevel);
            this.PanelQuestionsShow.Controls.Add(this.lblQuestionRemaining);
            this.PanelQuestionsShow.Location = new System.Drawing.Point(438, 116);
            this.PanelQuestionsShow.Name = "PanelQuestionsShow";
            this.PanelQuestionsShow.Size = new System.Drawing.Size(847, 513);
            this.PanelQuestionsShow.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Yellow;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(591, 408);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 58);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "--->";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.btnAnswer1);
            this.PanelButtons.Controls.Add(this.btnAnswer2);
            this.PanelButtons.Controls.Add(this.btnAnswer3);
            this.PanelButtons.Controls.Add(this.btnAnswer4);
            this.PanelButtons.Location = new System.Drawing.Point(145, 316);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(432, 194);
            this.PanelButtons.TabIndex = 31;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnswer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnswer1.FlatAppearance.BorderSize = 2;
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.ForeColor = System.Drawing.Color.Black;
            this.btnAnswer1.Location = new System.Drawing.Point(58, 30);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(111, 58);
            this.btnAnswer1.TabIndex = 9;
            this.btnAnswer1.Text = "Answer1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnswer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnswer2.FlatAppearance.BorderSize = 2;
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.ForeColor = System.Drawing.Color.Black;
            this.btnAnswer2.Location = new System.Drawing.Point(283, 30);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(111, 58);
            this.btnAnswer2.TabIndex = 16;
            this.btnAnswer2.Text = "Answer2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnswer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnswer3.FlatAppearance.BorderSize = 2;
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.ForeColor = System.Drawing.Color.Black;
            this.btnAnswer3.Location = new System.Drawing.Point(58, 128);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(111, 58);
            this.btnAnswer3.TabIndex = 18;
            this.btnAnswer3.Text = "Answer3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnswer4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnswer4.FlatAppearance.BorderSize = 2;
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.ForeColor = System.Drawing.Color.Black;
            this.btnAnswer4.Location = new System.Drawing.Point(283, 128);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(111, 58);
            this.btnAnswer4.TabIndex = 17;
            this.btnAnswer4.Text = "Answer4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(499, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 58);
            this.label4.TabIndex = 30;
            this.label4.Text = "|\r\n|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(258, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 58);
            this.label3.TabIndex = 29;
            this.label3.Text = "|\r\n|";
            // 
            // PanelCorrectAndWrong
            // 
            this.PanelCorrectAndWrong.Controls.Add(this.pictureBox1);
            this.PanelCorrectAndWrong.Controls.Add(this.pictureBox2);
            this.PanelCorrectAndWrong.Controls.Add(this.lblWrong);
            this.PanelCorrectAndWrong.Controls.Add(this.lblCorrect);
            this.PanelCorrectAndWrong.Location = new System.Drawing.Point(625, 128);
            this.PanelCorrectAndWrong.Name = "PanelCorrectAndWrong";
            this.PanelCorrectAndWrong.Size = new System.Drawing.Size(200, 229);
            this.PanelCorrectAndWrong.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWrong.Location = new System.Drawing.Point(142, 159);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(51, 25);
            this.lblWrong.TabIndex = 24;
            this.lblWrong.Text = "---";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorrect.Location = new System.Drawing.Point(142, 43);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(51, 25);
            this.lblCorrect.TabIndex = 25;
            this.lblCorrect.Text = "---";
            // 
            // lblCurrentOperation
            // 
            this.lblCurrentOperation.AutoSize = true;
            this.lblCurrentOperation.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentOperation.Font = new System.Drawing.Font("Unispace", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOperation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentOperation.Location = new System.Drawing.Point(696, 28);
            this.lblCurrentOperation.Name = "lblCurrentOperation";
            this.lblCurrentOperation.Size = new System.Drawing.Size(39, 20);
            this.lblCurrentOperation.TabIndex = 21;
            this.lblCurrentOperation.Text = "---";
            // 
            // lblCurrentLevel
            // 
            this.lblCurrentLevel.AutoSize = true;
            this.lblCurrentLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentLevel.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLevel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentLevel.Location = new System.Drawing.Point(416, 26);
            this.lblCurrentLevel.Name = "lblCurrentLevel";
            this.lblCurrentLevel.Size = new System.Drawing.Size(46, 23);
            this.lblCurrentLevel.TabIndex = 20;
            this.lblCurrentLevel.Text = "---";
            // 
            // lblCurrentRemaining
            // 
            this.lblCurrentRemaining.AutoSize = true;
            this.lblCurrentRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentRemaining.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRemaining.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentRemaining.Location = new System.Drawing.Point(184, 26);
            this.lblCurrentRemaining.Name = "lblCurrentRemaining";
            this.lblCurrentRemaining.Size = new System.Drawing.Size(46, 23);
            this.lblCurrentRemaining.TabIndex = 19;
            this.lblCurrentRemaining.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(205, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 50);
            this.label2.TabIndex = 15;
            this.label2.Text = "_______________";
            // 
            // lblPart2
            // 
            this.lblPart2.AutoSize = true;
            this.lblPart2.BackColor = System.Drawing.Color.Transparent;
            this.lblPart2.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPart2.Location = new System.Drawing.Point(279, 213);
            this.lblPart2.Name = "lblPart2";
            this.lblPart2.Size = new System.Drawing.Size(145, 50);
            this.lblPart2.TabIndex = 14;
            this.lblPart2.Text = "Part2";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.BackColor = System.Drawing.Color.Transparent;
            this.lblOperation.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOperation.Location = new System.Drawing.Point(209, 168);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(55, 36);
            this.lblOperation.TabIndex = 13;
            this.lblOperation.Text = "Op";
            // 
            // lblPart1
            // 
            this.lblPart1.AutoSize = true;
            this.lblPart1.BackColor = System.Drawing.Color.Transparent;
            this.lblPart1.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPart1.Location = new System.Drawing.Point(279, 93);
            this.lblPart1.Name = "lblPart1";
            this.lblPart1.Size = new System.Drawing.Size(144, 50);
            this.lblPart1.TabIndex = 12;
            this.lblPart1.Text = "Part1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(524, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Operation :";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLevel.Location = new System.Drawing.Point(305, 19);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(118, 29);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "Level :";
            // 
            // lblQuestionRemaining
            // 
            this.lblQuestionRemaining.AutoSize = true;
            this.lblQuestionRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionRemaining.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionRemaining.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuestionRemaining.Location = new System.Drawing.Point(14, 19);
            this.lblQuestionRemaining.Name = "lblQuestionRemaining";
            this.lblQuestionRemaining.Size = new System.Drawing.Size(178, 29);
            this.lblQuestionRemaining.TabIndex = 11;
            this.lblQuestionRemaining.Text = "Remaining :";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1491254392-falsecrossrejectdecline_82951.ico");
            this.imageList1.Images.SetKeyName(1, "1491254409-truecheckacceptapprove_82933.ico");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.BackColor = System.Drawing.Color.Transparent;
            this.lblTime1.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime1.Location = new System.Drawing.Point(191, 64);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(60, 42);
            this.lblTime1.TabIndex = 32;
            this.lblTime1.Text = "00";
            // 
            // lblColoun
            // 
            this.lblColoun.AutoSize = true;
            this.lblColoun.BackColor = System.Drawing.Color.Transparent;
            this.lblColoun.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColoun.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblColoun.Location = new System.Drawing.Point(152, 64);
            this.lblColoun.Name = "lblColoun";
            this.lblColoun.Size = new System.Drawing.Size(39, 42);
            this.lblColoun.TabIndex = 33;
            this.lblColoun.Text = ":";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.BackColor = System.Drawing.Color.Transparent;
            this.lblTime2.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime2.Location = new System.Drawing.Point(92, 64);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(60, 42);
            this.lblTime2.TabIndex = 34;
            this.lblTime2.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1297, 674);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblColoun);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.PanelQuestionsShow);
            this.Controls.Add(this.PanelMainMenu);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.PanelMainMenu.ResumeLayout(false);
            this.PanelMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTime)).EndInit();
            this.PanelQuestionsShow.ResumeLayout(false);
            this.PanelQuestionsShow.PerformLayout();
            this.PanelButtons.ResumeLayout(false);
            this.PanelCorrectAndWrong.ResumeLayout(false);
            this.PanelCorrectAndWrong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.ComboBox cbQuestionsLevel;
        private System.Windows.Forms.Label lblQuestionLevel;
        private System.Windows.Forms.Label lblOperationType;
        private System.Windows.Forms.ComboBox cbOperationType;
        private System.Windows.Forms.Panel PanelMainMenu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel PanelQuestionsShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblQuestionRemaining;
        private System.Windows.Forms.Label lblPart1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblPart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Label lblCurrentRemaining;
        private System.Windows.Forms.Label lblCurrentLevel;
        private System.Windows.Forms.Label lblCurrentOperation;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelCorrectAndWrong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericTime;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblColoun;
        private System.Windows.Forms.Label lblTime2;
    }
}

