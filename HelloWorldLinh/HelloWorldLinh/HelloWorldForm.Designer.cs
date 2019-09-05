namespace HelloWorldLinh
{
    partial class frmHelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorld));
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.picSpongebob = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSpongebob)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Georgia", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(180, 29);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(435, 77);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            this.lblGreeting.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("MS Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(281, 116);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(195, 33);
            this.lblSignature.TabIndex = 1;
            this.lblSignature.Text = "by Linh Ho";
            // 
            // picSpongebob
            // 
            this.picSpongebob.Image = ((System.Drawing.Image)(resources.GetObject("picSpongebob.Image")));
            this.picSpongebob.ImageLocation = "";
            this.picSpongebob.Location = new System.Drawing.Point(215, 162);
            this.picSpongebob.Name = "picSpongebob";
            this.picSpongebob.Size = new System.Drawing.Size(337, 276);
            this.picSpongebob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpongebob.TabIndex = 2;
            this.picSpongebob.TabStop = false;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSpongebob);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblGreeting);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "frmHelloWorld";
            this.Text = "Hello, World! by Linh";
            this.Load += new System.EventHandler(this.FrmHelloWorld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSpongebob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.PictureBox picSpongebob;
    }
}

