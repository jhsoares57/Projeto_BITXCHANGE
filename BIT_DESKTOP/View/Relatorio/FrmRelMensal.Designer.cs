namespace BIT_DESKTOP.View.Relatorio
{
    partial class FrmRelMensal
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dgvListarTransacoes = new System.Windows.Forms.DataGridView();
            this.btnfechar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.btnGerarPDF = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblDolar = new MaterialSkin.Controls.MaterialLabel();
            this.lblETHERUN = new MaterialSkin.Controls.MaterialLabel();
            this.lblreal = new MaterialSkin.Controls.MaterialLabel();
            this.lblBitCoin = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.imgreal = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTransacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(330, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 18);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Total por moeda";
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(666, 193);
            this.dtDataFinal.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(96, 20);
            this.dtDataFinal.TabIndex = 35;
            this.dtDataFinal.CloseUp += new System.EventHandler(this.dtDataFinal_CloseUp);
            // 
            // dgvListarTransacoes
            // 
            this.dgvListarTransacoes.AllowUserToOrderColumns = true;
            this.dgvListarTransacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListarTransacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListarTransacoes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListarTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarTransacoes.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListarTransacoes.Location = new System.Drawing.Point(12, 266);
            this.dgvListarTransacoes.Name = "dgvListarTransacoes";
            this.dgvListarTransacoes.Size = new System.Drawing.Size(776, 150);
            this.dgvListarTransacoes.TabIndex = 34;
            // 
            // btnfechar
            // 
            this.btnfechar.Depth = 0;
            this.btnfechar.Location = new System.Drawing.Point(668, 422);
            this.btnfechar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Primary = true;
            this.btnfechar.Size = new System.Drawing.Size(95, 23);
            this.btnfechar.TabIndex = 33;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(1, 248);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(797, 10);
            this.materialDivider6.TabIndex = 32;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.Depth = 0;
            this.btnGerarPDF.Location = new System.Drawing.Point(667, 219);
            this.btnGerarPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Primary = true;
            this.btnGerarPDF.Size = new System.Drawing.Size(95, 23);
            this.btnGerarPDF.TabIndex = 31;
            this.btnGerarPDF.Text = "Gerar PDF";
            this.btnGerarPDF.UseVisualStyleBackColor = true;
            this.btnGerarPDF.Click += new System.EventHandler(this.btnGerarPDF_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Depth = 0;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDolar.Location = new System.Drawing.Point(655, 143);
            this.lblDolar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(36, 18);
            this.lblDolar.TabIndex = 30;
            this.lblDolar.Text = "0,00";
            // 
            // lblETHERUN
            // 
            this.lblETHERUN.AutoSize = true;
            this.lblETHERUN.Depth = 0;
            this.lblETHERUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblETHERUN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblETHERUN.Location = new System.Drawing.Point(444, 143);
            this.lblETHERUN.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblETHERUN.Name = "lblETHERUN";
            this.lblETHERUN.Size = new System.Drawing.Size(36, 18);
            this.lblETHERUN.TabIndex = 29;
            this.lblETHERUN.Text = "0,00";
            // 
            // lblreal
            // 
            this.lblreal.AutoSize = true;
            this.lblreal.Depth = 0;
            this.lblreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblreal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblreal.Location = new System.Drawing.Point(282, 143);
            this.lblreal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblreal.Name = "lblreal";
            this.lblreal.Size = new System.Drawing.Size(36, 18);
            this.lblreal.TabIndex = 28;
            this.lblreal.Text = "0,00";
            // 
            // lblBitCoin
            // 
            this.lblBitCoin.AutoSize = true;
            this.lblBitCoin.Depth = 0;
            this.lblBitCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBitCoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBitCoin.Location = new System.Drawing.Point(97, 143);
            this.lblBitCoin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBitCoin.Name = "lblBitCoin";
            this.lblBitCoin.Size = new System.Drawing.Size(36, 18);
            this.lblBitCoin.TabIndex = 24;
            this.lblBitCoin.Text = "0,00";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(35, 177);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(728, 10);
            this.materialDivider1.TabIndex = 22;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.BackgroundImage = global::BIT_DESKTOP.Properties.Resources.Dolar;
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(591, 137);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(58, 34);
            this.materialDivider5.TabIndex = 27;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.BackgroundImage = global::BIT_DESKTOP.Properties.Resources.Eterum;
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(406, 128);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(32, 43);
            this.materialDivider4.TabIndex = 26;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // imgreal
            // 
            this.imgreal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgreal.BackgroundImage = global::BIT_DESKTOP.Properties.Resources.Real;
            this.imgreal.Depth = 0;
            this.imgreal.Location = new System.Drawing.Point(226, 128);
            this.imgreal.MouseState = MaterialSkin.MouseState.HOVER;
            this.imgreal.Name = "imgreal";
            this.imgreal.Size = new System.Drawing.Size(50, 43);
            this.imgreal.TabIndex = 25;
            this.imgreal.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.BackgroundImage = global::BIT_DESKTOP.Properties.Resources.BitCoin;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(52, 128);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(49, 43);
            this.materialDivider2.TabIndex = 23;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicial.Location = new System.Drawing.Point(519, 193);
            this.dtDataInicial.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(96, 20);
            this.dtDataInicial.TabIndex = 37;
            this.dtDataInicial.ValueChanged += new System.EventHandler(this.dtDataFinal_CloseUp);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(626, 193);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(34, 19);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "até:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(482, 193);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(31, 19);
            this.materialLabel3.TabIndex = 39;
            this.materialLabel3.Text = "De:";
            // 
            // FrmRelMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dtDataInicial);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtDataFinal);
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
            this.Name = "FrmRelMensal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Mensal";
            this.Load += new System.EventHandler(this.FrmRelDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTransacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.DataGridView dgvListarTransacoes;
        private MaterialSkin.Controls.MaterialRaisedButton btnfechar;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialRaisedButton btnGerarPDF;
        private MaterialSkin.Controls.MaterialLabel lblDolar;
        private MaterialSkin.Controls.MaterialLabel lblETHERUN;
        private MaterialSkin.Controls.MaterialLabel lblreal;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider imgreal;
        private MaterialSkin.Controls.MaterialLabel lblBitCoin;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}