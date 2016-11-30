using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Modulo6._forms;

namespace Modulo6.DAL
{
  public   class cls_myFunctions
    {
        string sMessageBox = "[Modulo 6 Ver 1.0]";

        public void setMessageBox(string sMessage, int iWhich)
        {
            switch (iWhich)
            {
                case 1:
                    MessageBox.Show(sMessage, sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show(sMessage, sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 3:
                    MessageBox.Show(sMessage, sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void setCreateError(string sErrorMessage)
        {
            try
            {
                MessageBox.Show(sErrorMessage, sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargaMasiva(string Entidad )
        {
            frmImportacion frmImportacion = new frmImportacion();
            frmImportacion.EntidadACargar = Entidad;
            frmImportacion.ShowDialog();
        }
        

    }
}
