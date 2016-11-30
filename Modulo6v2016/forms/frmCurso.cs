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

namespace Modulo6._forms
{
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }
        public string str, strEdit;
        DAL.clsODBC cls_Con = new Modulo6.DAL.clsODBC();
        OleDbCommand cmdForm = new OleDbCommand();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        private void frmMateria_Load(object sender, EventArgs e)
        {

           // MessageBox.Show(Program.Usuario.ToString());

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

            //frmStudent frm_Student = new frmStudent();

            // =========================================
            panel5.Visible = false;
            
            set_TabIndex();
            combo_Plan();
            list_Data();
            limpiar_forma();
        }

        private void combo_Plan()
        {
            cls_Con.comboFill(this.cmbMaestro, "select MaestroId,Maestro from tMaestro order by 2", "tMaestro", "Maestro", "MaestroId");
            cls_Con.listboxfill(this.lstb_Materia, "select MateriaId,Materia from tMateria order by 2", "tMateria", "Materia", "MateriaId");
            cls_Con.listboxfill(this.lstb_Grupo, "select GrupoId,Grupo from tGrupo order by 2", "tGrupo", "Grupo", "GrupoId");

            cls_Con.chklistfill(this.chklstGrupo, "select GrupoId,Grupo from tGrupo order by 2", "tGrupo", "Grupo", "GrupoId");
            cls_Con.chklistfill(this.chklstMateria, "select M.MateriaId,Materia=UPPER(M.Materia +'('+ p.[Plan] +')') from tMateria M INNER JOIN TPLAN P ON P.PLANID=M.PLANID order by 2 ", "tMateria", "Materia", "MateriaId");
        }

        private void list_Data()
        {
            cls_Con.list_DataView("proctCursoList", this.lstv_Subject);

        }
       
       
        private void set_TabIndex()
        {
           
            cmbMaestro.TabIndex = 2;
            groupboxform.TabIndex = 7;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            limpiar_forma();
            list_Data();


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

            //if (string.IsNullOrEmpty(cmbMaestro.Text))
            //{

            //    Curso.PlanId = 0;

            //}
            //else
            //{
            //    Curso.PlanId= Int16.Parse(cmbMaestro.SelectedValue.ToString());
            //}

            if (strEdit != null)
                {
                Curso.CursoId = Int32.Parse(strEdit);
            }
            else {
                Curso.CursoId = 0;
            }

            
            Curso.MaestroId =   cmbMaestro.SelectedValue.ToString();

            //Curso.MateriaId = lstb_Materia.SelectedValue.ToString();
            //Curso.GrupoId = lstb_Grupo.SelectedValue.ToString();

            Curso.MateriaId = chklstMateria.SelectedValue.ToString();
            Curso.GrupoId = chklstGrupo.SelectedValue.ToString();

           


            Curso.Guardar();
          
            limpiar_forma();
            list_Data();
        }

        private void limpiar_forma()
        {
            lstb_Materia.SelectedIndex = -1;
            lstb_Grupo.SelectedIndex = -1;

            chklstMateria.SelectedIndex = -1;
            chklstGrupo.SelectedIndex = -1;
            chklstMateria.ClearSelected();
            chklstGrupo.ClearSelected();

            cmbMaestro.SelectedIndex = -1;
            cmbMaestro.Focus();
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
            
       cls_Con.list_DataView("proctMateriaSearch '" + this.txt_Find.Text.Trim() + "'", this.lstv_Subject);

            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            clsCurso Curso = new clsCurso();

            Curso.CursoId = Int32.Parse(strEdit);

            Curso.Borrar();
            limpiar_forma();
            list_Data();
        }
    

        private void lstv_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* this.editID = (this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[0].Text.Trim());
            this.txt_Cname.Text = (this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[1].Text.Trim());*/


            if (str == "Modificando")
            {
                //this.com_Cname .SelectedIndex  = -1;
                //this.com_Teacher.SelectedIndex = -1;
                //this.com_Cname.Text = "";
                //this.com_Teacher.Text = "";
                //this.com_Cname.DropDownStyle = ComboBoxStyle.Simple;
                //this.com_Teacher.DropDownStyle = ComboBoxStyle.Simple;
                

                cls_Con.connCheck();
                OleDbCommand cmd = new OleDbCommand("proctCursoSelect " + (this.lstv_Subject .Items[lstv_Subject.FocusedItem.Index].SubItems[0].Text.Trim()) + "", cls_Con.cn);

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    limpiar_forma();
                    strEdit = dr["CursoId"].ToString();
                    lstb_Grupo.SelectedValue = dr["GrupoId"].ToString();
                    lstb_Materia.SelectedValue= dr["MateriaId"].ToString();

                    chklstGrupo.SelectedValue = dr["GrupoId"].ToString();
                    chklstMateria.SelectedValue = dr["MateriaId"].ToString();

                    chklstGrupo.SetItemChecked(chklstGrupo.Items.IndexOf(chklstGrupo.SelectedItem), true);
                    chklstMateria.SetItemChecked(chklstMateria.Items.IndexOf(chklstMateria.SelectedItem), true);



                    cmbMaestro.SelectedValue = dr["MaestroId"].ToString();

                }
                cls_Con.cn.Close();
                dr.Close();
                cmd.Dispose();
            }
            else
            {
                return;
            }
        }

        private void chklstMateria_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < chklstMateria.Items.Count; ++ix)
                    if (e.Index != ix) chklstMateria.SetItemChecked(ix, false);
        }

        private void chklstGrupo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < chklstGrupo.Items.Count; ++ix)
                    if (e.Index != ix) chklstGrupo.SetItemChecked(ix, false);
        }

        private void btn_Carga_Click(object sender, EventArgs e)
        {
            clsmyFunction.CargaMasiva("Cursos");
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            clsMateria Materia = new clsMateria();
           

            if (string.IsNullOrEmpty(cmbMaestro.Text))
            {

                Materia.PlanId = 0;

            }
            else
            {
                Materia.PlanId = Int16.Parse(cmbMaestro.SelectedValue.ToString());
            }


            Materia.Guardar();

            limpiar_forma();
            list_Data();
        }
      

     


        }

    }
