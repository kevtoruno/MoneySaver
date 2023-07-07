﻿namespace UI.Forms.LoanForms
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label4 = new Label();
            txtINSS = new MaskedTextBox();
            btnSearch = new Button();
            lblLoansTitle = new Label();
            gridLoansList = new DataGridView();
            SavingAccountID = new DataGridViewTextBoxColumn();
            INSS = new DataGridViewTextBoxColumn();
            ClientFullName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            LoanAmount = new DataGridViewTextBoxColumn();
            PendingAmount = new DataGridViewTextBoxColumn();
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
            // 
            // lblLoansTitle
            // 
            lblLoansTitle.Anchor = AnchorStyles.Top;
            lblLoansTitle.AutoSize = true;
            lblLoansTitle.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoansTitle.ForeColor = SystemColors.Control;
            lblLoansTitle.Location = new Point(439, 14);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridLoansList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridLoansList.ColumnHeadersHeight = 30;
            gridLoansList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridLoansList.Columns.AddRange(new DataGridViewColumn[] { SavingAccountID, INSS, ClientFullName, Description, LoanAmount, PendingAmount });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridLoansList.DefaultCellStyle = dataGridViewCellStyle5;
            gridLoansList.EnableHeadersVisualStyles = false;
            gridLoansList.GridColor = Color.SteelBlue;
            gridLoansList.Location = new Point(9, 292);
            gridLoansList.Name = "gridLoansList";
            gridLoansList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridLoansList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridLoansList.RowHeadersVisible = false;
            gridLoansList.RowHeadersWidth = 51;
            gridLoansList.RowTemplate.Height = 29;
            gridLoansList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridLoansList.Size = new Size(1070, 346);
            gridLoansList.TabIndex = 20;
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
            // INSS
            // 
            INSS.DataPropertyName = "INSS";
            INSS.HeaderText = "INSS";
            INSS.MinimumWidth = 6;
            INSS.Name = "INSS";
            INSS.ReadOnly = true;
            INSS.Width = 125;
            // 
            // ClientFullName
            // 
            ClientFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClientFullName.DataPropertyName = "ClientFullName";
            ClientFullName.HeaderText = "Trabajador";
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
            // LoanAmount
            // 
            LoanAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanAmount.DataPropertyName = "LoanAmount";
            LoanAmount.HeaderText = "Cantidad préstamo";
            LoanAmount.MinimumWidth = 6;
            LoanAmount.Name = "LoanAmount";
            LoanAmount.ReadOnly = true;
            // 
            // PendingAmount
            // 
            PendingAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PendingAmount.DataPropertyName = "PendingAmount";
            PendingAmount.HeaderText = "Cantidad pendiente";
            PendingAmount.MinimumWidth = 6;
            PendingAmount.Name = "PendingAmount";
            PendingAmount.ReadOnly = true;
            PendingAmount.Resizable = DataGridViewTriState.True;
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
        private DataGridViewTextBoxColumn SavingAccountID;
        private DataGridViewTextBoxColumn INSS;
        private DataGridViewTextBoxColumn ClientFullName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn LoanAmount;
        private DataGridViewTextBoxColumn PendingAmount;
        private Button btnNewLoan;
        private Button btnView;
    }
}