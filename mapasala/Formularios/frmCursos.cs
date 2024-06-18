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
    public partial class frmCursos : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmCursos()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(cursoEntidades).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "desenvolvimento de sistemas", "manha", true);
            dados.Rows.Add(2, "administraçao", "noite", true);
            dados.Rows.Add(3, "serviços juridicos", "tarde", false);
            dados.Rows.Add(4, " infonet", "tarde", true);

            DtGridCursos.DataSource = dados;
        }

        private void btnSalvarCursos_Click(object sender, EventArgs e)
        {
            cursoEntidades curso = new cursoEntidades();
            curso.Id = Convert.ToInt32(numIdCursos.Value);
            curso.Nome = txtNomeCursos.Text;
            curso.Turno = txtTurnoCursos.Text;
            curso.Ativo = chkAtivoCursos.Checked;
         

            dados.Rows.Add(curso.Linha());
            LimparCampos();
        }
            
        private void bntLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNomeCursos.Text = "";
            txtTurnoCursos.Text = "";
            numIdCursos.Value = 0;
            chkAtivoCursos.Checked = false;
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            DtGridCursos.Rows.RemoveAt(LinhaSelecionada);
        }


        private void DtGridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numIdCursos.Value = Convert.ToUInt32(DtGridCursos.Rows[LinhaSelecionada].Cells[0].Value);
            txtNomeCursos.Text = DtGridCursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtTurnoCursos.Text = DtGridCursos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            chkAtivoCursos.Checked = Convert.ToBoolean(DtGridCursos.Rows[LinhaSelecionada].Cells[3].Value);
        }

        private void btnEditarCursos_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = DtGridCursos.Rows[LinhaSelecionada];
            a.Cells[0].Value = numIdCursos.Value;
            a.Cells[1].Value = txtNomeCursos.Text;
            a.Cells[2].Value = txtTurnoCursos.Text;
            a.Cells[3].Value = chkAtivoCursos.Checked;
        }

        private void btnExcluirCurso_Click_1(object sender, EventArgs e)
        {
            DtGridCursos.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
