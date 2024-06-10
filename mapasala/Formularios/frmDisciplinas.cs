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
        BindingSource dados;
        public frmDisciplinas()
        {
            InitializeComponent();
            dados = new BindingSource();
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
        }

        private void DtGridDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
