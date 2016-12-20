using System;
using System.Collections.Generic;
using System.Text;

//SICH 03DIC2016: 
using System.Data;
using System.Data.SqlClient;

namespace Modulo6.BUL
{
    public class clsClave
    {
#region ATRIBUTOS
        private string sClaveId;
        private string sMateriaId;
        private Int16 iPreguntasCantidad;
        private Int16 iDistractoresCantidad;
        private string sSolRConcentrado;
        private string sPonderacion;
#endregion
        
#region PROPIEDADES
        public string ClaveId {
            get { return sClaveId; }
            set { sClaveId = value; }
        }

        public string MateriaId
        {
            get { return sMateriaId; }
            set { sMateriaId = value; }
        }

        public Int16 PreguntasCantidad
        {
            get { return iPreguntasCantidad; }
            set { iPreguntasCantidad = value; }
        }

        public Int16 DistractoresCantidad
        {
            get { return iDistractoresCantidad; }
            set { iDistractoresCantidad = value; }
        }

        public string SolRConcentrado
        {
            get { return sSolRConcentrado; }
            set { sSolRConcentrado = value; }
        }

        public string Ponderacion
        {
            get { return sPonderacion; }
            set { sPonderacion = value; }
        }
        #endregion

        public clsClave()
        {
            sClaveId = string.Empty;
            sMateriaId = string.Empty;
            iPreguntasCantidad = 0;
            iDistractoresCantidad = 0;
            sSolRConcentrado = string.Empty;
            sPonderacion = string.Empty;
        }

        public clsClave(string sClaveId)
        {
            DataTable dt = new DataTable();
            cConexion oConn = new cConexion(clsFuncionesComunes.Get_ConfigValue("ConnectionString"));

            SqlCommand oCmdDatos = new SqlCommand("proctClaveSelect");
            oCmdDatos.Parameters.Add("@ClaveId", SqlDbType.VarChar).Value = sClaveId;
            oCmdDatos.CommandType = CommandType.StoredProcedure;

            dt = oConn.Consultar(oCmdDatos);                        
            asignarDatosObjeto(dt);            
        }

        public bool actualizarClave() {
            cConexion oConn = new cConexion(clsFuncionesComunes.Get_ConfigValue("ConnectionString"));

            SqlCommand oCmd = new SqlCommand("proctClaveUpdate");
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.CommandTimeout = 3600;
 
            oCmd.Parameters.Add("@ClaveId", SqlDbType.VarChar).Value = sClaveId;
            oCmd.Parameters.Add("@MateriaId", SqlDbType.VarChar).Value = sMateriaId; 
            oCmd.Parameters.Add("@PreguntasCantidad", SqlDbType.Int).Value = iPreguntasCantidad;
            oCmd.Parameters.Add("@DistractoresCantidad", SqlDbType.Int).Value = iDistractoresCantidad;
            oCmd.Parameters.Add("@Ponderacion", SqlDbType.VarChar).Value = sPonderacion;
            oCmd.Parameters.Add("@SolRConcentrado", SqlDbType.VarChar).Value = sSolRConcentrado;
            
            try
            {                                                    
                oConn.Insert(oCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool eliminarClave()
        {
            cConexion oConn = new cConexion(clsFuncionesComunes.Get_ConfigValue("ConnectionString"));

            SqlCommand oCmd = new SqlCommand("proctClaveDelete");
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.CommandTimeout = 3600;

            oCmd.Parameters.Add("@ClaveId", SqlDbType.VarChar).Value = sClaveId;            

            try
            {
                oConn.Insert(oCmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool asignarDatosObjeto(DataTable oDT)
        {
            if (oDT.Rows.Count > 0)
            {
                sClaveId = oDT.Rows[0]["ClaveId"].ToString();
                sMateriaId = oDT.Rows[0]["MateriaId"].ToString();
                iPreguntasCantidad = Convert.ToInt16(oDT.Rows[0]["PreguntasCantidad"]);
                iDistractoresCantidad= Convert.ToInt16(oDT.Rows[0]["DistractoresCantidad"]);
                sSolRConcentrado = oDT.Rows[0]["SolRConcentrado"].ToString();
                sPonderacion = oDT.Rows[0]["Ponderacion"].ToString(); ;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
