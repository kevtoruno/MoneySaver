namespace UI.Forms.PeriodsForms
{
    partial class FrmSubPeriodCalculateInterestsForSavingAcc
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblSavingAccTitle = new Label();
            panel1 = new Panel();
            lblUtilityMonths = new Label();
            txtUtilityMonths = new NumericUpDown();
            lblTotalDepositsAmount = new Label();
            lblTotalDepositsAmountData = new Label();
            lblInterestFactorData = new Label();
            lblTotalAmountRecovered = new Label();
            btnPreview = new Button();
            label1 = new Label();
            lblTotalAmountLoaned = new Label();
            lblTotalAmountRecoveredData = new Label();
            lblTotalAmountLoanedData = new Label();
            gridInterestFactorPreview = new DataGridView();
            SavingAccountID = new DataGridViewTextBoxColumn();
            INSSNo = new DataGridViewTextBoxColumn();
            ClientFullName = new DataGridViewTextBoxColumn();
            TotalDepositAmountDisplay = new DataGridViewTextBoxColumn();
            InterestGeneratedAmountDisplay = new DataGridViewTextBoxColumn();
            btnCreate = new Button();
            btnCancel = new Button();
            btnBackToPeriod = new Button();
            label2 = new Label();
            dtDepositDate = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtUtilityMonths).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridInterestFactorPreview).BeginInit();
            SuspendLayout();
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(359, 23);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(303, 36);
            lblSavingAccTitle.TabIndex = 19;
            lblSavingAccTitle.Text = "Calcular factor interes";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(49, 66, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtDepositDate);
            panel1.Controls.Add(lblUtilityMonths);
            panel1.Controls.Add(txtUtilityMonths);
            panel1.Controls.Add(lblTotalDepositsAmount);
            panel1.Controls.Add(lblTotalDepositsAmountData);
            panel1.Controls.Add(lblInterestFactorData);
            panel1.Controls.Add(lblTotalAmountRecovered);
            panel1.Controls.Add(btnPreview);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTotalAmountLoaned);
            panel1.Controls.Add(lblTotalAmountRecoveredData);
            panel1.Controls.Add(lblTotalAmountLoanedData);
            panel1.Location = new Point(0, 77);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 139);
            panel1.TabIndex = 34;
            // 
            // lblUtilityMonths
            // 
            lblUtilityMonths.Anchor = AnchorStyles.None;
            lblUtilityMonths.AutoSize = true;
            lblUtilityMonths.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUtilityMonths.ForeColor = SystemColors.Control;
            lblUtilityMonths.Location = new Point(663, 60);
            lblUtilityMonths.Name = "lblUtilityMonths";
            lblUtilityMonths.Size = new Size(126, 25);
            lblUtilityMonths.TabIndex = 41;
            lblUtilityMonths.Text = "Meses utilidad";
            // 
            // txtUtilityMonths
            // 
            txtUtilityMonths.Anchor = AnchorStyles.None;
            txtUtilityMonths.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUtilityMonths.Location = new Point(681, 88);
            txtUtilityMonths.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            txtUtilityMonths.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            txtUtilityMonths.Name = "txtUtilityMonths";
            txtUtilityMonths.Size = new Size(79, 31);
            txtUtilityMonths.TabIndex = 40;
            txtUtilityMonths.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // lblTotalDepositsAmount
            // 
            lblTotalDepositsAmount.Anchor = AnchorStyles.Right;
            lblTotalDepositsAmount.AutoSize = true;
            lblTotalDepositsAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalDepositsAmount.ForeColor = Color.White;
            lblTotalDepositsAmount.Location = new Point(57, 91);
            lblTotalDepositsAmount.Name = "lblTotalDepositsAmount";
            lblTotalDepositsAmount.Size = new Size(151, 28);
            lblTotalDepositsAmount.TabIndex = 38;
            lblTotalDepositsAmount.Text = "Total cotizado:";
            // 
            // lblTotalDepositsAmountData
            // 
            lblTotalDepositsAmountData.Anchor = AnchorStyles.Right;
            lblTotalDepositsAmountData.AutoSize = true;
            lblTotalDepositsAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalDepositsAmountData.ForeColor = Color.LawnGreen;
            lblTotalDepositsAmountData.Location = new Point(232, 91);
            lblTotalDepositsAmountData.Name = "lblTotalDepositsAmountData";
            lblTotalDepositsAmountData.Size = new Size(60, 28);
            lblTotalDepositsAmountData.TabIndex = 39;
            lblTotalDepositsAmountData.Text = "$$$$";
            // 
            // lblInterestFactorData
            // 
            lblInterestFactorData.Anchor = AnchorStyles.Right;
            lblInterestFactorData.AutoSize = true;
            lblInterestFactorData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterestFactorData.ForeColor = Color.LawnGreen;
            lblInterestFactorData.Location = new Point(946, 15);
            lblInterestFactorData.Name = "lblInterestFactorData";
            lblInterestFactorData.Size = new Size(70, 28);
            lblInterestFactorData.TabIndex = 37;
            lblInterestFactorData.Text = "0.00%";
            // 
            // lblTotalAmountRecovered
            // 
            lblTotalAmountRecovered.Anchor = AnchorStyles.Right;
            lblTotalAmountRecovered.AutoSize = true;
            lblTotalAmountRecovered.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmountRecovered.ForeColor = Color.White;
            lblTotalAmountRecovered.Location = new Point(31, 52);
            lblTotalAmountRecovered.Name = "lblTotalAmountRecovered";
            lblTotalAmountRecovered.Size = new Size(177, 28);
            lblTotalAmountRecovered.TabIndex = 27;
            lblTotalAmountRecovered.Text = "Total recuperado:";
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.FromArgb(51, 178, 73);
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(795, 69);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(223, 50);
            btnPreview.TabIndex = 37;
            btnPreview.Text = "Calcular y previsualizar";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(781, 15);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 36;
            label1.Text = "Factor interés:";
            // 
            // lblTotalAmountLoaned
            // 
            lblTotalAmountLoaned.Anchor = AnchorStyles.Right;
            lblTotalAmountLoaned.AutoSize = true;
            lblTotalAmountLoaned.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmountLoaned.ForeColor = Color.White;
            lblTotalAmountLoaned.Location = new Point(55, 15);
            lblTotalAmountLoaned.Name = "lblTotalAmountLoaned";
            lblTotalAmountLoaned.Size = new Size(153, 28);
            lblTotalAmountLoaned.TabIndex = 34;
            lblTotalAmountLoaned.Text = "Total préstado:";
            // 
            // lblTotalAmountRecoveredData
            // 
            lblTotalAmountRecoveredData.Anchor = AnchorStyles.Right;
            lblTotalAmountRecoveredData.AutoSize = true;
            lblTotalAmountRecoveredData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmountRecoveredData.ForeColor = Color.LawnGreen;
            lblTotalAmountRecoveredData.Location = new Point(232, 52);
            lblTotalAmountRecoveredData.Name = "lblTotalAmountRecoveredData";
            lblTotalAmountRecoveredData.Size = new Size(60, 28);
            lblTotalAmountRecoveredData.TabIndex = 28;
            lblTotalAmountRecoveredData.Text = "$$$$";
            // 
            // lblTotalAmountLoanedData
            // 
            lblTotalAmountLoanedData.Anchor = AnchorStyles.Right;
            lblTotalAmountLoanedData.AutoSize = true;
            lblTotalAmountLoanedData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmountLoanedData.ForeColor = Color.LawnGreen;
            lblTotalAmountLoanedData.Location = new Point(232, 15);
            lblTotalAmountLoanedData.Name = "lblTotalAmountLoanedData";
            lblTotalAmountLoanedData.Size = new Size(60, 28);
            lblTotalAmountLoanedData.TabIndex = 35;
            lblTotalAmountLoanedData.Text = "$$$$";
            // 
            // gridInterestFactorPreview
            // 
            gridInterestFactorPreview.AllowUserToAddRows = false;
            gridInterestFactorPreview.AllowUserToResizeRows = false;
            gridInterestFactorPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridInterestFactorPreview.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridInterestFactorPreview.BorderStyle = BorderStyle.None;
            gridInterestFactorPreview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridInterestFactorPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridInterestFactorPreview.ColumnHeadersHeight = 30;
            gridInterestFactorPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridInterestFactorPreview.Columns.AddRange(new DataGridViewColumn[] { SavingAccountID, INSSNo, ClientFullName, TotalDepositAmountDisplay, InterestGeneratedAmountDisplay });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridInterestFactorPreview.DefaultCellStyle = dataGridViewCellStyle5;
            gridInterestFactorPreview.EnableHeadersVisualStyles = false;
            gridInterestFactorPreview.GridColor = Color.SteelBlue;
            gridInterestFactorPreview.Location = new Point(0, 238);
            gridInterestFactorPreview.Name = "gridInterestFactorPreview";
            gridInterestFactorPreview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridInterestFactorPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridInterestFactorPreview.RowHeadersVisible = false;
            gridInterestFactorPreview.RowHeadersWidth = 51;
            gridInterestFactorPreview.RowTemplate.Height = 29;
            gridInterestFactorPreview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridInterestFactorPreview.Size = new Size(1076, 315);
            gridInterestFactorPreview.TabIndex = 36;
            // 
            // SavingAccountID
            // 
            SavingAccountID.DataPropertyName = "SavingAccountID";
            SavingAccountID.HeaderText = "SavingAccountID";
            SavingAccountID.MinimumWidth = 6;
            SavingAccountID.Name = "SavingAccountID";
            SavingAccountID.Visible = false;
            SavingAccountID.Width = 125;
            // 
            // INSSNo
            // 
            INSSNo.DataPropertyName = "INSSNo";
            INSSNo.HeaderText = "INSS";
            INSSNo.MinimumWidth = 6;
            INSSNo.Name = "INSSNo";
            INSSNo.Width = 125;
            // 
            // ClientFullName
            // 
            ClientFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClientFullName.DataPropertyName = "ClientFullName";
            ClientFullName.FillWeight = 282.258057F;
            ClientFullName.HeaderText = "Afiliado";
            ClientFullName.MinimumWidth = 6;
            ClientFullName.Name = "ClientFullName";
            ClientFullName.ReadOnly = true;
            ClientFullName.Width = 400;
            // 
            // TotalDepositAmountDisplay
            // 
            TotalDepositAmountDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalDepositAmountDisplay.DataPropertyName = "TotalDepositAmountDisplay";
            TotalDepositAmountDisplay.FillWeight = 33.87097F;
            TotalDepositAmountDisplay.HeaderText = "Total cotizado";
            TotalDepositAmountDisplay.MinimumWidth = 6;
            TotalDepositAmountDisplay.Name = "TotalDepositAmountDisplay";
            TotalDepositAmountDisplay.ReadOnly = true;
            // 
            // InterestGeneratedAmountDisplay
            // 
            InterestGeneratedAmountDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InterestGeneratedAmountDisplay.DataPropertyName = "InterestGeneratedAmountDisplay";
            InterestGeneratedAmountDisplay.FillWeight = 33.87097F;
            InterestGeneratedAmountDisplay.HeaderText = "Intereses Generados";
            InterestGeneratedAmountDisplay.MinimumWidth = 6;
            InterestGeneratedAmountDisplay.Name = "InterestGeneratedAmountDisplay";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.FromArgb(51, 178, 73);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(9, 556);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 50);
            btnCreate.TabIndex = 38;
            btnCreate.Text = "Guardar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Visible = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(913, 556);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(163, 50);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnBackToPeriod
            // 
            btnBackToPeriod.Anchor = AnchorStyles.None;
            btnBackToPeriod.BackColor = Color.SteelBlue;
            btnBackToPeriod.Cursor = Cursors.Hand;
            btnBackToPeriod.FlatAppearance.BorderColor = Color.ForestGreen;
            btnBackToPeriod.FlatAppearance.BorderSize = 0;
            btnBackToPeriod.FlatStyle = FlatStyle.Flat;
            btnBackToPeriod.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackToPeriod.ForeColor = Color.White;
            btnBackToPeriod.Location = new Point(9, 16);
            btnBackToPeriod.Margin = new Padding(0);
            btnBackToPeriod.Name = "btnBackToPeriod";
            btnBackToPeriod.Size = new Size(139, 43);
            btnBackToPeriod.TabIndex = 51;
            btnBackToPeriod.Text = "Período";
            btnBackToPeriod.UseVisualStyleBackColor = false;
            btnBackToPeriod.Click += btnBackToPeriod_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(545, 60);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 43;
            label2.Text = "Fecha ";
            // 
            // dtDepositDate
            // 
            dtDepositDate.Anchor = AnchorStyles.None;
            dtDepositDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDepositDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDepositDate.Format = DateTimePickerFormat.Short;
            dtDepositDate.Location = new Point(504, 88);
            dtDepositDate.Name = "dtDepositDate";
            dtDepositDate.Size = new Size(157, 31);
            dtDepositDate.TabIndex = 42;
            // 
            // FrmSubPeriodCalculateInterestsForSavingAcc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1080, 615);
            Controls.Add(btnBackToPeriod);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(gridInterestFactorPreview);
            Controls.Add(panel1);
            Controls.Add(lblSavingAccTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSubPeriodCalculateInterestsForSavingAcc";
            Text = "FrnSubPeriodCalculateInterestsForSavingAcc";
            Load += FrmSubPeriodCalculateInterestsForSavingAcc_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtUtilityMonths).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridInterestFactorPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSavingAccTitle;
        private Panel panel1;
        private Label lblTotalAmountRecovered;
        private Label lblTotalAmountLoaned;
        private Label lblTotalAmountRecoveredData;
        private Label lblTotalAmountLoanedData;
        private Label label1;
        private Label lblInterestFactorData;
        private Button btnWithdrawInsterest;
        private DataGridView gridWidthdrawalsList;
        private DataGridViewTextBoxColumn SavingAccountHistorylID;
        private DataGridViewTextBoxColumn SubPeriodName;
        private DataGridViewTextBoxColumn HistoryType;
        private DataGridViewTextBoxColumn HistoryName;
        private DataGridViewTextBoxColumn AmountDisplay;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn TotalDisplay;
        private Button btnPreview;
        private Button btnCreate;
        private Button btnCancel;
        private Label lblTotalDepositsAmount;
        private Label lblTotalDepositsAmountData;
        private Label lblUtilityMonths;
        private NumericUpDown txtUtilityMonths;
        private DataGridViewTextBoxColumn SavingAccountID;
        private DataGridViewTextBoxColumn ClientFullName;
        private DataGridViewTextBoxColumn INSSNo;
        private DataGridViewTextBoxColumn TotalDepositAmountDisplay;
        private DataGridViewTextBoxColumn InterestGeneratedAmountDisplay;
        private DataGridView gridInterestFactorPreview;
        private Button button1;
        private Button btnBackToPeriod;
        private Label label2;
        private DateTimePicker dtDepositDate;
    }
}