namespace UI.Forms.SavingAccountForms
{
    partial class FrmSavingAccountNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSavingAccountNew));
            btnCerrar = new PictureBox();
            BarraTitulo = new Panel();
            lblSavingAccTitle = new Label();
            btnCreate = new Button();
            label4 = new Label();
            label3 = new Label();
            lblIdentification = new Label();
            txtBeneficiaryNames = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtBenenficiaryPhoneNumber = new MaskedTextBox();
            label14 = new Label();
            txtBeneficiaryAddress = new RichTextBox();
            txtBeneficiaryRelationship = new TextBox();
            label2 = new Label();
            txtBeneficiaryLastName = new TextBox();
            txtINSS = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            BarraTitulo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(826, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(2, 2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(854, 38);
            BarraTitulo.TabIndex = 2;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(215, 66);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(322, 36);
            lblSavingAccTitle.TabIndex = 6;
            lblSavingAccTitle.Text = "Nuevo fondo de ahorro";
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
            btnCreate.Location = new Point(314, 410);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(203, 66);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Crear fondo de ahorro";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(44, 154);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 17;
            label4.Text = "No INSS afiliado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(20, 32);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 23;
            label3.Text = "Nombres";
            // 
            // lblIdentification
            // 
            lblIdentification.AutoSize = true;
            lblIdentification.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentification.ForeColor = SystemColors.Control;
            lblIdentification.Location = new Point(306, 32);
            lblIdentification.Name = "lblIdentification";
            lblIdentification.Size = new Size(97, 25);
            lblIdentification.TabIndex = 22;
            lblIdentification.Text = "Parentesco";
            // 
            // txtBeneficiaryNames
            // 
            txtBeneficiaryNames.Anchor = AnchorStyles.Top;
            txtBeneficiaryNames.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeneficiaryNames.Location = new Point(20, 60);
            txtBeneficiaryNames.Name = "txtBeneficiaryNames";
            txtBeneficiaryNames.PlaceholderText = "Nombres";
            txtBeneficiaryNames.Size = new Size(211, 31);
            txtBeneficiaryNames.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(45, 66, 91);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBenenficiaryPhoneNumber);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtBeneficiaryAddress);
            groupBox1.Controls.Add(txtBeneficiaryRelationship);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBeneficiaryLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBeneficiaryNames);
            groupBox1.Controls.Add(lblIdentification);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(241, 134);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(603, 262);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beneficiario";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(20, 172);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 29;
            label1.Text = "Telefono";
            // 
            // txtBenenficiaryPhoneNumber
            // 
            txtBenenficiaryPhoneNumber.Anchor = AnchorStyles.Top;
            txtBenenficiaryPhoneNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBenenficiaryPhoneNumber.Location = new Point(20, 200);
            txtBenenficiaryPhoneNumber.Mask = "9999999999";
            txtBenenficiaryPhoneNumber.Name = "txtBenenficiaryPhoneNumber";
            txtBenenficiaryPhoneNumber.Size = new Size(125, 31);
            txtBenenficiaryPhoneNumber.TabIndex = 28;
            txtBenenficiaryPhoneNumber.ValidatingType = typeof(int);
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(306, 102);
            label14.Name = "label14";
            label14.Size = new Size(85, 25);
            label14.TabIndex = 59;
            label14.Text = "Dirección";
            // 
            // txtBeneficiaryAddress
            // 
            txtBeneficiaryAddress.Anchor = AnchorStyles.None;
            txtBeneficiaryAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeneficiaryAddress.Location = new Point(306, 130);
            txtBeneficiaryAddress.Name = "txtBeneficiaryAddress";
            txtBeneficiaryAddress.Size = new Size(292, 101);
            txtBeneficiaryAddress.TabIndex = 58;
            txtBeneficiaryAddress.Text = "";
            // 
            // txtBeneficiaryRelationship
            // 
            txtBeneficiaryRelationship.Anchor = AnchorStyles.Top;
            txtBeneficiaryRelationship.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeneficiaryRelationship.Location = new Point(306, 60);
            txtBeneficiaryRelationship.Name = "txtBeneficiaryRelationship";
            txtBeneficiaryRelationship.PlaceholderText = "Parentesco";
            txtBeneficiaryRelationship.Size = new Size(211, 31);
            txtBeneficiaryRelationship.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(20, 102);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 27;
            label2.Text = "Apellidos";
            // 
            // txtBeneficiaryLastName
            // 
            txtBeneficiaryLastName.Anchor = AnchorStyles.Top;
            txtBeneficiaryLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeneficiaryLastName.Location = new Point(20, 130);
            txtBeneficiaryLastName.Name = "txtBeneficiaryLastName";
            txtBeneficiaryLastName.PlaceholderText = "Apellidos";
            txtBeneficiaryLastName.Size = new Size(211, 31);
            txtBeneficiaryLastName.TabIndex = 26;
            // 
            // txtINSS
            // 
            txtINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtINSS.HidePromptOnLeave = true;
            txtINSS.InsertKeyMode = InsertKeyMode.Insert;
            txtINSS.Location = new Point(44, 182);
            txtINSS.Mask = "999999999";
            txtINSS.Name = "txtINSS";
            txtINSS.PromptChar = ' ';
            txtINSS.Size = new Size(142, 31);
            txtINSS.TabIndex = 28;
            txtINSS.ValidatingType = typeof(int);
            // 
            // FrmSavingAccountNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(858, 499);
            Controls.Add(txtINSS);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(btnCreate);
            Controls.Add(lblSavingAccTitle);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "FrmSavingAccountNew";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo fondo de ahorro";
            Load += FrmSavingAccountNew_Load;
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            BarraTitulo.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnCerrar;
        private Panel BarraTitulo;
        private Label lblSavingAccTitle;
        private Button btnCreate;
        private Label label4;
        private MaskedTextBox txtBenenficiaryPhoneNumber;
        private Label label1;
        private Label label3;
        private Label lblIdentification;
        private MaskedTextBox txtIdentification;
        private TextBox txtNames;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtBeneficiaryNames;
        private TextBox txtBeneficiaryLastName;
        private TextBox txtBeneficiaryRelationship;
        private Label label14;
        private RichTextBox txtBeneficiaryAddress;
        private MaskedTextBox txtINSS;
    }
}