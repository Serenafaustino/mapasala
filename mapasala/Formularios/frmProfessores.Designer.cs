
namespace mapasala.Formularios
{
    partial class frmProfessores
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtApelidoprof = new System.Windows.Forms.TextBox();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.DtGridProfessores = new System.Windows.Forms.DataGridView();
            this.numIdProf = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdProf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(40, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(142, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(265, 25);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(42, 13);
            this.lblApelido.TabIndex = 2;
            this.lblApelido.Text = "Apelido";
            // 
            // txtApelidoprof
            // 
            this.txtApelidoprof.Location = new System.Drawing.Point(235, 41);
            this.txtApelidoprof.Name = "txtApelidoprof";
            this.txtApelidoprof.Size = new System.Drawing.Size(100, 20);
            this.txtApelidoprof.TabIndex = 4;
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Location = new System.Drawing.Point(100, 42);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(129, 20);
            this.txtNomeProf.TabIndex = 5;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(359, 39);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 6;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // DtGridProfessores
            // 
            this.DtGridProfessores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGridProfessores.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DtGridProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridProfessores.Location = new System.Drawing.Point(26, 113);
            this.DtGridProfessores.Name = "DtGridProfessores";
            this.DtGridProfessores.Size = new System.Drawing.Size(500, 280);
            this.DtGridProfessores.TabIndex = 7;
            // 
            // numIdProf
            // 
            this.numIdProf.Location = new System.Drawing.Point(26, 42);
            this.numIdProf.Name = "numIdProf";
            this.numIdProf.Size = new System.Drawing.Size(68, 20);
            this.numIdProf.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(451, 38);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.numIdProf);
            this.Controls.Add(this.DtGridProfessores);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtNomeProf);
            this.Controls.Add(this.txtApelidoprof);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Name = "frmProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfessores";
            ((System.ComponentModel.ISupportInitialize)(this.DtGridProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtApelidoprof;
        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.DataGridView DtGridProfessores;
        private System.Windows.Forms.NumericUpDown numIdProf;
        private System.Windows.Forms.Button btnLimpar;
    }
}