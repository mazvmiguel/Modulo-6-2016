using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Modulo6.BUL;
using Modulo6.DAL;
//////////////////////////////
using System.Data.SqlClient;

namespace Modulo6._forms
{
    public partial class frmClave : Form
    {
        private clsClave oClave;
        private bool bNuevo;
        
        DAL.clsODBC cls_Con = new Modulo6.DAL.clsODBC();
        //OleDbCommand cmdForm = new OleDbCommand();
        //DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        public frmClave(bool _bNuevo)
        {
            bNuevo = _bNuevo;

            InitializeComponent();            
        }
        
        private void frmMateria_Load(object sender, EventArgs e)
        {
            if (!bNuevo) {
                this.lbl_Mode.Text = "Modificando";

                btn_Add.Visible = false;
                side1.Visible = false;
            }

            panel5.Visible = false;

            cls_Con.list_DataView("proctClaveList", this.lstv_Examen);
            clsFuncionesComunes.CargarDropDownList(ref cboMateria, "SELECT MateriaId, Materia FROM tMateria ORDER BY 2", "MateriaId", "Materia");            
        }
        
#region POR_REVISAR
        private void set_TabIndex()
        {
           
            cboMateria.TabIndex = 2;
            groupboxform.TabIndex = 7;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void txtMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clsCurso Curso = new clsCurso();
            

            //if (strEdit != null)
            //    {
            //    Curso.CursoId = Int32.Parse(strEdit);
            //}
            //else {
            //    Curso.CursoId = 0;
            //}

            
            Curso.MaestroId =   cboMateria.SelectedValue.ToString();           


            Curso.Guardar();
          
            limpiar_forma();
        }

        private void limpiar_forma()
        {
            //lstb_Materia.SelectedIndex = -1;
            //lstb_Grupo.SelectedIndex = -1;

            //chklstMateria.SelectedIndex = -1;
            //chklstGrupo.SelectedIndex = -1;
            //chklstMateria.ClearSelected();
            //chklstGrupo.ClearSelected();

            //cboMateria.SelectedIndex = -1;
            //cboMateria.Focus();
        }               

        private void rdo_Class_Click(object sender, EventArgs e)
        {
            //if (rdo_Class.Checked == true)
            //{
            //    cls_Con.list_DataView("select sub_id,sub_name,c_name,emp_name,sub_marks,remarks,is_active,is_teacher from view_subject where is_teacher=true and is_active=true and c_id=" + this.com_Sclass.SelectedValue + "", this.lstv_Subject);
            //}
        }

