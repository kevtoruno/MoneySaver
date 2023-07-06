namespace UI.Forms.SavingAccountForms
{
    partial class FrmSavingAccountAddDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSavingAccountAddDeposit));
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            lblAddDepositTitle = new Label();
            label3 = new Label();
            cbPeriods = new ComboBox();
            label1 = new Label();
            cbSubPeriods = new ComboBox();
            btnCreate = new Button();
            lblAmount = new Label();
            label2 = new Label();
            dtDateCreated = new DateTimePicker();
            txtAmount = new NumericUpDown();
            txtInterestsAmount = new NumericUpDown();
            lblInterestsAmount = new Label();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtInterestsAmount).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(534, 38);
            BarraTitulo.TabIndex = 2;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(504, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblAddDepositTitle
            // 
            lblAddDepositTitle.Anchor = AnchorStyles.Top;
            lblAddDepositTitle.AutoSize = true;
            lblAddDepositTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddDepositTitle.ForeColor = SystemColors.Control;
            lblAddDepositTitle.Location = new Point(143, 61);
            lblAddDepositTitle.Name = "lblAddDepositTitle";
            lblAddDepositTitle.Size = new Size(244, 36);
            lblAddDepositTitle.TabIndex = 6;
            lblAddDepositTitle.Text = "Agregar deposito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(30, 134);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 15;
            label3.Text = "Seleccionar período";
            // 
            // cbPeriods
            // 
            cbPeriods.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPeriods.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbPeriods.DisplayMember = "FullName";
            cbPeriods.FlatStyle = FlatStyle.Flat;
            cbPeriods.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbPeriods.FormattingEnabled = true;
            cbPeriods.Location = new Point(30, 175);
            cbPeriods.Name = "cbPeriods";
            cbPeriods.Size = new Size(186, 33);
            cbPeriods.TabIndex = 14;
            cbPeriods.SelectedIndexChanged += cbPeriods_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(30, 227);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 17;
            label1.Text = "Seleccionar subperiodo";
            // 
            // cbSubPeriods
            // 
            cbSubPeriods.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSubPeriods.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSubPeriods.DisplayMember = "FullName";
            cbSubPeriods.FlatStyle = FlatStyle.Flat;
            cbSubPeriods.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubPeriods.FormattingEnabled = true;
            cbSubPeriods.Location = new Point(30, 265);
            cbSubPeriods.Name = "cbSubPeriods";
            cbSubPeriods.Size = new Size(186, 33);
            cbSubPeriods.TabIndex = 16;
            cbSubPeriods.SelectedIndexChanged += cbSubPeriods_SelectedIndexChanged;
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
            btnCreate.Location = new Point(166, 435);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(192, 62);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Agregar deposito";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.ForeColor = SystemColors.Control;
            lblAmount.Location = new Point(353, 134);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(83, 25);
            lblAmount.TabIndex = 20;
            lblAmount.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(92, 318);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 24;
            label2.Text = "Fecha ";
            // 
            // dtDateCreated
            // 
            dtDateCreated.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Format = DateTimePickerFormat.Short;
            dtDateCreated.Location = new Point(56, 355);
            dtDateCreated.Name = "dtDateCreated";
            dtDateCreated.Size = new Size(134, 31);
            dtDateCreated.TabIndex = 23;
            // 
            // txtAmount
            // 
            txtAmount.DecimalPlaces = 2;
            txtAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(333, 175);
            txtAmount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 25;
            txtAmount.ThousandsSeparator = true;
            // 
            // txtInterestsAmount
            // 
            txtInterestsAmount.DecimalPlaces = 2;
            txtInterestsAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtInterestsAmount.Location = new Point(333, 265);
            txtInterestsAmount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtInterestsAmount.Name = "txtInterestsAmount";
            txtInterestsAmount.Size = new Size(150, 31);
            txtInterestsAmount.TabIndex = 27;
            txtInterestsAmount.ThousandsSeparator = true;
            txtInterestsAmount.Visible = false;
            // 
            // lblInterestsAmount
            // 
            lblInterestsAmount.AutoSize = true;
            lblInterestsAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblInterestsAmount.ForeColor = SystemColors.Control;
            lblInterestsAmount.Location = new Point(353, 228);
            lblInterestsAmount.Name = "lblInterestsAmount";
            lblInterestsAmount.Size = new Size(82, 25);
            lblInterestsAmount.TabIndex = 26;
            lblInterestsAmount.Text = "Intereses";
            lblInterestsAmount.Visible = false;
            // 
            // FrmSavingAccountAddDeposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(534, 560);
            Controls.Add(txtInterestsAmount);
            Controls.Add(lblInterestsAmount);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(dtDateCreated);
            Controls.Add(lblAmount);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(cbSubPeriods);
            Controls.Add(label3);
            Controls.Add(cbPeriods);
            Controls.Add(lblAddDepositTitle);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSavingAccountAddDeposit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmSavingAccountAddDeposit";
            Load += FrmSavingAccountAddDeposit_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtInterestsAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Label lblAddDepositTitle;
        private Label label3;
        private ComboBox cbPeriods;
        private Label label1;
        private ComboBox cbSubPeriods;
        private Button btnCreate;
        private Label lblAmount;
        private Label label2;
        private DateTimePicker dtDateCreated;
        private NumericUpDown txtAmount;
        private NumericUpDown txtInterestsAmount;
        private Label lblInterestsAmount;
    }
}