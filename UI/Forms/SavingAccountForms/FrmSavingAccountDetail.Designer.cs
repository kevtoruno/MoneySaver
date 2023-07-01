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
            label7 = new Label();
            lblINSSTitle = new Label();
            label8 = new Label();
            lblIdentificationTitle = new Label();
            label5 = new Label();
            lblClientFullNameData = new Label();
            label6 = new Label();
            lblINSSData = new Label();
            lblIdentificationData = new Label();
            label3 = new Label();
            label4 = new Label();
            btnWithdrawInsterests = new Button();
            btnFinishSavingAccount = new Button();
            lblTotalSavingData = new Label();
            lblTotalSavingTitle = new Label();
            lblSavingAccTitle = new Label();
            rightPanel = new Panel();
            btnDeposit = new Button();
            lblWithDrawalGridTitle = new Label();
            lblDepositGridTitle = new Label();
            gridDepositsList = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            gridWidthdrawalsList = new DataGridView();
            SavingAccountWithdrawalID = new DataGridViewTextBoxColumn();
            SubPeriodName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
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
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(btnWithdrawInsterests);
            leftPanel.Controls.Add(btnFinishSavingAccount);
            leftPanel.Controls.Add(lblTotalSavingData);
            leftPanel.Controls.Add(lblTotalSavingTitle);
            leftPanel.Controls.Add(lblSavingAccTitle);
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(500, 615);
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblINSSTitle);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblIdentificationTitle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblClientFullNameData);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblINSSData);
            panel1.Controls.Add(lblIdentificationData);
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 223);
            panel1.TabIndex = 33;
            // 
            // lblClientFullNameTitle
            // 
            lblClientFullNameTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblClientFullNameTitle.AutoSize = true;
            lblClientFullNameTitle.BackColor = Color.Transparent;
            lblClientFullNameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientFullNameTitle.ForeColor = Color.White;
            lblClientFullNameTitle.Location = new Point(96, 9);
            lblClientFullNameTitle.Name = "lblClientFullNameTitle";
            lblClientFullNameTitle.Size = new Size(109, 28);
            lblClientFullNameTitle.TabIndex = 15;
            lblClientFullNameTitle.Text = "Trabajador:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(224, 170);
            label7.Name = "label7";
            label7.Size = new Size(116, 28);
            label7.TabIndex = 32;
            label7.Text = "00/00/2000";
            // 
            // lblINSSTitle
            // 
            lblINSSTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblINSSTitle.AutoSize = true;
            lblINSSTitle.BackColor = Color.Transparent;
            lblINSSTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblINSSTitle.ForeColor = Color.White;
            lblINSSTitle.Location = new Point(115, 49);
            lblINSSTitle.Name = "lblINSSTitle";
            lblINSSTitle.Size = new Size(90, 28);
            lblINSSTitle.TabIndex = 16;
            lblINSSTitle.Text = "No INSS:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(38, 170);
            label8.Name = "label8";
            label8.Size = new Size(167, 28);
            label8.TabIndex = 31;
            label8.Text = "Fecha de creación";
            // 
            // lblIdentificationTitle
            // 
            lblIdentificationTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblIdentificationTitle.AutoSize = true;
            lblIdentificationTitle.BackColor = Color.Transparent;
            lblIdentificationTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentificationTitle.ForeColor = Color.White;
            lblIdentificationTitle.Location = new Point(129, 89);
            lblIdentificationTitle.Name = "lblIdentificationTitle";
            lblIdentificationTitle.Size = new Size(76, 28);
            lblIdentificationTitle.TabIndex = 17;
            lblIdentificationTitle.Text = "Cédula:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(224, 127);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 30;
            label5.Text = "Activa";
            // 
            // lblClientFullNameData
            // 
            lblClientFullNameData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblClientFullNameData.AutoSize = true;
            lblClientFullNameData.BackColor = Color.Transparent;
            lblClientFullNameData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientFullNameData.ForeColor = Color.White;
            lblClientFullNameData.Location = new Point(224, 9);
            lblClientFullNameData.Name = "lblClientFullNameData";
            lblClientFullNameData.Size = new Size(20, 28);
            lblClientFullNameData.TabIndex = 21;
            lblClientFullNameData.Text = "..";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(129, 127);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 29;
            label6.Text = "Estado:";
            // 
            // lblINSSData
            // 
            lblINSSData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblINSSData.AutoSize = true;
            lblINSSData.BackColor = Color.Transparent;
            lblINSSData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblINSSData.ForeColor = Color.White;
            lblINSSData.Location = new Point(224, 49);
            lblINSSData.Name = "lblINSSData";
            lblINSSData.Size = new Size(45, 28);
            lblINSSData.TabIndex = 22;
            lblINSSData.Text = "000";
            // 
            // lblIdentificationData
            // 
            lblIdentificationData.AutoSize = true;
            lblIdentificationData.BackColor = Color.Transparent;
            lblIdentificationData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentificationData.ForeColor = Color.White;
            lblIdentificationData.Location = new Point(224, 89);
            lblIdentificationData.Name = "lblIdentificationData";
            lblIdentificationData.Size = new Size(168, 28);
            lblIdentificationData.TabIndex = 23;
            lblIdentificationData.Text = "0000000000000A";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LawnGreen;
            label3.Location = new Point(290, 472);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 28;
            label3.Text = "$$$$";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 472);
            label4.Name = "label4";
            label4.Size = new Size(263, 28);
            label4.TabIndex = 27;
            label4.Text = "Acumulado para intereses:";
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
            // lblTotalSavingData
            // 
            lblTotalSavingData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalSavingData.AutoSize = true;
            lblTotalSavingData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalSavingData.ForeColor = Color.LawnGreen;
            lblTotalSavingData.Location = new Point(290, 582);
            lblTotalSavingData.Name = "lblTotalSavingData";
            lblTotalSavingData.Size = new Size(60, 28);
            lblTotalSavingData.TabIndex = 20;
            lblTotalSavingData.Text = "$$$$";
            // 
            // lblTotalSavingTitle
            // 
            lblTotalSavingTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalSavingTitle.AutoSize = true;
            lblTotalSavingTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalSavingTitle.ForeColor = Color.White;
            lblTotalSavingTitle.Location = new Point(10, 582);
            lblTotalSavingTitle.Name = "lblTotalSavingTitle";
            lblTotalSavingTitle.Size = new Size(156, 28);
            lblTotalSavingTitle.TabIndex = 19;
            lblTotalSavingTitle.Text = "Total ahorrado:";
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
            rightPanel.Location = new Point(500, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(580, 615);
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
            lblWithDrawalGridTitle.Location = new Point(282, 45);
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
            lblDepositGridTitle.Location = new Point(282, 299);
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
            gridDepositsList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
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
            gridDepositsList.Size = new Size(570, 279);
            gridDepositsList.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            dataGridViewTextBoxColumn1.HeaderText = "ClientID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "INSS";
            dataGridViewTextBoxColumn2.HeaderText = "INSS";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "FullName";
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "Identification";
            dataGridViewTextBoxColumn4.HeaderText = "Cédula";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "Age";
            dataGridViewTextBoxColumn5.HeaderText = "Edad";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
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
            gridWidthdrawalsList.Size = new Size(570, 169);
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
        private Label lblTotalSavingTitle;
        private Label lblIdentificationData;
        private Label lblINSSData;
        private Label lblClientFullNameData;
        private Label lblTotalSavingData;
        private DataGridView gridDepositsList;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView gridWidthdrawalsList;
        private Label lblWithDrawalGridTitle;
        private Label lblDepositGridTitle;
        private Button btnDeposit;
        private Button btnFinishSavingAccount;
        private Button btnWithdrawInsterests;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Label lblTotalWidthdrawnData;
        private Label lblTotalWidthdrawn;
        private Label lblCurrentAmountData;
        private Label lblCurrentAmount;
        private DataGridViewTextBoxColumn SavingAccountWithdrawalID;
        private DataGridViewTextBoxColumn SubPeriodName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn CreatedDate;
    }
}