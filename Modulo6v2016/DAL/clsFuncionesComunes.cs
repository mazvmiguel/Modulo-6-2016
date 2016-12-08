using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.OleDb;

//SICH:
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Modulo6
{
    public static class clsFuncionesComunes
    {
        public static string Get_ConfigValue(string Name)
        {
            return ConfigurationManager.AppSettings[Name] != null ? ConfigurationManager.AppSettings[Name].ToString() : string.Empty;
        }

        public static bool CargarDropDownList(ref ComboBox oDDL, string sQuery, string sValue, string sDisplay)
        {
            bool bResultado;
            cConexion oConn = new cConexion(Get_ConfigValue("ConnectionString"));            
            SqlCommand oCmd = new SqlCommand(sQuery);
            oCmd.CommandType = CommandType.Text;

            try
            {
                DataTable oDTDatos = oConn.Consultar(oCmd);

                DataRow oDR = oDTDatos.NewRow();
                oDR[sValue] = 0; //SICH 28ENE2016: se cambia de -1 de acuerdo al requerimiento de AXTEL
                oDR[sDisplay] = "Seleccione una opción";
                oDTDatos.Rows.InsertAt(oDR, 0);

                oDDL.ValueMember = sValue;
                oDDL.DisplayMember = sDisplay;
                oDDL.DataSource = oDTDatos;
                bResultado = true;
            }
            catch (Exception ex)
            {
                bResultado = false;
            }
            return bResultado;
        }

        public static void Cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidarNumero(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        public static bool ValidarNumero(char cCaracter)
        {
            if (!(char.IsNumber(cCaracter)) && (cCaracter != (char)Keys.Back) && (cCaracter != '.'))
            {
                return false;
            }
            return true;
        }

        public static string fnMapRespuesta(int iOpcion) {
            if (iOpcion<=0 && iOpcion > Convert.ToInt16(clsFuncionesComunes.Get_ConfigValue("MAX_NUM_OPCIONES")))
            {return "@";}            

            return Convert.ToString(Convert.ToChar(65 + iOpcion -1)).Trim();
        }

        public static int fnRevMapRespuesta(char cOpcion) {
            return (Convert.ToInt16(cOpcion) - 65 + 1);
        }
    }
}
