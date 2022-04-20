namespace Pawelsberg.KeyboardReading
{
    partial class StatusWindow
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
            this.labelStatusWindow = new System.Windows.Forms.Label();
            this.timerStatusChange = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelStatusWindow
            // 
            this.labelStatusWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatusWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusWindow.Location = new System.Drawing.Point(0, 0);
            this.labelStatusWindow.Name = "labelStatusWindow";
            this.labelStatusWindow.Size = new System.Drawing.Size(662, 51);
            this.labelStatusWindow.TabIndex = 0;
            this.labelStatusWindow.Text = "labelStatusWindow";
            this.labelStatusWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerStatusChange
            // 
            this.timerStatusChange.Tick += new System.EventHandler(this.timerStatusChange_Tick);
            // 
            // StatusWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelStatusWindow);
            this.Name = "StatusWindow";
            this.Size = new System.Drawing.Size(662, 51);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStatusWindow;
        private System.Windows.Forms.Timer timerStatusChange;
    }
}
