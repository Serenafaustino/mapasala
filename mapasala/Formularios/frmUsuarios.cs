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
        DataTable dados;
        int LinhaSelecionada;
        public frmUsuarios()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(UsuariosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "serena.silva@gmail.com", "Sefaustino25", "serena", true);
            dados.Rows.Add(2, "luisa.gimenes@gmail.com", "Lugi16", "luisa", true);
            dados.Rows.Add(3, "fernando.graciano@icloud.com", "Fernecoprof", "Fernando", false);

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

            dados.Rows.Add(usuario.Linha());
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

        private void DtGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numIdUsuario.Value = Convert.ToUInt32(DtGridUsuarios.Rows[LinhaSelecionada].Cells[0].Value);
            txtLoginUsuario.Text = DtGridUsuarios.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtSenhaUsuario.Text = DtGridUsuarios.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtNomeUsuario.Text = DtGridUsuarios.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            chkAtivoUsuario.Checked = Convert.ToBoolean(DtGridUsuarios.Rows[LinhaSelecionada].Cells[4].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DtGridUsuarios.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = DtGridUsuarios.Rows[LinhaSelecionada];
            a.Cells[0].Value = numIdUsuario.Value;
            a.Cells[1].Value = txtLoginUsuario.Text;
            a.Cells[2].Value = txtSenhaUsuario.Text;
            a.Cells[3].Value = txtNomeUsuario.Text;
            a.Cells[4].Value = chkAtivoUsuario.Checked;
        }
    }
}
