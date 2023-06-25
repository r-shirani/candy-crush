namespace candy_crush
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.usernameBox, "usernameBox");
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.passwordBox, "passwordBox");
            this.passwordBox.Name = "passwordBox";
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.signInBtn, "signInBtn");
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignInForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::candy_crush.Properties.Resources.Candy_Crush_Logo_PNG_Picture;
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.Opacity = 0.99D;
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button signInBtn;
    }
}