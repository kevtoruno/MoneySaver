namespace UI.Forms.PeriodsForms
{
    partial class FrmPeriodToDetail
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
            lblPeriodsTitle = new Label();
            panel1 = new Panel();
            lblPeriodEndDate = new Label();
            lblPeriodEndDateTitle = new Label();
            lblPeriodStartDateTitle = new Label();
            lblCreatedDateData = new Label();
            lblCreatedDate = new Label();
            lblPeriodStartDate = new Label();
            lblTotalOutcomeTitle = new Label();
            lblTotalIncomeTitle = new Label();
            lblTotalOutcome = new Label();
            lblTotalIncome = new Label();
            btnView = new Button();
            gridSubPeriodsList = new DataGridView();
            SubPeriodID = new DataGridViewTextBoxColumn();
            SubPeriodName = new DataGridViewTextBoxColumn();
            Month = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            TotalIncomeDisplay = new DataGridViewTextBoxColumn();
            TotalOutcomeDisplay = new DataGridViewTextBoxColumn();
            btnCalculateInterestFactor = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSubPeriodsList).BeginInit();
            SuspendLayout();
            // 
            // lblPeriodsTitle
            // 
            lblPeriodsTitle.Anchor = AnchorStyles.Top;
            lblPeriodsTitle.AutoSize = true;
            lblPeriodsTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodsTitle.ForeColor = SystemColors.Control;
            lblPeriodsTitle.Location = new Point(323, 23);
            lblPeriodsTitle.Name = "lblPeriodsTitle";
            lblPeriodsTitle.Size = new Size(195, 36);
            lblPeriodsTitle.TabIndex = 19;
            lblPeriodsTitle.Text = "Periodo 2023";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(49, 66, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblPeriodEndDate);
            panel1.Controls.Add(lblPeriodEndDateTitle);
            panel1.Controls.Add(lblPeriodStartDateTitle);
            panel1.Controls.Add(lblCreatedDateData);
            panel1.Controls.Add(lblCreatedDate);
            panel1.Controls.Add(lblPeriodStartDate);
            panel1.Controls.Add(lblTotalOutcomeTitle);
            panel1.Controls.Add(lblTotalIncomeTitle);
            panel1.Controls.Add(lblTotalOutcome);
            panel1.Controls.Add(lblTotalIncome);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 143);
            panel1.TabIndex = 34;
            // 
            // lblPeriodEndDate
            // 
            lblPeriodEndDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPeriodEndDate.AutoSize = true;
            lblPeriodEndDate.BackColor = Color.Transparent;
            lblPeriodEndDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodEndDate.ForeColor = Color.White;
            lblPeriodEndDate.Location = new Point(197, 63);
            lblPeriodEndDate.Name = "lblPeriodEndDate";
            lblPeriodEndDate.Size = new Size(18, 23);
            lblPeriodEndDate.TabIndex = 37;
            lblPeriodEndDate.Text = "..";
            // 
            // lblPeriodEndDateTitle
            // 
            lblPeriodEndDateTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPeriodEndDateTitle.AutoSize = true;
            lblPeriodEndDateTitle.BackColor = Color.Transparent;
            lblPeriodEndDateTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodEndDateTitle.ForeColor = Color.White;
            lblPeriodEndDateTitle.Location = new Point(94, 58);
            lblPeriodEndDateTitle.Name = "lblPeriodEndDateTitle";
            lblPeriodEndDateTitle.Size = new Size(97, 28);
            lblPeriodEndDateTitle.TabIndex = 36;
            lblPeriodEndDateTitle.Text = "Fecha Fin:";
            // 
            // lblPeriodStartDateTitle
            // 
            lblPeriodStartDateTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPeriodStartDateTitle.AutoSize = true;
            lblPeriodStartDateTitle.BackColor = Color.Transparent;
            lblPeriodStartDateTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodStartDateTitle.ForeColor = Color.White;
            lblPeriodStartDateTitle.Location = new Point(73, 20);
            lblPeriodStartDateTitle.Name = "lblPeriodStartDateTitle";
            lblPeriodStartDateTitle.Size = new Size(118, 28);
            lblPeriodStartDateTitle.TabIndex = 15;
            lblPeriodStartDateTitle.Text = "Fecha Inicio:";
            // 
            // lblCreatedDateData
            // 
            lblCreatedDateData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCreatedDateData.AutoSize = true;
            lblCreatedDateData.BackColor = Color.Transparent;
            lblCreatedDateData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedDateData.ForeColor = Color.White;
            lblCreatedDateData.Location = new Point(183, 175);
            lblCreatedDateData.Name = "lblCreatedDateData";
            lblCreatedDateData.Size = new Size(96, 23);
            lblCreatedDateData.TabIndex = 32;
            lblCreatedDateData.Text = "00/00/2000";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.BackColor = Color.Transparent;
            lblCreatedDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedDate.ForeColor = Color.White;
            lblCreatedDate.Location = new Point(7, 170);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(171, 28);
            lblCreatedDate.TabIndex = 31;
            lblCreatedDate.Text = "Fecha de creación:";
            // 
            // lblPeriodStartDate
            // 
            lblPeriodStartDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPeriodStartDate.AutoSize = true;
            lblPeriodStartDate.BackColor = Color.Transparent;
            lblPeriodStartDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodStartDate.ForeColor = Color.White;
            lblPeriodStartDate.Location = new Point(197, 25);
            lblPeriodStartDate.Name = "lblPeriodStartDate";
            lblPeriodStartDate.Size = new Size(18, 23);
            lblPeriodStartDate.TabIndex = 21;
            lblPeriodStartDate.Text = "..";
            // 
            // lblTotalOutcomeTitle
            // 
            lblTotalOutcomeTitle.Anchor = AnchorStyles.Right;
            lblTotalOutcomeTitle.AutoSize = true;
            lblTotalOutcomeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalOutcomeTitle.ForeColor = Color.White;
            lblTotalOutcomeTitle.Location = new Point(721, 79);
            lblTotalOutcomeTitle.Name = "lblTotalOutcomeTitle";
            lblTotalOutcomeTitle.Size = new Size(142, 28);
            lblTotalOutcomeTitle.TabIndex = 27;
            lblTotalOutcomeTitle.Text = "Total egresos:";
            // 
            // lblTotalIncomeTitle
            // 
            lblTotalIncomeTitle.Anchor = AnchorStyles.Right;
            lblTotalIncomeTitle.AutoSize = true;
            lblTotalIncomeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalIncomeTitle.ForeColor = Color.White;
            lblTotalIncomeTitle.Location = new Point(719, 29);
            lblTotalIncomeTitle.Name = "lblTotalIncomeTitle";
            lblTotalIncomeTitle.Size = new Size(149, 28);
            lblTotalIncomeTitle.TabIndex = 34;
            lblTotalIncomeTitle.Text = "Total ingresos:";
            // 
            // lblTotalOutcome
            // 
            lblTotalOutcome.Anchor = AnchorStyles.Right;
            lblTotalOutcome.AutoSize = true;
            lblTotalOutcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalOutcome.ForeColor = Color.LawnGreen;
            lblTotalOutcome.Location = new Point(874, 79);
            lblTotalOutcome.Name = "lblTotalOutcome";
            lblTotalOutcome.Size = new Size(60, 28);
            lblTotalOutcome.TabIndex = 28;
            lblTotalOutcome.Text = "$$$$";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.Anchor = AnchorStyles.Right;
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalIncome.ForeColor = Color.LawnGreen;
            lblTotalIncome.Location = new Point(874, 29);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(60, 28);
            lblTotalIncome.TabIndex = 35;
            lblTotalIncome.Text = "$$$$";
            // 
            // btnView
            // 
            btnView.BackColor = Color.SteelBlue;
            btnView.Cursor = Cursors.Hand;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(12, 211);
            btnView.Name = "btnView";
            btnView.Size = new Size(122, 50);
            btnView.TabIndex = 35;
            btnView.Text = "Ver";
            btnView.UseVisualStyleBackColor = false;
            // 
            // gridSubPeriodsList
            // 
            gridSubPeriodsList.AllowUserToAddRows = false;
            gridSubPeriodsList.AllowUserToResizeRows = false;
            gridSubPeriodsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridSubPeriodsList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridSubPeriodsList.BorderStyle = BorderStyle.None;
            gridSubPeriodsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridSubPeriodsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridSubPeriodsList.ColumnHeadersHeight = 30;
            gridSubPeriodsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridSubPeriodsList.Columns.AddRange(new DataGridViewColumn[] { SubPeriodID, SubPeriodName, Month, StartDate, EndDate, TotalIncomeDisplay, TotalOutcomeDisplay });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridSubPeriodsList.DefaultCellStyle = dataGridViewCellStyle2;
            gridSubPeriodsList.EnableHeadersVisualStyles = false;
            gridSubPeriodsList.GridColor = Color.SteelBlue;
            gridSubPeriodsList.Location = new Point(0, 267);
            gridSubPeriodsList.Name = "gridSubPeriodsList";
            gridSubPeriodsList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridSubPeriodsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridSubPeriodsList.RowHeadersVisible = false;
            gridSubPeriodsList.RowHeadersWidth = 51;
            gridSubPeriodsList.RowTemplate.Height = 29;
            gridSubPeriodsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSubPeriodsList.Size = new Size(1080, 348);
            gridSubPeriodsList.TabIndex = 36;
            gridSubPeriodsList.SelectionChanged += gridSubPeriodsList_SelectionChanged;
            // 
            // SubPeriodID
            // 
            SubPeriodID.DataPropertyName = "SubPeriodID";
            SubPeriodID.HeaderText = "SubPeriodID";
            SubPeriodID.MinimumWidth = 6;
            SubPeriodID.Name = "SubPeriodID";
            SubPeriodID.Visible = false;
            SubPeriodID.Width = 125;
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
            // Month
            // 
            Month.DataPropertyName = "Month";
            Month.HeaderText = "Mes";
            Month.MinimumWidth = 6;
            Month.Name = "Month";
            Month.Visible = false;
            Month.Width = 125;
            // 
            // StartDate
            // 
            StartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "Fecha Inicio";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "Fecha Fin";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            EndDate.Width = 125;
            // 
            // TotalIncomeDisplay
            // 
            TotalIncomeDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalIncomeDisplay.DataPropertyName = "TotalIncomeDisplay";
            TotalIncomeDisplay.HeaderText = "Ingresos";
            TotalIncomeDisplay.MinimumWidth = 6;
            TotalIncomeDisplay.Name = "TotalIncomeDisplay";
            TotalIncomeDisplay.ReadOnly = true;
            // 
            // TotalOutcomeDisplay
            // 
            TotalOutcomeDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalOutcomeDisplay.DataPropertyName = "TotalOutcomeDisplay";
            TotalOutcomeDisplay.HeaderText = "Egresos";
            TotalOutcomeDisplay.MinimumWidth = 6;
            TotalOutcomeDisplay.Name = "TotalOutcomeDisplay";
            // 
            // btnCalculateInterestFactor
            // 
            btnCalculateInterestFactor.BackColor = Color.SteelBlue;
            btnCalculateInterestFactor.Cursor = Cursors.Hand;
            btnCalculateInterestFactor.FlatAppearance.BorderSize = 0;
            btnCalculateInterestFactor.FlatStyle = FlatStyle.Flat;
            btnCalculateInterestFactor.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculateInterestFactor.ForeColor = Color.White;
            btnCalculateInterestFactor.Location = new Point(156, 211);
            btnCalculateInterestFactor.Name = "btnCalculateInterestFactor";
            btnCalculateInterestFactor.Size = new Size(205, 50);
            btnCalculateInterestFactor.TabIndex = 37;
            btnCalculateInterestFactor.Text = "Calcular factor interes";
            btnCalculateInterestFactor.UseVisualStyleBackColor = false;
            btnCalculateInterestFactor.Click += btnCalculateInterestFactor_Click;
            // 
            // FrmPeriodToDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1080, 615);
            Controls.Add(btnCalculateInterestFactor);
            Controls.Add(gridSubPeriodsList);
            Controls.Add(btnView);
            Controls.Add(panel1);
            Controls.Add(lblPeriodsTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPeriodToDetail";
            Text = "FrmPeriodToDetail";
            Load += FrmPeriodToDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridSubPeriodsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPeriodsTitle;
        private Panel panel1;
        private Label lblPeriodStartDate;
        private Label lblCreatedDateData;
        private Label lblCreatedDate;
        private Label lblClientFullNameData;
        private Label lblAmountForInterests;
        private Label lblCurrentAmount;
        private Label lblAmountForInterestsData;
        private Label lblCurrentAmountData;
        private Button btnView;
        private DataGridView gridSubPeriodsList;
        private DataGridViewTextBoxColumn SubPeriodID;
        private DataGridViewTextBoxColumn SubPeriodName;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn TotalIncomeDisplay;
        private DataGridViewTextBoxColumn TotalOutcomeDisplay;
        private Label lblPeriodEndDate;
        private Label label1;
        private Label lblPeriodStartDateTitle;
        private Label lblPeriodEndDateTitle;
        private Label lblTotalIncomeTitle;
        private Label lblTotalIncome;
        private Label lblTotalOutcomeTitle;
        private Label lblTotalOutcome;
        private Button btnCalculateInterestFactor;
    }
}