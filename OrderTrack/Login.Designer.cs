namespace OrderTrack
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labelLogin = new Label();
            labelPassword = new Label();
            labelRegister = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonEnter = new Button();
            labelAuth = new Label();
            buttonShow = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLogin.ForeColor = Color.Transparent;
            labelLogin.Location = new Point(110, 112);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(120, 45);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPassword.ForeColor = Color.Transparent;
            labelPassword.Location = new Point(110, 178);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(142, 45);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Пароль:";
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.BackColor = Color.FromArgb(1, 61, 102);
            labelRegister.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRegister.ForeColor = Color.Transparent;
            labelRegister.Location = new Point(324, 9);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(317, 62);
            labelRegister.TabIndex = 6;
            labelRegister.Text = "Авторизация";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxLogin.Location = new Point(308, 112);
            textBoxLogin.MaxLength = 50;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(477, 50);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(308, 178);
            textBoxPassword.MaxLength = 50;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(477, 50);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(10, 115, 166);
            buttonEnter.FlatAppearance.BorderSize = 0;
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEnter.ForeColor = Color.Transparent;
            buttonEnter.Location = new Point(110, 258);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(731, 69);
            buttonEnter.TabIndex = 2;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += ButtonEnter_Click;
            // 
            // labelAuth
            // 
            labelAuth.AutoSize = true;
            labelAuth.BackColor = Color.Transparent;
            labelAuth.Font = new Font("Segoe UI", 36F, FontStyle.Underline);
            labelAuth.ForeColor = Color.Transparent;
            labelAuth.Location = new Point(276, 344);
            labelAuth.Name = "labelAuth";
            labelAuth.Size = new Size(429, 65);
            labelAuth.TabIndex = 3;
            labelAuth.Text = "Ещё нет аккаунта?";
            labelAuth.Click += LabelAuth_Click;
            // 
            // buttonShow
            // 
            buttonShow.BackColor = Color.Transparent;
            buttonShow.BackgroundImage = (Image)resources.GetObject("buttonShow.BackgroundImage");
            buttonShow.BackgroundImageLayout = ImageLayout.Stretch;
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Location = new Point(791, 178);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(50, 50);
            buttonShow.TabIndex = 5;
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += ButtonShow_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 61, 102);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 87);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(10, 115, 166);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(258, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 50);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(10, 115, 166);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(258, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(50, 50);
            panel3.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 83, 133);
            ClientSize = new Size(944, 442);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonEnter);
            Controls.Add(labelAuth);
            Controls.Add(buttonShow);
            Controls.Add(labelRegister);
            Controls.Add(labelLogin);
            Controls.Add(labelPassword);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelPassword;
        private Label labelRegister;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonEnter;
        private Label labelAuth;
        private Button buttonShow;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
