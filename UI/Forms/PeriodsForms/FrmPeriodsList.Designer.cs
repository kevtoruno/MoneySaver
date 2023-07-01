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
            gridPeriodsList = new DataGridView();
            PeriodID = new DataGridViewTextBoxColumn();
            PeriodName = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            btnNewPeriod = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPeriodsList).BeginInit();
            SuspendLayout();
            // 
            // gridPeriodsList
            // 
            gridPeriodsList.AllowUserToAddRows = false;
            gridPeriodsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPeriodsList.BackgroundColor = Color.FromArgb(45, 66, 91);
            gridPeriodsList.BorderStyle = BorderStyle.None;
            gridPeriodsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridPeriodsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridPeriodsList.ColumnHeadersHeight = 30;
            gridPeriodsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridPeriodsList.Columns.AddRange(new DataGridViewColumn[] { PeriodID, PeriodName, StartDate, EndDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridPeriodsList.DefaultCellStyle = dataGridViewCellStyle2;
            gridPeriodsList.EnableHeadersVisualStyles = false;
            gridPeriodsList.GridColor = Color.SteelBlue;
            gridPeriodsList.Location = new Point(12, 291);
            gridPeriodsList.Name = "gridPeriodsList";
            gridPeriodsList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridPeriodsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridPeriodsList.RowHeadersVisible = false;
            gridPeriodsList.RowHeadersWidth = 51;
            gridPeriodsList.RowTemplate.Height = 29;
            gridPeriodsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPeriodsList.Size = new Size(1258, 300);
            gridPeriodsList.TabIndex = 5;
            // 
            // PeriodID
            // 
            PeriodID.DataPropertyName = "PeriodID";
            PeriodID.HeaderText = "PeriodID";
            PeriodID.MinimumWidth = 6;
            PeriodID.Name = "PeriodID";
            PeriodID.Visible = false;
            PeriodID.Width = 125;
            // 
            // PeriodName
            // 
            PeriodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PeriodName.DataPropertyName = "PeriodName";
            PeriodName.HeaderText = "Período";
            PeriodName.MinimumWidth = 6;
            PeriodName.Name = "PeriodName";
            PeriodName.ReadOnly = true;
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
            // btnNewPeriod
            // 
            btnNewPeriod.BackColor = Color.SteelBlue;
            btnNewPeriod.Cursor = Cursors.Hand;
            btnNewPeriod.FlatAppearance.BorderSize = 0;
            btnNewPeriod.FlatStyle = FlatStyle.Flat;
            btnNewPeriod.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewPeriod.ForeColor = SystemColors.Control;
            btnNewPeriod.Location = new Point(10, 10);
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
            Controls.Add(gridPeriodsList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPeriodsList";
            Text = "FrmPeriodsList";
            Load += FrmPeriodsList_Load;
            ((System.ComponentModel.ISupportInitialize)gridPeriodsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridPeriodsList;
        private Button btnNewPeriod;
        private Button btnView;
        private DataGridViewTextBoxColumn PeriodID;
        private DataGridViewTextBoxColumn PeriodName;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
    }
}