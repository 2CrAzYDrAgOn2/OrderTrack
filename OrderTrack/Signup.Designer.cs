namespace OrderTrack
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            buttonEnter = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            labelRegister = new Label();
            labelPassword = new Label();
            labelLogin = new Label();
            buttonClear = new Button();
            buttonShow = new Button();
            SuspendLayout();
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
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxLogin.Location = new Point(297, 151);
            textBoxLogin.MaxLength = 50;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(483, 93);
            textBoxLogin.TabIndex = 0;
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.BackColor = Color.Transparent;
            labelRegister.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRegister.ForeColor = Color.Black;
            labelRegister.Location = new Point(298, 12);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(412, 86);
            labelRegister.TabIndex = 5;
            labelRegister.Text = "Регистрация";
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
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Пароль:";
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
            labelLogin.TabIndex = 6;
            labelLogin.Text = "Логин:";
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
            buttonClear.TabIndex = 3;
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += ButtonClear_Click;
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
            buttonShow.TabIndex = 4;
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += ButtonShow_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1008, 537);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonEnter);
            Controls.Add(buttonClear);
            Controls.Add(buttonShow);
            Controls.Add(labelRegister);
            Controls.Add(labelLogin);
            Controls.Add(labelPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnter;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label labelRegister;
        private Label labelPassword;
        private Label labelLogin;
        private Button buttonClear;
        private Button buttonShow;
    }
}