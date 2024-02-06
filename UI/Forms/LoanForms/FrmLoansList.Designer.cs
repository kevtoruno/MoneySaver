namespace UI.Forms.LoanForms
{
    partial class FrmLoansList
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label4 = new Label();
            txtINSS = new MaskedTextBox();
            btnSearch = new Button();
            lblLoansTitle = new Label();
            gridLoansList = new DataGridView();
            LoanID = new DataGridViewTextBoxColumn();
            INSSNo = new DataGridViewTextBoxColumn();
            ClientFullName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            IsCurrent = new DataGridViewCheckBoxColumn();
            LoanAmount = new DataGridViewTextBoxColumn();
            DueAmount = new DataGridViewTextBoxColumn();
            btnNewLoan = new Button();
            btnView = new Button();
            btnUploadMonthlyDeposits = new Button();
            btnMassLoanCreator = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)gridLoansList).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(490, 80);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 19;
            label4.Text = "No INSS";
            // 
            // txtINSS
            // 
            txtINSS.Anchor = AnchorStyles.Top;
            txtINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtINSS.Location = new Point(471, 110);
            txtINSS.Mask = "9999999999";
            txtINSS.Name = "txtINSS";
            txtINSS.Size = new Size(125, 31);
            txtINSS.TabIndex = 18;
            txtINSS.ValidatingType = typeof(int);
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(458, 147);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 50);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblLoansTitle
            // 
            lblLoansTitle.Anchor = AnchorStyles.Top;
            lblLoansTitle.AutoSize = true;
            lblLoansTitle.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoansTitle.ForeColor = SystemColors.Control;
            lblLoansTitle.Location = new Point(450, 14);
            lblLoansTitle.Name = "lblLoansTitle";
            lblLoansTitle.Size = new Size(165, 37);
            lblLoansTitle.TabIndex = 16;
            lblLoansTitle.Text = "Préstamos";
            // 
            // gridLoansList
            // 
            gridLoansList.AllowUserToAddRows = false;
            gridLoansList.AllowUserToResizeRows = false;
            gridLoansList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridLoansList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridLoansList.BorderStyle = BorderStyle.None;
            gridLoansList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            gridLoansList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            gridLoansList.ColumnHeadersHeight = 30;
            gridLoansList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridLoansList.Columns.AddRange(new DataGridViewColumn[] { LoanID, INSSNo, ClientFullName, Description, IsCurrent, LoanAmount, DueAmount });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            gridLoansList.DefaultCellStyle = dataGridViewCellStyle8;
            gridLoansList.EnableHeadersVisualStyles = false;
            gridLoansList.GridColor = Color.SteelBlue;
            gridLoansList.Location = new Point(9, 292);
            gridLoansList.MultiSelect = false;
            gridLoansList.Name = "gridLoansList";
            gridLoansList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            gridLoansList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            gridLoansList.RowHeadersVisible = false;
            gridLoansList.RowHeadersWidth = 51;
            gridLoansList.RowTemplate.Height = 29;
            gridLoansList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridLoansList.Size = new Size(1070, 346);
            gridLoansList.TabIndex = 20;
            // 
            // LoanID
            // 
            LoanID.DataPropertyName = "LoanID";
            LoanID.FillWeight = 125F;
            LoanID.HeaderText = "LoanID";
            LoanID.MinimumWidth = 6;
            LoanID.Name = "LoanID";
            LoanID.Visible = false;
            LoanID.Width = 125;
            // 
            // INSSNo
            // 
            INSSNo.DataPropertyName = "INSSNo";
            INSSNo.HeaderText = "INSS";
            INSSNo.MinimumWidth = 6;
            INSSNo.Name = "INSSNo";
            INSSNo.ReadOnly = true;
            INSSNo.Width = 125;
            // 
            // ClientFullName
            // 
            ClientFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClientFullName.DataPropertyName = "ClientFullName";
            ClientFullName.HeaderText = "Afiliado";
            ClientFullName.MinimumWidth = 6;
            ClientFullName.Name = "ClientFullName";
            ClientFullName.ReadOnly = true;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Descripción";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // IsCurrent
            // 
            IsCurrent.DataPropertyName = "IsCurrent";
            IsCurrent.HeaderText = "¿Pendiente?";
            IsCurrent.MinimumWidth = 6;
            IsCurrent.Name = "IsCurrent";
            IsCurrent.Resizable = DataGridViewTriState.True;
            IsCurrent.SortMode = DataGridViewColumnSortMode.Automatic;
            IsCurrent.Width = 125;
            // 
            // LoanAmount
            // 
            LoanAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanAmount.DataPropertyName = "LoanAmount";
            LoanAmount.HeaderText = "Cantidad préstamo";
            LoanAmount.MinimumWidth = 6;
            LoanAmount.Name = "LoanAmount";
            LoanAmount.ReadOnly = true;
            // 
            // DueAmount
            // 
            DueAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DueAmount.DataPropertyName = "DueAmount";
            DueAmount.HeaderText = "Cantidad pendiente";
            DueAmount.MinimumWidth = 6;
            DueAmount.Name = "DueAmount";
            DueAmount.ReadOnly = true;
            DueAmount.Resizable = DataGridViewTriState.True;
            // 
            // btnNewLoan
            // 
            btnNewLoan.BackColor = Color.SteelBlue;
            btnNewLoan.Cursor = Cursors.Hand;
            btnNewLoan.FlatAppearance.BorderSize = 0;
            btnNewLoan.FlatStyle = FlatStyle.Flat;
            btnNewLoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewLoan.ForeColor = SystemColors.Control;
            btnNewLoan.Location = new Point(10, 10);
            btnNewLoan.Name = "btnNewLoan";
            btnNewLoan.Size = new Size(168, 50);
            btnNewLoan.TabIndex = 21;
            btnNewLoan.Text = "Nuevo préstamo";
            btnNewLoan.UseVisualStyleBackColor = false;
            btnNewLoan.Click += btnNewLoan_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.SteelBlue;
            btnView.Cursor = Cursors.Hand;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.ForeColor = SystemColors.Control;
            btnView.Location = new Point(9, 236);
            btnView.Name = "btnView";
            btnView.Size = new Size(87, 50);
            btnView.TabIndex = 22;
            btnView.Text = "Ver";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnUploadMonthlyDeposits
            // 
            btnUploadMonthlyDeposits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUploadMonthlyDeposits.BackColor = Color.SteelBlue;
            btnUploadMonthlyDeposits.Cursor = Cursors.Hand;
            btnUploadMonthlyDeposits.FlatAppearance.BorderSize = 0;
            btnUploadMonthlyDeposits.FlatStyle = FlatStyle.Flat;
            btnUploadMonthlyDeposits.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUploadMonthlyDeposits.ForeColor = SystemColors.Control;
            btnUploadMonthlyDeposits.Location = new Point(871, 10);
            btnUploadMonthlyDeposits.Name = "btnUploadMonthlyDeposits";
            btnUploadMonthlyDeposits.Size = new Size(197, 72);
            btnUploadMonthlyDeposits.TabIndex = 23;
            btnUploadMonthlyDeposits.Text = "Ingresar pagos mensuales";
            btnUploadMonthlyDeposits.UseVisualStyleBackColor = false;
            btnUploadMonthlyDeposits.Click += btnUploadMonthlyDeposits_Click;
            // 
            // btnMassLoanCreator
            // 
            btnMassLoanCreator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMassLoanCreator.BackColor = Color.SteelBlue;
            btnMassLoanCreator.Cursor = Cursors.Hand;
            btnMassLoanCreator.FlatAppearance.BorderSize = 0;
            btnMassLoanCreator.FlatStyle = FlatStyle.Flat;
            btnMassLoanCreator.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMassLoanCreator.ForeColor = SystemColors.Control;
            btnMassLoanCreator.Location = new Point(917, 100);
            btnMassLoanCreator.Name = "btnMassLoanCreator";
            btnMassLoanCreator.Size = new Size(151, 41);
            btnMassLoanCreator.TabIndex = 24;
            btnMassLoanCreator.Text = "Creador masivo";
            btnMassLoanCreator.UseVisualStyleBackColor = false;
            btnMassLoanCreator.Visible = false;
            btnMassLoanCreator.Click += btnMassLoanCreator_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(120, 236);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 50);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmLoansList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1080, 650);
            Controls.Add(btnDelete);
            Controls.Add(btnMassLoanCreator);
            Controls.Add(btnUploadMonthlyDeposits);
            Controls.Add(btnView);
            Controls.Add(btnNewLoan);
            Controls.Add(gridLoansList);
            Controls.Add(label4);
            Controls.Add(txtINSS);
            Controls.Add(btnSearch);
            Controls.Add(lblLoansTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLoansList";
            Text = "FrmLoansList";
            Load += FrmLoansList_Load;
            ((System.ComponentModel.ISupportInitialize)gridLoansList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private MaskedTextBox txtINSS;
        private Button btnSearch;
        private Label lblLoansTitle;
        private DataGridView gridLoansList;
        private Button btnNewLoan;
        private Button btnView;
        private DataGridViewTextBoxColumn LoanID;
        private DataGridViewTextBoxColumn INSSNo;
        private DataGridViewTextBoxColumn ClientFullName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewCheckBoxColumn IsCurrent;
        private DataGridViewTextBoxColumn LoanAmount;
        private DataGridViewTextBoxColumn DueAmount;
        private Button btnUploadMonthlyDeposits;
        private Button btnMassLoanCreator;
        private Button btnDelete;
    }
}