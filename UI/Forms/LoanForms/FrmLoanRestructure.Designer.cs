namespace UI.Forms.LoanForms
{
    partial class FrmLoanRestructure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoanRestructure));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnCerrar = new PictureBox();
            BarraTitulo = new Panel();
            gridCurrentInstallments = new DataGridView();
            LoanInstallmentID = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            IsPaid = new DataGridViewCheckBoxColumn();
            DueAmount = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            SubPeriodName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            DueAmountDisplay = new DataGridViewTextBoxColumn();
            DueDateDisplay = new DataGridViewTextBoxColumn();
            lblSavingAccTitle = new Label();
            btnPreviewRestructure = new Button();
            gridRestructuredLoanPreview = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            btnCreate = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurrentInstallments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridRestructuredLoanPreview).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(1252, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1280, 38);
            BarraTitulo.TabIndex = 4;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // gridCurrentInstallments
            // 
            gridCurrentInstallments.AllowUserToAddRows = false;
            gridCurrentInstallments.AllowUserToResizeRows = false;
            gridCurrentInstallments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridCurrentInstallments.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridCurrentInstallments.BorderStyle = BorderStyle.None;
            gridCurrentInstallments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridCurrentInstallments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridCurrentInstallments.ColumnHeadersHeight = 30;
            gridCurrentInstallments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridCurrentInstallments.Columns.AddRange(new DataGridViewColumn[] { LoanInstallmentID, TransactionType, IsPaid, DueAmount, DueDate, SubPeriodName, Amount, DueAmountDisplay, DueDateDisplay });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridCurrentInstallments.DefaultCellStyle = dataGridViewCellStyle2;
            gridCurrentInstallments.EnableHeadersVisualStyles = false;
            gridCurrentInstallments.GridColor = Color.SteelBlue;
            gridCurrentInstallments.Location = new Point(0, 120);
            gridCurrentInstallments.MultiSelect = false;
            gridCurrentInstallments.Name = "gridCurrentInstallments";
            gridCurrentInstallments.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridCurrentInstallments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridCurrentInstallments.RowHeadersVisible = false;
            gridCurrentInstallments.RowHeadersWidth = 51;
            gridCurrentInstallments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridCurrentInstallments.RowTemplate.Height = 29;
            gridCurrentInstallments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCurrentInstallments.Size = new Size(1280, 225);
            gridCurrentInstallments.TabIndex = 7;
            // 
            // LoanInstallmentID
            // 
            LoanInstallmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LoanInstallmentID.DataPropertyName = "LoanInstallmentID";
            LoanInstallmentID.FillWeight = 1F;
            LoanInstallmentID.HeaderText = "LoanInstallmentID";
            LoanInstallmentID.MinimumWidth = 2;
            LoanInstallmentID.Name = "LoanInstallmentID";
            LoanInstallmentID.Visible = false;
            LoanInstallmentID.Width = 2;
            // 
            // TransactionType
            // 
            TransactionType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TransactionType.DataPropertyName = "TransactionType";
            TransactionType.FillWeight = 1F;
            TransactionType.HeaderText = "TransactionType";
            TransactionType.MinimumWidth = 2;
            TransactionType.Name = "TransactionType";
            TransactionType.Visible = false;
            TransactionType.Width = 6;
            // 
            // IsPaid
            // 
            IsPaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IsPaid.DataPropertyName = "IsPaid";
            IsPaid.FillWeight = 1F;
            IsPaid.HeaderText = "¿Pagado?";
            IsPaid.MinimumWidth = 2;
            IsPaid.Name = "IsPaid";
            IsPaid.ReadOnly = true;
            IsPaid.Resizable = DataGridViewTriState.True;
            IsPaid.SortMode = DataGridViewColumnSortMode.Automatic;
            IsPaid.Visible = false;
            IsPaid.Width = 6;
            // 
            // DueAmount
            // 
            DueAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DueAmount.DataPropertyName = "DueAmount";
            DueAmount.FillWeight = 1F;
            DueAmount.HeaderText = "DueAmount";
            DueAmount.MinimumWidth = 2;
            DueAmount.Name = "DueAmount";
            DueAmount.ReadOnly = true;
            DueAmount.Visible = false;
            DueAmount.Width = 6;
            // 
            // DueDate
            // 
            DueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DueDate.DataPropertyName = "DueDate";
            DueDate.FillWeight = 1F;
            DueDate.HeaderText = "DueDate";
            DueDate.MinimumWidth = 2;
            DueDate.Name = "DueDate";
            DueDate.Visible = false;
            DueDate.Width = 2;
            // 
            // SubPeriodName
            // 
            SubPeriodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubPeriodName.DataPropertyName = "SubPeriodName";
            SubPeriodName.FillWeight = 180F;
            SubPeriodName.HeaderText = "Sub período";
            SubPeriodName.MinimumWidth = 6;
            SubPeriodName.Name = "SubPeriodName";
            SubPeriodName.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.FillWeight = 120F;
            Amount.HeaderText = "Cantidad";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // DueAmountDisplay
            // 
            DueAmountDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DueAmountDisplay.DataPropertyName = "DueAmountDisplay";
            DueAmountDisplay.FillWeight = 120F;
            DueAmountDisplay.HeaderText = "Pendiente";
            DueAmountDisplay.MinimumWidth = 6;
            DueAmountDisplay.Name = "DueAmountDisplay";
            DueAmountDisplay.ReadOnly = true;
            // 
            // DueDateDisplay
            // 
            DueDateDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DueDateDisplay.DataPropertyName = "DueDateDisplay";
            DueDateDisplay.FillWeight = 120F;
            DueDateDisplay.HeaderText = "Fecha limite";
            DueDateDisplay.MinimumWidth = 6;
            DueDateDisplay.Name = "DueDateDisplay";
            DueDateDisplay.ReadOnly = true;
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(454, 64);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(396, 36);
            lblSavingAccTitle.TabIndex = 36;
            lblSavingAccTitle.Text = "Restructuración de préstamo";
            // 
            // btnPreviewRestructure
            // 
            btnPreviewRestructure.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPreviewRestructure.BackColor = Color.FromArgb(51, 178, 73);
            btnPreviewRestructure.Cursor = Cursors.Hand;
            btnPreviewRestructure.FlatAppearance.BorderColor = Color.ForestGreen;
            btnPreviewRestructure.FlatAppearance.BorderSize = 0;
            btnPreviewRestructure.FlatStyle = FlatStyle.Flat;
            btnPreviewRestructure.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreviewRestructure.ForeColor = Color.White;
            btnPreviewRestructure.Location = new Point(1015, 365);
            btnPreviewRestructure.Margin = new Padding(0);
            btnPreviewRestructure.Name = "btnPreviewRestructure";
            btnPreviewRestructure.Size = new Size(256, 50);
            btnPreviewRestructure.TabIndex = 37;
            btnPreviewRestructure.Text = "Previsualizar restructuración";
            btnPreviewRestructure.UseVisualStyleBackColor = false;
            btnPreviewRestructure.Click += btnPreviewRestructure_Click;
            // 
            // gridRestructuredLoanPreview
            // 
            gridRestructuredLoanPreview.AllowUserToAddRows = false;
            gridRestructuredLoanPreview.AllowUserToResizeRows = false;
            gridRestructuredLoanPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridRestructuredLoanPreview.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridRestructuredLoanPreview.BorderStyle = BorderStyle.None;
            gridRestructuredLoanPreview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridRestructuredLoanPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridRestructuredLoanPreview.ColumnHeadersHeight = 30;
            gridRestructuredLoanPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridRestructuredLoanPreview.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridRestructuredLoanPreview.DefaultCellStyle = dataGridViewCellStyle5;
            gridRestructuredLoanPreview.EnableHeadersVisualStyles = false;
            gridRestructuredLoanPreview.GridColor = Color.SteelBlue;
            gridRestructuredLoanPreview.Location = new Point(0, 433);
            gridRestructuredLoanPreview.MultiSelect = false;
            gridRestructuredLoanPreview.Name = "gridRestructuredLoanPreview";
            gridRestructuredLoanPreview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridRestructuredLoanPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridRestructuredLoanPreview.RowHeadersVisible = false;
            gridRestructuredLoanPreview.RowHeadersWidth = 51;
            gridRestructuredLoanPreview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridRestructuredLoanPreview.RowTemplate.Height = 29;
            gridRestructuredLoanPreview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRestructuredLoanPreview.Size = new Size(1280, 225);
            gridRestructuredLoanPreview.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.DataPropertyName = "LoanInstallmentID";
            dataGridViewTextBoxColumn1.FillWeight = 1F;
            dataGridViewTextBoxColumn1.HeaderText = "LoanInstallmentID";
            dataGridViewTextBoxColumn1.MinimumWidth = 2;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.DataPropertyName = "TransactionType";
            dataGridViewTextBoxColumn2.FillWeight = 1F;
            dataGridViewTextBoxColumn2.HeaderText = "TransactionType";
            dataGridViewTextBoxColumn2.MinimumWidth = 2;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Visible = false;
            dataGridViewTextBoxColumn2.Width = 6;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCheckBoxColumn1.DataPropertyName = "IsPaid";
            dataGridViewCheckBoxColumn1.FillWeight = 1F;
            dataGridViewCheckBoxColumn1.HeaderText = "¿Pagado?";
            dataGridViewCheckBoxColumn1.MinimumWidth = 2;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.ReadOnly = true;
            dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewCheckBoxColumn1.Visible = false;
            dataGridViewCheckBoxColumn1.Width = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn3.DataPropertyName = "DueAmount";
            dataGridViewTextBoxColumn3.FillWeight = 1F;
            dataGridViewTextBoxColumn3.HeaderText = "DueAmount";
            dataGridViewTextBoxColumn3.MinimumWidth = 2;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Visible = false;
            dataGridViewTextBoxColumn3.Width = 6;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn4.DataPropertyName = "DueDate";
            dataGridViewTextBoxColumn4.FillWeight = 1F;
            dataGridViewTextBoxColumn4.HeaderText = "DueDate";
            dataGridViewTextBoxColumn4.MinimumWidth = 2;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Visible = false;
            dataGridViewTextBoxColumn4.Width = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.DataPropertyName = "SubPeriodName";
            dataGridViewTextBoxColumn6.FillWeight = 180F;
            dataGridViewTextBoxColumn6.HeaderText = "Sub período";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn7.DataPropertyName = "Amount";
            dataGridViewTextBoxColumn7.FillWeight = 120F;
            dataGridViewTextBoxColumn7.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.DataPropertyName = "DueAmountDisplay";
            dataGridViewTextBoxColumn8.FillWeight = 120F;
            dataGridViewTextBoxColumn8.HeaderText = "Pendiente";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn9.DataPropertyName = "DueDateDisplay";
            dataGridViewTextBoxColumn9.FillWeight = 120F;
            dataGridViewTextBoxColumn9.HeaderText = "Fecha limite";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
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
            btnCreate.Location = new Point(9, 661);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 50);
            btnCreate.TabIndex = 39;
            btnCreate.Text = "Guardar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Visible = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1101, 661);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmLoanRestructure
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1280, 720);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(gridRestructuredLoanPreview);
            Controls.Add(btnPreviewRestructure);
            Controls.Add(lblSavingAccTitle);
            Controls.Add(gridCurrentInstallments);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLoanRestructure";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Restructuracion de préstamo";
            Load += FrmLoanRestructure_Load;
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCurrentInstallments).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridRestructuredLoanPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnCerrar;
        private Panel BarraTitulo;
        private DataGridView gridCurrentInstallments;
        private DataGridViewTextBoxColumn LoanInstallmentID;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewCheckBoxColumn IsPaid;
        private DataGridViewTextBoxColumn DueAmount;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn TransactionTypeString;
        private DataGridViewTextBoxColumn SubPeriodName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn DueAmountDisplay;
        private DataGridViewTextBoxColumn DueDateDisplay;
        private DataGridViewTextBoxColumn DatePaidDisplay;
        private Label lblSavingAccTitle;
        private Button btnPayInstallment;
        private DataGridView gridRestructuredLoanPreview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Button btnCreate;
        private Button btnCancel;
        private Button btnPreviewRestructure;
    }
}