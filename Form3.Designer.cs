namespace WindowsFormsApplication1
{
    partial class Starcluckslogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starcluckslogin));
            this.Logininpic = new System.Windows.Forms.PictureBox();
            this.logoLBL = new System.Windows.Forms.Label();
            this.loginBTN = new System.Windows.Forms.Button();
            this.idLBL = new System.Windows.Forms.Label();
            this.loginTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logininpic)).BeginInit();
            this.SuspendLayout();
            // 
            // Logininpic
            // 
            this.Logininpic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logininpic.ErrorImage")));
            this.Logininpic.Image = ((System.Drawing.Image)(resources.GetObject("Logininpic.Image")));
            this.Logininpic.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logininpic.InitialImage")));
            this.Logininpic.Location = new System.Drawing.Point(421, 12);
            this.Logininpic.Name = "Logininpic";
            this.Logininpic.Size = new System.Drawing.Size(265, 254);
            this.Logininpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logininpic.TabIndex = 0;
            this.Logininpic.TabStop = false;
            // 
            // logoLBL
            // 
            this.logoLBL.AutoSize = true;
            this.logoLBL.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLBL.Location = new System.Drawing.Point(433, 224);
            this.logoLBL.Name = "logoLBL";
            this.logoLBL.Size = new System.Drawing.Size(249, 44);
            this.logoLBL.TabIndex = 1;
            this.logoLBL.Text = "STARCLUCKS";
            // 
            // loginBTN
            // 
            this.loginBTN.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(441, 343);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(229, 53);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Text = "Log In";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // idLBL
            // 
            this.idLBL.AutoSize = true;
            this.idLBL.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLBL.Location = new System.Drawing.Point(51, 292);
            this.idLBL.Name = "idLBL";
            this.idLBL.Size = new System.Drawing.Size(552, 24);
            this.idLBL.TabIndex = 3;
            this.idLBL.Text = "Please Enter Your Staff ID Number:                          ";
            // 
            // loginTXT
            // 
            this.loginTXT.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTXT.Location = new System.Drawing.Point(421, 295);
            this.loginTXT.Name = "loginTXT";
            this.loginTXT.Size = new System.Drawing.Size(265, 32);
            this.loginTXT.TabIndex = 4;
            // 
            // Starcluckslogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 444);
            this.Controls.Add(this.loginTXT);
            this.Controls.Add(this.idLBL);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.logoLBL);
            this.Controls.Add(this.Logininpic);
            this.Name = "Starcluckslogin";
            this.Text = "STARCLUCKS LOG IN";
            this.Load += new System.EventHandler(this.Starcluckslogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logininpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logininpic;
        private System.Windows.Forms.Label logoLBL;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Label idLBL;
        private System.Windows.Forms.TextBox loginTXT;
    }
}