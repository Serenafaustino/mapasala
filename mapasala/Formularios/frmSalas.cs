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
    public partial class frmSalas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add(1, "sala 02", 22, true, 24, true);
            dados.Rows.Add(2, "sala 22", 1, false, 42, false);

            dtGridSalas.DataSource = dados;

        }

        private void frmSalas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarSala1_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = new SalasEntidade();
            sala.Id = Convert.ToInt32(numIdSalas.Value);
            sala.Nome = txtNomesala1.Text;
            sala.IsLab = chkIsLabSala1.Checked;
            sala.NumeroCadeiras = Convert.ToInt32(numCadeiraSala1.Value);
            sala.NumeroComputadores = Convert.ToInt32(numCompsala1.Value);
            sala.Disponivel = chkDisponivSala1.Checked;

            dados.Rows.Add(sala.Linha());
            LimparCampos();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNomesala1.Text = "";
            numIdSalas.Value = 0;
            numCompsala1.Value = 0;
            numCadeiraSala1.Value = 0;
            chkDisponivSala1.Checked = false;
            chkIsLabSala1.Checked = false;
        }

        private void dtGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;

            numIdSalas.Value = Convert.ToUInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value);
            txtNomesala1.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            numCompsala1.Value = Convert.ToUInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value);
            chkIsLabSala1.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value);
            numCadeiraSala1.Value = Convert.ToUInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value);
            chkDisponivSala1.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[5].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = dtGridSalas.Rows[LinhaSelecionada];
            a.Cells[0].Value = numIdSalas.Value;
            a.Cells[1].Value = txtNomesala1.Text;
            a.Cells[2].Value = numCompsala1.Value;
            a.Cells[3].Value = chkIsLabSala1.Checked;
            a.Cells[4].Value = numCadeiraSala1.Value;
            a.Cells[5].Value = chkDisponivSala1.Checked;

        }
    }
}
