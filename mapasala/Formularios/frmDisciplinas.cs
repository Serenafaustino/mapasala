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
            foreach (var atributos in typeof(DisciplinasEntidades).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "matematica", "math", true);
            dados.Rows.Add(2, "português", "port", true);
            dados.Rows.Add(3, "fisica", "fis", false);
            dados.Rows.Add(4, "desenvolvimento de sistemas", "DS",true);

            DtGridDisciplina.DataSource = dados;
        }

        private void btnSalvarDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinasEntidades disciplina = new DisciplinasEntidades();
            disciplina.Id = Convert.ToInt32(numIdDisciplinas.Value);
            disciplina.Nome = txtNomeDisciplina.Text;
            disciplina.Sigla = txtSiglaDisciplinas.Text;
            disciplina.Ativo = chkAtivoDisciplina.Checked;


            dados.Rows.Add(disciplina.Linha());
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

        private void DtGridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numIdDisciplinas.Value = Convert.ToUInt32( DtGridDisciplina.Rows[LinhaSelecionada].Cells[0].Value);
            txtNomeDisciplina.Text = DtGridDisciplina.Rows[LinhaSelecionada].Cells[1].Value.ToString(); 
            txtSiglaDisciplinas.Text = DtGridDisciplina.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            chkAtivoDisciplina.Checked = Convert.ToBoolean(DtGridDisciplina.Rows[LinhaSelecionada].Cells[3].Value);
        }

        private void btnEditarDisciplina_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = DtGridDisciplina.Rows[LinhaSelecionada];
            a.Cells[0].Value = numIdDisciplinas.Value;
            a.Cells[1].Value = txtNomeDisciplina.Text;
            a.Cells[2].Value = txtSiglaDisciplinas.Text;
            a.Cells[3].Value = chkAtivoDisciplina.Checked; 


        }
    }
    }
