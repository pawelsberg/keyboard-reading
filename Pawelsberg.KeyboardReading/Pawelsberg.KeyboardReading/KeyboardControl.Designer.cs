namespace Pawelsberg.KeyboardReading
{
    partial class KeyboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelKeyboard = new System.Windows.Forms.Label();
            this.timerType = new System.Windows.Forms.Timer(this.components);
            this.timerPause = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelKeyboard
            // 
            this.labelKeyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKeyboard.Image = global::Pawelsberg.KeyboardReading.Resource.keyboard;
            this.labelKeyboard.Location = new System.Drawing.Point(0, 0);
            this.labelKeyboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeyboard.Name = "labelKeyboard";
            this.labelKeyboard.Size = new System.Drawing.Size(888, 260);
            this.labelKeyboard.TabIndex = 1;
            // 
            // timerType
            // 
            this.timerType.Tick += new System.EventHandler(this.timerType_Tick);
            // 
            // timerPause
            // 
            this.timerPause.Tick += new System.EventHandler(this.timerPause_Tick);
            // 
            // KeyboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelKeyboard);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KeyboardControl";
            this.Size = new System.Drawing.Size(888, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKeyboard;
        private System.Windows.Forms.Timer timerType;
        private System.Windows.Forms.Timer timerPause;
    }
}
