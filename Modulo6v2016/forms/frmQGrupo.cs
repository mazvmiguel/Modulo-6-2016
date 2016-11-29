using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Modulo6._forms
{
    public partial class frmQGrupo : Form
    {
        public frmQGrupo()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmGrupo frm_Grupo = new frmGrupo();


            frm_Grupo.str = "Modificando";
            this.Close();
            frm_Grupo.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmGrupo frm_Grupo = new frmGrupo();


            frm_Grupo.str = "Agregando";
            this.Close();
            frm_Grupo.Show();
        }
    }
}