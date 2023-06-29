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
            btnSearch = new Button();
            txtFirstName = new TextBox();
            txtLastNames = new TextBox();
            gridClientList = new DataGridView();
            ClientID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Identification = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            INSS = new DataGridViewTextBoxColumn();
            btnNewClient = new Button();
            btnView = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClientList).BeginInit();
            SuspendLayout();
            // 
            // lblClientTitle
            // 
            lblClientTitle.Anchor = AnchorStyles.Top;
            lblClientTitle.AutoSize = true;
            lblClientTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientTitle.ForeColor = SystemColors.Control;
            lblClientTitle.Location = new Point(557, 38);
            lblClientTitle.Name = "lblClientTitle";
            lblClientTitle.Size = new Size(158, 29);
            lblClientTitle.TabIndex = 1;
            lblClientTitle.Text = "Trabajadores";
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
            btnSearch.Location = new Point(557, 167);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(170, 50);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(535, 80);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Primer nombre";
            txtFirstName.Size = new Size(211, 31);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastNames
            // 
            txtLastNames.Anchor = AnchorStyles.Top;
            txtLastNames.BorderStyle = BorderStyle.FixedSingle;
            txtLastNames.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastNames.Location = new Point(535, 130);
            txtLastNames.Name = "txtLastNames";
            txtLastNames.PlaceholderText = "Apellidos";
            txtLastNames.Size = new Size(211, 31);
            txtLastNames.TabIndex = 2;
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
            gridClientList.Columns.AddRange(new DataGridViewColumn[] { ClientID, FullName, Identification, Age, INSS });
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
            gridClientList.Location = new Point(12, 338);
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
            gridClientList.Size = new Size(1276, 300);
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
            // INSS
            // 
            INSS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            INSS.DataPropertyName = "INSS";
            INSS.HeaderText = "INSS";
            INSS.MinimumWidth = 6;
            INSS.Name = "INSS";
            INSS.ReadOnly = true;
            // 
            // btnNewClient
            // 
            btnNewClient.BackColor = Color.SteelBlue;
            btnNewClient.Cursor = Cursors.Hand;
            btnNewClient.FlatAppearance.BorderSize = 0;
            btnNewClient.FlatStyle = FlatStyle.Flat;
            btnNewClient.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewClient.ForeColor = SystemColors.Control;
            btnNewClient.Location = new Point(12, 17);
            btnNewClient.Name = "btnNewClient";
            btnNewClient.Size = new Size(170, 50);
            btnNewClient.TabIndex = 5;
            btnNewClient.Text = "Nuevo trabajador";
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
            btnView.Location = new Point(22, 272);
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
            btnDelete.Location = new Point(129, 272);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 50);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // FrmClientList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1300, 650);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnNewClient);
            Controls.Add(gridClientList);
            Controls.Add(txtLastNames);
            Controls.Add(btnSearch);
            Controls.Add(txtFirstName);
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
        private TextBox txtFirstName;
        private TextBox txtLastNames;
        private DataGridView gridClientList;
        private Button btnNewClient;
        private DataGridViewTextBoxColumn ClientID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Identification;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn INSS;
        private Button btnView;
        private Button btnDelete;
    }
}