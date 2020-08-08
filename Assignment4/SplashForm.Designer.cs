namespace Assignment4
{
    partial class SplashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <jk name="disposing">true if managed resources should be disposed; otherwise, false.</jk>
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
            this.splashformtimer = new System.Windows.Forms.Timer(this.components);
            this.splashlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splashformtimer
            // 
            this.splashformtimer.Enabled = true;
            this.splashformtimer.Interval = 4000;
            this.splashformtimer.Tick += new System.EventHandler(this.splashformtimer_Tick);
            // 
            // splashlabel
            // 
            this.splashlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splashlabel.BackColor = System.Drawing.Color.OliveDrab;
            this.splashlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splashlabel.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashlabel.ForeColor = System.Drawing.Color.Snow;
            this.splashlabel.Location = new System.Drawing.Point(4, 15);
            this.splashlabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.splashlabel.Name = "splashlabel";
            this.splashlabel.Size = new System.Drawing.Size(605, 260);
            this.splashlabel.TabIndex = 0;
            this.splashlabel.Text = "BMI CALCULATOR";
            this.splashlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(614, 284);
            this.ControlBox = false;
            this.Controls.Add(this.splashlabel);
            this.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "SplashForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer splashformtimer;
        private System.Windows.Forms.Label splashlabel;
    }
}