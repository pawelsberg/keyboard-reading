namespace Pawelsberg.KeyboardReading
{
    partial class MainForm
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
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.textBoxTryWord = new System.Windows.Forms.TextBox();
            this.buttonTryWord = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.textWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusWindow = new Pawelsberg.KeyboardReading.StatusWindow();
            this.keyboardControl = new Pawelsberg.KeyboardReading.KeyboardControl();
            this.SuspendLayout();
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Enabled = false;
            this.textBoxSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSrc.Location = new System.Drawing.Point(220, 311);
            this.textBoxSrc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.PasswordChar = '*';
            this.textBoxSrc.Size = new System.Drawing.Size(224, 26);
            this.textBoxSrc.TabIndex = 1;
            // 
            // textBoxTryWord
            // 
            this.textBoxTryWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTryWord.Location = new System.Drawing.Point(220, 352);
            this.textBoxTryWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTryWord.Name = "textBoxTryWord";
            this.textBoxTryWord.Size = new System.Drawing.Size(224, 26);
            this.textBoxTryWord.TabIndex = 0;
            this.textBoxTryWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsr_KeyPress);
            // 
            // buttonTryWord
            // 
            this.buttonTryWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTryWord.Location = new System.Drawing.Point(480, 325);
            this.buttonTryWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTryWord.Name = "buttonTryWord";
            this.buttonTryWord.Size = new System.Drawing.Size(121, 37);
            this.buttonTryWord.TabIndex = 2;
            this.buttonTryWord.Text = "Check";
            this.buttonTryWord.UseVisualStyleBackColor = true;
            this.buttonTryWord.Click += new System.EventHandler(this.buttonChk_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(14, 14);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(97, 28);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(577, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level:";
            // 
            // textLevel
            // 
            this.textLevel.Enabled = false;
            this.textLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLevel.Location = new System.Drawing.Point(642, 14);
            this.textLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(59, 26);
            this.textLevel.TabIndex = 5;
            // 
            // textWord
            // 
            this.textWord.Enabled = false;
            this.textWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textWord.Location = new System.Drawing.Point(777, 14);
            this.textWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textWord.Name = "textWord";
            this.textWord.Size = new System.Drawing.Size(59, 26);
            this.textWord.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(712, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Word:";
            // 
            // statusWindow
            // 
            this.statusWindow.Location = new System.Drawing.Point(120, 12);
            this.statusWindow.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.statusWindow.Name = "statusWindow";
            this.statusWindow.Size = new System.Drawing.Size(448, 30);
            this.statusWindow.TabIndex = 8;
            this.statusWindow.Stop += new System.EventHandler(this.statusWindow_Stop);
            // 
            // keyboardControl
            // 
            this.keyboardControl.KeyDelay = 1000;
            this.keyboardControl.Location = new System.Drawing.Point(1, 48);
            this.keyboardControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.keyboardControl.Name = "keyboardControl";
            this.keyboardControl.Size = new System.Drawing.Size(886, 257);
            this.keyboardControl.TabIndex = 0;
            this.keyboardControl.Stop += new System.EventHandler(this.keyboardControl_Stop);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 387);
            this.Controls.Add(this.statusWindow);
            this.Controls.Add(this.textWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonTryWord);
            this.Controls.Add(this.textBoxTryWord);
            this.Controls.Add(this.textBoxSrc);
            this.Controls.Add(this.keyboardControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Visual Keyboard Reading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeyboardControl keyboardControl;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.TextBox textBoxTryWord;
        private System.Windows.Forms.Button buttonTryWord;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.TextBox textWord;
        private System.Windows.Forms.Label label2;
        private StatusWindow statusWindow;

    }
}

