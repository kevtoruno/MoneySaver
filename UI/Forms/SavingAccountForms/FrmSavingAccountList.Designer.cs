﻿namespace UI.Forms
{
    partial class FrmSavingAccountList
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
            lblSavingAcountTitle = new Label();
            btnSearch = new Button();
            btnNewSavingAccount = new Button();
            gridSavingAccountsList = new DataGridView();
            SavingAccountID = new DataGridViewTextBoxColumn();
            INSS = new DataGridViewTextBoxColumn();
            ClientFullName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            AmountForInterests = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            txtINSS = new MaskedTextBox();
            label4 = new Label();
            btnDelete = new Button();
            btnView = new Button();
            btnUploadMonthlyDeposits = new Button();
            ((System.ComponentModel.ISupportInitialize)gridSavingAccountsList).BeginInit();
            SuspendLayout();
            // 
            // lblSavingAcountTitle
            // 
            lblSavingAcountTitle.Anchor = AnchorStyles.Top;
            lblSavingAcountTitle.AutoSize = true;
            lblSavingAcountTitle.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSavingAcountTitle.ForeColor = SystemColors.Control;
            lblSavingAcountTitle.Location = new Point(399, 15);
            lblSavingAcountTitle.Name = "lblSavingAcountTitle";
            lblSavingAcountTitle.Size = new Size(265, 37);
            lblSavingAcountTitle.TabIndex = 0;
            lblSavingAcountTitle.Text = "Fondos de ahorro";
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
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnNewSavingAccount
            // 
            btnNewSavingAccount.BackColor = Color.SteelBlue;
            btnNewSavingAccount.Cursor = Cursors.Hand;
            btnNewSavingAccount.FlatAppearance.BorderSize = 0;
            btnNewSavingAccount.FlatStyle = FlatStyle.Flat;
            btnNewSavingAccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewSavingAccount.ForeColor = SystemColors.Control;
            btnNewSavingAccount.Location = new Point(10, 10);
            btnNewSavingAccount.Name = "btnNewSavingAccount";
            btnNewSavingAccount.Size = new Size(189, 50);
            btnNewSavingAccount.TabIndex = 6;
            btnNewSavingAccount.Text = "Nuevo fondo ahorro";
            btnNewSavingAccount.UseVisualStyleBackColor = false;
            btnNewSavingAccount.Click += btnNewSavingAccount_Click;
            // 
            // gridSavingAccountsList
            // 
            gridSavingAccountsList.AllowUserToAddRows = false;
            gridSavingAccountsList.AllowUserToResizeRows = false;
            gridSavingAccountsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridSavingAccountsList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridSavingAccountsList.BorderStyle = BorderStyle.None;
            gridSavingAccountsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridSavingAccountsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridSavingAccountsList.ColumnHeadersHeight = 30;
            gridSavingAccountsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridSavingAccountsList.Columns.AddRange(new DataGridViewColumn[] { SavingAccountID, INSS, ClientFullName, Amount, AmountForInterests, IsActive });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridSavingAccountsList.DefaultCellStyle = dataGridViewCellStyle2;
            gridSavingAccountsList.EnableHeadersVisualStyles = false;
            gridSavingAccountsList.GridColor = Color.SteelBlue;
            gridSavingAccountsList.Location = new Point(9, 292);
            gridSavingAccountsList.MultiSelect = false;
            gridSavingAccountsList.Name = "gridSavingAccountsList";
            gridSavingAccountsList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridSavingAccountsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridSavingAccountsList.RowHeadersVisible = false;
            gridSavingAccountsList.RowHeadersWidth = 51;
            gridSavingAccountsList.RowTemplate.Height = 29;
            gridSavingAccountsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSavingAccountsList.Size = new Size(1070, 346);
            gridSavingAccountsList.TabIndex = 7;
            // 
            // SavingAccountID
            // 
            SavingAccountID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SavingAccountID.DataPropertyName = "SavingAccountID";
            SavingAccountID.HeaderText = "SavingAccountID";
            SavingAccountID.MinimumWidth = 6;
            SavingAccountID.Name = "SavingAccountID";
            SavingAccountID.Visible = false;
            SavingAccountID.Width = 6;
            // 
            // INSS
            // 
            INSS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            INSS.DataPropertyName = "INSS";
            INSS.FillWeight = 130F;
            INSS.HeaderText = "INSS";
            INSS.MinimumWidth = 6;
            INSS.Name = "INSS";
            INSS.ReadOnly = true;
            // 
            // ClientFullName
            // 
            ClientFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClientFullName.DataPropertyName = "ClientFullName";
            ClientFullName.FillWeight = 350F;
            ClientFullName.HeaderText = "Afiliado";
            ClientFullName.MinimumWidth = 6;
            ClientFullName.Name = "ClientFullName";
            ClientFullName.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.FillWeight = 150F;
            Amount.HeaderText = "Cantidad";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // AmountForInterests
            // 
            AmountForInterests.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AmountForInterests.DataPropertyName = "AmountForInterests";
            AmountForInterests.FillWeight = 210F;
            AmountForInterests.HeaderText = "Intereses acumulados";
            AmountForInterests.MinimumWidth = 6;
            AmountForInterests.Name = "AmountForInterests";
            AmountForInterests.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "¿Activo?";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Resizable = DataGridViewTriState.True;
            IsActive.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txtINSS
            // 
            txtINSS.Anchor = AnchorStyles.Top;
            txtINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtINSS.Location = new Point(471, 110);
            txtINSS.Mask = "9999999999";
            txtINSS.Name = "txtINSS";
            txtINSS.Size = new Size(125, 31);
            txtINSS.TabIndex = 9;
            txtINSS.ValidatingType = typeof(int);
            txtINSS.Click += txtINSS_Click;
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
            label4.TabIndex = 15;
            label4.Text = "No INSS";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(116, 236);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 50);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
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
            btnView.TabIndex = 16;
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
            btnUploadMonthlyDeposits.TabIndex = 18;
            btnUploadMonthlyDeposits.Text = "Ingresar cotizaciones mensuales";
            btnUploadMonthlyDeposits.UseVisualStyleBackColor = false;
            btnUploadMonthlyDeposits.Click += btnUploadMonthlyDeposits_Click;
            // 
            // FrmSavingAccountList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1080, 650);
            Controls.Add(btnUploadMonthlyDeposits);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(label4);
            Controls.Add(txtINSS);
            Controls.Add(gridSavingAccountsList);
            Controls.Add(btnNewSavingAccount);
            Controls.Add(btnSearch);
            Controls.Add(lblSavingAcountTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSavingAccountList";
            Text = "FrmAhorroList";
            Load += FrmSavingAccountList_Load;
            ((System.ComponentModel.ISupportInitialize)gridSavingAccountsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSavingAcountTitle;
        private Button btnSearch;
        private Button btnNewSavingAccount;
        private DataGridView gridSavingAccountsList;
        private MaskedTextBox txtINSS;
        private Label label4;
        private Button btnDelete;
        private Button btnView;
        private Button btnUploadMonthlyDeposits;
        private DataGridViewTextBoxColumn SavingAccountID;
        private DataGridViewTextBoxColumn INSS;
        private DataGridViewTextBoxColumn ClientFullName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn AmountForInterests;
        private DataGridViewCheckBoxColumn IsActive;
        private DataGridViewTextBoxColumn CreatedDate;
    }
}