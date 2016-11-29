using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Modulo6.BUL
{
    class clsCurso
    {
        public Int32 CursoId;
        public string MaestroId;
        public string MateriaId;
        public string GrupoId;


        OleDbCommand comando = new OleDbCommand();
        DAL.clsODBC clsCon = new Modulo6.DAL.clsODBC();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        public bool Validar()
        {
            if (MateriaId.ToString().Length <= 0)
            {

                clsmyFunction.setMessageBox("No ha seleccionado Materia", 2);
                return false;
            }

            if (MateriaId.ToString().Length <= 0)
            {

                clsmyFunction.setMessageBox("No ha seleccionado Materia", 2);
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

                    comando.CommandText = "proctCursoUpdate";

                    comando.Parameters.Add("@CursoId", OleDbType.Integer);
                    comando.Parameters.Add("@MaestroId", OleDbType.VarChar);
                    comando.Parameters.Add("@MateriaId", OleDbType.VarChar);
                    comando.Parameters.Add("@GrupoId", OleDbType.VarChar);

                    comando.Parameters["@CursoId"].Value = this.CursoId;
                    comando.Parameters["@MaestroId"].Value = this.MaestroId;
                    comando.Parameters["@MateriaId"].Value = this.MateriaId;
                    comando.Parameters["@GrupoId"].Value = this.GrupoId;

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
                    comando.Parameters.Add("@CursoId", OleDbType.Integer);
                    comando.Parameters["@MateriaId"].Value = this.CursoId;
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


    }
}
