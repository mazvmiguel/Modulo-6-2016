using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Modulo6.BUL
   {
    class clsPeriodo
    {
    public string Periodo;
    public string PeriodoId;
    public DateTime FechaInicio;
    public DateTime FechaFin;
    public Int16 PlanID;
    public bool Activo;
         
        OleDbCommand comando = new OleDbCommand();
        DAL.clsODBC clsCon = new Modulo6.DAL.clsODBC();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        public bool Validar()
    {
        if (Periodo.ToString().Length <= 0)
        {
            
               clsmyFunction.setMessageBox("La longitud del nombre Periodo no es correcta", 2);
                return false;
        }

        if (PeriodoId.ToString().Length <= 0)
        {
            
                clsmyFunction.setMessageBox("La longitud del Periodo ID no es correcta", 2);
                return false ;
        }

        if (FechaInicio> FechaFin)
        {
            
                clsmyFunction.setMessageBox("La Fecha Fin debe ser mayor a la Fecha Inicio", 2);
             return false;
        }

            if (PlanID<=0)
            {
               
                clsmyFunction.setMessageBox("Debe seleccionar una tipo de plan", 2);
                return false;
            }
            return true;
       

      } //validar



        public bool Guardar()
        {
            if (Validar()==true)
            {
                try
                {
                    
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    comando.CommandText = "proctPeriodoUpdate";
                    comando.Parameters.Add("@Periodoid", OleDbType.VarChar);
                    comando.Parameters.Add("@Periodo", OleDbType.VarChar  );
                    comando.Parameters.Add("@FechaInicio", OleDbType.Date);
                    comando.Parameters.Add("@FechaFin", OleDbType.Date);
                    comando.Parameters.Add("@Activo", OleDbType.Boolean);
                    comando.Parameters.Add("@Planid", OleDbType.SmallInt);
                    comando.Parameters["@PeriodoId"].Value = this.PeriodoId;
                    comando.Parameters["@Periodo"].Value = this.Periodo;
                    comando.Parameters["@FechaInicio"].Value = this.FechaInicio;
                    comando.Parameters["@FechaFin"].Value = this.FechaFin;
                    comando.Parameters["@Activo"].Value = this.Activo;
                    comando.Parameters["@Planid"].Value = this.PlanID;
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

                if (Validar() == true && ret == DialogResult.Yes )
            {
                try
                {

                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "proctPeriodoDelete";
                    comando.Parameters.Add("@Periodoid", OleDbType.VarChar);
                    comando.Parameters["@PeriodoId"].Value = this.PeriodoId;
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
