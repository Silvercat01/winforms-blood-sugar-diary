namespace BloodSugarDiary
{
    partial class LoginForm
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SignUpButton = new Button();
            infoLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(194, 151);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(125, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(433, 151);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(255, 224, 192);
            loginButton.Location = new Point(249, 277);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 34);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.FromArgb(255, 224, 192);
            SignUpButton.Location = new Point(409, 277);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(94, 34);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(349, 323);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(13, 20);
            infoLabel.TabIndex = 4;
            infoLabel.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 128);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 128);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 254);
            label3.Name = "label3";
            label3.Size = new Size(213, 20);
            label3.TabIndex = 7;
            label3.Text = "You don't have an account yet?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(infoLabel);
            Controls.Add(SignUpButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button SignUpButton;
        private Label infoLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
