namespace UI.Forms.ClientsForms
{
    partial class FrmClientNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientNew));
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            txtLastName = new TextBox();
            btnCreate = new Button();
            txtFirstName = new TextBox();
            lblClientTitle = new Label();
            txtSecondName = new TextBox();
            btnCancel = new Button();
            txtIdentification = new MaskedTextBox();
            lblIdentification = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAge = new MaskedTextBox();
            txtINSS = new MaskedTextBox();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(2, 2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(688, 38);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(662, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top;
            txtLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(63, 295);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Apellidos";
            txtLastName.Size = new Size(211, 31);
            txtLastName.TabIndex = 3;
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
            btnCreate.Location = new Point(63, 374);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 50);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Agregar";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top;
            txtFirstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(63, 155);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Primer nombre";
            txtFirstName.Size = new Size(211, 31);
            txtFirstName.TabIndex = 1;
            // 
            // lblClientTitle
            // 
            lblClientTitle.Anchor = AnchorStyles.Top;
            lblClientTitle.AutoSize = true;
            lblClientTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientTitle.ForeColor = SystemColors.Control;
            lblClientTitle.Location = new Point(255, 70);
            lblClientTitle.Name = "lblClientTitle";
            lblClientTitle.Size = new Size(205, 36);
            lblClientTitle.TabIndex = 5;
            lblClientTitle.Text = "Nuevo afiliado";
            // 
            // txtSecondName
            // 
            txtSecondName.Anchor = AnchorStyles.Top;
            txtSecondName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSecondName.Location = new Point(63, 224);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.PlaceholderText = "Segundo nombre";
            txtSecondName.Size = new Size(211, 31);
            txtSecondName.TabIndex = 2;
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
            btnCancel.Location = new Point(443, 374);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtIdentification
            // 
            txtIdentification.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentification.Location = new Point(411, 295);
            txtIdentification.Mask = "0000000000000L";
            txtIdentification.Name = "txtIdentification";
            txtIdentification.Size = new Size(150, 31);
            txtIdentification.TabIndex = 6;
            // 
            // lblIdentification
            // 
            lblIdentification.AutoSize = true;
            lblIdentification.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentification.ForeColor = SystemColors.Control;
            lblIdentification.Location = new Point(411, 267);
            lblIdentification.Name = "lblIdentification";
            lblIdentification.Size = new Size(66, 25);
            lblIdentification.TabIndex = 9;
            lblIdentification.Text = "Cédula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(63, 267);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 10;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(63, 196);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 11;
            label2.Text = "Segundo nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(63, 127);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 12;
            label3.Text = "Primer nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(411, 127);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 13;
            label4.Text = "No INSS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(411, 196);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 14;
            label5.Text = "Edad";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(411, 224);
            txtAge.Mask = "000";
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(52, 31);
            txtAge.TabIndex = 5;
            // 
            // txtINSS
            // 
            txtINSS.Anchor = AnchorStyles.Top;
            txtINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtINSS.Location = new Point(411, 155);
            txtINSS.Mask = "9999999999";
            txtINSS.Name = "txtINSS";
            txtINSS.Size = new Size(125, 31);
            txtINSS.TabIndex = 4;
            txtINSS.ValidatingType = typeof(int);
            // 
            // FrmClientNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(692, 488);
            Controls.Add(txtINSS);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblIdentification);
            Controls.Add(txtIdentification);
            Controls.Add(btnCancel);
            Controls.Add(txtSecondName);
            Controls.Add(txtLastName);
            Controls.Add(btnCreate);
            Controls.Add(txtFirstName);
            Controls.Add(lblClientTitle);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "FrmClientNew";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmClientNew";
            Load += FrmClientNew_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private TextBox txtLastName;
        private Button btnCreate;
        private TextBox txtFirstName;
        private Label lblClientTitle;
        private TextBox txtSecondName;
        private Button btnCancel;
        private MaskedTextBox txtIdentification;
        private Label lblIdentification;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtAge;
        private MaskedTextBox txtINSS;
    }
}