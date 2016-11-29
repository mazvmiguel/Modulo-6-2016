using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Modulo6._forms
{
    public partial class frmQMaestro : Form
    {
        public frmQMaestro()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmMaestro frm_Mas = new frmMaestro();


            frm_Mas.str = "Agregando";
            this.Close();
            frm_Mas.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmMaestro frm_Mas = new frmMaestro();


            frm_Mas.str = "Modificando";
            this.Close();
            frm_Mas.Show();
        }
    }
}