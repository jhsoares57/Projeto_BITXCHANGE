namespace BIT_BACKUP_SERVER
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prgBackup = new System.Windows.Forms.ProgressBar();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDatabase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDiretorioBackup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnprocessarBackup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDirBackup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tmBack = new System.Windows.Forms.Timer(this.components);
            this.tmRestore = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtRestore = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbtBackup = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prgBackup);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtDiretorioBackup);
            this.groupBox1.Controls.Add(this.btnprocessarBackup);
            this.groupBox1.Controls.Add(this.btnDirBackup);
            this.groupBox1.Location = new System.Drawing.Point(10, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Executar";
            // 
            // prgBackup
            // 
            this.prgBackup.ForeColor = System.Drawing.Color.Orange;
            this.prgBackup.Location = new System.Drawing.Point(6, 154);
            this.prgBackup.Name = "prgBackup";
            this.prgBackup.Size = new System.Drawing.Size(585, 23);
            this.prgBackup.Step = 1;
            this.prgBackup.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBackup.TabIndex = 8;
            this.prgBackup.Visible = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(219, 38);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 19);
            this.materialLabel3.TabIndex = 7;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(29, 38);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Base de dados:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Depth = 0;
            this.txtDatabase.Enabled = false;
            this.txtDatabase.Hint = "";
            this.txtDatabase.Location = new System.Drawing.Point(33, 60);
            this.txtDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.SelectionLength = 0;
            this.txtDatabase.SelectionStart = 0;
            this.txtDatabase.Size = new System.Drawing.Size(167, 23);
            this.txtDatabase.TabIndex = 4;
            this.txtDatabase.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Diretorio:";
            // 
            // txtDiretorioBackup
            // 
            this.txtDiretorioBackup.Depth = 0;
            this.txtDiretorioBackup.Enabled = false;
            this.txtDiretorioBackup.Hint = "";
            this.txtDiretorioBackup.Location = new System.Drawing.Point(28, 108);
            this.txtDiretorioBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDiretorioBackup.Name = "txtDiretorioBackup";
            this.txtDiretorioBackup.PasswordChar = '\0';
            this.txtDiretorioBackup.SelectedText = "";
            this.txtDiretorioBackup.SelectionLength = 0;
            this.txtDiretorioBackup.SelectionStart = 0;
            this.txtDiretorioBackup.Size = new System.Drawing.Size(287, 23);
            this.txtDiretorioBackup.TabIndex = 0;
            this.txtDiretorioBackup.UseSystemPasswordChar = false;
            // 
            // btnprocessarBackup
            // 
            this.btnprocessarBackup.Depth = 0;
            this.btnprocessarBackup.Location = new System.Drawing.Point(471, 108);
            this.btnprocessarBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnprocessarBackup.Name = "btnprocessarBackup";
            this.btnprocessarBackup.Primary = true;
            this.btnprocessarBackup.Size = new System.Drawing.Size(109, 23);
            this.btnprocessarBackup.TabIndex = 2;
            this.btnprocessarBackup.Text = "Processar";
            this.btnprocessarBackup.UseVisualStyleBackColor = true;
            this.btnprocessarBackup.Click += new System.EventHandler(this.btnprocessarBackup_Click);
            // 
            // btnDirBackup
            // 
            this.btnDirBackup.Depth = 0;
            this.btnDirBackup.Location = new System.Drawing.Point(321, 108);
            this.btnDirBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDirBackup.Name = "btnDirBackup";
            this.btnDirBackup.Primary = true;
            this.btnDirBackup.Size = new System.Drawing.Size(109, 23);
            this.btnDirBackup.TabIndex = 1;
            this.btnDirBackup.Text = "Escolher";
            this.btnDirBackup.UseVisualStyleBackColor = true;
            this.btnDirBackup.Click += new System.EventHandler(this.btnDirBackup_Click);
            // 
            // tmBack
            // 
            this.tmBack.Tick += new System.EventHandler(this.tmBack_Tick);
            // 
            // tmRestore
            // 
            this.tmRestore.Tick += new System.EventHandler(this.tmRestore_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtRestore);
            this.groupBox2.Controls.Add(this.rdbtBackup);
            this.groupBox2.Location = new System.Drawing.Point(10, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 42);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ação";
            // 
            // rdbtRestore
            // 
            this.rdbtRestore.AutoSize = true;
            this.rdbtRestore.Depth = 0;
            this.rdbtRestore.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbtRestore.Location = new System.Drawing.Point(94, 12);
            this.rdbtRestore.Margin = new System.Windows.Forms.Padding(0);
            this.rdbtRestore.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbtRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbtRestore.Name = "rdbtRestore";
            this.rdbtRestore.Ripple = true;
            this.rdbtRestore.Size = new System.Drawing.Size(106, 30);
            this.rdbtRestore.TabIndex = 1;
            this.rdbtRestore.TabStop = true;
            this.rdbtRestore.Text = "Restauração";
            this.rdbtRestore.UseVisualStyleBackColor = true;
            // 
            // rdbtBackup
            // 
            this.rdbtBackup.AutoSize = true;
            this.rdbtBackup.Depth = 0;
            this.rdbtBackup.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbtBackup.Location = new System.Drawing.Point(6, 12);
            this.rdbtBackup.Margin = new System.Windows.Forms.Padding(0);
            this.rdbtBackup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbtBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbtBackup.Name = "rdbtBackup";
            this.rdbtBackup.Ripple = true;
            this.rdbtBackup.Size = new System.Drawing.Size(75, 30);
            this.rdbtBackup.TabIndex = 0;
            this.rdbtBackup.TabStop = true;
            this.rdbtBackup.Text = "Backup";
            this.rdbtBackup.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar prgBackup;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDatabase;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiretorioBackup;
        private MaterialSkin.Controls.MaterialRaisedButton btnprocessarBackup;
        private MaterialSkin.Controls.MaterialRaisedButton btnDirBackup;
        private System.Windows.Forms.Timer tmBack;
        private System.Windows.Forms.Timer tmRestore;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton rdbtRestore;
        private MaterialSkin.Controls.MaterialRadioButton rdbtBackup;
    }
}

