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
            buttonClear = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonEnter = new Button();
            labelAuth = new Label();
            buttonShow = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLogin.ForeColor = Color.Black;
            labelLogin.Location = new Point(54, 154);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(237, 86);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPassword.ForeColor = Color.Black;
            labelPassword.Location = new Point(12, 253);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(279, 86);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Пароль:";
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.BackColor = Color.Transparent;
            labelRegister.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRegister.ForeColor = Color.Black;
            labelRegister.Location = new Point(287, 9);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(434, 86);
            labelRegister.TabIndex = 6;
            labelRegister.Text = "Авторизация";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Transparent;
            buttonClear.BackgroundImage = (Image)resources.GetObject("buttonClear.BackgroundImage");
            buttonClear.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Location = new Point(903, 12);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(93, 93);
            buttonClear.TabIndex = 4;
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += ButtonClear_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxLogin.Location = new Point(297, 151);
            textBoxLogin.MaxLength = 50;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(483, 93);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(297, 250);
            textBoxPassword.MaxLength = 50;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(483, 93);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.Transparent;
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEnter.ForeColor = Color.Black;
            buttonEnter.Location = new Point(424, 349);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(230, 93);
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
            labelAuth.ForeColor = Color.Black;
            labelAuth.Location = new Point(290, 463);
            labelAuth.Name = "labelAuth";
            labelAuth.Size = new Size(429, 65);
            labelAuth.TabIndex = 3;
            labelAuth.Text = "Ещё нет аккаунта?";
            labelAuth.Click += LabelAuth_Click;
            // 
            // buttonShow
            // 
            buttonShow.BackColor = Color.Transparent;
            buttonShow.BackgroundImage = Properties.Resources.ShowPassword1;
            buttonShow.BackgroundImageLayout = ImageLayout.Stretch;
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Location = new Point(786, 250);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(93, 93);
            buttonShow.TabIndex = 5;
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += ButtonShow_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1008, 537);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonEnter);
            Controls.Add(labelAuth);
            Controls.Add(buttonClear);
            Controls.Add(buttonShow);
            Controls.Add(labelRegister);
            Controls.Add(labelLogin);
            Controls.Add(labelPassword);
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
        private Button buttonClear;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonEnter;
        private Label labelAuth;
        private Button buttonShow;
    }
}
