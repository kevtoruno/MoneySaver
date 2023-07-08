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
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtInstallments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLoanAmount).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(2, 2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(712, 38);
            BarraTitulo.TabIndex = 3;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(684, 5);
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
            lblSavingAccTitle.Location = new Point(225, 70);
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
            label4.Location = new Point(78, 124);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 19;
            label4.Text = "No INSS afiliado";
            // 
            // txtINSS
            // 
            txtINSS.Anchor = AnchorStyles.None;
            txtINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtINSS.Location = new Point(78, 151);
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
            txtDescription.Location = new Point(78, 221);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(263, 80);
            txtDescription.TabIndex = 20;
            txtDescription.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(78, 193);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 21;
            label1.Text = "Descripción";
            // 
            // txtInstallments
            // 
            txtInstallments.Anchor = AnchorStyles.None;
            txtInstallments.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtInstallments.Location = new Point(385, 151);
            txtInstallments.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txtInstallments.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
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
            label2.Location = new Point(385, 123);
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
            label3.Location = new Point(78, 314);
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
            txtLoanAmount.Location = new Point(78, 342);
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
            dtStartDate.Location = new Point(385, 221);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(209, 31);
            dtStartDate.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(385, 193);
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
            btnCancel.Location = new Point(467, 421);
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
            btnCreate.Location = new Point(91, 421);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 50);
            btnCreate.TabIndex = 29;
            btnCreate.Text = "Agregar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmLoanNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(716, 508);
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
            Text = "FrmLoanNew";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtInstallments).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLoanAmount).EndInit();
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
    }
}