
namespace mapasala.Formularios
{
    partial class frmCursos
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
            this.lblIdCursos = new System.Windows.Forms.Label();
            this.lblNomeCursos = new System.Windows.Forms.Label();
            this.lblTurnoCursos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAtivoCursos = new System.Windows.Forms.CheckBox();
            this.btnSalvarCursos = new System.Windows.Forms.Button();
            this.txtNomeCursos = new System.Windows.Forms.TextBox();
            this.txtTurnoCursos = new System.Windows.Forms.TextBox();
            this.DtGridCursos = new System.Windows.Forms.DataGridView();
            this.numIdCursos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCursos
            // 
            this.lblIdCursos.AutoSize = true;
            this.lblIdCursos.Location = new System.Drawing.Point(12, 9);
            this.lblIdCursos.Name = "lblIdCursos";
            this.lblIdCursos.Size = new System.Drawing.Size(16, 13);
            this.lblIdCursos.TabIndex = 0;
            this.lblIdCursos.Text = "Id";
            // 
            // lblNomeCursos
            // 
            this.lblNomeCursos.AutoSize = true;
            this.lblNomeCursos.Location = new System.Drawing.Point(86, 9);
            this.lblNomeCursos.Name = "lblNomeCursos";
            this.lblNomeCursos.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCursos.TabIndex = 1;
            this.lblNomeCursos.Text = "Nome";
            // 
            // lblTurnoCursos
            // 
            this.lblTurnoCursos.AutoSize = true;
            this.lblTurnoCursos.Location = new System.Drawing.Point(181, 9);
            this.lblTurnoCursos.Name = "lblTurnoCursos";
            this.lblTurnoCursos.Size = new System.Drawing.Size(35, 13);
            this.lblTurnoCursos.TabIndex = 2;
            this.lblTurnoCursos.Text = "Turno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // chkAtivoCursos
            // 
            this.chkAtivoCursos.AutoSize = true;
            this.chkAtivoCursos.Location = new System.Drawing.Point(248, 30);
            this.chkAtivoCursos.Name = "chkAtivoCursos";
            this.chkAtivoCursos.Size = new System.Drawing.Size(50, 17);
            this.chkAtivoCursos.TabIndex = 4;
            this.chkAtivoCursos.Text = "Ativo";
            this.chkAtivoCursos.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCursos
            // 
            this.btnSalvarCursos.Location = new System.Drawing.Point(327, 25);
            this.btnSalvarCursos.Name = "btnSalvarCursos";
            this.btnSalvarCursos.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCursos.TabIndex = 5;
            this.btnSalvarCursos.Text = "Salvar";
            this.btnSalvarCursos.UseVisualStyleBackColor = true;
            this.btnSalvarCursos.Click += new System.EventHandler(this.btnSalvarCursos_Click);
            // 
            // txtNomeCursos
            // 
            this.txtNomeCursos.Location = new System.Drawing.Point(64, 28);
            this.txtNomeCursos.Name = "txtNomeCursos";
            this.txtNomeCursos.Size = new System.Drawing.Size(77, 20);
            this.txtNomeCursos.TabIndex = 6;
            // 
            // txtTurnoCursos
            // 
            this.txtTurnoCursos.Location = new System.Drawing.Point(165, 29);
            this.txtTurnoCursos.Name = "txtTurnoCursos";
            this.txtTurnoCursos.Size = new System.Drawing.Size(60, 20);
            this.txtTurnoCursos.TabIndex = 7;
            // 
            // DtGridCursos
            // 
            this.DtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridCursos.Location = new System.Drawing.Point(0, 96);
            this.DtGridCursos.Name = "DtGridCursos";
            this.DtGridCursos.Size = new System.Drawing.Size(402, 150);
            this.DtGridCursos.TabIndex = 9;
            this.DtGridCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridCursos_CellContentClick);
            // 
            // numIdCursos
            // 
            this.numIdCursos.Location = new System.Drawing.Point(12, 27);
            this.numIdCursos.Name = "numIdCursos";
            this.numIdCursos.Size = new System.Drawing.Size(42, 20);
            this.numIdCursos.TabIndex = 10;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numIdCursos);
            this.Controls.Add(this.DtGridCursos);
            this.Controls.Add(this.txtTurnoCursos);
            this.Controls.Add(this.txtNomeCursos);
            this.Controls.Add(this.btnSalvarCursos);
            this.Controls.Add(this.chkAtivoCursos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTurnoCursos);
            this.Controls.Add(this.lblNomeCursos);
            this.Controls.Add(this.lblIdCursos);
            this.Name = "frmCursos";
            this.Text = "frmCursos";
            ((System.ComponentModel.ISupportInitialize)(this.DtGridCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCursos;
        private System.Windows.Forms.Label lblNomeCursos;
        private System.Windows.Forms.Label lblTurnoCursos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAtivoCursos;
        private System.Windows.Forms.Button btnSalvarCursos;
        private System.Windows.Forms.TextBox txtNomeCursos;
        private System.Windows.Forms.TextBox txtTurnoCursos;
        private System.Windows.Forms.DataGridView DtGridCursos;
        private System.Windows.Forms.NumericUpDown numIdCursos;
    }
}