namespace UI.Forms.SavingAccountForms
{
    partial class FrmSavingAccountNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSavingAccountNew));
            btnCerrar = new PictureBox();
            BarraTitulo = new Panel();
            lblSavingAccTitle = new Label();
            btnCreate = new Button();
            label4 = new Label();
            txtINSS = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            txtAge = new MaskedTextBox();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblIdentification = new Label();
            txtIdentification = new MaskedTextBox();
            txtNames = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtLastName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            BarraTitulo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(1017, 5);
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
            BarraTitulo.Location = new Point(2, 2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1045, 38);
            BarraTitulo.TabIndex = 2;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(310, 66);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(322, 36);
            lblSavingAccTitle.TabIndex = 6;
            lblSavingAccTitle.Text = "Nuevo fondo de ahorro";
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
            btnCreate.Location = new Point(351, 411);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(203, 66);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Crear fondo de ahorro";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(21, 134);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 17;
            label4.Text = "No INSS afiliado";
            // 
            // txtINSS
            // 
            txtINSS.Anchor = AnchorStyles.Top;
            txtINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtINSS.Location = new Point(21, 162);
            txtINSS.Mask = "9999999999";
            txtINSS.Name = "txtINSS";
            txtINSS.Size = new Size(125, 31);
            txtINSS.TabIndex = 16;
            txtINSS.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Top;
            maskedTextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(305, 62);
            maskedTextBox1.Mask = "9999999999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 31);
            maskedTextBox1.TabIndex = 19;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(308, 127);
            txtAge.Mask = "000";
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(52, 31);
            txtAge.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(305, 96);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 25;
            label5.Text = "Edad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(305, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 24;
            label1.Text = "No INSS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 34);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 23;
            label3.Text = "Nombres";
            // 
            // lblIdentification
            // 
            lblIdentification.AutoSize = true;
            lblIdentification.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentification.ForeColor = SystemColors.Control;
            lblIdentification.Location = new Point(305, 167);
            lblIdentification.Name = "lblIdentification";
            lblIdentification.Size = new Size(66, 25);
            lblIdentification.TabIndex = 22;
            lblIdentification.Text = "Cédula";
            // 
            // txtIdentification
            // 
            txtIdentification.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentification.Location = new Point(308, 198);
            txtIdentification.Mask = "0000000000000L";
            txtIdentification.Name = "txtIdentification";
            txtIdentification.Size = new Size(150, 31);
            txtIdentification.TabIndex = 21;
            // 
            // txtNames
            // 
            txtNames.Anchor = AnchorStyles.Top;
            txtNames.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNames.Location = new Point(18, 62);
            txtNames.Name = "txtNames";
            txtNames.PlaceholderText = "Nombres";
            txtNames.Size = new Size(211, 31);
            txtNames.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(45, 66, 91);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(txtNames);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtIdentification);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblIdentification);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(241, 134);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(803, 265);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beneficiario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 96);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 27;
            label2.Text = "Apellidos";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top;
            txtLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(18, 124);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Apellidos";
            txtLastName.Size = new Size(211, 31);
            txtLastName.TabIndex = 26;
            // 
            // FrmSavingAccountNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1049, 499);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(txtINSS);
            Controls.Add(btnCreate);
            Controls.Add(lblSavingAccTitle);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "FrmSavingAccountNew";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmSavingAccountNew";
            Load += FrmSavingAccountNew_Load;
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            BarraTitulo.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnCerrar;
        private Panel BarraTitulo;
        private Label lblSavingAccTitle;
        private Button btnCreate;
        private Label label4;
        private MaskedTextBox txtINSS;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox txtAge;
        private Label label5;
        private Label label1;
        private Label label3;
        private Label lblIdentification;
        private MaskedTextBox txtIdentification;
        private TextBox txtNames;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtLastName;
    }
}