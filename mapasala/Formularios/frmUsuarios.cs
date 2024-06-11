using Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapasala.Formularios
{
    public partial class frmUsuarios : Form
    {
        BindingSource dados;
        public frmUsuarios()
        {
            InitializeComponent();
            dados = new BindingSource();
            DtGridUsuarios.DataSource = dados;
        }

        private void btnSalvarUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosEntidade usuario = new UsuariosEntidade();
            usuario.Id = Convert.ToInt32(numIdUsuario.Value);
            usuario.Login = txtLoginUsuario.Text;
            usuario.Senha = txtSenhaUsuario.Text;
            usuario.Nome = txtNomeUsuario.Text;
            usuario.Ativo = chkAtivoUsuario.Checked;

            dados.Add(usuario);
            LimparCampos();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtLoginUsuario.Text = "";
            txtNomeUsuario.Text = "";
            txtSenhaUsuario.Text = "";
            numIdUsuario.Value = 0;
            chkAtivoUsuario.Checked = false;
        }
    }
}
