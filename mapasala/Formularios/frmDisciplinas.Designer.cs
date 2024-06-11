
namespace mapasala.Formularios
{
    partial class frmDisciplinas
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
            this.btnSalvarDisciplina = new System.Windows.Forms.Button();
            this.chkAtivoDisciplina = new System.Windows.Forms.CheckBox();
            this.lblIdDisciplinas = new System.Windows.Forms.Label();
            this.lblNomeDisciplinas = new System.Windows.Forms.Label();
            this.lblSiglaDisciplinas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.txtSiglaDisciplinas = new System.Windows.Forms.TextBox();
            this.numIdDisciplinas = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridDisciplina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarDisciplina
            // 
            this.btnSalvarDisciplina.Location = new System.Drawing.Point(329, 32);
            this.btnSalvarDisciplina.Name = "btnSalvarDisciplina";
            this.btnSalvarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarDisciplina.TabIndex = 0;
            this.btnSalvarDisciplina.Text = "Salvar";
            this.btnSalvarDisciplina.UseVisualStyleBackColor = true;
            this.btnSalvarDisciplina.Click += new System.EventHandler(this.btnSalvarDisciplina_Click);
            // 
            // chkAtivoDisciplina
            // 
            this.chkAtivoDisciplina.AutoSize = true;
            this.chkAtivoDisciplina.Location = new System.Drawing.Point(255, 36);
            this.chkAtivoDisciplina.Name = "chkAtivoDisciplina";
            this.chkAtivoDisciplina.Size = new System.Drawing.Size(50, 17);
            this.chkAtivoDisciplina.TabIndex = 1;
            this.chkAtivoDisciplina.Text = "Ativo";
            this.chkAtivoDisciplina.UseVisualStyleBackColor = true;
            // 
            // lblIdDisciplinas
            // 
            this.lblIdDisciplinas.AutoSize = true;
            this.lblIdDisciplinas.Location = new System.Drawing.Point(27, 9);
            this.lblIdDisciplinas.Name = "lblIdDisciplinas";
            this.lblIdDisciplinas.Size = new System.Drawing.Size(16, 13);
            this.lblIdDisciplinas.TabIndex = 2;
            this.lblIdDisciplinas.Text = "Id";
            // 
            // lblNomeDisciplinas
            // 
            this.lblNomeDisciplinas.AutoSize = true;
            this.lblNomeDisciplinas.Location = new System.Drawing.Point(98, 9);
            this.lblNomeDisciplinas.Name = "lblNomeDisciplinas";
            this.lblNomeDisciplinas.Size = new System.Drawing.Size(35, 13);
            this.lblNomeDisciplinas.TabIndex = 3;
            this.lblNomeDisciplinas.Text = "Nome";
            // 
            // lblSiglaDisciplinas
            // 
            this.lblSiglaDisciplinas.AutoSize = true;
            this.lblSiglaDisciplinas.Location = new System.Drawing.Point(186, 9);
            this.lblSiglaDisciplinas.Name = "lblSiglaDisciplinas";
            this.lblSiglaDisciplinas.Size = new System.Drawing.Size(30, 13);
            this.lblSiglaDisciplinas.TabIndex = 4;
            this.lblSiglaDisciplinas.Text = "Sigla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // DtGridDisciplina
            // 
            this.DtGridDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGridDisciplina.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridDisciplina.Location = new System.Drawing.Point(15, 81);
            this.DtGridDisciplina.Name = "DtGridDisciplina";
            this.DtGridDisciplina.Size = new System.Drawing.Size(574, 236);
            this.DtGridDisciplina.TabIndex = 6;
            this.DtGridDisciplina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridDisciplina_CellContentClick);
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.Location = new System.Drawing.Point(84, 35);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(65, 20);
            this.txtNomeDisciplina.TabIndex = 8;
            // 
            // txtSiglaDisciplinas
            // 
            this.txtSiglaDisciplinas.Location = new System.Drawing.Point(171, 35);
            this.txtSiglaDisciplinas.Name = "txtSiglaDisciplinas";
            this.txtSiglaDisciplinas.Size = new System.Drawing.Size(55, 20);
            this.txtSiglaDisciplinas.TabIndex = 9;
            // 
            // numIdDisciplinas
            // 
            this.numIdDisciplinas.Location = new System.Drawing.Point(15, 33);
            this.numIdDisciplinas.Name = "numIdDisciplinas";
            this.numIdDisciplinas.Size = new System.Drawing.Size(48, 20);
            this.numIdDisciplinas.TabIndex = 10;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(421, 32);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(514, 32);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.numIdDisciplinas);
            this.Controls.Add(this.txtSiglaDisciplinas);
            this.Controls.Add(this.txtNomeDisciplina);
            this.Controls.Add(this.DtGridDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSiglaDisciplinas);
            this.Controls.Add(this.lblNomeDisciplinas);
            this.Controls.Add(this.lblIdDisciplinas);
            this.Controls.Add(this.chkAtivoDisciplina);
            this.Controls.Add(this.btnSalvarDisciplina);
            this.Name = "frmDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.DtGridDisciplina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarDisciplina;
        private System.Windows.Forms.CheckBox chkAtivoDisciplina;
        private System.Windows.Forms.Label lblIdDisciplinas;
        private System.Windows.Forms.Label lblNomeDisciplinas;
        private System.Windows.Forms.Label lblSiglaDisciplinas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DtGridDisciplina;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.TextBox txtSiglaDisciplinas;
        private System.Windows.Forms.NumericUpDown numIdDisciplinas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
    }
}