using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb ;
using Modulo6.BUL;
using Modulo6.DAL;

namespace Modulo6._forms
{
    public partial class frmPeriodo : Form
    {
        public frmPeriodo()
        {
            InitializeComponent();
        }
       public string str = "";//get the value for form what do Modify/Add
        string newID, editID;// newID for New ID  and editID for Delete & Edit
       OleDbCommand   cmdForm = new OleDbCommand();
        DAL.clsODBC clsCon = new Modulo6.DAL.clsODBC();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            limpiar_forma();

        }

        private void lstv_Function()
        {
            this.clsCon.list_DataView("proctPeriodoList", this.lstv_Class);
        }

        
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lstv_Function();
            this.lstv_Class.Refresh();
            limpiar_forma();    
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clsPeriodo Periodo = new clsPeriodo();
            Periodo.Periodo = txtPeriodoNombre.Text;
            Periodo.PeriodoId = txtPeriodoId.Text;
            Periodo.FechaInicio = dtpFechaInicio.Value;
            Periodo.FechaFin = dtpFechaFin.Value;
            Periodo.Activo = chkActivo.Checked;
            if (string.IsNullOrEmpty(cmbPlan.Text))
            {

                Periodo.PlanID = 0;
                
            }
            else
            {
                Periodo.PlanID = Int16.Parse(cmbPlan.SelectedValue.ToString());
            }
            
            Periodo.Guardar();
            lstv_Function();
            limpiar_forma();
           
        }
       
        private void frmPeriodo_Load(object sender, EventArgs e)
        {
            if (str == "Agregando")
            {
                this.lbl_Mode.Text = str;
                btn_Edit.Visible = false;
                btn_Delete.Visible = false;
                side2.Visible = false;
                side3.Visible = false;
            }
            else
            {
                if (str == "Modificando")
                {
                    this.lbl_Mode.Text = str;
                    btn_Add.Visible = false;
                    side1.Visible = false;
                }
            }

            combo_Plan();
            lstv_Function();
            limpiar_forma();

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            clsPeriodo Periodo = new clsPeriodo();
            Periodo.Periodo = txtPeriodoNombre.Text;
            Periodo.PeriodoId = txtPeriodoId.Text;
            Periodo.FechaInicio = dtpFechaInicio.Value;
            Periodo.FechaFin = dtpFechaFin.Value;
            Periodo.Activo = chkActivo.Checked;
            Periodo.PlanID = Int16.Parse(cmbPlan.SelectedValue.ToString());
            Periodo.Guardar();
            lstv_Function();
            limpiar_forma();

        }

        
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            clsPeriodo Periodo = new clsPeriodo();
            Periodo.Periodo = txtPeriodoNombre.Text;
            Periodo.PeriodoId = txtPeriodoId.Text;
            Periodo.FechaInicio = dtpFechaInicio.Value;
            Periodo.FechaFin = dtpFechaFin.Value;
            Periodo.Activo = chkActivo.Checked;
            Periodo.PlanID = 1;
            Periodo.Borrar();
            lstv_Function();


        }

        private void txt_Cname_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Agregando")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.btn_Add_Click(sender, e);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

        }

        private void lstv_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.editID = (this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[0].Text.Trim());
            this.txtPeriodoId.Text= (this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[0].Text.Trim());
            this.txtPeriodoNombre.Text = (this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[1].Text.Trim());
            this.dtpFechaInicio.Value = DateTime.Parse(this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[2].Text.Trim());
            this.dtpFechaFin.Value = DateTime.Parse(this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[3].Text.Trim());
            this.chkActivo.Checked = bool.Parse(this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[4].Text.Trim());
            this.cmbPlan.SelectedValue = Int16.Parse(this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[5].Text.Trim());

        }

        private void combo_Plan()
        {
            clsCon.comboFill(this.cmbPlan , "select * from tPlan order by 2", "tPlan",  "Plan", "PlanId");

        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_forma()
        {

            this.txtPeriodoId.Text = "";
            this.txtPeriodoNombre.Text = "";
            this.dtpFechaFin.Value = DateTime.Now;
            this.dtpFechaInicio.Value = DateTime.Now;
            this.chkActivo.Checked = false;
            this.cmbPlan.SelectedIndex = -1;
            lstv_Function();
            this.txtPeriodoId.Focus();
        }

    }
}