        private void com_Sclass_SelectedValueChanged(object sender, EventArgs e)
        {
            rdo_Class_Click(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            txt_Find.Focus();
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            
            cls_Con.list_DataView("proctMateriaSearch '" + this.txt_Find.Text.Trim() + "'", this.lstv_Examen);            
        }
        
        //private void chklstMateria_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if (e.NewValue == CheckState.Checked)
        //        for (int ix = 0; ix < chklstMateria.Items.Count; ++ix)
        //            if (e.Index != ix) chklstMateria.SetItemChecked(ix, false);
        //}

        //private void chklstGrupo_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if (e.NewValue == CheckState.Checked)
        //        for (int ix = 0; ix < chklstGrupo.Items.Count; ++ix)
        //            if (e.Index != ix) chklstGrupo.SetItemChecked(ix, false);
        //}

#endregion

        private void btn_Save_Click(object sender, EventArgs e)
        {

            //SICH 09DIC2016: MANEJAR TODAS LAS VALIDACIONES ANTES DE CONSTRUIR EL OBJETO Y EJECUTAR <SAVE>            
            //SICH 09DIC2016: MANEJAR TODAS LAS VALIDACIONES ANTES DE CONSTRUIR EL OBJETO Y EJECUTAR <SAVE>            
            //SICH 09DIC2016: MANEJAR TODAS LAS VALIDACIONES ANTES DE CONSTRUIR EL OBJETO Y EJECUTAR <SAVE>            

            oClave = new clsClave();

            if (txtClaveId.Text != string.Empty && cboMateria.SelectedIndex != 0)
            {
                oClave.ClaveId = txtClaveId.Text;
                oClave.MateriaId = cboMateria.SelectedValue.ToString();
                oClave.PreguntasCantidad = Convert.ToInt16(txtNumPreguntas.Text);
                oClave.SolRConcentrado = ObtenerRespuestasDeGrid(oClave.PreguntasCantidad);
                oClave.Ponderacion = ObtenerPonderacionDeGrid(oClave.PreguntasCantidad);
                oClave.DistractoresCantidad = Convert.ToInt16(txtNumOpciones.Text);

                if (oClave.actualizarClave())
                {
                    MessageBox.Show("La informaci�n fue guardada exitosamente.\nSICH: Definir formato final de mensajes");
                    LimpiarForm();                    
                }
                else {
                    MessageBox.Show("Ocurri� un problema al procesar la solicitud. Vuelva a intentar.\nSICH: Definir formato final de mensajes");
                }

                //SICH 18DIC2016: FALTA LIMPIAR OBJETO
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //SICH 18DIC2016: MANEJAR PREGUNTA PARA ASEGURAR ESTAR OK CON ELIMINAR

            if (txtClaveId.Text != string.Empty && cboMateria.SelectedIndex != 0)
            {
                oClave.ClaveId = txtClaveId.Text;
                if (oClave.eliminarClave())
                {
                    MessageBox.Show("La informaci�n fue eliminada exitosamente.\nSICH: Definir formato final de mensajes");
                    oClave = new clsClave();

                    LimpiarForm();                    
                }
                else {
                    MessageBox.Show("Ocurri� un problema al procesar la solicitud. Vuelva a intentar.\nSICH: Definir formato final de mensajes");
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void LimpiarForm() {
            txtClaveId.Text = string.Empty;
            cboMateria.SelectedIndex = 0;
            txtNumPreguntas.Text = string.Empty;
            txtNumOpciones.Text = string.Empty;
            txtMateriaDesc.Text = string.Empty;
            txtPlanDesc.Text = string.Empty;
            dgvPonderacion.Rows.Clear();
            dgvRespuestas.Rows.Clear();
            for (int i = dgvRespuestas.Columns.Count - 1; i > 0; i--) { dgvRespuestas.Columns.RemoveAt(i); }            
            cls_Con.list_DataView("proctClaveList", this.lstv_Examen);

            txtClaveId.Focus();            
        }

        private string ObtenerRespuestasDeGrid(int iRespuestasCant) {
            bool bEncontrado;
            string sResultado = string.Empty;            

            for (int iRow=0; iRow < iRespuestasCant; iRow++) {
                bEncontrado = false;
                for (int iCol=1; iCol < dgvRespuestas.Columns.Count; iCol++) {
                    if (dgvRespuestas.Rows[iRow].Cells[iCol].Value != null) {
                        if (dgvRespuestas.Rows[iRow].Cells[iCol].Value.ToString() == "X") {
                            sResultado += clsFuncionesComunes.fnMapRespuesta(iCol);
                            bEncontrado = true;
                        }                        
                    }                    
                }

                if (!bEncontrado) { sResultado += Convert.ToChar(Keys.Space).ToString(); }
            }

            return sResultado;
        }

        private string ObtenerPonderacionDeGrid(int iRespuestasCant)
        {
            string sResultado = string.Empty;

            for (int iRow = 0; iRow < iRespuestasCant; iRow++)
            {
                if (dgvPonderacion.Rows[iRow].Cells[1].Value != null)
                {
                    sResultado += dgvPonderacion.Rows[iRow].Cells[1].Value.ToString() + "|";                    
                }
                else if((dgvPonderacion.Rows[iRow].Cells[1].Value == null) || (dgvPonderacion.Rows[iRow].Cells[1].Value.ToString().Trim() == string.Empty)) {
                    sResultado += "|";
                }
            }

            return sResultado.Substring(0, sResultado.Length - 1);
        }

        private void btnAsignarReactivos_Click(object sender, EventArgs e)
        {
            
            int iNumOpciones = txtNumOpciones.Text != string.Empty ? Convert.ToInt16(txtNumOpciones.Text) : 0;
            int iNumReactivos = txtNumPreguntas.Text!=string.Empty?Convert.ToInt16(txtNumPreguntas.Text):0;

            //SICH21NOV2016: validacion de entradas de acuerdo a dimensiones maximas definidas de reactivos y opciones
            if (iNumReactivos < 1 || iNumReactivos > Convert.ToInt16(clsFuncionesComunes.Get_ConfigValue("MAX_NUM_REACTIVOS")))
            {
                MessageBox.Show("La cantidad de reactivos no es v�lida. Favor de verificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (iNumOpciones < 1 || iNumOpciones > Convert.ToInt16(clsFuncionesComunes.Get_ConfigValue("MAX_NUM_OPCIONES")))
            {
                MessageBox.Show("La cantidad de opciones no es v�lida. Favor de verificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ConfigurarGrid(iNumReactivos, iNumOpciones);          
        }

        private void btnAsignarPonderacion_Click(object sender, EventArgs e)
        {
            AsignarPonderacion(txtNumPreguntas.Text != string.Empty ? Convert.ToInt16(txtNumPreguntas.Text) : 0, false, string.Empty);
        }

        private void lstv_Examen_SelectedIndexChanged(object sender, EventArgs e)
        {
            oClave = new clsClave(lstv_Examen.Items[lstv_Examen.FocusedItem.Index].SubItems[0].Text.Trim());
            char[] s_Solucion = oClave.SolRConcentrado.ToCharArray();
            string[] s_Ponderacion = oClave.Ponderacion.Split('|');

            txtClaveId.Text = oClave.ClaveId;
            cboMateria.SelectedValue = oClave.MateriaId;
            txtNumPreguntas.Text = oClave.PreguntasCantidad.ToString();
            txtNumOpciones.Text = oClave.DistractoresCantidad.ToString();

            //SICH 04DIC2016: esto se tiene que ejecutar en ese orden
            ConfigurarGrid(oClave.PreguntasCantidad, oClave.DistractoresCantidad);
            AsignarPonderacion(oClave.PreguntasCantidad, true, oClave.Ponderacion);
            for (int i = 0; i <= dgvRespuestas.Rows.Count - 1; i++) { 
                dgvRespuestas.Rows[i].Cells[clsFuncionesComunes.fnRevMapRespuesta(s_Solucion[i])].Value = "X";
            }
                        
        }
                
        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sMateriaId = string.Empty;

            DataRowView rowView = cboMateria.SelectedItem as DataRowView;
            if (rowView != null)
            {
                sMateriaId = rowView[0].ToString();
            }

            cls_Con.connCheck();
            OleDbCommand cmd = new OleDbCommand("SELECT b.MateriaId, a.[Plan] PlanEscolar FROM tPlan a INNER JOIN tMateria b ON a.PlanId=b.PlanId WHERE b.MateriaId='" + sMateriaId + "'", cls_Con.cn);

            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMateriaDesc.Text = dr[0].ToString();
                txtPlanDesc.Text = dr[1].ToString();
            }
            cls_Con.cn.Close();
            dr.Close();
            cmd.Dispose();
        }

        private void ConfigurarGrid(int iReactivosCantidad, int iNumDistractores)
        {
            GenerarColumnas(iNumDistractores);
            GenerarRenglones(iReactivosCantidad);
        }

        private void GenerarColumnas(int iNumDistractores)
        {
            int iNewCol = 1;

            //SICH21NOV2016: eliminacion de columnas adicionales
            for (int i = (dgvRespuestas.Columns.Count - 1); i >= 1; i--)
            {
                dgvRespuestas.Columns.RemoveAt(i);
            }
            //SICH21NOV2016: se crean las columnas para contener las respuestas correctas del examen
            for (int i = 1; i <= iNumDistractores; i++)
            {
                dgvRespuestas.Columns.Add("colOpt" + i.ToString(), clsFuncionesComunes.fnMapRespuesta(i));
                dgvRespuestas.Columns[iNewCol].ReadOnly = true;
                ((DataGridViewTextBoxColumn)dgvRespuestas.Columns[iNewCol]).MaxInputLength = 1;
                dgvRespuestas.Columns[iNewCol].Width = dgvRespuestas.Columns[0].Width;
                dgvRespuestas.Columns[iNewCol].SortMode = DataGridViewColumnSortMode.NotSortable;
                ((DataGridViewTextBoxColumn)dgvRespuestas.Columns[iNewCol]).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                iNewCol++;
            }
        }

        private void GenerarRenglones(int iReactivosCantidad)
        {
            //SICH21NOV2016: eliminacion de renglones adicionales
            for (int i = (dgvRespuestas.Rows.Count - 1); i >= 0; i--)
            {
                dgvRespuestas.Rows.RemoveAt(i);
                dgvPonderacion.Rows.RemoveAt(i);
            }
            //SICH21NOV2016: se crean los renglones para contener los reactivos y ponderaciones del examen
            for (int i = 0; i < iReactivosCantidad; i++)
            {
                dgvRespuestas.Rows.Add();
                dgvRespuestas.Rows[i].Cells[0].Value = (i + 1).ToString();

                dgvPonderacion.Rows.Add();
                dgvPonderacion.Rows[i].Cells[0].Value = (i + 1).ToString();                
            }
        }

        private void AsignarPonderacion(int iReactivosCantidad, bool bPonderacionDef, string sPonderacion)
        {
            if (dgvPonderacion.Rows.Count == 0) return;

            string[] s_Ponderacion = sPonderacion.Split('|');
            for (int i = 0; i < iReactivosCantidad; i++)
            {
                if (bPonderacionDef)
                {                    
                    dgvPonderacion.Rows[i].Cells[1].Value = String.Format("{0:##0.0##}", (Convert.ToDouble(s_Ponderacion[i])));
                }
                else { dgvPonderacion.Rows[i].Cells[1].Value = String.Format("{0:##0.0##}", (Convert.ToDouble(clsFuncionesComunes.Get_ConfigValue("BASE_EVAL")) / (double)iReactivosCantidad)); }
            }
        }
           
        private void dgvRespuestas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                if ((dgvRespuestas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) && (dgvRespuestas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != string.Empty))
                {
                    dgvRespuestas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Empty;
                    return;
                }

                for (int i = 1; i < dgvRespuestas.Columns.Count; i++)
                {
                    dgvRespuestas.Rows[e.RowIndex].Cells[i].Value = string.Empty;
                }

                dgvRespuestas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "X";
            }
        }

        private void txtNumPreguntas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Tab))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNumOpciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Tab))
            {
                e.Handled = true;
                return;
            }
        }
               
        private void dgvPonderacion_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox miText = e.Control as TextBox;
            miText.KeyPress += new KeyPressEventHandler(clsFuncionesComunes.Cell_KeyPress);
        }        
    }
}



