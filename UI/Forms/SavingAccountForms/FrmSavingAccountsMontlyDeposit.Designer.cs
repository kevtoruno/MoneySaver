namespace UI.Forms.SavingAccountForms
{
    partial class FrmSavingAccountsMontlyDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSavingAccountsMontlyDeposit));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            btnFileUpload = new Button();
            label2 = new Label();
            dtDateCreated = new DateTimePicker();
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            lblAddDepositTitle = new Label();
            btnPreview = new Button();
            gridPreview = new DataGridView();
            SavingAccountID = new DataGridViewTextBoxColumn();
            IsValid = new DataGridViewTextBoxColumn();
            INSS = new DataGridViewTextBoxColumn();
            ClientFullName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ErrorMessage = new DataGridViewTextBoxColumn();
            btnCreate = new Button();
            btnCancel = new Button();
            lblTotalAmount = new Label();
            lblTotalAmountData = new Label();
            lblClientsCount = new Label();
            label8 = new Label();
            lblFileName = new Label();
            helpProvider1 = new HelpProvider();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPreview).BeginInit();
            SuspendLayout();
            // 
            // btnFileUpload
            // 
            btnFileUpload.BackColor = Color.SteelBlue;
            btnFileUpload.Cursor = Cursors.Hand;
            btnFileUpload.FlatAppearance.BorderSize = 0;
            btnFileUpload.FlatStyle = FlatStyle.Flat;
            btnFileUpload.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFileUpload.ForeColor = SystemColors.Control;
            btnFileUpload.Location = new Point(258, 145);
            btnFileUpload.Name = "btnFileUpload";
            btnFileUpload.Size = new Size(137, 45);
            btnFileUpload.TabIndex = 7;
            btnFileUpload.Text = "Subir archivo";
            btnFileUpload.UseVisualStyleBackColor = false;
            btnFileUpload.Click += btnFileUpload_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(92, 117);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 30;
            label2.Text = "Fecha ";
            // 
            // dtDateCreated
            // 
            dtDateCreated.Anchor = AnchorStyles.None;
            dtDateCreated.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Format = DateTimePickerFormat.Short;
            dtDateCreated.Location = new Point(51, 145);
            dtDateCreated.Name = "dtDateCreated";
            dtDateCreated.Size = new Size(157, 31);
            dtDateCreated.TabIndex = 29;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1040, 38);
            BarraTitulo.TabIndex = 31;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(1012, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblAddDepositTitle
            // 
            lblAddDepositTitle.Anchor = AnchorStyles.Top;
            lblAddDepositTitle.AutoSize = true;
            lblAddDepositTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddDepositTitle.ForeColor = SystemColors.Control;
            lblAddDepositTitle.Location = new Point(314, 50);
            lblAddDepositTitle.Name = "lblAddDepositTitle";
            lblAddDepositTitle.Size = new Size(405, 36);
            lblAddDepositTitle.TabIndex = 32;
            lblAddDepositTitle.Text = "Agregar cotizaciones del mes";
            // 
            // btnPreview
            // 
            btnPreview.Anchor = AnchorStyles.Top;
            btnPreview.BackColor = Color.SteelBlue;
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.FlatAppearance.BorderColor = Color.ForestGreen;
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(865, 258);
            btnPreview.Margin = new Padding(0);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(163, 43);
            btnPreview.TabIndex = 34;
            btnPreview.Text = "Previsualizar";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // gridPreview
            // 
            gridPreview.AllowUserToAddRows = false;
            gridPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPreview.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridPreview.BorderStyle = BorderStyle.None;
            gridPreview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            gridPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            gridPreview.ColumnHeadersHeight = 30;
            gridPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridPreview.Columns.AddRange(new DataGridViewColumn[] { SavingAccountID, IsValid, INSS, ClientFullName, Amount, ErrorMessage });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            gridPreview.DefaultCellStyle = dataGridViewCellStyle11;
            gridPreview.EnableHeadersVisualStyles = false;
            gridPreview.GridColor = Color.SteelBlue;
            gridPreview.Location = new Point(12, 304);
            gridPreview.Name = "gridPreview";
            gridPreview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            gridPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            gridPreview.RowHeadersVisible = false;
            gridPreview.RowHeadersWidth = 51;
            gridPreview.RowTemplate.Height = 29;
            gridPreview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPreview.Size = new Size(1016, 376);
            gridPreview.TabIndex = 35;
            gridPreview.CellFormatting += gridPreview_CellFormatting;
            // 
            // SavingAccountID
            // 
            SavingAccountID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SavingAccountID.DataPropertyName = "SavingAccountID";
            SavingAccountID.HeaderText = "SavingAccountID";
            SavingAccountID.MinimumWidth = 6;
            SavingAccountID.Name = "SavingAccountID";
            SavingAccountID.Visible = false;
            SavingAccountID.Width = 125;
            // 
            // IsValid
            // 
            IsValid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IsValid.DataPropertyName = "IsValid";
            IsValid.HeaderText = "IsValid";
            IsValid.MinimumWidth = 6;
            IsValid.Name = "IsValid";
            IsValid.Visible = false;
            IsValid.Width = 125;
            // 
            // INSS
            // 
            INSS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            INSS.DataPropertyName = "INSSNo";
            INSS.FillWeight = 30F;
            INSS.HeaderText = "INSS";
            INSS.MinimumWidth = 100;
            INSS.Name = "INSS";
            INSS.ReadOnly = true;
            // 
            // ClientFullName
            // 
            ClientFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClientFullName.DataPropertyName = "ClientFullName";
            ClientFullName.FillWeight = 150F;
            ClientFullName.HeaderText = "Afiliado";
            ClientFullName.MinimumWidth = 300;
            ClientFullName.Name = "ClientFullName";
            ClientFullName.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "AmountDisplay";
            Amount.FillWeight = 11.5773888F;
            Amount.HeaderText = "Cantidad";
            Amount.MinimumWidth = 150;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ErrorMessage.DataPropertyName = "ErrorMessage";
            ErrorMessage.HeaderText = "Mensaje error";
            ErrorMessage.MinimumWidth = 400;
            ErrorMessage.Name = "ErrorMessage";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.None;
            btnCreate.BackColor = Color.FromArgb(51, 178, 73);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(17, 683);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 54);
            btnCreate.TabIndex = 36;
            btnCreate.Text = "Guardar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Visible = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(858, 687);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Right;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(629, 250);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(64, 28);
            lblTotalAmount.TabIndex = 38;
            lblTotalAmount.Text = "Total:";
            // 
            // lblTotalAmountData
            // 
            lblTotalAmountData.Anchor = AnchorStyles.None;
            lblTotalAmountData.AutoSize = true;
            lblTotalAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmountData.ForeColor = Color.LawnGreen;
            lblTotalAmountData.Location = new Point(629, 273);
            lblTotalAmountData.Name = "lblTotalAmountData";
            lblTotalAmountData.Size = new Size(60, 28);
            lblTotalAmountData.TabIndex = 39;
            lblTotalAmountData.Text = "$$$$";
            lblTotalAmountData.Visible = false;
            // 
            // lblClientsCount
            // 
            lblClientsCount.Anchor = AnchorStyles.None;
            lblClientsCount.AutoSize = true;
            lblClientsCount.BackColor = Color.Transparent;
            lblClientsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientsCount.ForeColor = Color.White;
            lblClientsCount.Location = new Point(17, 278);
            lblClientsCount.Name = "lblClientsCount";
            lblClientsCount.Size = new Size(18, 23);
            lblClientsCount.TabIndex = 45;
            lblClientsCount.Text = "..";
            lblClientsCount.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(17, 250);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 44;
            label8.Text = "Resultado";
            // 
            // lblFileName
            // 
            lblFileName.Anchor = AnchorStyles.None;
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFileName.ForeColor = Color.White;
            lblFileName.Location = new Point(289, 117);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(82, 25);
            lblFileName.TabIndex = 46;
            lblFileName.Text = "fileName";
            lblFileName.Visible = false;
            // 
            // FrmSavingAccountsMontlyDeposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1040, 742);
            Controls.Add(lblFileName);
            Controls.Add(lblClientsCount);
            Controls.Add(label8);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblTotalAmountData);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(gridPreview);
            Controls.Add(btnPreview);
            Controls.Add(lblAddDepositTitle);
            Controls.Add(BarraTitulo);
            Controls.Add(label2);
            Controls.Add(dtDateCreated);
            Controls.Add(btnFileUpload);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSavingAccountsMontlyDeposit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Deposito mensual";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFileUpload;
        private Label label2;
        private DateTimePicker dtDateCreated;
        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Label lblAddDepositTitle;
        private Button btnPreview;
        private DataGridView gridPreview;
        private Button btnCreate;
        private Button btnCancel;
        private Label lblTotalAmount;
        private Label lblTotalAmountData;
        private Label lblClientsCount;
        private Label label8;
        private Label lblFileName;
        private HelpProvider helpProvider1;
        private DataGridViewTextBoxColumn SavingAccountID;
        private DataGridViewTextBoxColumn IsValid;
        private DataGridViewTextBoxColumn INSS;
        private DataGridViewTextBoxColumn ClientFullName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn ErrorMessage;
    }
}