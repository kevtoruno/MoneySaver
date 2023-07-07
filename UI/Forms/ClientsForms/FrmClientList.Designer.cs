namespace UI.Forms
{
    partial class FrmClientList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblClientTitle = new Label();
            gridClientList = new DataGridView();
            ClientID = new DataGridViewTextBoxColumn();
            INSS = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Identification = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            btnNewClient = new Button();
            btnView = new Button();
            btnDelete = new Button();
            txtINSS = new MaskedTextBox();
            label4 = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClientList).BeginInit();
            SuspendLayout();
            // 
            // lblClientTitle
            // 
            lblClientTitle.Anchor = AnchorStyles.Top;
            lblClientTitle.AutoSize = true;
            lblClientTitle.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblClientTitle.ForeColor = SystemColors.Control;
            lblClientTitle.Location = new Point(460, 14);
            lblClientTitle.Name = "lblClientTitle";
            lblClientTitle.Size = new Size(140, 37);
            lblClientTitle.TabIndex = 1;
            lblClientTitle.Text = "Afiliados";
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
            gridClientList.Columns.AddRange(new DataGridViewColumn[] { ClientID, INSS, FullName, Identification, Age });
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
            gridClientList.Location = new Point(9, 292);
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
            gridClientList.Size = new Size(1070, 346);
            gridClientList.TabIndex = 4;
            gridClientList.RowStateChanged += gridClientList_RowStateChanged;
            // 
            // ClientID
            // 
            ClientID.DataPropertyName = "ClientID";
            ClientID.HeaderText = "ClientID";
            ClientID.MinimumWidth = 6;
            ClientID.Name = "ClientID";
            ClientID.Visible = false;
            ClientID.Width = 125;
            // 
            // INSS
            // 
            INSS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            INSS.DataPropertyName = "INSS";
            INSS.HeaderText = "INSS";
            INSS.MinimumWidth = 6;
            INSS.Name = "INSS";
            INSS.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Nombre";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Identification
            // 
            Identification.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Identification.DataPropertyName = "Identification";
            Identification.HeaderText = "Cédula";
            Identification.MinimumWidth = 6;
            Identification.Name = "Identification";
            Identification.ReadOnly = true;
            // 
            // Age
            // 
            Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Age.DataPropertyName = "Age";
            Age.HeaderText = "Edad";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // btnNewClient
            // 
            btnNewClient.BackColor = Color.SteelBlue;
            btnNewClient.Cursor = Cursors.Hand;
            btnNewClient.FlatAppearance.BorderSize = 0;
            btnNewClient.FlatStyle = FlatStyle.Flat;
            btnNewClient.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewClient.ForeColor = SystemColors.Control;
            btnNewClient.Location = new Point(10, 10);
            btnNewClient.Name = "btnNewClient";
            btnNewClient.Size = new Size(170, 50);
            btnNewClient.TabIndex = 5;
            btnNewClient.Text = "Nuevo afiliado";
            btnNewClient.UseVisualStyleBackColor = false;
            btnNewClient.Click += btnNewClient_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.SteelBlue;
            btnView.Cursor = Cursors.Hand;
            btnView.Enabled = false;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.ForeColor = SystemColors.Control;
            btnView.Location = new Point(9, 236);
            btnView.Name = "btnView";
            btnView.Size = new Size(87, 50);
            btnView.TabIndex = 6;
            btnView.Text = "Ver";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(116, 236);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 50);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtINSS
            // 
            txtINSS.Anchor = AnchorStyles.Top;
            txtINSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtINSS.Location = new Point(471, 110);
            txtINSS.Mask = "9999999999";
            txtINSS.Name = "txtINSS";
            txtINSS.Size = new Size(125, 31);
            txtINSS.TabIndex = 8;
            txtINSS.ValidatingType = typeof(int);
            txtINSS.MaskInputRejected += txtINSS_MaskInputRejected;
            txtINSS.Click += txtINSS_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(490, 80);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 14;
            label4.Text = "No INSS";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(458, 147);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 50);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // FrmClientList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1080, 650);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(txtINSS);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnNewClient);
            Controls.Add(gridClientList);
            Controls.Add(lblClientTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClientList";
            Text = "FrmClientList";
            Load += FrmClientList_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClientTitle;
        private Button btnSearch;
        private DataGridView gridClientList;
        private Button btnNewClient;
        private Button btnView;
        private Button btnDelete;
        private MaskedTextBox txtINSS;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn ClientID;
        private DataGridViewTextBoxColumn INSS;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Identification;
        private DataGridViewTextBoxColumn Age;
    }
}