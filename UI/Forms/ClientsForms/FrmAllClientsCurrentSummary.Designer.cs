using Microsoft.Reporting.WinForms;

namespace UI.Forms.ClientsForms
{
    partial class FrmAllClientsCurrentSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAllClientsCurrentSummary));
            dataSet11 = new Reports.DataSet1();
            btnCerrar = new PictureBox();
            BarraTitulo = new Panel();
            rvAllClientsSummary = new ReportViewer();
            ((System.ComponentModel.ISupportInitialize)dataSet11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            BarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // dataSet11
            // 
            dataSet11.DataSetName = "DataSet1";
            dataSet11.Namespace = "http://tempuri.org/DataSet1.xsd";
            dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(810, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(850, 38);
            BarraTitulo.TabIndex = 33;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // rvAllClientsSummary
            // 
            rvAllClientsSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rvAllClientsSummary.Location = new Point(0, 38);
            rvAllClientsSummary.Name = "ReportViewer";
            rvAllClientsSummary.ServerReport.BearerToken = null;
            rvAllClientsSummary.Size = new Size(850, 700);
            rvAllClientsSummary.TabIndex = 0;
            // 
            // FrmAllClientsCurrentSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(850, 742);
            Controls.Add(BarraTitulo);
            Controls.Add(rvAllClientsSummary);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAllClientsCurrentSummary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desglose actual";
            Load += FrmAllClientsCurrentSummary_Load;
            ((System.ComponentModel.ISupportInitialize)dataSet11).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            BarraTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Reports.DataSet1 dataSet11;
        private PictureBox btnCerrar;
        private Panel BarraTitulo;
        private ReportViewer rvAllClientsSummary;
    }
}