using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace Modulo6.BUL
{
    class clsMateria
    {
        public string MateriaId;
        public string Materia;
        public Int16 PlanId;
        

        OleDbCommand comando = new OleDbCommand();
        SqlCommand comandosql = new SqlCommand();

        DAL.clsODBC clsCon = new Modulo6.DAL.clsODBC();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        public bool Validar()
        {
            if (MateriaId.ToString().Length <= 0)
            {

                clsmyFunction.setMessageBox("La longitud de la Materia ID no es correcta", 2);
                return false;
            }

            if (Materia.ToString().Length <= 0)
            {

                clsmyFunction.setMessageBox("La longitud del nombre del Materia no es correcta", 2);
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

                    comando.CommandText = "proctMateriaUpdate";
                    comando.Parameters.Add("@MateriaId", OleDbType.VarChar);
                    comando.Parameters.Add("@Materia", OleDbType.VarChar);
                    comando.Parameters.Add("@PlanId", OleDbType.SmallInt);
                    comando.Parameters["@MateriaId"].Value = this.MateriaId;
                    comando.Parameters["@Materia"].Value = this.Materia;
                    comando.Parameters["@PlanId"].Value = this.PlanId;

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
                    comando.CommandText = "proctMateriaDelete";
                    comando.Parameters.Add("@MateriaId", OleDbType.VarChar);
                    comando.Parameters["@MateriaId"].Value = this.MateriaId;
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
                comandosql.CommandText = "proctMateriaBulkLoad";

                DataTable table = new DataTable();
                table = ds.Tables[0];

                /*ordenando las columnas*/
                table.Columns["MateriaId"].SetOrdinal(0);
                table.Columns["MateriaNombre"].SetOrdinal(1);
                table.Columns["PlanId"].SetOrdinal(2);
                
                //para cambiar el tipo de dato a cada columna, hay que clonar la tabla y luego importar
                DataTable dtCloned = table.Clone();

                dtCloned.Columns[0].DataType = typeof(string);
                dtCloned.Columns[1].DataType = typeof(string);
                dtCloned.Columns[2].DataType = typeof(Int16);

                PlanId= new Int16();

                
                foreach (DataRow row in table.Rows)
                {
                    if (row[2].ToString().Trim().Length==0)
                    {
                        row[2] = "0";
                    }
                    //validando que planid sea numerico
                    if (Int16.TryParse(row[2].ToString(), out PlanId))
                    {
                        dtCloned.ImportRow(row);
                    }
                    
                }
                SqlParameter parameter;
                parameter = comandosql.Parameters.AddWithValue("@zMateria", dtCloned);
                parameter.SqlDbType = SqlDbType.Structured;
                parameter.TypeName = "dbo.zMateria";

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
