using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Modulo6._forms
{
    public partial class frmQMateria : Form
    {
        public frmQMateria()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmMateria frm_Materia= new frmMateria();

            frm_Materia.str = "Agregando";
            this.Close();
            frm_Materia.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            frmMateria frm_Materia = new frmMateria();

            frm_Materia.str = "Modificando";
            this.Close();
            frm_Materia.Show();
        }
    }
}