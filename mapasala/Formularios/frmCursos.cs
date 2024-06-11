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
        BindingSource dados;
        public frmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            DtGridCursos.DataSource = dados;
        }

        private void btnSalvarCursos_Click(object sender, EventArgs e)
        {
            cursoEntidades curso = new cursoEntidades();
            curso.Id = Convert.ToInt32(numIdCursos.Value);
            curso.Nome = txtNomeCursos.Text;
            curso.Turno = txtTurnoCursos.Text;
            curso.Ativo = chkAtivoCursos.Checked;
         

            dados.Add(curso);
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
    }
}
