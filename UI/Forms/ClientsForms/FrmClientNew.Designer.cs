namespace UI.Forms.ClientsForms
{
    partial class FrmClientNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientNew));
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            txtLastName = new TextBox();
            btnCreate = new Button();
            txtFirstName = new TextBox();
            lblClientTitle = new Label();
            btnCancel = new Button();
            txtIdentification = new MaskedTextBox();
            lblIdentification = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtINSS = new MaskedTextBox();
            label14 = new Label();
            txtAddress = new RichTextBox();
            txtWorkArea = new TextBox();
            label11 = new Label();
            label13 = new Label();
            txtBaseIncome = new NumericUpDown();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBaseIncome).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(2, 2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(740, 38);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(714, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(30, 224);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Apellidos";
            txtLastName.Size = new Size(211, 31);
            txtLastName.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top;
            btnCreate.BackColor = Color.FromArgb(51, 178, 73);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(30, 379);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 50);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Agregar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(30, 155);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Nombres";
            txtFirstName.Size = new Size(211, 31);
            txtFirstName.TabIndex = 1;
            // 
            // lblClientTitle
            // 
            lblClientTitle.Anchor = AnchorStyles.Top;
            lblClientTitle.AutoSize = true;
            lblClientTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientTitle.ForeColor = SystemColors.Control;
            lblClientTitle.Location = new Point(281, 70);
            lblClientTitle.Name = "lblClientTitle";
            lblClientTitle.Size = new Size(205, 36);
            lblClientTitle.TabIndex = 5;
            lblClientTitle.Text = "Nuevo afiliado";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(550, 379);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtIdentification
            // 
            txtIdentification.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentification.Location = new Point(292, 155);
            txtIdentification.Mask = "0000000000000L";
            txtIdentification.Name = "txtIdentification";
            txtIdentification.Size = new Size(150, 31);
            txtIdentification.TabIndex = 5;
            // 
            // lblIdentification
            // 
            lblIdentification.AutoSize = true;
            lblIdentification.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentification.ForeColor = SystemColors.Control;
            lblIdentification.Location = new Point(292, 127);
            lblIdentification.Name = "lblIdentification";
            lblIdentification.Size = new Size(66, 25);
            lblIdentification.TabIndex = 9;
            lblIdentification.Text = "Cédula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(30, 196);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 10;
            label1.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(30, 127);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 12;
            label3.Text = "Nombres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(30, 266);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 13;
            label4.Text = "No INSS";
            // 
            // txtINSS
            // 
            txtINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtINSS.HidePromptOnLeave = true;
            txtINSS.InsertKeyMode = InsertKeyMode.Insert;
            txtINSS.Location = new Point(30, 294);
            txtINSS.Mask = "999999999";
            txtINSS.Name = "txtINSS";
            txtINSS.PromptChar = ' ';
            txtINSS.Size = new Size(125, 31);
            txtINSS.TabIndex = 4;
            txtINSS.ValidatingType = typeof(int);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(489, 127);
            label14.Name = "label14";
            label14.Size = new Size(85, 25);
            label14.TabIndex = 59;
            label14.Text = "Dirección";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(489, 155);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(231, 100);
            txtAddress.TabIndex = 7;
            txtAddress.Text = "";
            // 
            // txtWorkArea
            // 
            txtWorkArea.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkArea.Location = new Point(292, 294);
            txtWorkArea.Name = "txtWorkArea";
            txtWorkArea.Size = new Size(150, 31);
            txtWorkArea.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(292, 266);
            label11.Name = "label11";
            label11.Size = new Size(48, 25);
            label11.TabIndex = 60;
            label11.Text = "Area";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(292, 196);
            label13.Name = "label13";
            label13.Size = new Size(107, 25);
            label13.TabIndex = 63;
            label13.Text = "Salario base";
            // 
            // txtBaseIncome
            // 
            txtBaseIncome.DecimalPlaces = 2;
            txtBaseIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBaseIncome.Location = new Point(292, 224);
            txtBaseIncome.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            txtBaseIncome.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            txtBaseIncome.Name = "txtBaseIncome";
            txtBaseIncome.Size = new Size(164, 31);
            txtBaseIncome.TabIndex = 6;
            txtBaseIncome.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // FrmClientNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(744, 453);
            Controls.Add(label13);
            Controls.Add(txtBaseIncome);
            Controls.Add(txtWorkArea);
            Controls.Add(label11);
            Controls.Add(label14);
            Controls.Add(txtAddress);
            Controls.Add(txtINSS);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblIdentification);
            Controls.Add(txtIdentification);
            Controls.Add(btnCancel);
            Controls.Add(txtLastName);
            Controls.Add(btnCreate);
            Controls.Add(txtFirstName);
            Controls.Add(lblClientTitle);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "FrmClientNew";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo afiliado";
            Load += FrmClientNew_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBaseIncome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private TextBox txtLastName;
        private Button btnCreate;
        private TextBox txtFirstName;
        private Label lblClientTitle;
        private Button btnCancel;
        private MaskedTextBox txtIdentification;
        private Label lblIdentification;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtINSS;
        private Label label14;
        private RichTextBox txtAddress;
        private TextBox txtWorkArea;
        private Label label11;
        private Label label13;
        private NumericUpDown txtBaseIncome;
    }
}