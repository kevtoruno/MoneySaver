namespace UI.Forms.SavingAccountForms
{
    partial class FrmSavingAccountWithdrawInterests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSavingAccountWithdrawInterests));
            BarraTitulo = new Panel();
            btnClose = new PictureBox();
            label1 = new Label();
            cbSubPeriods = new ComboBox();
            label3 = new Label();
            cbPeriods = new ComboBox();
            lblInterestsWithdrawTitle = new Label();
            label2 = new Label();
            dtDateCreated = new DateTimePicker();
            btnCreate = new Button();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnClose);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(503, 38);
            BarraTitulo.TabIndex = 3;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(474, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 233);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 21;
            label1.Text = "Seleccionar subperiodo";
            // 
            // cbSubPeriods
            // 
            cbSubPeriods.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSubPeriods.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSubPeriods.DisplayMember = "FullName";
            cbSubPeriods.FlatStyle = FlatStyle.Flat;
            cbSubPeriods.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubPeriods.FormattingEnabled = true;
            cbSubPeriods.Location = new Point(32, 271);
            cbSubPeriods.Name = "cbSubPeriods";
            cbSubPeriods.Size = new Size(186, 33);
            cbSubPeriods.TabIndex = 20;
            cbSubPeriods.SelectedIndexChanged += cbSubPeriods_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(32, 140);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 19;
            label3.Text = "Seleccionar período";
            // 
            // cbPeriods
            // 
            cbPeriods.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPeriods.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbPeriods.DisplayMember = "FullName";
            cbPeriods.FlatStyle = FlatStyle.Flat;
            cbPeriods.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbPeriods.FormattingEnabled = true;
            cbPeriods.Location = new Point(32, 181);
            cbPeriods.Name = "cbPeriods";
            cbPeriods.Size = new Size(186, 33);
            cbPeriods.TabIndex = 18;
            cbPeriods.SelectedIndexChanged += cbPeriods_SelectedIndexChanged;
            // 
            // lblInterestsWithdrawTitle
            // 
            lblInterestsWithdrawTitle.Anchor = AnchorStyles.Top;
            lblInterestsWithdrawTitle.AutoSize = true;
            lblInterestsWithdrawTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblInterestsWithdrawTitle.ForeColor = SystemColors.Control;
            lblInterestsWithdrawTitle.Location = new Point(116, 68);
            lblInterestsWithdrawTitle.Name = "lblInterestsWithdrawTitle";
            lblInterestsWithdrawTitle.Size = new Size(265, 36);
            lblInterestsWithdrawTitle.TabIndex = 22;
            lblInterestsWithdrawTitle.Text = "Retiro de Intereses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(349, 140);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 26;
            label2.Text = "Fecha ";
            // 
            // dtDateCreated
            // 
            dtDateCreated.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Format = DateTimePickerFormat.Short;
            dtDateCreated.Location = new Point(313, 177);
            dtDateCreated.Name = "dtDateCreated";
            dtDateCreated.Size = new Size(134, 31);
            dtDateCreated.TabIndex = 25;
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
            btnCreate.Location = new Point(138, 337);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(192, 62);
            btnCreate.TabIndex = 27;
            btnCreate.Text = "Retirar Intereses";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmSavingAccountWithdrawInterests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(503, 441);
            Controls.Add(btnCreate);
            Controls.Add(label2);
            Controls.Add(dtDateCreated);
            Controls.Add(lblInterestsWithdrawTitle);
            Controls.Add(label1);
            Controls.Add(cbSubPeriods);
            Controls.Add(label3);
            Controls.Add(cbPeriods);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSavingAccountWithdrawInterests";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Retirar intereses";
            Load += FrmSavingAccountWithdrawInterests_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private PictureBox btnClose;
        private Label label1;
        private ComboBox cbSubPeriods;
        private Label label3;
        private ComboBox cbPeriods;
        private Label lblInterestsWithdrawTitle;
        private Label label2;
        private DateTimePicker dtDateCreated;
        private Button btnCreate;
    }
}