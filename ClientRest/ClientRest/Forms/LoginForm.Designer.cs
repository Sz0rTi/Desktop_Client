namespace ClientRest.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.MailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.AutoLoginChB = new System.Windows.Forms.CheckBox();
            this.RegisterLabel = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MailLabel
            // 
            resources.ApplyResources(this.MailLabel, "MailLabel");
            this.MailLabel.Name = "MailLabel";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // MailTB
            // 
            resources.ApplyResources(this.MailTB, "MailTB");
            this.MailTB.Name = "MailTB";
            // 
            // PasswordTB
            // 
            resources.ApplyResources(this.PasswordTB, "PasswordTB");
            this.PasswordTB.Name = "PasswordTB";
            // 
            // AutoLoginChB
            // 
            resources.ApplyResources(this.AutoLoginChB, "AutoLoginChB");
            this.AutoLoginChB.Name = "AutoLoginChB";
            this.AutoLoginChB.UseVisualStyleBackColor = true;
            // 
            // RegisterLabel
            // 
            resources.ApplyResources(this.RegisterLabel, "RegisterLabel");
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.TabStop = true;
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // LoginButton
            // 
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ErrorLabel
            // 
            resources.ApplyResources(this.ErrorLabel, "ErrorLabel");
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Name = "ErrorLabel";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.AutoLoginChB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.MailTB);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.MailLabel);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.CheckBox AutoLoginChB;
        private System.Windows.Forms.LinkLabel RegisterLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}