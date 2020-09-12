namespace BIT_DESKTOP.View.Relatorio
{
    partial class FrmRelDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelDiario));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.lblBitCoin = new MaterialSkin.Controls.MaterialLabel();
            this.imgreal = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.lblreal = new MaterialSkin.Controls.MaterialLabel();
            this.lblETHERUN = new MaterialSkin.Controls.MaterialLabel();
            this.lblDolar = new MaterialSkin.Controls.MaterialLabel();
            this.btnGerarPDF = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.btnfechar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvListarTransacoes = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTransacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(35, 170);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(728, 10);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.BackgroundImage = global::BIT_DESKTOP.Properties.Resources.BitCoin;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(52, 121);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(49, 43);
            this.materialDivider2.TabIndex = 1;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // lblBitCoin
            // 
            this.lblBitCoin.AutoSize = true;
            this.lblBitCoin.Depth = 0;
            this.lblBitCoin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBitCoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBitCoin.Location = new System.Drawing.Point(97, 136);
            this.lblBitCoin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBitCoin.Name = "lblBitCoin";
            this.lblBitCoin.Size = new System.Drawing.Size(36, 19);
            this.lblBitCoin.TabIndex = 2;
            this.lblBitCoin.Text = "0,00";
            // 
            // imgreal
            // 
            this.imgreal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgreal.BackgroundImage = global::BIT_DESKTOP.Properties.Resources.Real;
            this.imgreal.Depth = 0;
            this.imgreal.Location = new System.Drawing.Point(226, 121);
            this.imgreal.MouseState = MaterialSkin.MouseState.HOVER;
            this.imgreal.Name = "imgreal";
            this.imgreal.Size = new System.Drawing.Size(50, 43);
            this.imgreal.TabIndex = 3;
            this.imgreal.Text = "materialDivider3";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.BackgroundImage = global::BIT_DESKTOP.Properties.Resources.Eterum;
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(406, 121);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(32, 43);
            this.materialDivider4.TabIndex = 4;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.BackgroundImage = global::BIT_DESKTOP.Properties.Resources.Dolar;
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(591, 130);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(58, 34);
            this.materialDivider5.TabIndex = 5;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // lblreal
            // 
            this.lblreal.AutoSize = true;
            this.lblreal.Depth = 0;
            this.lblreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblreal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblreal.Location = new System.Drawing.Point(282, 136);
            this.lblreal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblreal.Name = "lblreal";
            this.lblreal.Size = new System.Drawing.Size(36, 18);
            this.lblreal.TabIndex = 6;
            this.lblreal.Text = "0,00";
            // 
            // lblETHERUN
            // 
            this.lblETHERUN.AutoSize = true;
            this.lblETHERUN.Depth = 0;
            this.lblETHERUN.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblETHERUN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblETHERUN.Location = new System.Drawing.Point(444, 136);
            this.lblETHERUN.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblETHERUN.Name = "lblETHERUN";
            this.lblETHERUN.Size = new System.Drawing.Size(36, 19);
            this.lblETHERUN.TabIndex = 7;
            this.lblETHERUN.Text = "0,00";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Depth = 0;
            this.lblDolar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDolar.Location = new System.Drawing.Point(655, 136);
            this.lblDolar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(36, 19);
            this.lblDolar.TabIndex = 8;
            this.lblDolar.Text = "0,00";
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.Depth = 0;
            this.btnGerarPDF.Location = new System.Drawing.Point(667, 212);
            this.btnGerarPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Primary = true;
            this.btnGerarPDF.Size = new System.Drawing.Size(95, 23);
            this.btnGerarPDF.TabIndex = 12;
            this.btnGerarPDF.Text = "Gerar PDF";
            this.btnGerarPDF.UseVisualStyleBackColor = true;
            this.btnGerarPDF.Click += new System.EventHandler(this.btnGerarPDF_Click);
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(1, 241);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(797, 10);
            this.materialDivider6.TabIndex = 13;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // btnfechar
            // 
            this.btnfechar.Depth = 0;
            this.btnfechar.Location = new System.Drawing.Point(668, 415);
            this.btnfechar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Primary = true;
            this.btnfechar.Size = new System.Drawing.Size(95, 23);
            this.btnfechar.TabIndex = 14;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // dgvListarTransacoes
            // 
            this.dgvListarTransacoes.AllowUserToOrderColumns = true;
            this.dgvListarTransacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListarTransacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListarTransacoes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListarTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarTransacoes.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListarTransacoes.Location = new System.Drawing.Point(12, 259);
            this.dgvListarTransacoes.Name = "dgvListarTransacoes";
            this.dgvListarTransacoes.Size = new System.Drawing.Size(776, 150);
            this.dgvListarTransacoes.TabIndex = 15;
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(667, 186);
            this.txtData.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(96, 20);
            this.txtData.TabIndex = 20;
            this.txtData.CloseUp += new System.EventHandler(this.txtData_CloseUp);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(330, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Total por moeda";
            // 
            // FrmRelDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.dgvListarTransacoes);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.materialDivider6);
            this.Controls.Add(this.btnGerarPDF);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblETHERUN);
            this.Controls.Add(this.lblreal);
            this.Controls.Add(this.materialDivider5);
            this.Controls.Add(this.materialDivider4);
            this.Controls.Add(this.imgreal);
            this.Controls.Add(this.lblBitCoin);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Name = "FrmRelDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Diário";
            this.Load += new System.EventHandler(this.FrmRelDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTransacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel lblBitCoin;
        private MaterialSkin.Controls.MaterialDivider imgreal;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialLabel lblreal;
        private MaterialSkin.Controls.MaterialLabel lblETHERUN;
        private MaterialSkin.Controls.MaterialLabel lblDolar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGerarPDF;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialRaisedButton btnfechar;
        private System.Windows.Forms.DataGridView dgvListarTransacoes;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}