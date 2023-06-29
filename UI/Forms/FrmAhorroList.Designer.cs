namespace UI.Forms
{
    partial class FrmAhorroList
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
            lblSavingAcountTitle = new Label();
            gridSavingAccountsList = new DataGridView();
            textBox1 = new TextBox();
            btnNewSavingAccount = new Button();
            btnSearch = new Button();
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
            // gridSavingAccountsList
            // 
            gridSavingAccountsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridSavingAccountsList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridSavingAccountsList.BorderStyle = BorderStyle.None;
            gridSavingAccountsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSavingAccountsList.Location = new Point(12, 338);
            gridSavingAccountsList.Name = "gridSavingAccountsList";
            gridSavingAccountsList.RowHeadersWidth = 51;
            gridSavingAccountsList.RowTemplate.Height = 29;
            gridSavingAccountsList.Size = new Size(1276, 300);
            gridSavingAccountsList.TabIndex = 1;
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
            // btnNewSavingAccount
            // 
            btnNewSavingAccount.BackColor = Color.SteelBlue;
            btnNewSavingAccount.FlatAppearance.BorderSize = 0;
            btnNewSavingAccount.FlatStyle = FlatStyle.Flat;
            btnNewSavingAccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewSavingAccount.ForeColor = SystemColors.Control;
            btnNewSavingAccount.Location = new Point(12, 16);
            btnNewSavingAccount.Name = "btnNewSavingAccount";
            btnNewSavingAccount.Size = new Size(193, 50);
            btnNewSavingAccount.TabIndex = 3;
            btnNewSavingAccount.Text = "Nueva cuenta ahorro";
            btnNewSavingAccount.UseVisualStyleBackColor = false;
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
            // FrmAhorroList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1300, 650);
            Controls.Add(btnSearch);
            Controls.Add(btnNewSavingAccount);
            Controls.Add(textBox1);
            Controls.Add(gridSavingAccountsList);
            Controls.Add(lblSavingAcountTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAhorroList";
            Text = "FrmAhorroList";
            ((System.ComponentModel.ISupportInitialize)gridSavingAccountsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSavingAcountTitle;
        private DataGridView gridSavingAccountsList;
        private TextBox textBox1;
        private Button btnNewSavingAccount;
        private Button btnSearch;
    }
}