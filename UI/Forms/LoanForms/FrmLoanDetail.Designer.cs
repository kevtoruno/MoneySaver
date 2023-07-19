namespace UI.Forms.LoanForms
{
    partial class FrmLoanDetail
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            gridInstallments = new DataGridView();
            LoanInstallmentID = new DataGridViewTextBoxColumn();
            SubPeriodName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            DueAmountDisplay = new DataGridViewTextBoxColumn();
            DueAmount = new DataGridViewTextBoxColumn();
            IsPaid = new DataGridViewCheckBoxColumn();
            DueDateDisplay = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label3 = new Label();
            lblAmountData = new Label();
            label2 = new Label();
            lblTermsData = new Label();
            lblDescriptionData = new Label();
            label1 = new Label();
            lblClientFullNameTitle = new Label();
            lblINSSTitle = new Label();
            lblInterestsData = new Label();
            lblStatusData = new Label();
            lblClientFullNameData = new Label();
            lblPendingAmountData = new Label();
            lblStatus = new Label();
            lblAmountForInterests = new Label();
            lblINSSData = new Label();
            lblTotalWidthdrawn = new Label();
            lblTotalAmount = new Label();
            lblCurrentAmount = new Label();
            lblInstallmentAmountData = new Label();
            lblLoanAmountData = new Label();
            lblSavingAccTitle = new Label();
            btnPayInstallment = new Button();
            ((System.ComponentModel.ISupportInitialize)gridInstallments).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridInstallments
            // 
            gridInstallments.AllowUserToAddRows = false;
            gridInstallments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridInstallments.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridInstallments.BorderStyle = BorderStyle.None;
            gridInstallments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            gridInstallments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            gridInstallments.ColumnHeadersHeight = 30;
            gridInstallments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridInstallments.Columns.AddRange(new DataGridViewColumn[] { LoanInstallmentID, SubPeriodName, Amount, DueAmountDisplay, DueAmount, IsPaid, DueDateDisplay, DueDate });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            gridInstallments.DefaultCellStyle = dataGridViewCellStyle11;
            gridInstallments.EnableHeadersVisualStyles = false;
            gridInstallments.GridColor = Color.SteelBlue;
            gridInstallments.Location = new Point(0, 326);
            gridInstallments.Name = "gridInstallments";
            gridInstallments.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            gridInstallments.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            gridInstallments.RowHeadersVisible = false;
            gridInstallments.RowHeadersWidth = 51;
            gridInstallments.RowTemplate.Height = 29;
            gridInstallments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridInstallments.Size = new Size(1080, 289);
            gridInstallments.TabIndex = 6;
            gridInstallments.CellFormatting += gridInstallments_CellFormatting;
            // 
            // LoanInstallmentID
            // 
            LoanInstallmentID.DataPropertyName = "LoanInstallmentID";
            LoanInstallmentID.HeaderText = "LoanInstallmentID";
            LoanInstallmentID.MinimumWidth = 6;
            LoanInstallmentID.Name = "LoanInstallmentID";
            LoanInstallmentID.Visible = false;
            LoanInstallmentID.Width = 125;
            // 
            // SubPeriodName
            // 
            SubPeriodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubPeriodName.DataPropertyName = "SubPeriodName";
            SubPeriodName.FillWeight = 18.47356F;
            SubPeriodName.HeaderText = "Sub período";
            SubPeriodName.MinimumWidth = 6;
            SubPeriodName.Name = "SubPeriodName";
            SubPeriodName.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Cantidad";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // DueAmountDisplay
            // 
            DueAmountDisplay.DataPropertyName = "DueAmountDisplay";
            DueAmountDisplay.HeaderText = "Pendiente";
            DueAmountDisplay.MinimumWidth = 6;
            DueAmountDisplay.Name = "DueAmountDisplay";
            DueAmountDisplay.Width = 125;
            // 
            // DueAmount
            // 
            DueAmount.DataPropertyName = "DueAmount";
            DueAmount.HeaderText = "DueAmount";
            DueAmount.MinimumWidth = 6;
            DueAmount.Name = "DueAmount";
            DueAmount.Visible = false;
            DueAmount.Width = 125;
            // 
            // IsPaid
            // 
            IsPaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IsPaid.DataPropertyName = "IsPaid";
            IsPaid.FillWeight = 12.3157082F;
            IsPaid.HeaderText = "Pagado";
            IsPaid.MinimumWidth = 6;
            IsPaid.Name = "IsPaid";
            IsPaid.ReadOnly = true;
            IsPaid.Resizable = DataGridViewTriState.True;
            IsPaid.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DueDateDisplay
            // 
            DueDateDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DueDateDisplay.DataPropertyName = "DueDateDisplay";
            DueDateDisplay.FillWeight = 12.3157082F;
            DueDateDisplay.HeaderText = "Fecha limite";
            DueDateDisplay.MinimumWidth = 6;
            DueDateDisplay.Name = "DueDateDisplay";
            DueDateDisplay.ReadOnly = true;
            // 
            // DueDate
            // 
            DueDate.DataPropertyName = "DueDate";
            DueDate.HeaderText = "DueDate";
            DueDate.MinimumWidth = 6;
            DueDate.Name = "DueDate";
            DueDate.Visible = false;
            DueDate.Width = 125;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(49, 66, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblAmountData);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTermsData);
            panel1.Controls.Add(lblDescriptionData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblClientFullNameTitle);
            panel1.Controls.Add(lblINSSTitle);
            panel1.Controls.Add(lblInterestsData);
            panel1.Controls.Add(lblStatusData);
            panel1.Controls.Add(lblClientFullNameData);
            panel1.Controls.Add(lblPendingAmountData);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblAmountForInterests);
            panel1.Controls.Add(lblINSSData);
            panel1.Controls.Add(lblTotalWidthdrawn);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Controls.Add(lblCurrentAmount);
            panel1.Controls.Add(lblInstallmentAmountData);
            panel1.Controls.Add(lblLoanAmountData);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 202);
            panel1.TabIndex = 34;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(669, 70);
            label3.Name = "label3";
            label3.Size = new Size(203, 28);
            label3.TabIndex = 42;
            label3.Text = "Cantidad entregada:";
            // 
            // lblAmountData
            // 
            lblAmountData.Anchor = AnchorStyles.Right;
            lblAmountData.AutoSize = true;
            lblAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmountData.ForeColor = Color.LawnGreen;
            lblAmountData.Location = new Point(883, 70);
            lblAmountData.Name = "lblAmountData";
            lblAmountData.Size = new Size(60, 28);
            lblAmountData.TabIndex = 43;
            lblAmountData.Text = "$$$$";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(669, 12);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 40;
            label2.Text = "Plazo:";
            // 
            // lblTermsData
            // 
            lblTermsData.Anchor = AnchorStyles.Right;
            lblTermsData.AutoSize = true;
            lblTermsData.BackColor = Color.Transparent;
            lblTermsData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTermsData.ForeColor = Color.White;
            lblTermsData.Location = new Point(883, 12);
            lblTermsData.Name = "lblTermsData";
            lblTermsData.Size = new Size(48, 28);
            lblTermsData.TabIndex = 41;
            lblTermsData.Text = "000";
            // 
            // lblDescriptionData
            // 
            lblDescriptionData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDescriptionData.AutoSize = true;
            lblDescriptionData.BackColor = Color.Transparent;
            lblDescriptionData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescriptionData.ForeColor = Color.White;
            lblDescriptionData.Location = new Point(226, 115);
            lblDescriptionData.MaximumSize = new Size(380, 80);
            lblDescriptionData.Name = "lblDescriptionData";
            lblDescriptionData.Size = new Size(367, 69);
            lblDescriptionData.TabIndex = 39;
            lblDescriptionData.Text = "Esto es la descripcion de un texto muy grande que pretende describir una descrpcion cuyo objetivo es describir el motivo del préstamo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 110);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 38;
            label1.Text = "Descripción préstamo:";
            // 
            // lblClientFullNameTitle
            // 
            lblClientFullNameTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblClientFullNameTitle.AutoSize = true;
            lblClientFullNameTitle.BackColor = Color.Transparent;
            lblClientFullNameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientFullNameTitle.ForeColor = Color.White;
            lblClientFullNameTitle.Location = new Point(14, 20);
            lblClientFullNameTitle.Name = "lblClientFullNameTitle";
            lblClientFullNameTitle.Size = new Size(80, 28);
            lblClientFullNameTitle.TabIndex = 15;
            lblClientFullNameTitle.Text = "Afiliado";
            // 
            // lblINSSTitle
            // 
            lblINSSTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblINSSTitle.AutoSize = true;
            lblINSSTitle.BackColor = Color.Transparent;
            lblINSSTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblINSSTitle.ForeColor = Color.White;
            lblINSSTitle.Location = new Point(14, 50);
            lblINSSTitle.Name = "lblINSSTitle";
            lblINSSTitle.Size = new Size(90, 28);
            lblINSSTitle.TabIndex = 16;
            lblINSSTitle.Text = "No INSS:";
            // 
            // lblInterestsData
            // 
            lblInterestsData.Anchor = AnchorStyles.Right;
            lblInterestsData.AutoSize = true;
            lblInterestsData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterestsData.ForeColor = Color.LawnGreen;
            lblInterestsData.Location = new Point(883, 100);
            lblInterestsData.Name = "lblInterestsData";
            lblInterestsData.Size = new Size(60, 28);
            lblInterestsData.TabIndex = 37;
            lblInterestsData.Text = "$$$$";
            // 
            // lblStatusData
            // 
            lblStatusData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatusData.AutoSize = true;
            lblStatusData.BackColor = Color.Transparent;
            lblStatusData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusData.ForeColor = Color.White;
            lblStatusData.Location = new Point(226, 85);
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
            lblClientFullNameData.Location = new Point(226, 25);
            lblClientFullNameData.Name = "lblClientFullNameData";
            lblClientFullNameData.Size = new Size(18, 23);
            lblClientFullNameData.TabIndex = 21;
            lblClientFullNameData.Text = "..";
            // 
            // lblPendingAmountData
            // 
            lblPendingAmountData.Anchor = AnchorStyles.Right;
            lblPendingAmountData.AutoSize = true;
            lblPendingAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendingAmountData.ForeColor = Color.LawnGreen;
            lblPendingAmountData.Location = new Point(883, 160);
            lblPendingAmountData.Name = "lblPendingAmountData";
            lblPendingAmountData.Size = new Size(60, 28);
            lblPendingAmountData.TabIndex = 20;
            lblPendingAmountData.Text = "$$$$";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(14, 80);
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
            lblAmountForInterests.Location = new Point(669, 100);
            lblAmountForInterests.Name = "lblAmountForInterests";
            lblAmountForInterests.Size = new Size(102, 28);
            lblAmountForInterests.TabIndex = 27;
            lblAmountForInterests.Text = "Intereses:";
            // 
            // lblINSSData
            // 
            lblINSSData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblINSSData.AutoSize = true;
            lblINSSData.BackColor = Color.Transparent;
            lblINSSData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblINSSData.ForeColor = Color.White;
            lblINSSData.Location = new Point(226, 55);
            lblINSSData.Name = "lblINSSData";
            lblINSSData.Size = new Size(37, 23);
            lblINSSData.TabIndex = 22;
            lblINSSData.Text = "000";
            // 
            // lblTotalWidthdrawn
            // 
            lblTotalWidthdrawn.Anchor = AnchorStyles.Right;
            lblTotalWidthdrawn.AutoSize = true;
            lblTotalWidthdrawn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalWidthdrawn.ForeColor = Color.White;
            lblTotalWidthdrawn.Location = new Point(669, 160);
            lblTotalWidthdrawn.Name = "lblTotalWidthdrawn";
            lblTotalWidthdrawn.Size = new Size(181, 28);
            lblTotalWidthdrawn.TabIndex = 36;
            lblTotalWidthdrawn.Text = "Monto pendiente:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Right;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(669, 130);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(72, 28);
            lblTotalAmount.TabIndex = 19;
            lblTotalAmount.Text = "Cuota:";
            // 
            // lblCurrentAmount
            // 
            lblCurrentAmount.Anchor = AnchorStyles.Right;
            lblCurrentAmount.AutoSize = true;
            lblCurrentAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentAmount.ForeColor = Color.White;
            lblCurrentAmount.Location = new Point(669, 40);
            lblCurrentAmount.Name = "lblCurrentAmount";
            lblCurrentAmount.Size = new Size(198, 28);
            lblCurrentAmount.TabIndex = 34;
            lblCurrentAmount.Text = "Cantidad solicitada:";
            // 
            // lblInstallmentAmountData
            // 
            lblInstallmentAmountData.Anchor = AnchorStyles.Right;
            lblInstallmentAmountData.AutoSize = true;
            lblInstallmentAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstallmentAmountData.ForeColor = Color.LawnGreen;
            lblInstallmentAmountData.Location = new Point(883, 130);
            lblInstallmentAmountData.Name = "lblInstallmentAmountData";
            lblInstallmentAmountData.Size = new Size(60, 28);
            lblInstallmentAmountData.TabIndex = 28;
            lblInstallmentAmountData.Text = "$$$$";
            // 
            // lblLoanAmountData
            // 
            lblLoanAmountData.Anchor = AnchorStyles.Right;
            lblLoanAmountData.AutoSize = true;
            lblLoanAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoanAmountData.ForeColor = Color.LawnGreen;
            lblLoanAmountData.Location = new Point(883, 40);
            lblLoanAmountData.Name = "lblLoanAmountData";
            lblLoanAmountData.Size = new Size(60, 28);
            lblLoanAmountData.TabIndex = 35;
            lblLoanAmountData.Text = "$$$$";
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(443, 23);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(140, 36);
            lblSavingAccTitle.TabIndex = 35;
            lblSavingAccTitle.Text = "Préstamo";
            // 
            // btnPayInstallment
            // 
            btnPayInstallment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPayInstallment.BackColor = Color.FromArgb(51, 178, 73);
            btnPayInstallment.Cursor = Cursors.Hand;
            btnPayInstallment.FlatAppearance.BorderColor = Color.ForestGreen;
            btnPayInstallment.FlatAppearance.BorderSize = 0;
            btnPayInstallment.FlatStyle = FlatStyle.Flat;
            btnPayInstallment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayInstallment.ForeColor = Color.White;
            btnPayInstallment.Location = new Point(12, 267);
            btnPayInstallment.Margin = new Padding(0);
            btnPayInstallment.Name = "btnPayInstallment";
            btnPayInstallment.Size = new Size(157, 50);
            btnPayInstallment.TabIndex = 36;
            btnPayInstallment.Text = "Pagar cuota";
            btnPayInstallment.UseVisualStyleBackColor = false;
            // 
            // FrmLoanDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1080, 615);
            Controls.Add(btnPayInstallment);
            Controls.Add(lblSavingAccTitle);
            Controls.Add(panel1);
            Controls.Add(gridInstallments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLoanDetail";
            Text = "FrmLoanDetail";
            Load += FrmLoanDetail_Load;
            ((System.ComponentModel.ISupportInitialize)gridInstallments).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridInstallments;
        private Panel panel1;
        private Label lblClientFullNameTitle;
        private Label lblINSSTitle;
        private Label lblInterestsData;
        private Label lblStatusData;
        private Label lblClientFullNameData;
        private Label lblPendingAmountData;
        private Label lblStatus;
        private Label lblAmountForInterests;
        private Label lblINSSData;
        private Label lblTotalWidthdrawn;
        private Label lblTotalAmount;
        private Label lblCurrentAmount;
        private Label lblInstallmentAmountData;
        private Label lblLoanAmountData;
        private Label label1;
        private Label lblDescriptionData;
        private Label lblSavingAccTitle;
        private Label label2;
        private Label lblTermsData;
        private DataGridViewTextBoxColumn LoanInstallmentID;
        private DataGridViewTextBoxColumn SubPeriodName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn DueAmountDisplay;
        private DataGridViewTextBoxColumn DueAmount;
        private DataGridViewCheckBoxColumn IsPaid;
        private DataGridViewTextBoxColumn DueDateDisplay;
        private DataGridViewTextBoxColumn DueDate;
        private Label label3;
        private Label label4;
        private Label lblAmountData;
        private Button btnPayInstallment;
    }
}