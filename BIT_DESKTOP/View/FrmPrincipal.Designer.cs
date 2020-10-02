namespace BIT_DESKTOP.View
{
    partial class FrmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRelMensal = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRelDiario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBackup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.btnRelMensal);
            this.panel1.Controls.Add(this.btnRelDiario);
            this.panel1.Controls.Add(this.materialRaisedButton1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 53);
            this.panel1.TabIndex = 2;
            // 
            // btnInicio
            // 
            this.btnInicio.Depth = 0;
            this.btnInicio.Location = new System.Drawing.Point(17, 14);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(148, 30);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnRelMensal
            // 
            this.btnRelMensal.Depth = 0;
            this.btnRelMensal.Location = new System.Drawing.Point(353, 14);
            this.btnRelMensal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelMensal.Name = "btnRelMensal";
            this.btnRelMensal.Primary = true;
            this.btnRelMensal.Size = new System.Drawing.Size(148, 30);
            this.btnRelMensal.TabIndex = 2;
            this.btnRelMensal.Text = "Relatorio Mensal";
            this.btnRelMensal.UseVisualStyleBackColor = true;
            this.btnRelMensal.Click += new System.EventHandler(this.btnRelMensal_Click);
            // 
            // btnRelDiario
            // 
            this.btnRelDiario.Depth = 0;
            this.btnRelDiario.Location = new System.Drawing.Point(188, 14);
            this.btnRelDiario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelDiario.Name = "btnRelDiario";
            this.btnRelDiario.Primary = true;
            this.btnRelDiario.Size = new System.Drawing.Size(148, 30);
            this.btnRelDiario.TabIndex = 1;
            this.btnRelDiario.Text = "Relatorio Diario";
            this.btnRelDiario.UseVisualStyleBackColor = true;
            this.btnRelDiario.Click += new System.EventHandler(this.btnRelDiario_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(520, 14);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(122, 30);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Usuário";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Depth = 0;
            this.btnBackup.Location = new System.Drawing.Point(665, 14);
            this.btnBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Primary = true;
            this.btnBackup.Size = new System.Drawing.Size(122, 30);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnRelDiario;
        private MaterialSkin.Controls.MaterialRaisedButton btnRelMensal;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
        private MaterialSkin.Controls.MaterialRaisedButton btnBackup;
    }
}