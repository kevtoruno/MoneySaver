namespace UI.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblSavingAcountTitle = new Label();
            textBox1 = new TextBox();
            btnSearch = new Button();
            btnNewSavingAccount = new Button();
            gridSavingAccountsList = new DataGridView();
            SavingAccountID = new DataGridViewTextBoxColumn();
            ClientFullName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            AmountForInterests = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridSavingAccountsList).BeginInit();
            SuspendLayout();
            // 
            // lblSavingAcountTitle
            // 
            lblSavingAcountTitle.Anchor = AnchorStyles.Top;
            lblSavingAcountTitle.AutoSize = true;
            lblSavingAcountTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAcountTitle.ForeColor = SystemColors.Control;
            lblSavingAcountTitle.Location = new Point(535, 35);
            lblSavingAcountTitle.Name = "lblSavingAcountTitle";
            lblSavingAcountTitle.Size = new Size(211, 29);
            lblSavingAcountTitle.TabIndex = 0;
            lblSavingAcountTitle.Text = "Cuentas de ahorro";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(535, 80);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Cédula";
            textBox1.Size = new Size(211, 31);
            textBox1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(553, 117);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(170, 50);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnNewSavingAccount
            // 
            btnNewSavingAccount.BackColor = Color.SteelBlue;
            btnNewSavingAccount.Cursor = Cursors.Hand;
            btnNewSavingAccount.FlatAppearance.BorderSize = 0;
            btnNewSavingAccount.FlatStyle = FlatStyle.Flat;
            btnNewSavingAccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewSavingAccount.ForeColor = SystemColors.Control;
            btnNewSavingAccount.Location = new Point(12, 12);
            btnNewSavingAccount.Name = "btnNewSavingAccount";
            btnNewSavingAccount.Size = new Size(189, 50);
            btnNewSavingAccount.TabIndex = 6;
            btnNewSavingAccount.Text = "Nueva cuenta ahorro";
            btnNewSavingAccount.UseVisualStyleBackColor = false;
            btnNewSavingAccount.Click += btnNewSavingAccount_Click;
            // 
            // gridSavingAccountsList
            // 
            gridSavingAccountsList.AllowUserToAddRows = false;
            gridSavingAccountsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridSavingAccountsList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridSavingAccountsList.BorderStyle = BorderStyle.None;
            gridSavingAccountsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridSavingAccountsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridSavingAccountsList.ColumnHeadersHeight = 30;
            gridSavingAccountsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridSavingAccountsList.Columns.AddRange(new DataGridViewColumn[] { SavingAccountID, ClientFullName, Amount, AmountForInterests, IsActive, CreatedDate });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridSavingAccountsList.DefaultCellStyle = dataGridViewCellStyle5;
            gridSavingAccountsList.EnableHeadersVisualStyles = false;
            gridSavingAccountsList.GridColor = Color.SteelBlue;
            gridSavingAccountsList.Location = new Point(12, 338);
            gridSavingAccountsList.Name = "gridSavingAccountsList";
            gridSavingAccountsList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridSavingAccountsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridSavingAccountsList.RowHeadersVisible = false;
            gridSavingAccountsList.RowHeadersWidth = 51;
            gridSavingAccountsList.RowTemplate.Height = 29;
            gridSavingAccountsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSavingAccountsList.Size = new Size(1276, 300);
            gridSavingAccountsList.TabIndex = 7;
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
            // ClientFullName
            // 
            ClientFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClientFullName.DataPropertyName = "ClientFullName";
            ClientFullName.HeaderText = "Trabajador";
            ClientFullName.MinimumWidth = 6;
            ClientFullName.Name = "ClientFullName";
            ClientFullName.ReadOnly = true;
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
            // AmountForInterests
            // 
            AmountForInterests.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AmountForInterests.DataPropertyName = "AmountForInterests";
            AmountForInterests.HeaderText = "Cantidad para intereses";
            AmountForInterests.MinimumWidth = 6;
            AmountForInterests.Name = "AmountForInterests";
            AmountForInterests.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "¿Esta activa?";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Resizable = DataGridViewTriState.True;
            IsActive.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "Fecha creada";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Width = 125;
            // 
            // FrmSavingAccountList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1300, 650);
            Controls.Add(gridSavingAccountsList);
            Controls.Add(btnNewSavingAccount);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button btnSearch;
        private Button btnNewSavingAccount;
        private DataGridView gridSavingAccountsList;
        private DataGridViewTextBoxColumn SavingAccountID;
        private DataGridViewTextBoxColumn ClientFullName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn AmountForInterests;
        private DataGridViewCheckBoxColumn IsActive;
        private DataGridViewTextBoxColumn CreatedDate;
    }
}