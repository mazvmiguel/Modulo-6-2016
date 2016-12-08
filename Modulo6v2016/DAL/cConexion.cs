using System;
using System.Data;
using System.Data.SqlClient;

namespace Modulo6
{
	/// <summary>
	/// Descripción breve de Class_conection.
	/// </summary>
	public class cConexion
	{
        string sConexionString = string.Empty;
		public SqlConnection con = new SqlConnection();
        
        public cConexion(string _sConexionString)
		{			
            sConexionString = _sConexionString;            
		}

		private void conect()
		{            
            con.ConnectionString = sConexionString;            
            con.Open();            			
		}

		private void disconect()
		{
			con.Close();
		}

		public DataTable Consultar(SqlCommand com)
		{
			com.Connection = con;
			SqlDataAdapter da = new SqlDataAdapter(com);            
			conect();            
			DataSet ds = new DataSet();
			da.Fill(ds);
			disconect();
			return ds.Tables[0];
		}

		public DataSet ConsultarTablas(SqlCommand com)
		{
			com.Connection = con;
			SqlDataAdapter da = new SqlDataAdapter(com);
			conect();
			DataSet ds = new DataSet();
			da.Fill(ds);
			disconect();
			return ds;
		}

		public DataTable ConsultarPag(SqlCommand com, int n, int RCount, string tabla)
		{
			com.Connection = con;
			SqlDataAdapter da = new SqlDataAdapter(com);
			conect();
			DataSet ds = new DataSet();
			da.Fill(ds, (n-1)*RCount, RCount, tabla);
			disconect();
			return ds.Tables[0];
		}

		public void Insert(SqlCommand com)
		{
			conect();
			com.Connection = con;
			com.ExecuteNonQuery();
			disconect();
		}

        public int EjecutarComando(SqlCommand com)
        {
            int iError;

            conect();
            com.Connection = con;
            iError = com.ExecuteNonQuery();
            disconect();

            return iError;
        }
	}
}
