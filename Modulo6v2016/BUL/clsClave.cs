using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace Modulo6.BUL
{
    class clsClave
    {
        
        OleDbCommand comando = new OleDbCommand();
        SqlCommand comandosql = new SqlCommand();

        DAL.clsODBC clsCon = new Modulo6.DAL.clsODBC();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        public bool Validar()
        {
           

            return true;


        } //validar



        public bool Guardar()
        {
            if (Validar() == true)
            {
                try
                {

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    comando.CommandText = "proctClaveUpdate";
                    comando.Parameters.Add("@ClaveId", OleDbType.VarChar);
                    comando.Parameters.Add("@MateriaId", OleDbType.VarChar);
                    comando.Parameters.Add("@PlanId", OleDbType.SmallInt);
                    //comando.Parameters["@MateriaId"].Value = this.MateriaId;
                    //comando.Parameters["@Materia"].Value = this.Materia;
                    //comando.Parameters["@PlanId"].Value = this.PlanId;

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
                    comando.CommandText = "proctClaveDelete";
                    comando.Parameters.Add("@ClaveId", OleDbType.VarChar);
                    //comando.Parameters["@MateriaId"].Value = this.MateriaId;
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
                comandosql.CommandText = "proctClaveBulkLoad";

                DataTable table = new DataTable();
                table = ds.Tables[0];

                //validar que exista la columna Ponderacion
                //si no existe crearla
                
                /*ordenando las columnas*/
                //ClaveId,
		        //MateriaId,
		        //PreguntasCantidad,
		        //DistractoresCantidad,
		        //Ponderacion,
		        //SolRConcentrado
                
                
                if (ds.Tables[0].Columns.IndexOf("Ponderacion")<0)
                {
                    DataColumn Ponderacion = new DataColumn();
                    Ponderacion.DataType = System.Type.GetType("System.String");
                    Ponderacion.ColumnName = "Ponderacion";
                    Ponderacion.Expression = "";
                    ds.Tables[0].Columns.Add(Ponderacion);
                }

                table.Columns["ClaveId"].SetOrdinal(0);
                table.Columns["MateriaId"].SetOrdinal(1);
                table.Columns["PreguntasCantidad"].SetOrdinal(2);
                table.Columns["DistractoresCantidad"].SetOrdinal(3);
                table.Columns["Ponderacion"].SetOrdinal(4);
                table.Columns["SolRConcentrado"].SetOrdinal(5);

                //para cambiar el tipo de dato a cada columna, hay que clonar la tabla y luego importar
                DataTable dtCloned = table.Clone();

                dtCloned.Columns[0].DataType = typeof(string);
                dtCloned.Columns[1].DataType = typeof(string);
                dtCloned.Columns[2].DataType = typeof(Int16);
                dtCloned.Columns[3].DataType = typeof(Int16);
                dtCloned.Columns[4].DataType = typeof(string);
                dtCloned.Columns[5].DataType = typeof(string);
                
                
                foreach (DataRow row in table.Rows)
                {
                        dtCloned.ImportRow(row);
                }
                SqlParameter parameter;
                parameter = comandosql.Parameters.AddWithValue("@zClave", dtCloned);
                parameter.SqlDbType = SqlDbType.Structured;
                parameter.TypeName = "dbo.zClave";

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
