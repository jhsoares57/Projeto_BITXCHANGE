namespace BIT_DESKTOP.View
{
    partial class FrmListaUsuario
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
            this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExtrato = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvCarregarUsuario = new System.Windows.Forms.DataGridView();
            this.btnFechar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPesquisaUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarregarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Depth = 0;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 82);
            this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Primary = true;
            this.btnAdicionar.Size = new System.Drawing.Size(122, 34);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(156, 82);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(122, 34);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.Depth = 0;
            this.btnExtrato.Location = new System.Drawing.Point(297, 82);
            this.btnExtrato.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Primary = true;
            this.btnExtrato.Size = new System.Drawing.Size(122, 34);
            this.btnExtrato.TabIndex = 2;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // dgvCarregarUsuario
            // 
            this.dgvCarregarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarregarUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCarregarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarregarUsuario.Location = new System.Drawing.Point(12, 184);
            this.dgvCarregarUsuario.Name = "dgvCarregarUsuario";
            this.dgvCarregarUsuario.Size = new System.Drawing.Size(776, 254);
            this.dgvCarregarUsuario.TabIndex = 3;
            this.dgvCarregarUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarregarUsuario_CellClick);
            // 
            // btnFechar
            // 
            this.btnFechar.Depth = 0;
            this.btnFechar.Location = new System.Drawing.Point(436, 82);
            this.btnFechar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Primary = true;
            this.btnFechar.Size = new System.Drawing.Size(122, 34);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 151);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Pesquisar:";
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisaUsuario.Depth = 0;
            this.txtPesquisaUsuario.Hint = "";
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(98, 147);
            this.txtPesquisaUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.PasswordChar = '\0';
            this.txtPesquisaUsuario.SelectedText = "";
            this.txtPesquisaUsuario.SelectionLength = 0;
            this.txtPesquisaUsuario.SelectionStart = 0;
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(204, 23);
            this.txtPesquisaUsuario.TabIndex = 6;
            this.txtPesquisaUsuario.UseSystemPasswordChar = false;
            this.txtPesquisaUsuario.TextChanged += new System.EventHandler(this.txtPesquisaUsuario_TextChanged);
            // 
            // FrmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtPesquisaUsuario);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvCarregarUsuario);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "FrmListaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de usuário";
            this.Load += new System.EventHandler(this.FrmListaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarregarUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnExtrato;
        private System.Windows.Forms.DataGridView dgvCarregarUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnFechar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisaUsuario;
    }
}