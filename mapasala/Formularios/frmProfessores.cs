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
        BindingSource dados;
        public frmProfessores()
        {
            InitializeComponent();
            dados = new BindingSource();
            DtGridProfessores.DataSource = dados;
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade Professor = new ProfessoresEntidade();
            Professor.Id = Convert.ToInt32(txtId.Text);
            Professor.Nome = txtNomeProf.Text;
            Professor.Apelido = txtApelidoprof.Text;

            dados.Add(Professor);
        }
    }
}
