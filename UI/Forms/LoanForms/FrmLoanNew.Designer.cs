namespace UI.Forms.LoanForms
{
    partial class FrmLoanNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoanNew));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            lblSavingAccTitle = new Label();
            label4 = new Label();
            txtINSS = new MaskedTextBox();
            txtDescription = new RichTextBox();
            label1 = new Label();
            txtInstallments = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            txtLoanAmount = new NumericUpDown();
            dtStartDate = new DateTimePicker();
            label5 = new Label();
            btnCancel = new Button();
            btnCreate = new Button();
            gridPreview = new DataGridView();
            PeriodName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            btnPreview = new Button();
            lblInterests = new Label();
            lblInterestsData = new Label();
            label6 = new Label();
            lblTermAmountData = new Label();
            label7 = new Label();
            lblAmountData = new Label();
            label8 = new Label();
            lblClientFullNameData = new Label();
            label9 = new Label();
            lblPaperCostData = new Label();
            groupBox1 = new GroupBox();
            label14 = new Label();
            txtGurantorAddress = new RichTextBox();
            label13 = new Label();
            txtGuarantorBaseIncome = new NumericUpDown();
            label12 = new Label();
            txtGuarantorINSS = new MaskedTextBox();
            txtGuarantorWorkArea = new TextBox();
            label11 = new Label();
            txtGuarantorFullName = new TextBox();
            label10 = new Label();
            label15 = new Label();
            txtCKCode = new MaskedTextBox();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtInstallments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLoanAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPreview).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGuarantorBaseIncome).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(2, 2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1118, 38);
            BarraTitulo.TabIndex = 3;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(1090, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(428, 70);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(232, 36);
            lblSavingAccTitle.TabIndex = 7;
            lblSavingAccTitle.Text = "Nuevo préstamo";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(27, 137);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 19;
            label4.Text = "No INSS afiliado";
            // 
            // txtINSS
            // 
            txtINSS.Anchor = AnchorStyles.None;
            txtINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtINSS.Location = new Point(27, 164);
            txtINSS.Mask = "9999999999";
            txtINSS.Name = "txtINSS";
            txtINSS.Size = new Size(125, 31);
            txtINSS.TabIndex = 18;
            txtINSS.ValidatingType = typeof(int);
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(27, 303);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 73);
            txtDescription.TabIndex = 20;
            txtDescription.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(27, 275);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 21;
            label1.Text = "Descripción";
            // 
            // txtInstallments
            // 
            txtInstallments.Anchor = AnchorStyles.None;
            txtInstallments.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtInstallments.Location = new Point(299, 234);
            txtInstallments.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txtInstallments.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtInstallments.Name = "txtInstallments";
            txtInstallments.Size = new Size(107, 31);
            txtInstallments.TabIndex = 22;
            txtInstallments.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(299, 206);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 24;
            label2.Text = "Cuotas";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(299, 137);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 26;
            label3.Text = "Cantidad préstamo";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Anchor = AnchorStyles.None;
            txtLoanAmount.DecimalPlaces = 2;
            txtLoanAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoanAmount.Location = new Point(299, 165);
            txtLoanAmount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            txtLoanAmount.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(164, 31);
            txtLoanAmount.TabIndex = 25;
            txtLoanAmount.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // dtStartDate
            // 
            dtStartDate.Anchor = AnchorStyles.None;
            dtStartDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtStartDate.Location = new Point(299, 303);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(172, 31);
            dtStartDate.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(299, 275);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 28;
            label5.Text = "Fecha de Inicio ";
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
            btnCancel.Location = new Point(921, 733);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top;
            btnCreate.BackColor = Color.FromArgb(51, 178, 73);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(44, 733);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 50);
            btnCreate.TabIndex = 29;
            btnCreate.Text = "Guardar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Visible = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // gridPreview
            // 
            gridPreview.AllowUserToAddRows = false;
            gridPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPreview.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridPreview.BorderStyle = BorderStyle.None;
            gridPreview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridPreview.ColumnHeadersHeight = 30;
            gridPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridPreview.Columns.AddRange(new DataGridViewColumn[] { PeriodName, Amount, DueDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridPreview.DefaultCellStyle = dataGridViewCellStyle2;
            gridPreview.EnableHeadersVisualStyles = false;
            gridPreview.GridColor = Color.SteelBlue;
            gridPreview.Location = new Point(8, 465);
            gridPreview.Name = "gridPreview";
            gridPreview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridPreview.RowHeadersVisible = false;
            gridPreview.RowHeadersWidth = 51;
            gridPreview.RowTemplate.Height = 29;
            gridPreview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPreview.Size = new Size(1109, 265);
            gridPreview.TabIndex = 32;
            // 
            // PeriodName
            // 
            PeriodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PeriodName.DataPropertyName = "PeriodName";
            PeriodName.HeaderText = "Periodo";
            PeriodName.MinimumWidth = 6;
            PeriodName.Name = "PeriodName";
            PeriodName.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Cuota";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // DueDate
            // 
            DueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DueDate.DataPropertyName = "DueDate";
            DueDate.HeaderText = "Fecha pago";
            DueDate.MinimumWidth = 6;
            DueDate.Name = "DueDate";
            DueDate.ReadOnly = true;
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
            btnPreview.Location = new Point(948, 419);
            btnPreview.Margin = new Padding(0);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(163, 43);
            btnPreview.TabIndex = 33;
            btnPreview.Text = "Previsualizar";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // lblInterests
            // 
            lblInterests.Anchor = AnchorStyles.Right;
            lblInterests.AutoSize = true;
            lblInterests.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterests.ForeColor = Color.White;
            lblInterests.Location = new Point(366, 406);
            lblInterests.Name = "lblInterests";
            lblInterests.Size = new Size(97, 28);
            lblInterests.TabIndex = 36;
            lblInterests.Text = "Intereses";
            // 
            // lblInterestsData
            // 
            lblInterestsData.Anchor = AnchorStyles.Right;
            lblInterestsData.AutoSize = true;
            lblInterestsData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterestsData.ForeColor = Color.LawnGreen;
            lblInterestsData.Location = new Point(348, 434);
            lblInterestsData.Name = "lblInterestsData";
            lblInterestsData.Size = new Size(60, 28);
            lblInterestsData.TabIndex = 37;
            lblInterestsData.Text = "$$$$";
            lblInterestsData.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(642, 406);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 38;
            label6.Text = "Cuota";
            // 
            // lblTermAmountData
            // 
            lblTermAmountData.Anchor = AnchorStyles.Right;
            lblTermAmountData.AutoSize = true;
            lblTermAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTermAmountData.ForeColor = Color.LawnGreen;
            lblTermAmountData.Location = new Point(612, 434);
            lblTermAmountData.Name = "lblTermAmountData";
            lblTermAmountData.Size = new Size(60, 28);
            lblTermAmountData.TabIndex = 39;
            lblTermAmountData.Text = "$$$$";
            lblTermAmountData.Visible = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(761, 406);
            label7.Name = "label7";
            label7.Size = new Size(163, 28);
            label7.TabIndex = 40;
            label7.Text = "Total a entregar";
            // 
            // lblAmountData
            // 
            lblAmountData.Anchor = AnchorStyles.Right;
            lblAmountData.AutoSize = true;
            lblAmountData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmountData.ForeColor = Color.LawnGreen;
            lblAmountData.Location = new Point(772, 434);
            lblAmountData.Name = "lblAmountData";
            lblAmountData.Size = new Size(60, 28);
            lblAmountData.TabIndex = 41;
            lblAmountData.Text = "$$$$";
            lblAmountData.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(44, 402);
            label8.Name = "label8";
            label8.Size = new Size(87, 28);
            label8.TabIndex = 42;
            label8.Text = "Afiliado";
            // 
            // lblClientFullNameData
            // 
            lblClientFullNameData.Anchor = AnchorStyles.Right;
            lblClientFullNameData.AutoSize = true;
            lblClientFullNameData.BackColor = Color.Transparent;
            lblClientFullNameData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientFullNameData.ForeColor = Color.White;
            lblClientFullNameData.Location = new Point(8, 439);
            lblClientFullNameData.Name = "lblClientFullNameData";
            lblClientFullNameData.Size = new Size(18, 23);
            lblClientFullNameData.TabIndex = 43;
            lblClientFullNameData.Text = "..";
            lblClientFullNameData.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(505, 406);
            label9.Name = "label9";
            label9.Size = new Size(87, 28);
            label9.TabIndex = 44;
            label9.Text = "Papeleo";
            // 
            // lblPaperCostData
            // 
            lblPaperCostData.Anchor = AnchorStyles.Right;
            lblPaperCostData.AutoSize = true;
            lblPaperCostData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaperCostData.ForeColor = Color.LawnGreen;
            lblPaperCostData.Location = new Point(505, 434);
            lblPaperCostData.Name = "lblPaperCostData";
            lblPaperCostData.Size = new Size(60, 28);
            lblPaperCostData.TabIndex = 45;
            lblPaperCostData.Text = "$$$$";
            lblPaperCostData.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(45, 66, 91);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtGurantorAddress);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtGuarantorBaseIncome);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtGuarantorINSS);
            groupBox1.Controls.Add(txtGuarantorWorkArea);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtGuarantorFullName);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(505, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 262);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del fiador";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(294, 110);
            label14.Name = "label14";
            label14.Size = new Size(85, 25);
            label14.TabIndex = 57;
            label14.Text = "Dirección";
            // 
            // txtGurantorAddress
            // 
            txtGurantorAddress.Anchor = AnchorStyles.None;
            txtGurantorAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtGurantorAddress.Location = new Point(294, 138);
            txtGurantorAddress.Name = "txtGurantorAddress";
            txtGurantorAddress.Size = new Size(292, 101);
            txtGurantorAddress.TabIndex = 56;
            txtGurantorAddress.Text = "";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(294, 34);
            label13.Name = "label13";
            label13.Size = new Size(107, 25);
            label13.TabIndex = 55;
            label13.Text = "Salario base";
            // 
            // txtGuarantorBaseIncome
            // 
            txtGuarantorBaseIncome.Anchor = AnchorStyles.None;
            txtGuarantorBaseIncome.DecimalPlaces = 2;
            txtGuarantorBaseIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuarantorBaseIncome.Location = new Point(294, 62);
            txtGuarantorBaseIncome.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            txtGuarantorBaseIncome.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            txtGuarantorBaseIncome.Name = "txtGuarantorBaseIncome";
            txtGuarantorBaseIncome.Size = new Size(164, 31);
            txtGuarantorBaseIncome.TabIndex = 54;
            txtGuarantorBaseIncome.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(24, 180);
            label12.Name = "label12";
            label12.Size = new Size(79, 25);
            label12.TabIndex = 53;
            label12.Text = "No INSS";
            // 
            // txtGuarantorINSS
            // 
            txtGuarantorINSS.Anchor = AnchorStyles.None;
            txtGuarantorINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuarantorINSS.Location = new Point(24, 208);
            txtGuarantorINSS.Mask = "9999999999";
            txtGuarantorINSS.Name = "txtGuarantorINSS";
            txtGuarantorINSS.Size = new Size(125, 31);
            txtGuarantorINSS.TabIndex = 52;
            txtGuarantorINSS.ValidatingType = typeof(int);
            // 
            // txtGuarantorWorkArea
            // 
            txtGuarantorWorkArea.Location = new Point(24, 138);
            txtGuarantorWorkArea.Name = "txtGuarantorWorkArea";
            txtGuarantorWorkArea.Size = new Size(196, 31);
            txtGuarantorWorkArea.TabIndex = 51;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(24, 110);
            label11.Name = "label11";
            label11.Size = new Size(115, 25);
            label11.TabIndex = 50;
            label11.Text = "Dependencia";
            // 
            // txtGuarantorFullName
            // 
            txtGuarantorFullName.Location = new Point(24, 62);
            txtGuarantorFullName.Name = "txtGuarantorFullName";
            txtGuarantorFullName.Size = new Size(236, 31);
            txtGuarantorFullName.TabIndex = 49;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(24, 38);
            label10.Name = "label10";
            label10.Size = new Size(159, 25);
            label10.TabIndex = 48;
            label10.Text = "Nombre completo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(27, 206);
            label15.Name = "label15";
            label15.Size = new Size(97, 25);
            label15.TabIndex = 48;
            label15.Text = "Codigo CK";
            // 
            // txtCKCode
            // 
            txtCKCode.Anchor = AnchorStyles.None;
            txtCKCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCKCode.Location = new Point(27, 234);
            txtCKCode.Mask = "9999999";
            txtCKCode.Name = "txtCKCode";
            txtCKCode.Size = new Size(97, 31);
            txtCKCode.TabIndex = 49;
            txtCKCode.ValidatingType = typeof(int);
            // 
            // FrmLoanNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1122, 798);
            Controls.Add(txtCKCode);
            Controls.Add(label15);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(lblPaperCostData);
            Controls.Add(lblClientFullNameData);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblAmountData);
            Controls.Add(label6);
            Controls.Add(lblTermAmountData);
            Controls.Add(lblInterests);
            Controls.Add(lblInterestsData);
            Controls.Add(btnPreview);
            Controls.Add(gridPreview);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(label5);
            Controls.Add(dtStartDate);
            Controls.Add(label3);
            Controls.Add(txtLoanAmount);
            Controls.Add(label2);
            Controls.Add(txtInstallments);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtINSS);
            Controls.Add(lblSavingAccTitle);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "FrmLoanNew";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo préstamo";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtInstallments).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLoanAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPreview).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtGuarantorBaseIncome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Label lblSavingAccTitle;
        private Label label4;
        private MaskedTextBox txtINSS;
        private RichTextBox txtDescription;
        private Label label1;
        private NumericUpDown txtInstallments;
        private Label label2;
        private Label label3;
        private NumericUpDown txtLoanAmount;
        private DateTimePicker dtStartDate;
        private Label label5;
        private Button btnCancel;
        private Button btnCreate;
        private DataGridView gridPreview;
        private Button btnPreview;
        private DataGridViewTextBoxColumn PeriodName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn DueDate;
        private Label lblInterests;
        private Label lblInterestsData;
        private Label label6;
        private Label lblTermAmountData;
        private Label label7;
        private Label lblAmountData;
        private Label label8;
        private Label lblClientFullNameData;
        private Label label9;
        private Label lblPaperCostData;
        private GroupBox groupBox1;
        private TextBox txtGuarantorFullName;
        private Label label10;
        private TextBox txtGuarantorWorkArea;
        private Label label11;
        private Label label12;
        private MaskedTextBox txtGuarantorINSS;
        private Label label13;
        private NumericUpDown txtGuarantorBaseIncome;
        private Label label14;
        private RichTextBox txtGurantorAddress;
        private Label label15;
        private MaskedTextBox txtCKCode;
    }
}