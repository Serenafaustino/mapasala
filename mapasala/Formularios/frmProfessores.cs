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
    public partial class frmProfessores : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmProfessores()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add(1, "fernando", "ferneco");
            dados.Rows.Add(2, "Alexandre", "Galvani");
            dados.Rows.Add(3, "carol", "carolinda");

            DtGridProfessores.DataSource = dados;
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade Professor = new ProfessoresEntidade();
            Professor.Id = Convert.ToInt32(numIdProf.Value);
            Professor.Nome = txtNomeProf.Text;
            Professor.Apelido = txtApelidoprof.Text;

            dados.Rows.Add(Professor.Linha());
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void LimparCampos()
        {
            txtApelidoprof.Text = "";
            txtNomeProf.Text = "";
            numIdProf.Value = 0;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DtGridProfessores.Rows.RemoveAt(LinhaSelecionada);
        }

        private void DtGridProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numIdProf.Value = Convert.ToInt32(DtGridProfessores.Rows[LinhaSelecionada].Cells[0].Value);
            txtNomeProf.Text = DtGridProfessores.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtApelidoprof.Text = DtGridProfessores.Rows[LinhaSelecionada].Cells[1].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = DtGridProfessores.Rows[LinhaSelecionada];
            a.Cells[0].Value = numIdProf.Value;
            a.Cells[1].Value = txtNomeProf.Text;
            a.Cells[2].Value = txtApelidoprof.Text;
        }
    }
}
