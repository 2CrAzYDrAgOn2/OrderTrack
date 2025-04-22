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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(241, 156, 55);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(260, 452);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 44);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.FromArgb(10, 115, 166);
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(273, 12);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(223, 32);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(10, 115, 166);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(344, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 8;
            label1.Text = "Клиент";
            // 
            // labelFullNameClients
            // 
            labelFullNameClients.AutoSize = true;
            labelFullNameClients.BackColor = Color.Transparent;
            labelFullNameClients.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFullNameClients.ForeColor = Color.FromArgb(97, 97, 97);
            labelFullNameClients.Location = new Point(224, 18);
            labelFullNameClients.Margin = new Padding(4, 0, 4, 0);
            labelFullNameClients.Name = "labelFullNameClients";
            labelFullNameClients.Size = new Size(318, 25);
            labelFullNameClients.TabIndex = 9;
            labelFullNameClients.Text = "Контактное лицо / Организация:";
            // 
            // textBoxFullNameClients
            // 
            textBoxFullNameClients.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFullNameClients.Location = new Point(151, 46);
            textBoxFullNameClients.Margin = new Padding(4, 3, 4, 3);
            textBoxFullNameClients.Name = "textBoxFullNameClients";
            textBoxFullNameClients.Size = new Size(455, 33);
            textBoxFullNameClients.TabIndex = 0;
            // 
            // labelClientTypeID
            // 
            labelClientTypeID.AutoSize = true;
            labelClientTypeID.BackColor = Color.Transparent;
            labelClientTypeID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelClientTypeID.ForeColor = Color.FromArgb(97, 97, 97);
            labelClientTypeID.Location = new Point(313, 88);
            labelClientTypeID.Margin = new Padding(4, 0, 4, 0);
            labelClientTypeID.Name = "labelClientTypeID";
            labelClientTypeID.Size = new Size(131, 25);
            labelClientTypeID.TabIndex = 10;
            labelClientTypeID.Text = "Тип клиента:";
            // 
            // comboBoxClientTypeID
            // 
            comboBoxClientTypeID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientTypeID.Font = new Font("Segoe UI", 14.25F);
            comboBoxClientTypeID.FormattingEnabled = true;
            comboBoxClientTypeID.Location = new Point(230, 116);
            comboBoxClientTypeID.Name = "comboBoxClientTypeID";
            comboBoxClientTypeID.Size = new Size(307, 33);
            comboBoxClientTypeID.TabIndex = 1;
            // 
            // labelEmailClients
            // 
            labelEmailClients.AutoSize = true;
            labelEmailClients.BackColor = Color.Transparent;
            labelEmailClients.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEmailClients.ForeColor = Color.FromArgb(97, 97, 97);
            labelEmailClients.Location = new Point(285, 366);
            labelEmailClients.Margin = new Padding(4, 0, 4, 0);
            labelEmailClients.Name = "labelEmailClients";
            labelEmailClients.Size = new Size(198, 25);
            labelEmailClients.TabIndex = 11;
            labelEmailClients.Text = "Электронная почта:";
            // 
            // textBoxEmailClients
            // 
            textBoxEmailClients.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmailClients.Location = new Point(151, 394);
            textBoxEmailClients.Margin = new Padding(4, 3, 4, 3);
            textBoxEmailClients.Name = "textBoxEmailClients";
            textBoxEmailClients.Size = new Size(455, 33);
            textBoxEmailClients.TabIndex = 2;
            // 
            // labelPhoneClients
            // 
            labelPhoneClients.AutoSize = true;
            labelPhoneClients.BackColor = Color.Transparent;
            labelPhoneClients.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPhoneClients.ForeColor = Color.FromArgb(97, 97, 97);
            labelPhoneClients.Location = new Point(331, 159);
            labelPhoneClients.Margin = new Padding(4, 0, 4, 0);
            labelPhoneClients.Name = "labelPhoneClients";
            labelPhoneClients.Size = new Size(96, 25);
            labelPhoneClients.TabIndex = 12;
            labelPhoneClients.Text = "Телефон:";
            // 
            // maskedTextBoxPhoneClients
            // 
            maskedTextBoxPhoneClients.Font = new Font("Segoe UI", 14.25F);
            maskedTextBoxPhoneClients.Location = new Point(230, 187);
            maskedTextBoxPhoneClients.Mask = "+7 (999) 999-99-99";
            maskedTextBoxPhoneClients.Name = "maskedTextBoxPhoneClients";
            maskedTextBoxPhoneClients.Size = new Size(307, 33);
            maskedTextBoxPhoneClients.TabIndex = 3;
            maskedTextBoxPhoneClients.MaskInputRejected += maskedTextBoxPhoneClients_MaskInputRejected;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddress.ForeColor = Color.FromArgb(97, 97, 97);
            labelAddress.Location = new Point(343, 229);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(74, 25);
            labelAddress.TabIndex = 13;
            labelAddress.Text = "Адрес:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAddress.Location = new Point(151, 257);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(455, 33);
            textBoxAddress.TabIndex = 4;
            // 
            // labelINN
            // 
            labelINN.AutoSize = true;
            labelINN.BackColor = Color.Transparent;
            labelINN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelINN.ForeColor = Color.FromArgb(97, 97, 97);
            labelINN.Location = new Point(348, 297);
            labelINN.Margin = new Padding(4, 0, 4, 0);
            labelINN.Name = "labelINN";
            labelINN.Size = new Size(62, 25);
            labelINN.TabIndex = 14;
            labelINN.Text = "ИНН:";
            // 
            // textBoxINN
            // 
            textBoxINN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxINN.Location = new Point(151, 325);
            textBoxINN.Margin = new Padding(4, 3, 4, 3);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(455, 33);
            textBoxINN.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(10, 115, 166);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 75);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 115, 166);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 97);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(201, 201, 209);
            panel2.Controls.Add(labelFullNameClients);
            panel2.Controls.Add(buttonSave);
            panel2.Controls.Add(labelINN);
            panel2.Controls.Add(labelAddress);
            panel2.Controls.Add(textBoxEmailClients);
            panel2.Controls.Add(textBoxAddress);
            panel2.Controls.Add(labelEmailClients);
            panel2.Controls.Add(labelPhoneClients);
            panel2.Controls.Add(textBoxINN);
            panel2.Controls.Add(maskedTextBoxPhoneClients);
            panel2.Controls.Add(labelClientTypeID);
            panel2.Controls.Add(comboBoxClientTypeID);
            panel2.Controls.Add(textBoxFullNameClients);
            panel2.Location = new Point(-2, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 523);
            panel2.TabIndex = 17;
            // 
            // AddFormClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(751, 614);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormClients";
            Text = "Добавить клиента";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}