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
    BindingSource dados;
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            DtGridCursos.DataSource = dados;
        }

        private void btnSalvarCursos_Click(object sender, EventArgs e)
        {
            CursosEntidade curso = new CursosEntidade();
            curso.Id = Convert.ToInt32(txtIdSala1.Text);
            curso.Nome = txtNomeCursos.Text;
            curso.Ativo = chkAtivoCursos.Checked;
         

            dados.Add(curso);
        }
    }
}
