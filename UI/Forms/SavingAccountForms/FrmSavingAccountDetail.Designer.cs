namespace UI.Forms.SavingAccountForms
{
    partial class FrmSavingAccountDetail
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
            lblTotalWidthdrawnData = new Label();
            lblTotalWidthdrawn = new Label();
            lblCurrentAmountData = new Label();
            lblCurrentAmount = new Label();
            panel1 = new Panel();
            lblBeneficiaryData = new Label();
            lblBeneficiaryTitle = new Label();
            lblClientFullNameTitle = new Label();
            lblCreatedDateData = new Label();
            lblINSSTitle = new Label();
            lblCreatedDate = new Label();
            lblIdentificationTitle = new Label();
            lblStatusData = new Label();
            lblClientFullNameData = new Label();
            lblTotalAmountData = new Label();
            lblStatus = new Label();
            lblAmountForInterests = new Label();
            lblINSSData = new Label();
            lblIdentificationData = new Label();
            lblTotalAmount = new Label();
            lblAmountForInterestsData = new Label();
            btnWithdrawInsterest = new Button();
            btnFinishSavingAccount = new Button();
            lblSavingAccTitle = new Label();
            btnDeposit = new Button();
            gridWidthdrawalsList = new DataGridView();
            SavingAccountHistoryID = new DataGridViewTextBoxColumn();
            SubPeriodName = new DataGridViewTextBoxColumn();
            HistoryType = new DataGridViewTextBoxColumn();
            HistoryName = new DataGridViewTextBoxColumn();
            AmountDisplay = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            TotalDisplay = new DataGridViewTextBoxColumn();
            btnEditBeneficiary = new Button();
            btnExportData = new Button();
            btnRevertInterestsWithdrawal = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridWidthdrawalsList).BeginInit();
            SuspendLayout();
            // 
            // lblTotalWidthdrawnData
            // 
            lblTotalWidthdrawnData.Anchor = AnchorStyles.Right;
            lblTotalWidthdrawnData.AutoSize = true;
            lblTotalWidthdrawnData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalWidthdrawnData.ForeColor = Color.LawnGreen;
            lblTotalWidthdrawnData.Location = new Point(895, 120);
            lblTotalWidthdrawnData.Name = "lblTotalWidthdrawnData";
            lblTotalWidthdrawnData.Size = new Size(60, 28);
            lblTotalWidthdrawnData.TabIndex = 37;
            lblTotalWidthdrawnData.Text = "$$$$";
            // 
            // lblTotalWidthdrawn
            // 
            lblTotalWidthdrawn.Anchor = AnchorStyles.Right;
            lblTotalWidthdrawn.AutoSize = true;
            lblTotalWidthdrawn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalWidthdrawn.ForeColor = Color.White;
            lblTotalWidthdrawn.Location = new Point(743, 120);
            lblTotalWidthdrawn.Name = "lblTotalWidthdrawn";
            lblTotalWidthdrawn.Size = new Size(146, 28);
            lblTotalWidthdrawn.TabIndex = 36;
            lblTotalWidthdrawn.Text = "Total retirado:";
            // 
            // lblCurrentAmountData
            // 
            lblCurrentAmountData.Anchor = AnchorStyles.Right;
            lblCurrentAmountData.AutoSize = true;
            lblCurrentAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentAmountData.ForeColor = Color.LawnGreen;
            lblCurrentAmountData.Location = new Point(895, 20);
            lblCurrentAmountData.Name = "lblCurrentAmountData";
            lblCurrentAmountData.Size = new Size(60, 28);
            lblCurrentAmountData.TabIndex = 35;
            lblCurrentAmountData.Text = "$$$$";
            // 
            // lblCurrentAmount
            // 
            lblCurrentAmount.Anchor = AnchorStyles.Right;
            lblCurrentAmount.AutoSize = true;
            lblCurrentAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentAmount.ForeColor = Color.White;
            lblCurrentAmount.Location = new Point(745, 20);
            lblCurrentAmount.Name = "lblCurrentAmount";
            lblCurrentAmount.Size = new Size(144, 28);
            lblCurrentAmount.TabIndex = 34;
            lblCurrentAmount.Text = "Monto actual:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(49, 66, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblBeneficiaryData);
            panel1.Controls.Add(lblBeneficiaryTitle);
            panel1.Controls.Add(lblClientFullNameTitle);
            panel1.Controls.Add(lblCreatedDateData);
            panel1.Controls.Add(lblINSSTitle);
            panel1.Controls.Add(lblCreatedDate);
            panel1.Controls.Add(lblIdentificationTitle);
            panel1.Controls.Add(lblTotalWidthdrawnData);
            panel1.Controls.Add(lblStatusData);
            panel1.Controls.Add(lblClientFullNameData);
            panel1.Controls.Add(lblTotalAmountData);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblAmountForInterests);
            panel1.Controls.Add(lblINSSData);
            panel1.Controls.Add(lblTotalWidthdrawn);
            panel1.Controls.Add(lblIdentificationData);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Controls.Add(lblCurrentAmount);
            panel1.Controls.Add(lblAmountForInterestsData);
            panel1.Controls.Add(lblCurrentAmountData);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 202);
            panel1.TabIndex = 33;
            // 
            // lblBeneficiaryData
            // 
            lblBeneficiaryData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblBeneficiaryData.AutoSize = true;
            lblBeneficiaryData.BackColor = Color.Transparent;
            lblBeneficiaryData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBeneficiaryData.ForeColor = Color.White;
            lblBeneficiaryData.Location = new Point(183, 95);
            lblBeneficiaryData.Name = "lblBeneficiaryData";
            lblBeneficiaryData.Size = new Size(122, 23);
            lblBeneficiaryData.TabIndex = 39;
            lblBeneficiaryData.Text = "BeneficiaryInfo";
            // 
            // lblBeneficiaryTitle
            // 
            lblBeneficiaryTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblBeneficiaryTitle.AutoSize = true;
            lblBeneficiaryTitle.BackColor = Color.Transparent;
            lblBeneficiaryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBeneficiaryTitle.ForeColor = Color.White;
            lblBeneficiaryTitle.Location = new Point(61, 90);
            lblBeneficiaryTitle.Name = "lblBeneficiaryTitle";
            lblBeneficiaryTitle.Size = new Size(117, 28);
            lblBeneficiaryTitle.TabIndex = 38;
            lblBeneficiaryTitle.Text = "Beneficiario:";
            // 
            // lblClientFullNameTitle
            // 
            lblClientFullNameTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblClientFullNameTitle.AutoSize = true;
            lblClientFullNameTitle.BackColor = Color.Transparent;
            lblClientFullNameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientFullNameTitle.ForeColor = Color.White;
            lblClientFullNameTitle.Location = new Point(94, 0);
            lblClientFullNameTitle.Name = "lblClientFullNameTitle";
            lblClientFullNameTitle.Size = new Size(84, 28);
            lblClientFullNameTitle.TabIndex = 15;
            lblClientFullNameTitle.Text = "Afiliado:";
            // 
            // lblCreatedDateData
            // 
            lblCreatedDateData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCreatedDateData.AutoSize = true;
            lblCreatedDateData.BackColor = Color.Transparent;
            lblCreatedDateData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedDateData.ForeColor = Color.White;
            lblCreatedDateData.Location = new Point(183, 155);
            lblCreatedDateData.Name = "lblCreatedDateData";
            lblCreatedDateData.Size = new Size(96, 23);
            lblCreatedDateData.TabIndex = 32;
            lblCreatedDateData.Text = "00/00/2000";
            // 
            // lblINSSTitle
            // 
            lblINSSTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblINSSTitle.AutoSize = true;
            lblINSSTitle.BackColor = Color.Transparent;
            lblINSSTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblINSSTitle.ForeColor = Color.White;
            lblINSSTitle.Location = new Point(88, 30);
            lblINSSTitle.Name = "lblINSSTitle";
            lblINSSTitle.Size = new Size(90, 28);
            lblINSSTitle.TabIndex = 16;
            lblINSSTitle.Text = "No INSS:";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.BackColor = Color.Transparent;
            lblCreatedDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedDate.ForeColor = Color.White;
            lblCreatedDate.Location = new Point(7, 150);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(171, 28);
            lblCreatedDate.TabIndex = 31;
            lblCreatedDate.Text = "Fecha de creación:";
            // 
            // lblIdentificationTitle
            // 
            lblIdentificationTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblIdentificationTitle.AutoSize = true;
            lblIdentificationTitle.BackColor = Color.Transparent;
            lblIdentificationTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentificationTitle.ForeColor = Color.White;
            lblIdentificationTitle.Location = new Point(102, 60);
            lblIdentificationTitle.Name = "lblIdentificationTitle";
            lblIdentificationTitle.Size = new Size(76, 28);
            lblIdentificationTitle.TabIndex = 17;
            lblIdentificationTitle.Text = "Cédula:";
            // 
            // lblStatusData
            // 
            lblStatusData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatusData.AutoSize = true;
            lblStatusData.BackColor = Color.Transparent;
            lblStatusData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusData.ForeColor = Color.White;
            lblStatusData.Location = new Point(183, 125);
            lblStatusData.Name = "lblStatusData";
            lblStatusData.Size = new Size(56, 23);
            lblStatusData.TabIndex = 30;
            lblStatusData.Text = "Activa";
            // 
            // lblClientFullNameData
            // 
            lblClientFullNameData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblClientFullNameData.AutoSize = true;
            lblClientFullNameData.BackColor = Color.Transparent;
            lblClientFullNameData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientFullNameData.ForeColor = Color.White;
            lblClientFullNameData.Location = new Point(183, 5);
            lblClientFullNameData.Name = "lblClientFullNameData";
            lblClientFullNameData.Size = new Size(18, 23);
            lblClientFullNameData.TabIndex = 21;
            lblClientFullNameData.Text = "..";
            // 
            // lblTotalAmountData
            // 
            lblTotalAmountData.Anchor = AnchorStyles.Right;
            lblTotalAmountData.AutoSize = true;
            lblTotalAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmountData.ForeColor = Color.LawnGreen;
            lblTotalAmountData.Location = new Point(895, 170);
            lblTotalAmountData.Name = "lblTotalAmountData";
            lblTotalAmountData.Size = new Size(60, 28);
            lblTotalAmountData.TabIndex = 20;
            lblTotalAmountData.Text = "$$$$";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(102, 120);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 28);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "Estado:";
            // 
            // lblAmountForInterests
            // 
            lblAmountForInterests.Anchor = AnchorStyles.Right;
            lblAmountForInterests.AutoSize = true;
            lblAmountForInterests.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmountForInterests.ForeColor = Color.White;
            lblAmountForInterests.Location = new Point(668, 70);
            lblAmountForInterests.Name = "lblAmountForInterests";
            lblAmountForInterests.Size = new Size(221, 28);
            lblAmountForInterests.TabIndex = 27;
            lblAmountForInterests.Text = "Intereses acumulados:";
            // 
            // lblINSSData
            // 
            lblINSSData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblINSSData.AutoSize = true;
            lblINSSData.BackColor = Color.Transparent;
            lblINSSData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblINSSData.ForeColor = Color.White;
            lblINSSData.Location = new Point(183, 35);
            lblINSSData.Name = "lblINSSData";
            lblINSSData.Size = new Size(37, 23);
            lblINSSData.TabIndex = 22;
            lblINSSData.Text = "000";
            // 
            // lblIdentificationData
            // 
            lblIdentificationData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblIdentificationData.AutoSize = true;
            lblIdentificationData.BackColor = Color.Transparent;
            lblIdentificationData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentificationData.ForeColor = Color.White;
            lblIdentificationData.Location = new Point(183, 65);
            lblIdentificationData.Name = "lblIdentificationData";
            lblIdentificationData.Size = new Size(138, 23);
            lblIdentificationData.TabIndex = 23;
            lblIdentificationData.Text = "0000000000000A";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Right;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(733, 170);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(156, 28);
            lblTotalAmount.TabIndex = 19;
            lblTotalAmount.Text = "Total ahorrado:";
            // 
            // lblAmountForInterestsData
            // 
            lblAmountForInterestsData.Anchor = AnchorStyles.Right;
            lblAmountForInterestsData.AutoSize = true;
            lblAmountForInterestsData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmountForInterestsData.ForeColor = Color.LawnGreen;
            lblAmountForInterestsData.Location = new Point(895, 70);
            lblAmountForInterestsData.Name = "lblAmountForInterestsData";
            lblAmountForInterestsData.Size = new Size(60, 28);
            lblAmountForInterestsData.TabIndex = 28;
            lblAmountForInterestsData.Text = "$$$$";
            // 
            // btnWithdrawInsterest
            // 
            btnWithdrawInsterest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWithdrawInsterest.BackColor = Color.FromArgb(51, 178, 73);
            btnWithdrawInsterest.Cursor = Cursors.Hand;
            btnWithdrawInsterest.FlatAppearance.BorderColor = Color.ForestGreen;
            btnWithdrawInsterest.FlatAppearance.BorderSize = 0;
            btnWithdrawInsterest.FlatStyle = FlatStyle.Flat;
            btnWithdrawInsterest.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithdrawInsterest.ForeColor = Color.White;
            btnWithdrawInsterest.Location = new Point(722, 270);
            btnWithdrawInsterest.Margin = new Padding(0);
            btnWithdrawInsterest.Name = "btnWithdrawInsterest";
            btnWithdrawInsterest.Size = new Size(160, 50);
            btnWithdrawInsterest.TabIndex = 26;
            btnWithdrawInsterest.Text = "Retirar intereses";
            btnWithdrawInsterest.UseVisualStyleBackColor = false;
            btnWithdrawInsterest.Click += btnWithdrawInsterest_Click;
            // 
            // btnFinishSavingAccount
            // 
            btnFinishSavingAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinishSavingAccount.BackColor = Color.Crimson;
            btnFinishSavingAccount.Cursor = Cursors.Hand;
            btnFinishSavingAccount.FlatAppearance.BorderColor = Color.ForestGreen;
            btnFinishSavingAccount.FlatAppearance.BorderSize = 0;
            btnFinishSavingAccount.FlatStyle = FlatStyle.Flat;
            btnFinishSavingAccount.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinishSavingAccount.ForeColor = Color.White;
            btnFinishSavingAccount.Location = new Point(908, 270);
            btnFinishSavingAccount.Margin = new Padding(0);
            btnFinishSavingAccount.Name = "btnFinishSavingAccount";
            btnFinishSavingAccount.Size = new Size(163, 50);
            btnFinishSavingAccount.TabIndex = 25;
            btnFinishSavingAccount.Text = "Retiro total";
            btnFinishSavingAccount.UseVisualStyleBackColor = false;
            btnFinishSavingAccount.Click += btnFinishSavingAccount_Click;
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(424, 23);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(237, 36);
            lblSavingAccTitle.TabIndex = 18;
            lblSavingAccTitle.Text = "Fondo de ahorro";
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.SteelBlue;
            btnDeposit.Cursor = Cursors.Hand;
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(12, 270);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(111, 50);
            btnDeposit.TabIndex = 27;
            btnDeposit.Text = "Depositar";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // gridWidthdrawalsList
            // 
            gridWidthdrawalsList.AllowUserToAddRows = false;
            gridWidthdrawalsList.AllowUserToResizeRows = false;
            gridWidthdrawalsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridWidthdrawalsList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridWidthdrawalsList.BorderStyle = BorderStyle.None;
            gridWidthdrawalsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridWidthdrawalsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridWidthdrawalsList.ColumnHeadersHeight = 30;
            gridWidthdrawalsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridWidthdrawalsList.Columns.AddRange(new DataGridViewColumn[] { SavingAccountHistoryID, SubPeriodName, HistoryType, HistoryName, AmountDisplay, CreatedDate, TotalDisplay });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridWidthdrawalsList.DefaultCellStyle = dataGridViewCellStyle2;
            gridWidthdrawalsList.EnableHeadersVisualStyles = false;
            gridWidthdrawalsList.GridColor = Color.SteelBlue;
            gridWidthdrawalsList.Location = new Point(0, 326);
            gridWidthdrawalsList.MultiSelect = false;
            gridWidthdrawalsList.Name = "gridWidthdrawalsList";
            gridWidthdrawalsList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridWidthdrawalsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridWidthdrawalsList.RowHeadersVisible = false;
            gridWidthdrawalsList.RowHeadersWidth = 51;
            gridWidthdrawalsList.RowTemplate.Height = 29;
            gridWidthdrawalsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridWidthdrawalsList.Size = new Size(1080, 289);
            gridWidthdrawalsList.TabIndex = 5;
            gridWidthdrawalsList.CellFormatting += gridWidthdrawalsList_CellFormatting;
            gridWidthdrawalsList.SelectionChanged += gridWidthdrawalsList_SelectionChanged;
            // 
            // SavingAccountHistoryID
            // 
            SavingAccountHistoryID.DataPropertyName = "SavingAccountHistoryID";
            SavingAccountHistoryID.HeaderText = "SavingAccountHistorylID";
            SavingAccountHistoryID.MinimumWidth = 6;
            SavingAccountHistoryID.Name = "SavingAccountHistoryID";
            SavingAccountHistoryID.Visible = false;
            SavingAccountHistoryID.Width = 125;
            // 
            // SubPeriodName
            // 
            SubPeriodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubPeriodName.DataPropertyName = "SubPeriodName";
            SubPeriodName.FillWeight = 150F;
            SubPeriodName.HeaderText = "Sub período";
            SubPeriodName.MinimumWidth = 6;
            SubPeriodName.Name = "SubPeriodName";
            SubPeriodName.ReadOnly = true;
            // 
            // HistoryType
            // 
            HistoryType.DataPropertyName = "HistoryType";
            HistoryType.HeaderText = "HistoryTypeData";
            HistoryType.MinimumWidth = 6;
            HistoryType.Name = "HistoryType";
            HistoryType.Visible = false;
            HistoryType.Width = 125;
            // 
            // HistoryName
            // 
            HistoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HistoryName.DataPropertyName = "HistoryName";
            HistoryName.FillWeight = 120F;
            HistoryName.HeaderText = "Tipo";
            HistoryName.MinimumWidth = 120;
            HistoryName.Name = "HistoryName";
            // 
            // AmountDisplay
            // 
            AmountDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AmountDisplay.DataPropertyName = "AmountDisplay";
            AmountDisplay.HeaderText = "Cantidad";
            AmountDisplay.MinimumWidth = 6;
            AmountDisplay.Name = "AmountDisplay";
            AmountDisplay.ReadOnly = true;
            // 
            // CreatedDate
            // 
            CreatedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "Fecha";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.ReadOnly = true;
            // 
            // TotalDisplay
            // 
            TotalDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalDisplay.DataPropertyName = "TotalDisplay";
            TotalDisplay.HeaderText = "Total";
            TotalDisplay.MinimumWidth = 6;
            TotalDisplay.Name = "TotalDisplay";
            // 
            // btnEditBeneficiary
            // 
            btnEditBeneficiary.BackColor = Color.SteelBlue;
            btnEditBeneficiary.Cursor = Cursors.Hand;
            btnEditBeneficiary.FlatAppearance.BorderSize = 0;
            btnEditBeneficiary.FlatStyle = FlatStyle.Flat;
            btnEditBeneficiary.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditBeneficiary.ForeColor = Color.White;
            btnEditBeneficiary.Location = new Point(138, 270);
            btnEditBeneficiary.Name = "btnEditBeneficiary";
            btnEditBeneficiary.Size = new Size(129, 50);
            btnEditBeneficiary.TabIndex = 34;
            btnEditBeneficiary.Text = "Beneficiario";
            btnEditBeneficiary.UseVisualStyleBackColor = false;
            btnEditBeneficiary.Click += btnEditBeneficiary_Click;
            // 
            // btnExportData
            // 
            btnExportData.BackColor = Color.SteelBlue;
            btnExportData.Cursor = Cursors.Hand;
            btnExportData.FlatAppearance.BorderSize = 0;
            btnExportData.FlatStyle = FlatStyle.System;
            btnExportData.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportData.ForeColor = Color.White;
            btnExportData.Location = new Point(970, 12);
            btnExportData.Name = "btnExportData";
            btnExportData.Size = new Size(101, 33);
            btnExportData.TabIndex = 35;
            btnExportData.Text = "Exportar";
            btnExportData.UseVisualStyleBackColor = false;
            btnExportData.Click += btnExportData_Click;
            // 
            // btnRevertInterestsWithdrawal
            // 
            btnRevertInterestsWithdrawal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRevertInterestsWithdrawal.BackColor = Color.Crimson;
            btnRevertInterestsWithdrawal.Cursor = Cursors.Hand;
            btnRevertInterestsWithdrawal.FlatAppearance.BorderColor = Color.ForestGreen;
            btnRevertInterestsWithdrawal.FlatAppearance.BorderSize = 0;
            btnRevertInterestsWithdrawal.FlatStyle = FlatStyle.Flat;
            btnRevertInterestsWithdrawal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRevertInterestsWithdrawal.ForeColor = Color.White;
            btnRevertInterestsWithdrawal.Location = new Point(578, 270);
            btnRevertInterestsWithdrawal.Margin = new Padding(0);
            btnRevertInterestsWithdrawal.Name = "btnRevertInterestsWithdrawal";
            btnRevertInterestsWithdrawal.Size = new Size(131, 50);
            btnRevertInterestsWithdrawal.TabIndex = 36;
            btnRevertInterestsWithdrawal.Text = "Revertir";
            btnRevertInterestsWithdrawal.UseVisualStyleBackColor = false;
            btnRevertInterestsWithdrawal.Click += btnRevertInterestsWithdrawal_Click;
            // 
            // FrmSavingAccountDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1080, 615);
            Controls.Add(btnRevertInterestsWithdrawal);
            Controls.Add(btnExportData);
            Controls.Add(btnEditBeneficiary);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdrawInsterest);
            Controls.Add(btnFinishSavingAccount);
            Controls.Add(gridWidthdrawalsList);
            Controls.Add(panel1);
            Controls.Add(lblSavingAccTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSavingAccountDetail";
            Text = "FrmSavingAccountDetail";
            Load += FrmSavingAccountDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridWidthdrawalsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIdentificationTitle;
        private Label lblINSSTitle;
        private Label lblClientFullNameTitle;
        private Label lblSavingAccTitle;
        private Label lblTotalAmount;
        private Label lblIdentificationData;
        private Label lblINSSData;
        private Label lblClientFullNameData;
        private Label lblTotalAmountData;
        private DataGridView gridWidthdrawalsList;
        private Label lblDepositGridTitle;
        private Button btnDeposit;
        private Button btnFinishSavingAccount;
        private Button btnWithdrawInsterest;
        private Label lblAmountForInterestsData;
        private Label lblAmountForInterests;
        private Label lblStatusData;
        private Label lblStatus;
        private Label lblCreatedDateData;
        private Label lblCreatedDate;
        private Panel panel1;
        private Label lblTotalWidthdrawnData;
        private Label lblTotalWidthdrawn;
        private Label lblCurrentAmountData;
        private Label lblCurrentAmount;
        private DataGridViewTextBoxColumn SavingAccountDepositID;
        private DataGridViewTextBoxColumn SubPeriod;
        private DataGridViewTextBoxColumn AmountColumn;
        private DataGridViewTextBoxColumn CreatedDateColumn;
        private Label lblBeneficiaryTitle;
        private Label lblBeneficiaryData;
        private Button btnEditBeneficiary;
        private Button btnExportData;
        private Button btnRevertInterestsWithdrawal;
        private DataGridViewTextBoxColumn SavingAccountHistoryID;
        private DataGridViewTextBoxColumn SubPeriodName;
        private DataGridViewTextBoxColumn HistoryType;
        private DataGridViewTextBoxColumn HistoryName;
        private DataGridViewTextBoxColumn AmountDisplay;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn TotalDisplay;
    }
}