using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo6._forms
{
    public partial class frmEjercicio : Form
    {
        public frmEjercicio()
        {
            InitializeComponent();
           
           
        }

    

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
          
                TextBox autoText = e.Control as TextBox;
                autoText.KeyPress += new KeyPressEventHandler(ValidacionX);
                     
        }

        private void ValidacionX(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() =="\b" )
                return;
            else
            {
                e.KeyChar = char.Parse("X");
            }
            

        }
    }
}

