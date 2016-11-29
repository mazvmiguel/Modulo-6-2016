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
    public partial class frmMateria : Form
    {
        public frmMateria()
        {
            InitializeComponent();
        }
        public string str, strEdit;
        DAL.clsODBC cls_Con = new Modulo6.DAL.clsODBC();
        OleDbCommand cmdForm = new OleDbCommand();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        private void frmMateria_Load(object sender, EventArgs e)
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
            cls_Con.comboFill(this.cmbPlan, "select * from tPlan order by 2", "tPlan", "Plan", "PlanId");

        }

        private void list_Data()
        {
            cls_Con.list_DataView("proctMateriaList", this.lstv_Subject);

        }
       
       
        private void set_TabIndex()
        {
           
            txtMateriaId.TabIndex = 0;
            txtMateria.TabIndex = 1;
            cmbPlan.TabIndex = 2;
           
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
           

            clsMateria Materia = new clsMateria();
            Materia.Materia = txtMateria.Text.Trim();
            Materia.MateriaId = txtMateriaId.Text.Trim();

            if (string.IsNullOrEmpty(cmbPlan.Text))
            {

                Materia.PlanId = 0;

            }
            else
            {
                Materia.PlanId= Int16.Parse(cmbPlan.SelectedValue.ToString());
            }


            Materia.Guardar();
          
            limpiar_forma();
            list_Data();
        }

        private void limpiar_forma()
        {
            txtMateria.Text = "";
            this.txtMateriaId.Text = "";
            cmbPlan.SelectedIndex = -1;
            txtMateriaId.Focus();
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
            clsMateria Materia = new clsMateria();
            Materia.Materia = txtMateria.Text.Trim();
            Materia.MateriaId = txtMateriaId.Text.Trim();

           
            Materia.Borrar();
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
                OleDbCommand cmd = new OleDbCommand("proctMateriaSelect '" + (this.lstv_Subject .Items[lstv_Subject.FocusedItem.Index].SubItems[0].Text.Trim()) + "'", cls_Con.cn);

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    strEdit = dr["MateriaId"].ToString();

                    txtMateriaId.Text = dr["MateriaId"].ToString();
                    this.txtMateria.Text = dr["Materia"].ToString().Trim();
                    cmbPlan.SelectedValue = dr["PlanId"].ToString();

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

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            clsMateria Materia = new clsMateria();
            Materia.Materia = txtMateria.Text.Trim();
            Materia.MateriaId = txtMateriaId.Text.Trim();

            if (string.IsNullOrEmpty(cmbPlan.Text))
            {

                Materia.PlanId = 0;

            }
            else
            {
                Materia.PlanId = Int16.Parse(cmbPlan.SelectedValue.ToString());
            }


            Materia.Guardar();

            limpiar_forma();
            list_Data();
        }
      

     


        }

    }
