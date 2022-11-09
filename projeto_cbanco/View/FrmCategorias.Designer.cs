namespace projeto_cbanco.View
{
    partial class FrmCategorias
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
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnLixo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(290, 25);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(287, 20);
            this.txtCategoria.TabIndex = 59;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(203, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 27);
            this.label.TabIndex = 58;
            this.label.Text = "Categoria:";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(82, 25);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(62, 20);
            this.textID.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 27);
            this.label6.TabIndex = 56;
            this.label6.Text = "Código:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(478, 157);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(55, 34);
            this.btnPesquisa.TabIndex = 55;
            this.btnPesquisa.Text = "🔎";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(125, 169);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(321, 20);
            this.txtPesquisa.TabIndex = 54;
            this.txtPesquisa.Text = "Cidade que deseja pesquisar... ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 27);
            this.label4.TabIndex = 53;
            this.label4.Text = "Pesquisa:";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToOrderColumns = true;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(43, 217);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(523, 386);
            this.dgvCategorias.TabIndex = 52;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // btnLixo
            // 
            this.btnLixo.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLixo.Location = new System.Drawing.Point(414, 94);
            this.btnLixo.Name = "btnLixo";
            this.btnLixo.Size = new System.Drawing.Size(119, 47);
            this.btnLixo.TabIndex = 51;
            this.btnLixo.Text = "🗑️ Excluir";
            this.btnLixo.UseVisualStyleBackColor = true;
            this.btnLixo.Click += new System.EventHandler(this.btnLixo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(437, 609);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 47);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "↩️ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(227, 94);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(119, 47);
            this.btnAlterar.TabIndex = 49;
            this.btnAlterar.Text = "🔄 Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(43, 94);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(114, 47);
            this.btnIncluir.TabIndex = 48;
            this.btnIncluir.Text = "➕ Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(645, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 38);
            this.button1.TabIndex = 60;
            this.button1.Text = " ❌";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 662);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnLixo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnLixo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button button1;
    }
}