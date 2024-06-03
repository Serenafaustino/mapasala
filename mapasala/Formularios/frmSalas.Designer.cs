
namespace mapasala.Formularios
{
    partial class frmSalas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomesala1 = new System.Windows.Forms.TextBox();
            this.txtIdSala1 = new System.Windows.Forms.TextBox();
            this.chkIsLabSala1 = new System.Windows.Forms.CheckBox();
            this.chkDisponivSala1 = new System.Windows.Forms.CheckBox();
            this.btnSalvarSala1 = new System.Windows.Forms.Button();
            this.numCompsala1 = new System.Windows.Forms.NumericUpDown();
            this.numCadeiraSala1 = new System.Windows.Forms.NumericUpDown();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numCompsala1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiraSala1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de computadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de cadeiras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id";
            // 
            // txtNomesala1
            // 
            this.txtNomesala1.Location = new System.Drawing.Point(87, 35);
            this.txtNomesala1.Name = "txtNomesala1";
            this.txtNomesala1.Size = new System.Drawing.Size(100, 20);
            this.txtNomesala1.TabIndex = 4;
            // 
            // txtIdSala1
            // 
            this.txtIdSala1.Location = new System.Drawing.Point(38, 35);
            this.txtIdSala1.Name = "txtIdSala1";
            this.txtIdSala1.Size = new System.Drawing.Size(35, 20);
            this.txtIdSala1.TabIndex = 7;
            // 
            // chkIsLabSala1
            // 
            this.chkIsLabSala1.AutoSize = true;
            this.chkIsLabSala1.Location = new System.Drawing.Point(457, 35);
            this.chkIsLabSala1.Name = "chkIsLabSala1";
            this.chkIsLabSala1.Size = new System.Drawing.Size(85, 17);
            this.chkIsLabSala1.TabIndex = 8;
            this.chkIsLabSala1.Text = "É laboratorio";
            this.chkIsLabSala1.UseVisualStyleBackColor = true;
            // 
            // chkDisponivSala1
            // 
            this.chkDisponivSala1.AutoSize = true;
            this.chkDisponivSala1.Location = new System.Drawing.Point(548, 34);
            this.chkDisponivSala1.Name = "chkDisponivSala1";
            this.chkDisponivSala1.Size = new System.Drawing.Size(75, 17);
            this.chkDisponivSala1.TabIndex = 9;
            this.chkDisponivSala1.Text = "Disponivel";
            this.chkDisponivSala1.UseVisualStyleBackColor = true;
            // 
            // btnSalvarSala1
            // 
            this.btnSalvarSala1.Location = new System.Drawing.Point(629, 32);
            this.btnSalvarSala1.Name = "btnSalvarSala1";
            this.btnSalvarSala1.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarSala1.TabIndex = 10;
            this.btnSalvarSala1.Text = "Salvar";
            this.btnSalvarSala1.UseVisualStyleBackColor = true;
            this.btnSalvarSala1.Click += new System.EventHandler(this.btnSalvarSala1_Click);
            // 
            // numCompsala1
            // 
            this.numCompsala1.Location = new System.Drawing.Point(214, 34);
            this.numCompsala1.Name = "numCompsala1";
            this.numCompsala1.Size = new System.Drawing.Size(81, 20);
            this.numCompsala1.TabIndex = 11;
            // 
            // numCadeiraSala1
            // 
            this.numCadeiraSala1.Location = new System.Drawing.Point(336, 35);
            this.numCadeiraSala1.Name = "numCadeiraSala1";
            this.numCadeiraSala1.Size = new System.Drawing.Size(87, 20);
            this.numCadeiraSala1.TabIndex = 12;
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(38, 73);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.Size = new System.Drawing.Size(727, 329);
            this.dtGridSalas.TabIndex = 13;
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.numCadeiraSala1);
            this.Controls.Add(this.numCompsala1);
            this.Controls.Add(this.btnSalvarSala1);
            this.Controls.Add(this.chkDisponivSala1);
            this.Controls.Add(this.chkIsLabSala1);
            this.Controls.Add(this.txtIdSala1);
            this.Controls.Add(this.txtNomesala1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalas";
            this.Load += new System.EventHandler(this.frmSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCompsala1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiraSala1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomesala1;
        private System.Windows.Forms.TextBox txtIdSala1;
        private System.Windows.Forms.CheckBox chkIsLabSala1;
        private System.Windows.Forms.CheckBox chkDisponivSala1;
        private System.Windows.Forms.Button btnSalvarSala1;
        private System.Windows.Forms.NumericUpDown numCompsala1;
        private System.Windows.Forms.NumericUpDown numCadeiraSala1;
        private System.Windows.Forms.DataGridView dtGridSalas;
    }
}