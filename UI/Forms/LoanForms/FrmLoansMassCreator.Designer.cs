namespace UI.Forms.LoanForms
{
    partial class FrmLoansMassCreator
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblAddDepositTitle = new Label();
            lblFileName = new Label();
            btnFileUpload = new Button();
            btnPreview = new Button();
            gridPreview = new DataGridView();
            IsValid = new DataGridViewTextBoxColumn();
            INSS = new DataGridViewTextBoxColumn();
            ClientFullName = new DataGridViewTextBoxColumn();
            CKCode = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            LoanAmount = new DataGridViewTextBoxColumn();
            TotalInstallments = new DataGridViewTextBoxColumn();
            ErrorMessage = new DataGridViewTextBoxColumn();
            lblTotalPendingAmount = new Label();
            lblLoansCountData = new Label();
            lblTotalPDFAmount = new Label();
            lblTotalPDFAmountData = new Label();
            btnCancel = new Button();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPreview).BeginInit();
            SuspendLayout();
            // 
            // lblAddDepositTitle
            // 
            lblAddDepositTitle.Anchor = AnchorStyles.None;
            lblAddDepositTitle.AutoSize = true;
            lblAddDepositTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddDepositTitle.ForeColor = SystemColors.Control;
            lblAddDepositTitle.Location = new Point(358, 21);
            lblAddDepositTitle.Name = "lblAddDepositTitle";
            lblAddDepositTitle.Size = new Size(420, 36);
            lblAddDepositTitle.TabIndex = 34;
            lblAddDepositTitle.Text = "Creacion masiva de prestamos";
            // 
            // lblFileName
            // 
            lblFileName.Anchor = AnchorStyles.None;
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFileName.ForeColor = Color.White;
            lblFileName.Location = new Point(138, 95);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(82, 25);
            lblFileName.TabIndex = 57;
            lblFileName.Text = "fileName";
            lblFileName.Visible = false;
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
            btnFileUpload.Location = new Point(107, 123);
            btnFileUpload.Name = "btnFileUpload";
            btnFileUpload.Size = new Size(137, 45);
            btnFileUpload.TabIndex = 56;
            btnFileUpload.Text = "Subir archivo";
            btnFileUpload.UseVisualStyleBackColor = false;
            btnFileUpload.Click += btnFileUpload_Click;
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
            btnPreview.Location = new Point(970, 189);
            btnPreview.Margin = new Padding(0);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(163, 43);
            btnPreview.TabIndex = 58;
            btnPreview.Text = "Previsualizar";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
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
            gridPreview.Columns.AddRange(new DataGridViewColumn[] { IsValid, INSS, ClientFullName, CKCode, Date, LoanAmount, TotalInstallments, ErrorMessage });
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
            gridPreview.Location = new Point(12, 235);
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
            gridPreview.Size = new Size(1132, 441);
            gridPreview.TabIndex = 59;
            gridPreview.CellFormatting += gridPreview_CellFormatting;
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
            ClientFullName.FillWeight = 50F;
            ClientFullName.HeaderText = "Afiliado";
            ClientFullName.MinimumWidth = 200;
            ClientFullName.Name = "ClientFullName";
            ClientFullName.ReadOnly = true;
            ClientFullName.Width = 200;
            // 
            // CKCode
            // 
            CKCode.DataPropertyName = "CKCode";
            CKCode.HeaderText = "No Cheque";
            CKCode.MinimumWidth = 6;
            CKCode.Name = "CKCode";
            CKCode.Width = 125;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Fecha";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // LoanAmount
            // 
            LoanAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LoanAmount.DataPropertyName = "LoanAmount";
            LoanAmount.FillWeight = 1F;
            LoanAmount.HeaderText = "Cantidad Prestamo";
            LoanAmount.MinimumWidth = 200;
            LoanAmount.Name = "LoanAmount";
            LoanAmount.Width = 200;
            // 
            // TotalInstallments
            // 
            TotalInstallments.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TotalInstallments.DataPropertyName = "TotalInstallments";
            TotalInstallments.FillWeight = 11.5773888F;
            TotalInstallments.HeaderText = "Cuotas";
            TotalInstallments.MinimumWidth = 75;
            TotalInstallments.Name = "TotalInstallments";
            TotalInstallments.ReadOnly = true;
            TotalInstallments.Width = 75;
            // 
            // ErrorMessage
            // 
            ErrorMessage.DataPropertyName = "ErrorMessage";
            ErrorMessage.HeaderText = "Mensaje error";
            ErrorMessage.MinimumWidth = 330;
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Width = 330;
            // 
            // lblTotalPendingAmount
            // 
            lblTotalPendingAmount.Anchor = AnchorStyles.None;
            lblTotalPendingAmount.AutoSize = true;
            lblTotalPendingAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPendingAmount.ForeColor = Color.White;
            lblTotalPendingAmount.Location = new Point(718, 181);
            lblTotalPendingAmount.Name = "lblTotalPendingAmount";
            lblTotalPendingAmount.Size = new Size(159, 28);
            lblTotalPendingAmount.TabIndex = 60;
            lblTotalPendingAmount.Text = "Cant Préstamos";
            // 
            // lblLoansCountData
            // 
            lblLoansCountData.Anchor = AnchorStyles.None;
            lblLoansCountData.AutoSize = true;
            lblLoansCountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoansCountData.ForeColor = Color.White;
            lblLoansCountData.Location = new Point(735, 204);
            lblLoansCountData.Name = "lblLoansCountData";
            lblLoansCountData.Size = new Size(24, 28);
            lblLoansCountData.TabIndex = 61;
            lblLoansCountData.Text = "0";
            lblLoansCountData.Visible = false;
            // 
            // lblTotalPDFAmount
            // 
            lblTotalPDFAmount.Anchor = AnchorStyles.None;
            lblTotalPDFAmount.AutoSize = true;
            lblTotalPDFAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPDFAmount.ForeColor = Color.White;
            lblTotalPDFAmount.Location = new Point(521, 181);
            lblTotalPDFAmount.Name = "lblTotalPDFAmount";
            lblTotalPDFAmount.Size = new Size(163, 28);
            lblTotalPDFAmount.TabIndex = 62;
            lblTotalPDFAmount.Text = "Total préstamos";
            // 
            // lblTotalPDFAmountData
            // 
            lblTotalPDFAmountData.Anchor = AnchorStyles.None;
            lblTotalPDFAmountData.AutoSize = true;
            lblTotalPDFAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPDFAmountData.ForeColor = Color.LawnGreen;
            lblTotalPDFAmountData.Location = new Point(521, 204);
            lblTotalPDFAmountData.Name = "lblTotalPDFAmountData";
            lblTotalPDFAmountData.Size = new Size(60, 28);
            lblTotalPDFAmountData.TabIndex = 63;
            lblTotalPDFAmountData.Text = "$$$$";
            lblTotalPDFAmountData.Visible = false;
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
            btnCancel.Location = new Point(974, 681);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 65;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
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
            btnCreate.Location = new Point(12, 679);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 54);
            btnCreate.TabIndex = 64;
            btnCreate.Text = "Guardar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Visible = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmLoansMassCreator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1156, 742);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(lblTotalPDFAmount);
            Controls.Add(lblTotalPDFAmountData);
            Controls.Add(lblTotalPendingAmount);
            Controls.Add(lblLoansCountData);
            Controls.Add(gridPreview);
            Controls.Add(btnPreview);
            Controls.Add(lblFileName);
            Controls.Add(btnFileUpload);
            Controls.Add(lblAddDepositTitle);
            Name = "FrmLoansMassCreator";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmLoansMassCreator";
            Load += FrmLoansMassCreator_Load;
            ((System.ComponentModel.ISupportInitialize)gridPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddDepositTitle;
        private Label lblFileName;
        private Button btnFileUpload;
        private Button btnPreview;
        private DataGridView gridPreview;
        private Label lblTotalPendingAmount;
        private Label lblLoansCountData;
        private Label lblTotalPDFAmount;
        private Label lblTotalPDFAmountData;
        private Button btnCancel;
        private Button btnCreate;
        private DataGridViewTextBoxColumn IsValid;
        private DataGridViewTextBoxColumn INSS;
        private DataGridViewTextBoxColumn ClientFullName;
        private DataGridViewTextBoxColumn CKCode;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn LoanAmount;
        private DataGridViewTextBoxColumn TotalInstallments;
        private DataGridViewTextBoxColumn ErrorMessage;
    }
}