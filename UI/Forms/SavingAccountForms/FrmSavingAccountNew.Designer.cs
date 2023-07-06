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
            cbClients = new ComboBox();
            label3 = new Label();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            BarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(660, 5);
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
            BarraTitulo.Size = new Size(688, 38);
            BarraTitulo.TabIndex = 2;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // lblSavingAccTitle
            // 
            lblSavingAccTitle.Anchor = AnchorStyles.Top;
            lblSavingAccTitle.AutoSize = true;
            lblSavingAccTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavingAccTitle.ForeColor = SystemColors.Control;
            lblSavingAccTitle.Location = new Point(179, 64);
            lblSavingAccTitle.Name = "lblSavingAccTitle";
            lblSavingAccTitle.Size = new Size(322, 36);
            lblSavingAccTitle.TabIndex = 6;
            lblSavingAccTitle.Text = "Nuevo fondo de ahorro";
            // 
            // cbClients
            // 
            cbClients.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbClients.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbClients.DisplayMember = "FullName";
            cbClients.FlatStyle = FlatStyle.Flat;
            cbClients.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(140, 176);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(401, 33);
            cbClients.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(238, 136);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 13;
            label3.Text = "Selecciona al afiliado";
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
            btnCreate.Location = new Point(246, 259);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(203, 66);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Crear fondo de ahorro";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmSavingAccountNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(692, 389);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(cbClients);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnCerrar;
        private Panel BarraTitulo;
        private Label lblSavingAccTitle;
        private ComboBox cbClients;
        private Label label3;
        private Button btnCreate;
    }
}