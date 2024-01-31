namespace UI.Forms.LoanForms
{
    partial class FrmLoansMonthlyPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoansMonthlyPayments));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            lblAddDepositTitle = new Label();
            btnCancel = new Button();
            btnCreate = new Button();
            gridPreview = new DataGridView();
            LoanInstallmentID = new DataGridViewTextBoxColumn();
            IsValid = new DataGridViewTextBoxColumn();
            INSS = new DataGridViewTextBoxColumn();
            ClientFullName = new DataGridViewTextBoxColumn();
            PendingAmountDisplay = new DataGridViewTextBoxColumn();
            PaymentAmountDisplay = new DataGridViewTextBoxColumn();
            ErrorMessage = new DataGridViewTextBoxColumn();
            lblFileName = new Label();
            lblClientsCount = new Label();
            label8 = new Label();
            lblTotalPDFAmount = new Label();
            lblTotalPDFAmountData = new Label();
            btnPreview = new Button();
            label2 = new Label();
            dtDateCreated = new DateTimePicker();
            btnFileUpload = new Button();
            lblTotalPendingAmount = new Label();
            lblTotalPendingAmountData = new Label();
            label4 = new Label();
            dtSubPeriodDate = new DateTimePicker();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPreview).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1156, 38);
            BarraTitulo.TabIndex = 32;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(1128, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblAddDepositTitle
            // 
            lblAddDepositTitle.Anchor = AnchorStyles.None;
            lblAddDepositTitle.AutoSize = true;
            lblAddDepositTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddDepositTitle.ForeColor = SystemColors.Control;
            lblAddDepositTitle.Location = new Point(372, 50);
            lblAddDepositTitle.Name = "lblAddDepositTitle";
            lblAddDepositTitle.Size = new Size(409, 36);
            lblAddDepositTitle.TabIndex = 33;
            lblAddDepositTitle.Text = "Agregar deducciones del mes";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(974, 679);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.None;
            btnCreate.BackColor = Color.FromArgb(51, 178, 73);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(12, 677);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 54);
            btnCreate.TabIndex = 38;
            btnCreate.Text = "Guardar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Visible = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // gridPreview
            // 
            gridPreview.AllowUserToAddRows = false;
            gridPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPreview.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridPreview.BorderStyle = BorderStyle.None;
            gridPreview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridPreview.ColumnHeadersHeight = 30;
            gridPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridPreview.Columns.AddRange(new DataGridViewColumn[] { LoanInstallmentID, IsValid, INSS, ClientFullName, PendingAmountDisplay, PaymentAmountDisplay, ErrorMessage });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridPreview.DefaultCellStyle = dataGridViewCellStyle2;
            gridPreview.EnableHeadersVisualStyles = false;
            gridPreview.GridColor = Color.SteelBlue;
            gridPreview.Location = new Point(12, 300);
            gridPreview.Name = "gridPreview";
            gridPreview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridPreview.RowHeadersVisible = false;
            gridPreview.RowHeadersWidth = 51;
            gridPreview.RowTemplate.Height = 29;
            gridPreview.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridPreview.Size = new Size(1132, 376);
            gridPreview.TabIndex = 40;
            gridPreview.CellFormatting += gridPreview_CellFormatting;
            // 
            // LoanInstallmentID
            // 
            LoanInstallmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LoanInstallmentID.DataPropertyName = "LoanInstallmentID";
            LoanInstallmentID.HeaderText = "LoanID";
            LoanInstallmentID.MinimumWidth = 6;
            LoanInstallmentID.Name = "LoanInstallmentID";
            LoanInstallmentID.Visible = false;
            LoanInstallmentID.Width = 125;
            // 
            // IsValid
            // 
            IsValid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IsValid.DataPropertyName = "IsValid";
            IsValid.HeaderText = "IsValid";
            IsValid.MinimumWidth = 6;
            IsValid.Name = "IsValid";
            IsValid.Visible = false;
            IsValid.Width = 125;
            // 
            // INSS
            // 
            INSS.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            INSS.DataPropertyName = "INSSNo";
            INSS.FillWeight = 30F;
            INSS.HeaderText = "INSS";
            INSS.MinimumWidth = 100;
            INSS.Name = "INSS";
            INSS.ReadOnly = true;
            INSS.Width = 125;
            // 
            // ClientFullName
            // 
            ClientFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClientFullName.DataPropertyName = "ClientFullName";
            ClientFullName.FillWeight = 150F;
            ClientFullName.HeaderText = "Afiliado";
            ClientFullName.MinimumWidth = 305;
            ClientFullName.Name = "ClientFullName";
            ClientFullName.ReadOnly = true;
            ClientFullName.Width = 330;
            // 
            // PendingAmountDisplay
            // 
            PendingAmountDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PendingAmountDisplay.DataPropertyName = "PendingAmountDisplay";
            PendingAmountDisplay.FillWeight = 1F;
            PendingAmountDisplay.HeaderText = "Cantidad pendiente";
            PendingAmountDisplay.MinimumWidth = 200;
            PendingAmountDisplay.Name = "PendingAmountDisplay";
            PendingAmountDisplay.Width = 200;
            // 
            // PaymentAmountDisplay
            // 
            PaymentAmountDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PaymentAmountDisplay.DataPropertyName = "PaymentAmountDisplay";
            PaymentAmountDisplay.FillWeight = 11.5773888F;
            PaymentAmountDisplay.HeaderText = "Cantidad pago";
            PaymentAmountDisplay.MinimumWidth = 150;
            PaymentAmountDisplay.Name = "PaymentAmountDisplay";
            PaymentAmountDisplay.ReadOnly = true;
            PaymentAmountDisplay.Width = 150;
            // 
            // ErrorMessage
            // 
            ErrorMessage.DataPropertyName = "ErrorMessage";
            ErrorMessage.HeaderText = "Mensaje error";
            ErrorMessage.MinimumWidth = 330;
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Width = 330;
            // 
            // lblFileName
            // 
            lblFileName.Anchor = AnchorStyles.None;
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFileName.ForeColor = Color.White;
            lblFileName.Location = new Point(413, 113);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(82, 25);
            lblFileName.TabIndex = 55;
            lblFileName.Text = "fileName";
            lblFileName.Visible = false;
            // 
            // lblClientsCount
            // 
            lblClientsCount.Anchor = AnchorStyles.None;
            lblClientsCount.AutoSize = true;
            lblClientsCount.BackColor = Color.Transparent;
            lblClientsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientsCount.ForeColor = Color.White;
            lblClientsCount.Location = new Point(12, 274);
            lblClientsCount.Name = "lblClientsCount";
            lblClientsCount.Size = new Size(18, 23);
            lblClientsCount.TabIndex = 54;
            lblClientsCount.Text = "..";
            lblClientsCount.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 246);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 53;
            label8.Text = "Resultado";
            // 
            // lblTotalPDFAmount
            // 
            lblTotalPDFAmount.Anchor = AnchorStyles.None;
            lblTotalPDFAmount.AutoSize = true;
            lblTotalPDFAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPDFAmount.ForeColor = Color.White;
            lblTotalPDFAmount.Location = new Point(522, 246);
            lblTotalPDFAmount.Name = "lblTotalPDFAmount";
            lblTotalPDFAmount.Size = new Size(107, 28);
            lblTotalPDFAmount.TabIndex = 51;
            lblTotalPDFAmount.Text = "Total PDF:";
            // 
            // lblTotalPDFAmountData
            // 
            lblTotalPDFAmountData.Anchor = AnchorStyles.None;
            lblTotalPDFAmountData.AutoSize = true;
            lblTotalPDFAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPDFAmountData.ForeColor = Color.LawnGreen;
            lblTotalPDFAmountData.Location = new Point(522, 269);
            lblTotalPDFAmountData.Name = "lblTotalPDFAmountData";
            lblTotalPDFAmountData.Size = new Size(60, 28);
            lblTotalPDFAmountData.TabIndex = 52;
            lblTotalPDFAmountData.Text = "$$$$";
            lblTotalPDFAmountData.Visible = false;
            // 
            // btnPreview
            // 
            btnPreview.Anchor = AnchorStyles.None;
            btnPreview.BackColor = Color.SteelBlue;
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.FlatAppearance.BorderColor = Color.ForestGreen;
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(981, 254);
            btnPreview.Margin = new Padding(0);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(163, 43);
            btnPreview.TabIndex = 50;
            btnPreview.Text = "Previsualizar";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(206, 113);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 49;
            label2.Text = "Fecha pago";
            // 
            // dtDateCreated
            // 
            dtDateCreated.Anchor = AnchorStyles.None;
            dtDateCreated.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Format = DateTimePickerFormat.Short;
            dtDateCreated.Location = new Point(206, 141);
            dtDateCreated.Name = "dtDateCreated";
            dtDateCreated.Size = new Size(157, 31);
            dtDateCreated.TabIndex = 48;
            // 
            // btnFileUpload
            // 
            btnFileUpload.Anchor = AnchorStyles.None;
            btnFileUpload.BackColor = Color.SteelBlue;
            btnFileUpload.Cursor = Cursors.Hand;
            btnFileUpload.FlatAppearance.BorderSize = 0;
            btnFileUpload.FlatStyle = FlatStyle.Flat;
            btnFileUpload.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFileUpload.ForeColor = SystemColors.Control;
            btnFileUpload.Location = new Point(413, 141);
            btnFileUpload.Name = "btnFileUpload";
            btnFileUpload.Size = new Size(137, 45);
            btnFileUpload.TabIndex = 47;
            btnFileUpload.Text = "Subir archivo";
            btnFileUpload.UseVisualStyleBackColor = false;
            btnFileUpload.Click += btnFileUpload_Click;
            // 
            // lblTotalPendingAmount
            // 
            lblTotalPendingAmount.Anchor = AnchorStyles.None;
            lblTotalPendingAmount.AutoSize = true;
            lblTotalPendingAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPendingAmount.ForeColor = Color.White;
            lblTotalPendingAmount.Location = new Point(753, 246);
            lblTotalPendingAmount.Name = "lblTotalPendingAmount";
            lblTotalPendingAmount.Size = new Size(165, 28);
            lblTotalPendingAmount.TabIndex = 56;
            lblTotalPendingAmount.Text = "Total pendiente:";
            // 
            // lblTotalPendingAmountData
            // 
            lblTotalPendingAmountData.Anchor = AnchorStyles.None;
            lblTotalPendingAmountData.AutoSize = true;
            lblTotalPendingAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPendingAmountData.ForeColor = Color.LawnGreen;
            lblTotalPendingAmountData.Location = new Point(753, 269);
            lblTotalPendingAmountData.Name = "lblTotalPendingAmountData";
            lblTotalPendingAmountData.Size = new Size(60, 28);
            lblTotalPendingAmountData.TabIndex = 57;
            lblTotalPendingAmountData.Text = "$$$$";
            lblTotalPendingAmountData.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(28, 113);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 59;
            label4.Text = "Mes a pagar";
            // 
            // dtSubPeriodDate
            // 
            dtSubPeriodDate.Anchor = AnchorStyles.None;
            dtSubPeriodDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtSubPeriodDate.CustomFormat = "MM/yyyy";
            dtSubPeriodDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtSubPeriodDate.Format = DateTimePickerFormat.Custom;
            dtSubPeriodDate.Location = new Point(28, 141);
            dtSubPeriodDate.Name = "dtSubPeriodDate";
            dtSubPeriodDate.Size = new Size(144, 31);
            dtSubPeriodDate.TabIndex = 58;
            // 
            // FrmLoansMonthlyPayments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1156, 742);
            Controls.Add(label4);
            Controls.Add(dtSubPeriodDate);
            Controls.Add(lblTotalPendingAmount);
            Controls.Add(lblTotalPendingAmountData);
            Controls.Add(lblFileName);
            Controls.Add(lblClientsCount);
            Controls.Add(label8);
            Controls.Add(lblTotalPDFAmount);
            Controls.Add(lblTotalPDFAmountData);
            Controls.Add(btnPreview);
            Controls.Add(label2);
            Controls.Add(dtDateCreated);
            Controls.Add(btnFileUpload);
            Controls.Add(gridPreview);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(lblAddDepositTitle);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLoansMonthlyPayments";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmLoansMonthlyPayments";
            Load += FrmLoansMonthlyPayments_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Label lblAddDepositTitle;
        private Button btnCancel;
        private Button btnCreate;
        private DataGridView gridPreview;
        private DataGridViewTextBoxColumn LoanInstallmentID;
        private DataGridViewTextBoxColumn IsValid;
        private DataGridViewTextBoxColumn INSS;
        private DataGridViewTextBoxColumn ClientFullName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn ErrorMessage;
        private Label lblFileName;
        private Label lblClientsCount;
        private Label label8;
        private Label lblTotalAmount;
        private Label lblTotalAmountData;
        private Button btnPreview;
        private Label label2;
        private DateTimePicker dtDateCreated;
        private Button btnFileUpload;
        private Label lblTotalPDFAmount;
        private Label lblTotalPDFAmountData;
        private Label label1;
        private Label label3;
        private Label lblTotalPendingAmount;
        private Label lblTotalPendingAmountData;
        private DataGridViewTextBoxColumn PendingAmountDisplay;
        private DataGridViewTextBoxColumn PaymentAmountDisplay;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtSubPeriodDate;
    }
}