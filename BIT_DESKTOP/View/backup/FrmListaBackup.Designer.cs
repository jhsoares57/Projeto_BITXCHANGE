namespace BIT_DESKTOP.View.backup
{
    partial class FrmListaBackup
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
            this.dgvListaBackup = new System.Windows.Forms.DataGridView();
            this.btnGerarBackup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaBackup
            // 
            this.dgvListaBackup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaBackup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaBackup.Location = new System.Drawing.Point(24, 146);
            this.dgvListaBackup.Name = "dgvListaBackup";
            this.dgvListaBackup.Size = new System.Drawing.Size(675, 150);
            this.dgvListaBackup.TabIndex = 22;
            // 
            // btnGerarBackup
            // 
            this.btnGerarBackup.Depth = 0;
            this.btnGerarBackup.Location = new System.Drawing.Point(24, 80);
            this.btnGerarBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGerarBackup.Name = "btnGerarBackup";
            this.btnGerarBackup.Primary = true;
            this.btnGerarBackup.Size = new System.Drawing.Size(150, 30);
            this.btnGerarBackup.TabIndex = 24;
            this.btnGerarBackup.Text = "Gerar backup";
            this.btnGerarBackup.UseVisualStyleBackColor = true;
            this.btnGerarBackup.Click += new System.EventHandler(this.btnGerarBackup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "São listados apenas os 20 ultimos backups realizados";
            // 
            // FrmListaBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarBackup);
            this.Controls.Add(this.dgvListaBackup);
            this.Name = "FrmListaBackup";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.FrmListaBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBackup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListaBackup;
        private MaterialSkin.Controls.MaterialRaisedButton btnGerarBackup;
        private System.Windows.Forms.Label label1;
    }
}