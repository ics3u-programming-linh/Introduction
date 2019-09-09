namespace HelloIntLinh
{
    partial class frmHelloInt
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbGreetings = new System.Windows.Forms.GroupBox();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radVietnamese = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.grbGreetings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(200, 141);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(378, 78);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // grbGreetings
            // 
            this.grbGreetings.Controls.Add(this.radFrench);
            this.grbGreetings.Controls.Add(this.radVietnamese);
            this.grbGreetings.Controls.Add(this.radSpanish);
            this.grbGreetings.Controls.Add(this.radEnglish);
            this.grbGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGreetings.Location = new System.Drawing.Point(131, 264);
            this.grbGreetings.Name = "grbGreetings";
            this.grbGreetings.Size = new System.Drawing.Size(501, 110);
            this.grbGreetings.TabIndex = 1;
            this.grbGreetings.TabStop = false;
            this.grbGreetings.Text = "Language";
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(21, 45);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(101, 29);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Location = new System.Drawing.Point(128, 45);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(108, 29);
            this.radSpanish.TabIndex = 1;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Español";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged_1);
            // 
            // radVietnamese
            // 
            this.radVietnamese.AutoSize = true;
            this.radVietnamese.Location = new System.Drawing.Point(242, 45);
            this.radVietnamese.Name = "radVietnamese";
            this.radVietnamese.Size = new System.Drawing.Size(127, 29);
            this.radVietnamese.TabIndex = 2;
            this.radVietnamese.TabStop = true;
            this.radVietnamese.Text = "Tiếng Việt";
            this.radVietnamese.UseVisualStyleBackColor = true;
            this.radVietnamese.CheckedChanged += new System.EventHandler(this.RadVietnamese_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(375, 45);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(113, 29);
            this.radFrench.TabIndex = 3;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "Français";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // frmHelloInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbGreetings);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloInt";
            this.Text = "Hello, World! International by Linh H";
            this.grbGreetings.ResumeLayout(false);
            this.grbGreetings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox grbGreetings;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radVietnamese;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radFrench;
    }
}

