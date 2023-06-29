namespace UI.Forms.PeriodsForms
{
    partial class FrmPeriodNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeriodNew));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnCerrar = new PictureBox();
            BarraTitulo = new Panel();
            lblPeriodTitle = new Label();
            lblYear = new Label();
            txtYear = new MaskedTextBox();
            button1 = new Button();
            btnCreate = new Button();
            btnPreview = new Button();
            gridClientList = new DataGridView();
            dtPeriodStartDate = new DateTimePicker();
            dtPeriodEndDate = new DateTimePicker();
            Month = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientList).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(753, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 0;
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
            BarraTitulo.Size = new Size(781, 38);
            BarraTitulo.TabIndex = 2;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // lblPeriodTitle
            // 
            lblPeriodTitle.Anchor = AnchorStyles.Top;
            lblPeriodTitle.AutoSize = true;
            lblPeriodTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodTitle.ForeColor = SystemColors.Control;
            lblPeriodTitle.Location = new Point(263, 59);
            lblPeriodTitle.Name = "lblPeriodTitle";
            lblPeriodTitle.Size = new Size(211, 36);
            lblPeriodTitle.TabIndex = 6;
            lblPeriodTitle.Text = "Nuevo período";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblYear.ForeColor = SystemColors.Control;
            lblYear.Location = new Point(21, 97);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(113, 25);
            lblYear.TabIndex = 14;
            lblYear.Text = "Año período";
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtYear.Location = new Point(21, 127);
            txtYear.Mask = "9999";
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(98, 31);
            txtYear.TabIndex = 15;
            txtYear.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.ForestGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(542, 471);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(170, 50);
            button1.TabIndex = 17;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top;
            btnCreate.BackColor = Color.FromArgb(51, 178, 73);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(38, 471);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 50);
            btnCreate.TabIndex = 16;
            btnCreate.Text = "Guardar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Visible = false;
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
            btnPreview.Location = new Point(137, 122);
            btnPreview.Margin = new Padding(0);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(153, 40);
            btnPreview.TabIndex = 18;
            btnPreview.Text = "Previsualizar";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // gridClientList
            // 
            gridClientList.AllowUserToAddRows = false;
            gridClientList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridClientList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridClientList.BorderStyle = BorderStyle.None;
            gridClientList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridClientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridClientList.ColumnHeadersHeight = 30;
            gridClientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridClientList.Columns.AddRange(new DataGridViewColumn[] { Month, StartDate, EndDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridClientList.DefaultCellStyle = dataGridViewCellStyle2;
            gridClientList.EnableHeadersVisualStyles = false;
            gridClientList.GridColor = Color.SteelBlue;
            gridClientList.Location = new Point(12, 179);
            gridClientList.Name = "gridClientList";
            gridClientList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridClientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridClientList.RowHeadersVisible = false;
            gridClientList.RowHeadersWidth = 51;
            gridClientList.RowTemplate.Height = 29;
            gridClientList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientList.Size = new Size(741, 206);
            gridClientList.TabIndex = 19;
            // 
            // dtPeriodStartDate
            // 
            dtPeriodStartDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtPeriodStartDate.Enabled = false;
            dtPeriodStartDate.Format = DateTimePickerFormat.Short;
            dtPeriodStartDate.Location = new Point(456, 135);
            dtPeriodStartDate.Name = "dtPeriodStartDate";
            dtPeriodStartDate.Size = new Size(134, 27);
            dtPeriodStartDate.TabIndex = 20;
            // 
            // dtPeriodEndDate
            // 
            dtPeriodEndDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtPeriodEndDate.Enabled = false;
            dtPeriodEndDate.Format = DateTimePickerFormat.Short;
            dtPeriodEndDate.Location = new Point(621, 135);
            dtPeriodEndDate.Name = "dtPeriodEndDate";
            dtPeriodEndDate.Size = new Size(132, 27);
            dtPeriodEndDate.TabIndex = 21;
            // 
            // Month
            // 
            Month.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Month.DataPropertyName = "Month";
            Month.HeaderText = "Mes";
            Month.MinimumWidth = 6;
            Month.Name = "Month";
            Month.ReadOnly = true;
            // 
            // StartDate
            // 
            StartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "Fecha inicio";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            EndDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "Fecha fin";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            // 
            // FrmPeriodNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(781, 552);
            Controls.Add(dtPeriodEndDate);
            Controls.Add(dtPeriodStartDate);
            Controls.Add(gridClientList);
            Controls.Add(btnPreview);
            Controls.Add(button1);
            Controls.Add(btnCreate);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(lblPeriodTitle);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPeriodNew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPeriodNew";
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClientList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnCerrar;
        private Panel BarraTitulo;
        private Label lblPeriodTitle;
        private Label lblYear;
        private MaskedTextBox txtYear;
        private Button button1;
        private Button btnCreate;
        private Button btnPreview;
        private DataGridView gridClientList;
        private DateTimePicker dtPeriodStartDate;
        private DateTimePicker dtPeriodEndDate;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
    }
}