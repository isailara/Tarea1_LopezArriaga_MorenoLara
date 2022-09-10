namespace tarea1_LopezArriaga_MorenoLara
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mainWordBox = new System.Windows.Forms.TextBox();
            this.wordSetterButton = new System.Windows.Forms.Button();
            this.letterBox = new System.Windows.Forms.TextBox();
            this.letterSetterButton = new System.Windows.Forms.Button();
            this.finalWordBox = new System.Windows.Forms.TextBox();
            this.finalWordSetterButton = new System.Windows.Forms.Button();
            this.finalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.nAttempts = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.nAttemptsSetter = new System.Windows.Forms.NumericUpDown();
            this.nAttemptsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nAttemptsSetter)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(167, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 172);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // mainWordBox
            // 
            this.mainWordBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainWordBox.Location = new System.Drawing.Point(426, 98);
            this.mainWordBox.Name = "mainWordBox";
            this.mainWordBox.Size = new System.Drawing.Size(213, 27);
            this.mainWordBox.TabIndex = 1;
            this.mainWordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainWordBox.TextChanged += new System.EventHandler(this.mainWordBox_TextChanged);
            // 
            // wordSetterButton
            // 
            this.wordSetterButton.Enabled = false;
            this.wordSetterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordSetterButton.Location = new System.Drawing.Point(426, 179);
            this.wordSetterButton.Name = "wordSetterButton";
            this.wordSetterButton.Size = new System.Drawing.Size(213, 29);
            this.wordSetterButton.TabIndex = 2;
            this.wordSetterButton.Text = "Set word";
            this.wordSetterButton.UseVisualStyleBackColor = true;
            this.wordSetterButton.Click += new System.EventHandler(this.wordSetterButton_Click);
            // 
            // letterBox
            // 
            this.letterBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterBox.Location = new System.Drawing.Point(426, 249);
            this.letterBox.Name = "letterBox";
            this.letterBox.Size = new System.Drawing.Size(69, 27);
            this.letterBox.TabIndex = 3;
            this.letterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterBox.Visible = false;
            this.letterBox.TextChanged += new System.EventHandler(this.letterBox_TextChanged);
            // 
            // letterSetterButton
            // 
            this.letterSetterButton.Enabled = false;
            this.letterSetterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSetterButton.Location = new System.Drawing.Point(501, 249);
            this.letterSetterButton.Name = "letterSetterButton";
            this.letterSetterButton.Size = new System.Drawing.Size(135, 27);
            this.letterSetterButton.TabIndex = 4;
            this.letterSetterButton.Text = "Try letter";
            this.letterSetterButton.UseVisualStyleBackColor = true;
            this.letterSetterButton.Visible = false;
            this.letterSetterButton.Click += new System.EventHandler(this.letterSetterButton_Click);
            // 
            // finalWordBox
            // 
            this.finalWordBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalWordBox.Location = new System.Drawing.Point(294, 301);
            this.finalWordBox.Name = "finalWordBox";
            this.finalWordBox.Size = new System.Drawing.Size(100, 27);
            this.finalWordBox.TabIndex = 5;
            this.finalWordBox.Visible = false;
            this.finalWordBox.TextChanged += new System.EventHandler(this.finalWordBox_TextChanged);
            // 
            // finalWordSetterButton
            // 
            this.finalWordSetterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalWordSetterButton.Location = new System.Drawing.Point(426, 301);
            this.finalWordSetterButton.Name = "finalWordSetterButton";
            this.finalWordSetterButton.Size = new System.Drawing.Size(158, 27);
            this.finalWordSetterButton.TabIndex = 6;
            this.finalWordSetterButton.Text = "Try final word";
            this.finalWordSetterButton.UseVisualStyleBackColor = true;
            this.finalWordSetterButton.Visible = false;
            this.finalWordSetterButton.Click += new System.EventHandler(this.finalWordSetterButton_Click);
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalLabel.Location = new System.Drawing.Point(354, 378);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(87, 21);
            this.finalLabel.TabIndex = 7;
            this.finalLabel.Text = "FinalLabel";
            this.finalLabel.Visible = false;
            this.finalLabel.Click += new System.EventHandler(this.finalLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "HANGMAN GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Set a word and try to guess it letter by letter!";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.Location = new System.Drawing.Point(352, 345);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(92, 21);
            this.wordLabel.TabIndex = 10;
            this.wordLabel.Text = "wordLabel";
            this.wordLabel.Visible = false;
            this.wordLabel.Click += new System.EventHandler(this.wordLabel_Click);
            // 
            // nAttempts
            // 
            this.nAttempts.AutoSize = true;
            this.nAttempts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nAttempts.Location = new System.Drawing.Point(427, 220);
            this.nAttempts.Name = "nAttempts";
            this.nAttempts.Size = new System.Drawing.Size(209, 21);
            this.nAttempts.TabIndex = 11;
            this.nAttempts.Text = "You have x attempts left!";
            this.nAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nAttempts.Visible = false;
            // 
            // newGame
            // 
            this.newGame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.Location = new System.Drawing.Point(343, 413);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(132, 35);
            this.newGame.TabIndex = 12;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Visible = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // nAttemptsSetter
            // 
            this.nAttemptsSetter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nAttemptsSetter.Location = new System.Drawing.Point(426, 137);
            this.nAttemptsSetter.Name = "nAttemptsSetter";
            this.nAttemptsSetter.Size = new System.Drawing.Size(101, 27);
            this.nAttemptsSetter.TabIndex = 13;
            this.nAttemptsSetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nAttemptsSetter.ValueChanged += new System.EventHandler(this.nAttemptsSetter_ValueChanged);
            // 
            // nAttemptsLabel
            // 
            this.nAttemptsLabel.AutoSize = true;
            this.nAttemptsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nAttemptsLabel.Location = new System.Drawing.Point(533, 139);
            this.nAttemptsLabel.Name = "nAttemptsLabel";
            this.nAttemptsLabel.Size = new System.Drawing.Size(106, 21);
            this.nAttemptsLabel.TabIndex = 14;
            this.nAttemptsLabel.Text = "N. Attempts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.nAttemptsLabel);
            this.Controls.Add(this.nAttemptsSetter);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.nAttempts);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.finalWordSetterButton);
            this.Controls.Add(this.finalWordBox);
            this.Controls.Add(this.letterSetterButton);
            this.Controls.Add(this.letterBox);
            this.Controls.Add(this.wordSetterButton);
            this.Controls.Add(this.mainWordBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nAttemptsSetter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox mainWordBox;
        private System.Windows.Forms.Button wordSetterButton;
        private System.Windows.Forms.TextBox letterBox;
        private System.Windows.Forms.Button letterSetterButton;
        private System.Windows.Forms.TextBox finalWordBox;
        private System.Windows.Forms.Button finalWordSetterButton;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label nAttempts;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.NumericUpDown nAttemptsSetter;
        private System.Windows.Forms.Label nAttemptsLabel;
    }
}

