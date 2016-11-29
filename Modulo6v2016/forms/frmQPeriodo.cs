using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Modulo6._forms
{
    public partial class frmQPeriodo : Form
    {
        public frmQPeriodo()
        {
            InitializeComponent();
        }

        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmPeriodo frm_Periodo= new frmPeriodo();


            frm_Periodo.str="Agregando";
            this.Close();        
            frm_Periodo.Show();

        }
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmPeriodo frm_Periodo = new frmPeriodo();
            frm_Periodo.str="Modificando";
            this.Close();
            frm_Periodo.Show(); 
        }
    }
}