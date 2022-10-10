namespace Salvapantallas_DVD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uc_dvd_icon = new Salvapantallas_DVD.DVD_icon();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uc_dvd_icon
            // 
            this.uc_dvd_icon.BackColor = System.Drawing.Color.White;
            this.uc_dvd_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc_dvd_icon.BackgroundImage")));
            this.uc_dvd_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uc_dvd_icon.Location = new System.Drawing.Point(48, 33);
            this.uc_dvd_icon.Margin = new System.Windows.Forms.Padding(0);
            this.uc_dvd_icon.Name = "uc_dvd_icon";
            this.uc_dvd_icon.Size = new System.Drawing.Size(308, 138);
            this.uc_dvd_icon.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1272, 762);
            this.Controls.Add(this.uc_dvd_icon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DVD_icon uc_dvd_icon;
        private System.Windows.Forms.Timer timer1;
    }
}