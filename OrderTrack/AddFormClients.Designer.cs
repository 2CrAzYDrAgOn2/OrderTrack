namespace OrderTrack
{
    partial class AddFormClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormClients));
            buttonSave = new Button();
            labelTitle = new Label();
            label1 = new Label();
            labelFullNameClients = new Label();
            textBoxFullNameClients = new TextBox();
            labelClientTypeID = new Label();
            comboBoxClientTypeID = new ComboBox();
            labelEmailClients = new Label();
            textBoxEmailClients = new TextBox();
            labelPhoneClients = new Label();
            maskedTextBoxPhoneClients = new MaskedTextBox();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            labelINN = new Label();
            textBoxINN = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.WhiteSmoke;
            buttonSave.Location = new Point(330, 763);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(243, 10);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 25);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(244, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 8;
            label1.Text = "Клиент";
            // 
            // labelFullNameClients
            // 
            labelFullNameClients.AutoSize = true;
            labelFullNameClients.BackColor = Color.Transparent;
            labelFullNameClients.ForeColor = Color.WhiteSmoke;
            labelFullNameClients.Location = new Point(193, 456);
            labelFullNameClients.Margin = new Padding(4, 0, 4, 0);
            labelFullNameClients.Name = "labelFullNameClients";
            labelFullNameClients.Size = new Size(93, 15);
            labelFullNameClients.TabIndex = 9;
            labelFullNameClients.Text = "Наименование:";
            // 
            // textBoxFullNameClients
            // 
            textBoxFullNameClients.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFullNameClients.Location = new Point(292, 445);
            textBoxFullNameClients.Margin = new Padding(4, 3, 4, 3);
            textBoxFullNameClients.Name = "textBoxFullNameClients";
            textBoxFullNameClients.Size = new Size(455, 33);
            textBoxFullNameClients.TabIndex = 0;
            // 
            // labelClientTypeID
            // 
            labelClientTypeID.AutoSize = true;
            labelClientTypeID.BackColor = Color.Transparent;
            labelClientTypeID.ForeColor = Color.WhiteSmoke;
            labelClientTypeID.Location = new Point(209, 501);
            labelClientTypeID.Margin = new Padding(4, 0, 4, 0);
            labelClientTypeID.Name = "labelClientTypeID";
            labelClientTypeID.Size = new Size(77, 15);
            labelClientTypeID.TabIndex = 10;
            labelClientTypeID.Text = "Тип клиента:";
            // 
            // comboBoxClientTypeID
            // 
            comboBoxClientTypeID.Font = new Font("Segoe UI", 14.25F);
            comboBoxClientTypeID.FormattingEnabled = true;
            comboBoxClientTypeID.Items.AddRange(new object[] { "Физическое лицо", "Юридическое лицо" });
            comboBoxClientTypeID.Location = new Point(292, 490);
            comboBoxClientTypeID.Name = "comboBoxClientTypeID";
            comboBoxClientTypeID.Size = new Size(455, 33);
            comboBoxClientTypeID.TabIndex = 1;
            // 
            // labelEmailClients
            // 
            labelEmailClients.AutoSize = true;
            labelEmailClients.BackColor = Color.Transparent;
            labelEmailClients.ForeColor = Color.WhiteSmoke;
            labelEmailClients.Location = new Point(170, 549);
            labelEmailClients.Margin = new Padding(4, 0, 4, 0);
            labelEmailClients.Name = "labelEmailClients";
            labelEmailClients.Size = new Size(116, 15);
            labelEmailClients.TabIndex = 11;
            labelEmailClients.Text = "Электронная почта:";
            // 
            // textBoxEmailClients
            // 
            textBoxEmailClients.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmailClients.Location = new Point(292, 538);
            textBoxEmailClients.Margin = new Padding(4, 3, 4, 3);
            textBoxEmailClients.Name = "textBoxEmailClients";
            textBoxEmailClients.Size = new Size(455, 33);
            textBoxEmailClients.TabIndex = 2;
            // 
            // labelPhoneClients
            // 
            labelPhoneClients.AutoSize = true;
            labelPhoneClients.BackColor = Color.Transparent;
            labelPhoneClients.ForeColor = Color.Black;
            labelPhoneClients.Location = new Point(228, 591);
            labelPhoneClients.Margin = new Padding(4, 0, 4, 0);
            labelPhoneClients.Name = "labelPhoneClients";
            labelPhoneClients.Size = new Size(58, 15);
            labelPhoneClients.TabIndex = 12;
            labelPhoneClients.Text = "Телефон:";
            // 
            // maskedTextBoxPhoneClients
            // 
            maskedTextBoxPhoneClients.Font = new Font("Segoe UI", 14.25F);
            maskedTextBoxPhoneClients.Location = new Point(292, 580);
            maskedTextBoxPhoneClients.Mask = "+7 (999) 999-99-99";
            maskedTextBoxPhoneClients.Name = "maskedTextBoxPhoneClients";
            maskedTextBoxPhoneClients.Size = new Size(455, 33);
            maskedTextBoxPhoneClients.TabIndex = 3;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.ForeColor = Color.WhiteSmoke;
            labelAddress.Location = new Point(243, 636);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(43, 15);
            labelAddress.TabIndex = 13;
            labelAddress.Text = "Адрес:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAddress.Location = new Point(292, 625);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(455, 33);
            textBoxAddress.TabIndex = 4;
            // 
            // labelINN
            // 
            labelINN.AutoSize = true;
            labelINN.BackColor = Color.Transparent;
            labelINN.ForeColor = Color.Black;
            labelINN.Location = new Point(249, 681);
            labelINN.Margin = new Padding(4, 0, 4, 0);
            labelINN.Name = "labelINN";
            labelINN.Size = new Size(37, 15);
            labelINN.TabIndex = 14;
            labelINN.Text = "ИНН:";
            // 
            // textBoxINN
            // 
            textBoxINN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxINN.Location = new Point(292, 670);
            textBoxINN.Margin = new Padding(4, 3, 4, 3);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(455, 33);
            textBoxINN.TabIndex = 5;
            // 
            // AddFormClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelFullNameClients);
            Controls.Add(textBoxFullNameClients);
            Controls.Add(labelClientTypeID);
            Controls.Add(comboBoxClientTypeID);
            Controls.Add(labelEmailClients);
            Controls.Add(textBoxEmailClients);
            Controls.Add(labelPhoneClients);
            Controls.Add(maskedTextBoxPhoneClients);
            Controls.Add(labelAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(labelINN);
            Controls.Add(textBoxINN);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormClients";
            Text = "Добавить клиента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private Label labelFullNameClients;
        private TextBox textBoxFullNameClients;
        private Label labelClientTypeID;
        private ComboBox comboBoxClientTypeID;
        private Label labelEmailClients;
        private TextBox textBoxEmailClients;
        private Label labelPhoneClients;
        private MaskedTextBox maskedTextBoxPhoneClients;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Label labelINN;
        private TextBox textBoxINN;
    }
}