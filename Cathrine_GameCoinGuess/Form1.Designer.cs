namespace Cathrine_GameCoinGuess
{
    partial class FormGuessTheCoinFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuessTheCoinFace));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUrMoney = new System.Windows.Forms.Label();
            this.pictureBoxCoin = new System.Windows.Forms.PictureBox();
            this.labelHeadTail = new System.Windows.Forms.Label();
            this.buttonStartRestart = new System.Windows.Forms.Button();
            this.labelBet = new System.Windows.Forms.Label();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.groupBoxGuess = new System.Windows.Forms.GroupBox();
            this.radioButtonHead = new System.Windows.Forms.RadioButton();
            this.radioButtonTail = new System.Windows.Forms.RadioButton();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelDisplayMoney = new System.Windows.Forms.Label();
            this.labelDisplayComment = new System.Windows.Forms.Label();
            this.labelNumberGuess = new System.Windows.Forms.Label();
            this.labelCorrectGuess = new System.Windows.Forms.Label();
            this.labelPercentageCorrect = new System.Windows.Forms.Label();
            this.labelShowGuess = new System.Windows.Forms.Label();
            this.labelShowCorrect = new System.Windows.Forms.Label();
            this.labelShowPercentage = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelRp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).BeginInit();
            this.groupBoxGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Maroon;
            this.labelTitle.Location = new System.Drawing.Point(86, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(285, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Guess The Face of The Coin";
            // 
            // labelUrMoney
            // 
            this.labelUrMoney.AutoSize = true;
            this.labelUrMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelUrMoney.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrMoney.Location = new System.Drawing.Point(21, 102);
            this.labelUrMoney.Name = "labelUrMoney";
            this.labelUrMoney.Size = new System.Drawing.Size(90, 16);
            this.labelUrMoney.TabIndex = 1;
            this.labelUrMoney.Text = "Your Money:";
            // 
            // pictureBoxCoin
            // 
            this.pictureBoxCoin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin.BackgroundImage = global::Cathrine_GameCoinGuess.Properties.Resources.QuestionMark;
            this.pictureBoxCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCoin.Location = new System.Drawing.Point(27, 164);
            this.pictureBoxCoin.Name = "pictureBoxCoin";
            this.pictureBoxCoin.Size = new System.Drawing.Size(161, 152);
            this.pictureBoxCoin.TabIndex = 2;
            this.pictureBoxCoin.TabStop = false;
            // 
            // labelHeadTail
            // 
            this.labelHeadTail.AutoSize = true;
            this.labelHeadTail.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadTail.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadTail.ForeColor = System.Drawing.Color.DimGray;
            this.labelHeadTail.Location = new System.Drawing.Point(24, 144);
            this.labelHeadTail.Name = "labelHeadTail";
            this.labelHeadTail.Size = new System.Drawing.Size(93, 17);
            this.labelHeadTail.TabIndex = 3;
            this.labelHeadTail.Text = "Head or Tail?";
            // 
            // buttonStartRestart
            // 
            this.buttonStartRestart.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartRestart.Location = new System.Drawing.Point(323, 97);
            this.buttonStartRestart.Name = "buttonStartRestart";
            this.buttonStartRestart.Size = new System.Drawing.Size(115, 29);
            this.buttonStartRestart.TabIndex = 4;
            this.buttonStartRestart.Text = "Start/Restart";
            this.buttonStartRestart.UseVisualStyleBackColor = true;
            this.buttonStartRestart.Click += new System.EventHandler(this.buttonStartRestart_Click);
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.BackColor = System.Drawing.Color.Transparent;
            this.labelBet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBet.Location = new System.Drawing.Point(200, 183);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(89, 16);
            this.labelBet.TabIndex = 5;
            this.labelBet.Text = "Put your Bet:";
            // 
            // textBoxBet
            // 
            this.textBoxBet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBet.Location = new System.Drawing.Point(295, 180);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(108, 22);
            this.textBoxBet.TabIndex = 6;
            // 
            // groupBoxGuess
            // 
            this.groupBoxGuess.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGuess.Controls.Add(this.radioButtonTail);
            this.groupBoxGuess.Controls.Add(this.radioButtonHead);
            this.groupBoxGuess.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGuess.Location = new System.Drawing.Point(203, 206);
            this.groupBoxGuess.Name = "groupBoxGuess";
            this.groupBoxGuess.Size = new System.Drawing.Size(200, 99);
            this.groupBoxGuess.TabIndex = 7;
            this.groupBoxGuess.TabStop = false;
            this.groupBoxGuess.Text = "Select your Guess";
            // 
            // radioButtonHead
            // 
            this.radioButtonHead.AutoSize = true;
            this.radioButtonHead.Location = new System.Drawing.Point(19, 31);
            this.radioButtonHead.Name = "radioButtonHead";
            this.radioButtonHead.Size = new System.Drawing.Size(58, 20);
            this.radioButtonHead.TabIndex = 0;
            this.radioButtonHead.TabStop = true;
            this.radioButtonHead.Text = "Head";
            this.radioButtonHead.UseVisualStyleBackColor = true;
            // 
            // radioButtonTail
            // 
            this.radioButtonTail.AutoSize = true;
            this.radioButtonTail.Location = new System.Drawing.Point(19, 54);
            this.radioButtonTail.Name = "radioButtonTail";
            this.radioButtonTail.Size = new System.Drawing.Size(49, 20);
            this.radioButtonTail.TabIndex = 1;
            this.radioButtonTail.TabStop = true;
            this.radioButtonTail.Text = "Tail";
            this.radioButtonTail.UseVisualStyleBackColor = true;
            // 
            // buttonLock
            // 
            this.buttonLock.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLock.Location = new System.Drawing.Point(214, 313);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(75, 23);
            this.buttonLock.TabIndex = 8;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(298, 313);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(93, 23);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Submit Answer";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelDisplayMoney
            // 
            this.labelDisplayMoney.AutoSize = true;
            this.labelDisplayMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayMoney.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayMoney.Location = new System.Drawing.Point(161, 102);
            this.labelDisplayMoney.Name = "labelDisplayMoney";
            this.labelDisplayMoney.Size = new System.Drawing.Size(99, 16);
            this.labelDisplayMoney.TabIndex = 10;
            this.labelDisplayMoney.Text = "display money";
            // 
            // labelDisplayComment
            // 
            this.labelDisplayComment.AutoSize = true;
            this.labelDisplayComment.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayComment.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayComment.ForeColor = System.Drawing.Color.Maroon;
            this.labelDisplayComment.Location = new System.Drawing.Point(24, 366);
            this.labelDisplayComment.Name = "labelDisplayComment";
            this.labelDisplayComment.Size = new System.Drawing.Size(164, 16);
            this.labelDisplayComment.TabIndex = 11;
            this.labelDisplayComment.Text = "display  comment in here";
            // 
            // labelNumberGuess
            // 
            this.labelNumberGuess.AutoSize = true;
            this.labelNumberGuess.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberGuess.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumberGuess.Location = new System.Drawing.Point(24, 433);
            this.labelNumberGuess.Name = "labelNumberGuess";
            this.labelNumberGuess.Size = new System.Drawing.Size(141, 16);
            this.labelNumberGuess.TabIndex = 12;
            this.labelNumberGuess.Text = "The number of Guess:";
            // 
            // labelCorrectGuess
            // 
            this.labelCorrectGuess.AutoSize = true;
            this.labelCorrectGuess.BackColor = System.Drawing.Color.Transparent;
            this.labelCorrectGuess.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCorrectGuess.Location = new System.Drawing.Point(24, 458);
            this.labelCorrectGuess.Name = "labelCorrectGuess";
            this.labelCorrectGuess.Size = new System.Drawing.Size(194, 16);
            this.labelCorrectGuess.TabIndex = 13;
            this.labelCorrectGuess.Text = "The number of  Correct Guess:";
            // 
            // labelPercentageCorrect
            // 
            this.labelPercentageCorrect.AutoSize = true;
            this.labelPercentageCorrect.BackColor = System.Drawing.Color.Transparent;
            this.labelPercentageCorrect.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentageCorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPercentageCorrect.Location = new System.Drawing.Point(24, 484);
            this.labelPercentageCorrect.Name = "labelPercentageCorrect";
            this.labelPercentageCorrect.Size = new System.Drawing.Size(188, 16);
            this.labelPercentageCorrect.TabIndex = 14;
            this.labelPercentageCorrect.Text = "Percentage of  Correct Guess:";
            // 
            // labelShowGuess
            // 
            this.labelShowGuess.AutoSize = true;
            this.labelShowGuess.BackColor = System.Drawing.Color.Transparent;
            this.labelShowGuess.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelShowGuess.Location = new System.Drawing.Point(247, 433);
            this.labelShowGuess.Name = "labelShowGuess";
            this.labelShowGuess.Size = new System.Drawing.Size(79, 16);
            this.labelShowGuess.TabIndex = 15;
            this.labelShowGuess.Text = "show result";
            // 
            // labelShowCorrect
            // 
            this.labelShowCorrect.AutoSize = true;
            this.labelShowCorrect.BackColor = System.Drawing.Color.Transparent;
            this.labelShowCorrect.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowCorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelShowCorrect.Location = new System.Drawing.Point(247, 458);
            this.labelShowCorrect.Name = "labelShowCorrect";
            this.labelShowCorrect.Size = new System.Drawing.Size(79, 16);
            this.labelShowCorrect.TabIndex = 16;
            this.labelShowCorrect.Text = "show result";
            // 
            // labelShowPercentage
            // 
            this.labelShowPercentage.AutoSize = true;
            this.labelShowPercentage.BackColor = System.Drawing.Color.Transparent;
            this.labelShowPercentage.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelShowPercentage.Location = new System.Drawing.Point(247, 484);
            this.labelShowPercentage.Name = "labelShowPercentage";
            this.labelShowPercentage.Size = new System.Drawing.Size(79, 16);
            this.labelShowPercentage.TabIndex = 17;
            this.labelShowPercentage.Text = "show result";
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.BackColor = System.Drawing.Color.Transparent;
            this.labelPercentage.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPercentage.Location = new System.Drawing.Point(340, 484);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(18, 16);
            this.labelPercentage.TabIndex = 18;
            this.labelPercentage.Text = "%";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.Location = new System.Drawing.Point(115, 555);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 19;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(262, 555);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelRp
            // 
            this.labelRp.AutoSize = true;
            this.labelRp.BackColor = System.Drawing.Color.Transparent;
            this.labelRp.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRp.Location = new System.Drawing.Point(126, 102);
            this.labelRp.Name = "labelRp";
            this.labelRp.Size = new System.Drawing.Size(29, 16);
            this.labelRp.TabIndex = 21;
            this.labelRp.Text = "Rp.";
            // 
            // FormGuessTheCoinFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 599);
            this.Controls.Add(this.labelRp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.labelShowPercentage);
            this.Controls.Add(this.labelShowCorrect);
            this.Controls.Add(this.labelShowGuess);
            this.Controls.Add(this.labelPercentageCorrect);
            this.Controls.Add(this.labelCorrectGuess);
            this.Controls.Add(this.labelNumberGuess);
            this.Controls.Add(this.labelDisplayComment);
            this.Controls.Add(this.labelDisplayMoney);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.groupBoxGuess);
            this.Controls.Add(this.textBoxBet);
            this.Controls.Add(this.labelBet);
            this.Controls.Add(this.buttonStartRestart);
            this.Controls.Add(this.labelHeadTail);
            this.Controls.Add(this.pictureBoxCoin);
            this.Controls.Add(this.labelUrMoney);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormGuessTheCoinFace";
            this.Text = "Guess The Coin Face";
            this.Load += new System.EventHandler(this.FormGuessTheCoinFace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).EndInit();
            this.groupBoxGuess.ResumeLayout(false);
            this.groupBoxGuess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUrMoney;
        private System.Windows.Forms.PictureBox pictureBoxCoin;
        private System.Windows.Forms.Label labelHeadTail;
        private System.Windows.Forms.Button buttonStartRestart;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.GroupBox groupBoxGuess;
        private System.Windows.Forms.RadioButton radioButtonTail;
        private System.Windows.Forms.RadioButton radioButtonHead;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelDisplayMoney;
        private System.Windows.Forms.Label labelDisplayComment;
        private System.Windows.Forms.Label labelNumberGuess;
        private System.Windows.Forms.Label labelCorrectGuess;
        private System.Windows.Forms.Label labelPercentageCorrect;
        private System.Windows.Forms.Label labelShowGuess;
        private System.Windows.Forms.Label labelShowCorrect;
        private System.Windows.Forms.Label labelShowPercentage;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelRp;
    }
}

