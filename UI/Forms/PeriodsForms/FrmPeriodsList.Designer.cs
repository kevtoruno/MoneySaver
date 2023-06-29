namespace UI.Forms.PeriodsForms
{
    partial class FrmPeriodsList
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
            gridClientList = new DataGridView();
            ClientID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Identification = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            INSS = new DataGridViewTextBoxColumn();
            btnNewPeriod = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClientList).BeginInit();
            SuspendLayout();
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
            gridClientList.Location = new Point(12, 291);
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
            gridClientList.Size = new Size(1258, 300);
            gridClientList.TabIndex = 5;
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
            // btnNewPeriod
            // 
            btnNewPeriod.BackColor = Color.SteelBlue;
            btnNewPeriod.Cursor = Cursors.Hand;
            btnNewPeriod.FlatAppearance.BorderSize = 0;
            btnNewPeriod.FlatStyle = FlatStyle.Flat;
            btnNewPeriod.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewPeriod.ForeColor = SystemColors.Control;
            btnNewPeriod.Location = new Point(12, 12);
            btnNewPeriod.Name = "btnNewPeriod";
            btnNewPeriod.Size = new Size(170, 50);
            btnNewPeriod.TabIndex = 6;
            btnNewPeriod.Text = "Nuevo período";
            btnNewPeriod.UseVisualStyleBackColor = false;
            btnNewPeriod.Click += btnNewPeriod_Click;
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
            btnView.Location = new Point(12, 235);
            btnView.Name = "btnView";
            btnView.Size = new Size(87, 50);
            btnView.TabIndex = 7;
            btnView.Text = "Ver";
            btnView.UseVisualStyleBackColor = false;
            // 
            // FrmPeriodsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1282, 603);
            Controls.Add(btnView);
            Controls.Add(btnNewPeriod);
            Controls.Add(gridClientList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPeriodsList";
            Text = "FrmPeriodsList";
            ((System.ComponentModel.ISupportInitialize)gridClientList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridClientList;
        private DataGridViewTextBoxColumn ClientID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Identification;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn INSS;
        private Button btnNewPeriod;
        private Button btnView;
    }
}