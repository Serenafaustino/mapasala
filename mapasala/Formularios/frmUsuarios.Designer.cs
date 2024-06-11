
namespace mapasala.Formularios
{
    partial class frmUsuarios
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
            this.numIdUsuario = new System.Windows.Forms.NumericUpDown();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.chkAtivoUsuario = new System.Windows.Forms.CheckBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.DtGridUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSalvarUsuarios = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numIdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // numIdUsuario
            // 
            this.numIdUsuario.Location = new System.Drawing.Point(32, 37);
            this.numIdUsuario.Name = "numIdUsuario";
            this.numIdUsuario.Size = new System.Drawing.Size(80, 20);
            this.numIdUsuario.TabIndex = 0;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(52, 21);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(16, 13);
            this.lblIdUsuario.TabIndex = 1;
            this.lblIdUsuario.Text = "Id";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(173, 21);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Location = new System.Drawing.Point(294, 21);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaUsuario.TabIndex = 3;
            this.lblSenhaUsuario.Text = "Senha";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(421, 21);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNomeUsuario.TabIndex = 4;
            this.lblNomeUsuario.Text = "Nome";
            // 
            // chkAtivoUsuario
            // 
            this.chkAtivoUsuario.AutoSize = true;
            this.chkAtivoUsuario.Location = new System.Drawing.Point(517, 37);
            this.chkAtivoUsuario.Name = "chkAtivoUsuario";
            this.chkAtivoUsuario.Size = new System.Drawing.Size(50, 17);
            this.chkAtivoUsuario.TabIndex = 5;
            this.chkAtivoUsuario.Text = "Ativo";
            this.chkAtivoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAtivoUsuario.UseVisualStyleBackColor = true;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(141, 37);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsuario.TabIndex = 6;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(260, 37);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(107, 20);
            this.txtSenhaUsuario.TabIndex = 7;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(388, 37);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomeUsuario.TabIndex = 8;
            // 
            // DtGridUsuarios
            // 
            this.DtGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGridUsuarios.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DtGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridUsuarios.Location = new System.Drawing.Point(32, 103);
            this.DtGridUsuarios.Name = "DtGridUsuarios";
            this.DtGridUsuarios.Size = new System.Drawing.Size(565, 150);
            this.DtGridUsuarios.TabIndex = 9;
            // 
            // btnSalvarUsuarios
            // 
            this.btnSalvarUsuarios.Location = new System.Drawing.Point(586, 33);
            this.btnSalvarUsuarios.Name = "btnSalvarUsuarios";
            this.btnSalvarUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarUsuarios.TabIndex = 10;
            this.btnSalvarUsuarios.Text = "salvar";
            this.btnSalvarUsuarios.UseVisualStyleBackColor = true;
            this.btnSalvarUsuarios.Click += new System.EventHandler(this.btnSalvarUsuarios_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(676, 31);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnSalvarUsuarios);
            this.Controls.Add(this.DtGridUsuarios);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.chkAtivoUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.numIdUsuario);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.numIdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numIdUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.CheckBox chkAtivoUsuario;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.DataGridView DtGridUsuarios;
        private System.Windows.Forms.Button btnSalvarUsuarios;
        private System.Windows.Forms.Button btnlimpar;
    }
}