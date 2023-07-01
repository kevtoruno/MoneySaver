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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            leftPanel = new Panel();
            lblTotalWidthdrawnData = new Label();
            lblTotalWidthdrawn = new Label();
            lblCurrentAmountData = new Label();
            lblCurrentAmount = new Label();
            panel1 = new Panel();
            lblClientFullNameTitle = new Label();
            lblCreatedDateData = new Label();
            lblINSSTitle = new Label();
            lblCreatedDate = new Label();
            lblIdentificationTitle = new Label();
            lblStatusData = new Label();
            lblClientFullNameData = new Label();
            lblStatus = new Label();
            lblINSSData = new Label();
            lblIdentificationData = new Label();
            lblAmountForInterestsData = new Label();
            lblAmountForInterests = new Label();
            btnWithdrawInsterests = new Button();
            btnFinishSavingAccount = new Button();
            lblTotalAmountData = new Label();
            lblTotalAmount = new Label();
            lblSavingAccTitle = new Label();
            rightPanel = new Panel();
            btnDeposit = new Button();
            lblWithDrawalGridTitle = new Label();
            lblDepositGridTitle = new Label();
            gridDepositsList = new DataGridView();
            gridWidthdrawalsList = new DataGridView();
            SavingAccountWithdrawalID = new DataGridViewTextBoxColumn();
            SubPeriodName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            SavingAccountDepositID = new DataGridViewTextBoxColumn();
            SubPeriod = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            CreatedDateColumn = new DataGridViewTextBoxColumn();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDepositsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridWidthdrawalsList).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            leftPanel.BackColor = Color.FromArgb(49, 66, 82);
            leftPanel.Controls.Add(lblTotalWidthdrawnData);
            leftPanel.Controls.Add(lblTotalWidthdrawn);
            leftPanel.Controls.Add(lblCurrentAmountData);
            leftPanel.Controls.Add(lblCurrentAmount);
            leftPanel.Controls.Add(panel1);
            leftPanel.Controls.Add(lblAmountForInterestsData);
            leftPanel.Controls.Add(lblAmountForInterests);
            leftPanel.Controls.Add(btnWithdrawInsterests);
            leftPanel.Controls.Add(btnFinishSavingAccount);
            leftPanel.Controls.Add(lblTotalAmountData);
            leftPanel.Controls.Add(lblTotalAmount);
            leftPanel.Controls.Add(lblSavingAccTitle);
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(520, 615);
            leftPanel.TabIndex = 0;
            // 
            // lblTotalWidthdrawnData
            // 
            lblTotalWidthdrawnData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalWidthdrawnData.AutoSize = true;
            lblTotalWidthdrawnData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalWidthdrawnData.ForeColor = Color.LawnGreen;
            lblTotalWidthdrawnData.Location = new Point(290, 542);
            lblTotalWidthdrawnData.Name = "lblTotalWidthdrawnData";
            lblTotalWidthdrawnData.Size = new Size(60, 28);
            lblTotalWidthdrawnData.TabIndex = 37;
            lblTotalWidthdrawnData.Text = "$$$$";
            // 
            // lblTotalWidthdrawn
            // 
            lblTotalWidthdrawn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalWidthdrawn.AutoSize = true;
            lblTotalWidthdrawn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalWidthdrawn.ForeColor = Color.White;
            lblTotalWidthdrawn.Location = new Point(10, 542);
            lblTotalWidthdrawn.Name = "lblTotalWidthdrawn";
            lblTotalWidthdrawn.Size = new Size(146, 28);
            lblTotalWidthdrawn.TabIndex = 36;
            lblTotalWidthdrawn.Text = "Total retirado:";
            // 
            // lblCurrentAmountData
            // 
            lblCurrentAmountData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentAmountData.AutoSize = true;
            lblCurrentAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentAmountData.ForeColor = Color.LawnGreen;
            lblCurrentAmountData.Location = new Point(290, 502);
            lblCurrentAmountData.Name = "lblCurrentAmountData";
            lblCurrentAmountData.Size = new Size(60, 28);
            lblCurrentAmountData.TabIndex = 35;
            lblCurrentAmountData.Text = "$$$$";
            // 
            // lblCurrentAmount
            // 
            lblCurrentAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentAmount.AutoSize = true;
            lblCurrentAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentAmount.ForeColor = Color.White;
            lblCurrentAmount.Location = new Point(10, 502);
            lblCurrentAmount.Name = "lblCurrentAmount";
            lblCurrentAmount.Size = new Size(144, 28);
            lblCurrentAmount.TabIndex = 34;
            lblCurrentAmount.Text = "Monto actual:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(49, 66, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblClientFullNameTitle);
            panel1.Controls.Add(lblCreatedDateData);
            panel1.Controls.Add(lblINSSTitle);
            panel1.Controls.Add(lblCreatedDate);
            panel1.Controls.Add(lblIdentificationTitle);
            panel1.Controls.Add(lblStatusData);
            panel1.Controls.Add(lblClientFullNameData);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblINSSData);
            panel1.Controls.Add(lblIdentificationData);
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 223);
            panel1.TabIndex = 33;
            // 
            // lblClientFullNameTitle
            // 
            lblClientFullNameTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblClientFullNameTitle.AutoSize = true;
            lblClientFullNameTitle.BackColor = Color.Transparent;
            lblClientFullNameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientFullNameTitle.ForeColor = Color.White;
            lblClientFullNameTitle.Location = new Point(65, 13);
            lblClientFullNameTitle.Name = "lblClientFullNameTitle";
            lblClientFullNameTitle.Size = new Size(109, 28);
            lblClientFullNameTitle.TabIndex = 15;
            lblClientFullNameTitle.Text = "Trabajador:";
            // 
            // lblCreatedDateData
            // 
            lblCreatedDateData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCreatedDateData.AutoSize = true;
            lblCreatedDateData.BackColor = Color.Transparent;
            lblCreatedDateData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedDateData.ForeColor = Color.White;
            lblCreatedDateData.Location = new Point(179, 179);
            lblCreatedDateData.Name = "lblCreatedDateData";
            lblCreatedDateData.Size = new Size(96, 23);
            lblCreatedDateData.TabIndex = 32;
            lblCreatedDateData.Text = "00/00/2000";
            // 
            // lblINSSTitle
            // 
            lblINSSTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblINSSTitle.AutoSize = true;
            lblINSSTitle.BackColor = Color.Transparent;
            lblINSSTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblINSSTitle.ForeColor = Color.White;
            lblINSSTitle.Location = new Point(84, 53);
            lblINSSTitle.Name = "lblINSSTitle";
            lblINSSTitle.Size = new Size(90, 28);
            lblINSSTitle.TabIndex = 16;
            lblINSSTitle.Text = "No INSS:";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.BackColor = Color.Transparent;
            lblCreatedDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedDate.ForeColor = Color.White;
            lblCreatedDate.Location = new Point(7, 174);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(167, 28);
            lblCreatedDate.TabIndex = 31;
            lblCreatedDate.Text = "Fecha de creación";
            // 
            // lblIdentificationTitle
            // 
            lblIdentificationTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblIdentificationTitle.AutoSize = true;
            lblIdentificationTitle.BackColor = Color.Transparent;
            lblIdentificationTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentificationTitle.ForeColor = Color.White;
            lblIdentificationTitle.Location = new Point(98, 93);
            lblIdentificationTitle.Name = "lblIdentificationTitle";
            lblIdentificationTitle.Size = new Size(76, 28);
            lblIdentificationTitle.TabIndex = 17;
            lblIdentificationTitle.Text = "Cédula:";
            // 
            // lblStatusData
            // 
            lblStatusData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStatusData.AutoSize = true;
            lblStatusData.BackColor = Color.Transparent;
            lblStatusData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusData.ForeColor = Color.White;
            lblStatusData.Location = new Point(179, 136);
            lblStatusData.Name = "lblStatusData";
            lblStatusData.Size = new Size(56, 23);
            lblStatusData.TabIndex = 30;
            lblStatusData.Text = "Activa";
            // 
            // lblClientFullNameData
            // 
            lblClientFullNameData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblClientFullNameData.AutoSize = true;
            lblClientFullNameData.BackColor = Color.Transparent;
            lblClientFullNameData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientFullNameData.ForeColor = Color.White;
            lblClientFullNameData.Location = new Point(179, 18);
            lblClientFullNameData.Name = "lblClientFullNameData";
            lblClientFullNameData.Size = new Size(18, 23);
            lblClientFullNameData.TabIndex = 21;
            lblClientFullNameData.Text = "..";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(98, 131);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 28);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "Estado:";
            // 
            // lblINSSData
            // 
            lblINSSData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblINSSData.AutoSize = true;
            lblINSSData.BackColor = Color.Transparent;
            lblINSSData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblINSSData.ForeColor = Color.White;
            lblINSSData.Location = new Point(179, 58);
            lblINSSData.Name = "lblINSSData";
            lblINSSData.Size = new Size(37, 23);
            lblINSSData.TabIndex = 22;
            lblINSSData.Text = "000";
            // 
            // lblIdentificationData
            // 
            lblIdentificationData.AutoSize = true;
            lblIdentificationData.BackColor = Color.Transparent;
            lblIdentificationData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentificationData.ForeColor = Color.White;
            lblIdentificationData.Location = new Point(179, 98);
            lblIdentificationData.Name = "lblIdentificationData";
            lblIdentificationData.Size = new Size(138, 23);
            lblIdentificationData.TabIndex = 23;
            lblIdentificationData.Text = "0000000000000A";
            // 
            // lblAmountForInterestsData
            // 
            lblAmountForInterestsData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAmountForInterestsData.AutoSize = true;
            lblAmountForInterestsData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmountForInterestsData.ForeColor = Color.LawnGreen;
            lblAmountForInterestsData.Location = new Point(290, 472);
            lblAmountForInterestsData.Name = "lblAmountForInterestsData";
            lblAmountForInterestsData.Size = new Size(60, 28);
            lblAmountForInterestsData.TabIndex = 28;
            lblAmountForInterestsData.Text = "$$$$";
            // 
            // lblAmountForInterests
            // 
            lblAmountForInterests.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAmountForInterests.AutoSize = true;
            lblAmountForInterests.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmountForInterests.ForeColor = Color.White;
            lblAmountForInterests.Location = new Point(10, 472);
            lblAmountForInterests.Name = "lblAmountForInterests";
            lblAmountForInterests.Size = new Size(263, 28);
            lblAmountForInterests.TabIndex = 27;
            lblAmountForInterests.Text = "Acumulado para intereses:";
            // 
            // btnWithdrawInsterests
            // 
            btnWithdrawInsterests.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnWithdrawInsterests.BackColor = Color.FromArgb(51, 178, 73);
            btnWithdrawInsterests.Cursor = Cursors.Hand;
            btnWithdrawInsterests.FlatAppearance.BorderColor = Color.ForestGreen;
            btnWithdrawInsterests.FlatAppearance.BorderSize = 0;
            btnWithdrawInsterests.FlatStyle = FlatStyle.Flat;
            btnWithdrawInsterests.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithdrawInsterests.ForeColor = Color.White;
            btnWithdrawInsterests.Location = new Point(317, 330);
            btnWithdrawInsterests.Margin = new Padding(0);
            btnWithdrawInsterests.Name = "btnWithdrawInsterests";
            btnWithdrawInsterests.Size = new Size(170, 50);
            btnWithdrawInsterests.TabIndex = 26;
            btnWithdrawInsterests.Text = "Retirar intereses";
            btnWithdrawInsterests.UseVisualStyleBackColor = false;
            // 
            // btnFinishSavingAccount
            // 
            btnFinishSavingAccount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFinishSavingAccount.BackColor = Color.Crimson;
            btnFinishSavingAccount.Cursor = Cursors.Hand;
            btnFinishSavingAccount.FlatAppearance.BorderColor = Color.ForestGreen;
            btnFinishSavingAccount.FlatAppearance.BorderSize = 0;
            btnFinishSavingAccount.FlatStyle = FlatStyle.Flat;
            btnFinishSavingAccount.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinishSavingAccount.ForeColor = Color.White;
            btnFinishSavingAccount.Location = new Point(16, 322);
            btnFinishSavingAccount.Margin = new Padding(0);
            btnFinishSavingAccount.Name = "btnFinishSavingAccount";
            btnFinishSavingAccount.Size = new Size(172, 66);
            btnFinishSavingAccount.TabIndex = 25;
            btnFinishSavingAccount.Text = "Cerrar cuenta de ahorro";
            btnFinishSavingAccount.UseVisualStyleBackColor = false;
            // 
            // lblTotalAmountData
            // 
            lblTotalAmountData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalAmountData.AutoSize = true;
            lblTotalAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmountData.ForeColor = Color.LawnGreen;
            lblTotalAmountData.Location = new Point(290, 582);
            lblTotalAmountData.Name = "lblTotalAmountData";
            lblTotalAmountData.Size = new Size(60, 28);
            lblTotalAmountData.TabIndex = 20;
            lblTotalAmountData.Text = "$$$$";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(10, 582);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(156, 28);
            lblTotalAmount.TabIndex = 19;
            lblTotalAmount.Text = "Total ahorrado:";
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(147, 39);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(246, 36);
            lblSavingAccTitle.TabIndex = 18;
            lblSavingAccTitle.Text = "Cuenta de ahorro";
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rightPanel.BackColor = Color.FromArgb(49, 66, 82);
            rightPanel.Controls.Add(btnDeposit);
            rightPanel.Controls.Add(lblWithDrawalGridTitle);
            rightPanel.Controls.Add(lblDepositGridTitle);
            rightPanel.Controls.Add(gridDepositsList);
            rightPanel.Controls.Add(gridWidthdrawalsList);
            rightPanel.Location = new Point(520, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(560, 615);
            rightPanel.TabIndex = 1;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.SteelBlue;
            btnDeposit.Cursor = Cursors.Hand;
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeposit.ForeColor = SystemColors.Control;
            btnDeposit.Location = new Point(6, 293);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(125, 34);
            btnDeposit.TabIndex = 27;
            btnDeposit.Text = "Depositar";
            btnDeposit.TextAlign = ContentAlignment.TopCenter;
            btnDeposit.UseVisualStyleBackColor = false;
            // 
            // lblWithDrawalGridTitle
            // 
            lblWithDrawalGridTitle.Anchor = AnchorStyles.Top;
            lblWithDrawalGridTitle.AutoSize = true;
            lblWithDrawalGridTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblWithDrawalGridTitle.ForeColor = SystemColors.Control;
            lblWithDrawalGridTitle.Location = new Point(216, 46);
            lblWithDrawalGridTitle.Name = "lblWithDrawalGridTitle";
            lblWithDrawalGridTitle.Size = new Size(90, 29);
            lblWithDrawalGridTitle.TabIndex = 25;
            lblWithDrawalGridTitle.Text = "Retiros";
            // 
            // lblDepositGridTitle
            // 
            lblDepositGridTitle.Anchor = AnchorStyles.Top;
            lblDepositGridTitle.AutoSize = true;
            lblDepositGridTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepositGridTitle.ForeColor = SystemColors.Control;
            lblDepositGridTitle.Location = new Point(216, 293);
            lblDepositGridTitle.Name = "lblDepositGridTitle";
            lblDepositGridTitle.Size = new Size(122, 29);
            lblDepositGridTitle.TabIndex = 24;
            lblDepositGridTitle.Text = "Depósitos";
            // 
            // gridDepositsList
            // 
            gridDepositsList.AllowUserToAddRows = false;
            gridDepositsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridDepositsList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridDepositsList.BorderStyle = BorderStyle.None;
            gridDepositsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridDepositsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridDepositsList.ColumnHeadersHeight = 30;
            gridDepositsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridDepositsList.Columns.AddRange(new DataGridViewColumn[] { SavingAccountDepositID, SubPeriod, AmountColumn, CreatedDateColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridDepositsList.DefaultCellStyle = dataGridViewCellStyle2;
            gridDepositsList.EnableHeadersVisualStyles = false;
            gridDepositsList.GridColor = Color.SteelBlue;
            gridDepositsList.Location = new Point(3, 333);
            gridDepositsList.Name = "gridDepositsList";
            gridDepositsList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridDepositsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridDepositsList.RowHeadersVisible = false;
            gridDepositsList.RowHeadersWidth = 51;
            gridDepositsList.RowTemplate.Height = 29;
            gridDepositsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDepositsList.Size = new Size(550, 279);
            gridDepositsList.TabIndex = 6;
            // 
            // gridWidthdrawalsList
            // 
            gridWidthdrawalsList.AllowUserToAddRows = false;
            gridWidthdrawalsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridWidthdrawalsList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridWidthdrawalsList.BorderStyle = BorderStyle.None;
            gridWidthdrawalsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridWidthdrawalsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridWidthdrawalsList.ColumnHeadersHeight = 30;
            gridWidthdrawalsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridWidthdrawalsList.Columns.AddRange(new DataGridViewColumn[] { SavingAccountWithdrawalID, SubPeriodName, Amount, CreatedDate });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridWidthdrawalsList.DefaultCellStyle = dataGridViewCellStyle5;
            gridWidthdrawalsList.EnableHeadersVisualStyles = false;
            gridWidthdrawalsList.GridColor = Color.SteelBlue;
            gridWidthdrawalsList.Location = new Point(3, 77);
            gridWidthdrawalsList.Name = "gridWidthdrawalsList";
            gridWidthdrawalsList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridWidthdrawalsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridWidthdrawalsList.RowHeadersVisible = false;
            gridWidthdrawalsList.RowHeadersWidth = 51;
            gridWidthdrawalsList.RowTemplate.Height = 29;
            gridWidthdrawalsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridWidthdrawalsList.Size = new Size(550, 169);
            gridWidthdrawalsList.TabIndex = 5;
            // 
            // SavingAccountWithdrawalID
            // 
            SavingAccountWithdrawalID.DataPropertyName = "SavingAccountWithdrawalID";
            SavingAccountWithdrawalID.HeaderText = "SavingAccountWithdrawalID";
            SavingAccountWithdrawalID.MinimumWidth = 6;
            SavingAccountWithdrawalID.Name = "SavingAccountWithdrawalID";
            SavingAccountWithdrawalID.Visible = false;
            SavingAccountWithdrawalID.Width = 125;
            // 
            // SubPeriodName
            // 
            SubPeriodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubPeriodName.DataPropertyName = "SubPeriodName";
            SubPeriodName.HeaderText = "Sub período";
            SubPeriodName.MinimumWidth = 6;
            SubPeriodName.Name = "SubPeriodName";
            SubPeriodName.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Cantidad";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
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
            // SavingAccountDepositID
            // 
            SavingAccountDepositID.DataPropertyName = "SavingAccountDepositID";
            SavingAccountDepositID.HeaderText = "SavingAccountDepositID";
            SavingAccountDepositID.MinimumWidth = 6;
            SavingAccountDepositID.Name = "SavingAccountDepositID";
            SavingAccountDepositID.Visible = false;
            SavingAccountDepositID.Width = 125;
            // 
            // SubPeriod
            // 
            SubPeriod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubPeriod.DataPropertyName = "SubPeriodName";
            SubPeriod.HeaderText = "Sub período";
            SubPeriod.MinimumWidth = 6;
            SubPeriod.Name = "SubPeriod";
            SubPeriod.ReadOnly = true;
            // 
            // AmountColumn
            // 
            AmountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AmountColumn.DataPropertyName = "Amount";
            AmountColumn.HeaderText = "Cantidad";
            AmountColumn.MinimumWidth = 6;
            AmountColumn.Name = "AmountColumn";
            AmountColumn.ReadOnly = true;
            // 
            // CreatedDateColumn
            // 
            CreatedDateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreatedDateColumn.DataPropertyName = "CreatedDate";
            CreatedDateColumn.HeaderText = "Fecha";
            CreatedDateColumn.MinimumWidth = 6;
            CreatedDateColumn.Name = "CreatedDateColumn";
            CreatedDateColumn.ReadOnly = true;
            // 
            // FrmSavingAccountDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1080, 615);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSavingAccountDetail";
            Text = "FrmSavingAccountDetail";
            Load += FrmSavingAccountDetail_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridDepositsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridWidthdrawalsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel rightPanel;
        private Label lblIdentificationTitle;
        private Label lblINSSTitle;
        private Label lblClientFullNameTitle;
        private Label lblSavingAccTitle;
        private Label lblTotalAmount;
        private Label lblIdentificationData;
        private Label lblINSSData;
        private Label lblClientFullNameData;
        private Label lblTotalAmountData;
        private DataGridView gridDepositsList;
        private DataGridView gridWidthdrawalsList;
        private Label lblWithDrawalGridTitle;
        private Label lblDepositGridTitle;
        private Button btnDeposit;
        private Button btnFinishSavingAccount;
        private Button btnWithdrawInsterests;
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
        private DataGridViewTextBoxColumn SavingAccountWithdrawalID;
        private DataGridViewTextBoxColumn SubPeriodName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn SavingAccountDepositID;
        private DataGridViewTextBoxColumn SubPeriod;
        private DataGridViewTextBoxColumn AmountColumn;
        private DataGridViewTextBoxColumn CreatedDateColumn;
    }
}