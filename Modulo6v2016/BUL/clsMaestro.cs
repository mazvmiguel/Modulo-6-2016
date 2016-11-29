using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Modulo6.BUL
{
    class clsMaestro
    {
        public string MaestroId;
        public string Maestro;
        

        OleDbCommand comando = new OleDbCommand();
        SqlCommand comandosql = new SqlCommand();

        DAL.clsODBC clsCon = new Modulo6.DAL.clsODBC();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        public bool Validar()
        {
            if (MaestroId.ToString().Length <= 0)
            {

                clsmyFunction.setMessageBox("La longitud del Maestro ID no es correcta", 2);
                return false;
            }

            if (Maestro.ToString().Length <= 0)
            {

                clsmyFunction.setMessageBox("La longitud del nombre del Maestro no es correcta", 2);
                return false;
            }

            return true;


        } //validar



        public bool Guardar()
        {
            if (Validar() == true)
            {
                try
                {

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    comando.CommandText = "proctMaestroUpdate";
                    comando.Parameters.Add("@MaestroId", OleDbType.VarChar);
                    comando.Parameters.Add("@Maestro", OleDbType.VarChar);
                    comando.Parameters["@MaestroId"].Value = this.MaestroId;
                    comando.Parameters["@Maestro"].Value = this.Maestro;
                    

                    clsCon.cmdOpen(comando);
                    clsCon.cmdClose(comando);
                    clsmyFunction.setMessageBox("Datos guardados exitosamente", 1);

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }

            }


            return true;


        } //guardar

        public bool Borrar()
        {

            DialogResult ret;
            ret = MessageBox.Show("Esta seguro de borrar registro!", "Borrar".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (Validar() == true && ret == DialogResult.Yes)
            {
                try
                {

                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "proctMaestroDelete";
                    comando.Parameters.Add("@MaestroId", OleDbType.VarChar);
                    comando.Parameters["@MaestroId"].Value = this.MaestroId;
                    clsCon.cmdOpen(comando);
                    clsCon.cmdClose(comando);
                    clsmyFunction.setMessageBox("Datos borrados exitosamente", 1);

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }

            }


            return true;


        } //

        public void CargaMasiva(DataSet ds)
        {
            //la logica es subir la tabla 0 del dataset como objeto Table definidi por el usuario
            //hacemos una clonacion para cambiar al tipo de datos
            try
            {

                comandosql.CommandType = CommandType.StoredProcedure;
                comandosql.CommandText = "proctMaestroBulkLoad";

                DataTable table = new DataTable();
                table = ds.Tables[0];

                /*ordenando las columnas*/
                table.Columns["MaestroId"].SetOrdinal(0);
                table.Columns["MaestroNombre"].SetOrdinal(1);

                //para cambiar el tipo de dato a cada columna, hay que clonar la tabla y luego importar
                DataTable dtCloned = table.Clone();

                dtCloned.Columns[0].DataType = typeof(string);
                dtCloned.Columns[1].DataType = typeof(string);
                
                foreach (DataRow row in table.Rows)
                {
                        dtCloned.ImportRow(row);

                }
                SqlParameter parameter;
                parameter = comandosql.Parameters.AddWithValue("@zMaestro", dtCloned);
                parameter.SqlDbType = SqlDbType.Structured;
                parameter.TypeName = "dbo.zMaestro";

                clsCon.cmdSQLOpen(comandosql);
                clsCon.cmdSQLClose(comandosql);

                clsmyFunction.setMessageBox("Datos guardados exitosamente", 1);

            }
            catch (Exception exp)
            {
                clsmyFunction.setCreateError(exp.Message);

            }
        }


    }
}
