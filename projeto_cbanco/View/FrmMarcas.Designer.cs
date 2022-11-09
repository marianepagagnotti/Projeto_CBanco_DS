namespace projeto_cbanco.View
{
    partial class FrmMarcas
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
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLixo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(485, 161);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(55, 34);
            this.btnPesquisa.TabIndex = 43;
            this.btnPesquisa.Text = "🔎";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(132, 173);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(321, 20);
            this.txtPesquisa.TabIndex = 42;
            this.txtPesquisa.Text = "Cidade que deseja pesquisar... ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 27);
            this.label4.TabIndex = 41;
            this.label4.Text = "Pesquisa:";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.AllowUserToOrderColumns = true;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(50, 221);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.Size = new System.Drawing.Size(523, 386);
            this.dgvMarcas.TabIndex = 40;
            this.dgvMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellClick);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(688, -80);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 38);
            this.btnFechar.TabIndex = 39;
            this.btnFechar.Text = " ❌";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnLixo
            // 
            this.btnLixo.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLixo.Location = new System.Drawing.Point(421, 98);
            this.btnLixo.Name = "btnLixo";
            this.btnLixo.Size = new System.Drawing.Size(119, 47);
            this.btnLixo.TabIndex = 38;
            this.btnLixo.Text = "🗑️ Excluir";
            this.btnLixo.UseVisualStyleBackColor = true;
            this.btnLixo.Click += new System.EventHandler(this.btnLixo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(444, 613);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 47);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "↩️ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(234, 98);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(119, 47);
            this.btnAlterar.TabIndex = 36;
            this.btnAlterar.Text = "🔄 Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(50, 98);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(114, 47);
            this.btnIncluir.TabIndex = 35;
            this.btnIncluir.Text = "➕ Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(335, -62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(287, 20);
            this.txtNome.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, -68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cidade:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(145, -61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(62, 20);
            this.txtID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, -67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código:";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(286, 30);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(287, 20);
            this.txtmarca.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 27);
            this.label5.TabIndex = 46;
            this.label5.Text = "Marca:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(89, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 20);
            this.txtCodigo.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 27);
            this.label6.TabIndex = 44;
            this.label6.Text = "Código:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(672, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 38);
            this.button1.TabIndex = 48;
            this.button1.Text = " ❌";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 670);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLixo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "FrmMarcas";
            this.Text = "FrmMarcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLixo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}