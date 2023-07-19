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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            gridLoansList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridLoansList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridLoansList.BorderStyle = BorderStyle.None;
            gridLoansList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridLoansList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridLoansList.ColumnHeadersHeight = 30;
            gridLoansList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridLoansList.Columns.AddRange(new DataGridViewColumn[] { LoanID, INSSNo, ClientFullName, Description, IsCurrent, LoanAmount, DueAmount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridLoansList.DefaultCellStyle = dataGridViewCellStyle2;
            gridLoansList.EnableHeadersVisualStyles = false;
            gridLoansList.GridColor = Color.SteelBlue;
            gridLoansList.Location = new Point(9, 292);
            gridLoansList.Name = "gridLoansList";
            gridLoansList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridLoansList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            // FrmLoansList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1080, 650);
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
    }
}