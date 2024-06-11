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
        BindingSource dados; 
        public frmSalas()
        {
            InitializeComponent();
            dados = new BindingSource();
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

            dados.Add(sala);
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
    }
}
