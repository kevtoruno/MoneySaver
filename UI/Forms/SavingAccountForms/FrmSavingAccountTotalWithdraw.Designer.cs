namespace UI.Forms.SavingAccountForms
{
    partial class FrmSavingAccountTotalWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSavingAccountTotalWithdraw));
            BarraTitulo = new Panel();
            btnCerrar = new PictureBox();
            lblAddDepositTitle = new Label();
            btnTotalWithdraw = new Button();
            label2 = new Label();
            dtDateCreated = new DateTimePicker();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(355, 38);
            BarraTitulo.TabIndex = 2;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(325, 5);
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
            lblAddDepositTitle.Location = new Point(89, 55);
            lblAddDepositTitle.Name = "lblAddDepositTitle";
            lblAddDepositTitle.Size = new Size(169, 36);
            lblAddDepositTitle.TabIndex = 6;
            lblAddDepositTitle.Text = "Retiro Total";
            // 
            // btnTotalWithdraw
            // 
            btnTotalWithdraw.Anchor = AnchorStyles.Top;
            btnTotalWithdraw.BackColor = Color.Crimson;
            btnTotalWithdraw.Cursor = Cursors.Hand;
            btnTotalWithdraw.FlatAppearance.BorderColor = Color.ForestGreen;
            btnTotalWithdraw.FlatAppearance.BorderSize = 0;
            btnTotalWithdraw.FlatStyle = FlatStyle.Flat;
            btnTotalWithdraw.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTotalWithdraw.ForeColor = Color.White;
            btnTotalWithdraw.Location = new Point(66, 209);
            btnTotalWithdraw.Margin = new Padding(0);
            btnTotalWithdraw.Name = "btnTotalWithdraw";
            btnTotalWithdraw.Size = new Size(192, 62);
            btnTotalWithdraw.TabIndex = 18;
            btnTotalWithdraw.Text = "Retiro total";
            btnTotalWithdraw.UseVisualStyleBackColor = false;
            btnTotalWithdraw.Click += btnTotalWithdraw_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(108, 120);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 24;
            label2.Text = "Fecha retiro";
            // 
            // dtDateCreated
            // 
            dtDateCreated.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateCreated.Format = DateTimePickerFormat.Short;
            dtDateCreated.Location = new Point(89, 148);
            dtDateCreated.Name = "dtDateCreated";
            dtDateCreated.Size = new Size(150, 31);
            dtDateCreated.TabIndex = 23;
            // 
            // FrmSavingAccountTotalWithdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(355, 298);
            Controls.Add(label2);
            Controls.Add(dtDateCreated);
            Controls.Add(btnTotalWithdraw);
            Controls.Add(lblAddDepositTitle);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSavingAccountTotalWithdraw";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Retiro total";
            Load += FrmSavingAccountTotalWithdraw_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Label lblAddDepositTitle;
        private Button btnTotalWithdraw;
        private Label label2;
        private DateTimePicker dtDateCreated;
    }
}