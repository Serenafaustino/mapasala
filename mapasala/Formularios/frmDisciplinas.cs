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
    public partial class frmDisciplinas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmDisciplinas()
        {
            InitializeComponent();
            dados = new DataTable();
            DtGridDisciplina.DataSource = dados;
        }

        private void btnSalvarDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinasEntidades disciplina = new DisciplinasEntidades();
            disciplina.Id = Convert.ToInt32(numIdDisciplinas.Value);
            disciplina.Nome = txtNomeDisciplina.Text;
            disciplina.Sigla = txtSiglaDisciplinas.Text;
            disciplina.Ativo = chkAtivoDisciplina.Checked;
        

            dados.Add(disciplina);
            LimparCampos();
        }

        private void DtGridDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LimparCampos()
        {
            txtNomeDisciplina.Text = "";
            txtSiglaDisciplinas.Text = "";
            numIdDisciplinas.Value = 0;
            chkAtivoDisciplina.Checked = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
        }
    }
    }
