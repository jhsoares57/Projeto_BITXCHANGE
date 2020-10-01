namespace BIT_DESKTOP.View.backup
{
    partial class FrmBackup
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
            this.components = new System.ComponentModel.Container();
            this.txtDiretorioBackup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDirBackup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnprocessarBackup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prgBackup = new System.Windows.Forms.ProgressBar();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDatabase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tmBack = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiretorioBackup
            // 
            this.txtDiretorioBackup.Depth = 0;
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
            // btnprocessarBackup
            // 
            this.btnprocessarBackup.Depth = 0;
            this.btnprocessarBackup.Enabled = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prgBackup);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtDiretorioBackup);
            this.groupBox1.Controls.Add(this.btnprocessarBackup);
            this.groupBox1.Controls.Add(this.btnDirBackup);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // prgBackup
            // 
            this.prgBackup.ForeColor = System.Drawing.Color.Orange;
            this.prgBackup.Location = new System.Drawing.Point(6, 154);
            this.prgBackup.Name = "prgBackup";
            this.prgBackup.Size = new System.Drawing.Size(585, 23);
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
            this.materialLabel3.Size = new System.Drawing.Size(163, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Usuário a gerar backup";
            // 
            // txtUser
            // 
            this.txtUser.Depth = 0;
            this.txtUser.Hint = "";
            this.txtUser.Location = new System.Drawing.Point(223, 60);
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(167, 23);
            this.txtUser.TabIndex = 6;
            this.txtUser.UseSystemPasswordChar = false;
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
            // tmBack
            // 
            this.tmBack.Tick += new System.EventHandler(this.tmBack_Tick);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 273);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBackup";
            this.Text = "FrmBackup";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiretorioBackup;
        private MaterialSkin.Controls.MaterialRaisedButton btnDirBackup;
        private MaterialSkin.Controls.MaterialRaisedButton btnprocessarBackup;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDatabase;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private System.Windows.Forms.ProgressBar prgBackup;
        private System.Windows.Forms.Timer tmBack;
    }
}