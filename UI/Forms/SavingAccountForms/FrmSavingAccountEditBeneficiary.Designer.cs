namespace UI.Forms.SavingAccountForms
{
    partial class FrmSavingAccountEditBeneficiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSavingAccountEditBeneficiary));
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            label1 = new Label();
            txtBenenficiaryPhoneNumber = new MaskedTextBox();
            label14 = new Label();
            txtBeneficiaryAddress = new RichTextBox();
            txtBeneficiaryRelationship = new TextBox();
            label2 = new Label();
            txtBeneficiaryLastName = new TextBox();
            label3 = new Label();
            txtBeneficiaryNames = new TextBox();
            lblIdentification = new Label();
            btnCancel = new Button();
            btnCreate = new Button();
            lblSavingAccTitle = new Label();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(665, 38);
            BarraTitulo.TabIndex = 3;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(637, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(37, 264);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 67;
            label1.Text = "Telefono";
            // 
            // txtBenenficiaryPhoneNumber
            // 
            txtBenenficiaryPhoneNumber.Anchor = AnchorStyles.None;
            txtBenenficiaryPhoneNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBenenficiaryPhoneNumber.Location = new Point(37, 292);
            txtBenenficiaryPhoneNumber.Mask = "9999999999";
            txtBenenficiaryPhoneNumber.Name = "txtBenenficiaryPhoneNumber";
            txtBenenficiaryPhoneNumber.Size = new Size(125, 31);
            txtBenenficiaryPhoneNumber.TabIndex = 65;
            txtBenenficiaryPhoneNumber.ValidatingType = typeof(int);
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(323, 194);
            label14.Name = "label14";
            label14.Size = new Size(85, 25);
            label14.TabIndex = 69;
            label14.Text = "Dirección";
            // 
            // txtBeneficiaryAddress
            // 
            txtBeneficiaryAddress.Anchor = AnchorStyles.None;
            txtBeneficiaryAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeneficiaryAddress.Location = new Point(323, 222);
            txtBeneficiaryAddress.Name = "txtBeneficiaryAddress";
            txtBeneficiaryAddress.Size = new Size(292, 101);
            txtBeneficiaryAddress.TabIndex = 68;
            txtBeneficiaryAddress.Text = "";
            // 
            // txtBeneficiaryRelationship
            // 
            txtBeneficiaryRelationship.Anchor = AnchorStyles.None;
            txtBeneficiaryRelationship.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeneficiaryRelationship.Location = new Point(323, 152);
            txtBeneficiaryRelationship.Name = "txtBeneficiaryRelationship";
            txtBeneficiaryRelationship.PlaceholderText = "Parentesco";
            txtBeneficiaryRelationship.Size = new Size(211, 31);
            txtBeneficiaryRelationship.TabIndex = 66;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(37, 194);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 64;
            label2.Text = "Apellidos";
            // 
            // txtBeneficiaryLastName
            // 
            txtBeneficiaryLastName.Anchor = AnchorStyles.None;
            txtBeneficiaryLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeneficiaryLastName.Location = new Point(37, 222);
            txtBeneficiaryLastName.Name = "txtBeneficiaryLastName";
            txtBeneficiaryLastName.PlaceholderText = "Apellidos";
            txtBeneficiaryLastName.Size = new Size(211, 31);
            txtBeneficiaryLastName.TabIndex = 63;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(37, 124);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 62;
            label3.Text = "Nombres";
            // 
            // txtBeneficiaryNames
            // 
            txtBeneficiaryNames.Anchor = AnchorStyles.None;
            txtBeneficiaryNames.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeneficiaryNames.Location = new Point(37, 152);
            txtBeneficiaryNames.Name = "txtBeneficiaryNames";
            txtBeneficiaryNames.PlaceholderText = "Nombres";
            txtBeneficiaryNames.Size = new Size(211, 31);
            txtBeneficiaryNames.TabIndex = 60;
            // 
            // lblIdentification
            // 
            lblIdentification.Anchor = AnchorStyles.None;
            lblIdentification.AutoSize = true;
            lblIdentification.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentification.ForeColor = SystemColors.Control;
            lblIdentification.Location = new Point(323, 124);
            lblIdentification.Name = "lblIdentification";
            lblIdentification.Size = new Size(97, 25);
            lblIdentification.TabIndex = 61;
            lblIdentification.Text = "Parentesco";
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
            btnCancel.Location = new Point(486, 349);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 71;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            btnCreate.Location = new Point(24, 349);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 50);
            btnCreate.TabIndex = 70;
            btnCreate.Text = "Guardar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(222, 66);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(171, 36);
            lblSavingAccTitle.TabIndex = 72;
            lblSavingAccTitle.Text = "Beneficiario";
            // 
            // FrmSavingAccountEditBeneficiary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(665, 417);
            Controls.Add(lblSavingAccTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(txtBenenficiaryPhoneNumber);
            Controls.Add(label14);
            Controls.Add(txtBeneficiaryAddress);
            Controls.Add(txtBeneficiaryRelationship);
            Controls.Add(label2);
            Controls.Add(txtBeneficiaryLastName);
            Controls.Add(label3);
            Controls.Add(txtBeneficiaryNames);
            Controls.Add(lblIdentification);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "FrmSavingAccountEditBeneficiary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar beneficiario";
            Load += FrmSavingAccountEditBeneficiary_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Label label1;
        private MaskedTextBox txtBenenficiaryPhoneNumber;
        private Label label14;
        private RichTextBox txtBeneficiaryAddress;
        private TextBox txtBeneficiaryRelationship;
        private Label label2;
        private TextBox txtBeneficiaryLastName;
        private Label label3;
        private TextBox txtBeneficiaryNames;
        private Label lblIdentification;
        private Button btnCancel;
        private Button btnCreate;
        private Label lblSavingAccTitle;
    }
}