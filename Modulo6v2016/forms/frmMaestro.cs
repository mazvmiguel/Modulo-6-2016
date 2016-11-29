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
    public partial class frmMaestro: Form
    {
        public frmMaestro()
        {
            InitializeComponent();
        }
        int myID,editID;//For New ID also used in Save Process
        public string str, strEdit;
        DAL.clsODBC cls_Con = new Modulo6.DAL.clsODBC();
        OleDbCommand cmdForm = new OleDbCommand();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            tab_Index();
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
            emp_ID();
            list_Data();
        }
        private void list_Data()
        {
            this.cls_Con.list_DataView("proctMaestroList", this.lstv_Employee);
        }
        private void tab_Index()
        {
            txtMaestroId.TabIndex = 0;
            this.txtMaestro.TabIndex = 1;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            clsMaestro Maestro = new clsMaestro();
            Maestro.Maestro = txtMaestro.Text.Trim();
            Maestro.MaestroId = txtMaestroId.Text.Trim();
            Maestro.Guardar();
            limpiar_forma();
            list_Data();
        }
        private void limpiar_forma()
        {
            this.txtMaestroId.Text = "";
            this.txtMaestro.Text = "";
            this.txtMaestroId.Focus();
        }
   

        private void emp_ID()
        {
            if (this.lbl_Mode.Text != "Agregando")
            {
                return;
            }
            else
            {

                try
                {


                    //cls_Con.connCheck();
                    //OleDbCommand cmddr = new OleDbCommand("select max(n_id) as ids from employee ", cls_Con.cn);
                    //OleDbDataReader dr = cmddr.ExecuteReader();

                    //while (dr.Read())
                    //{
                    //    string strid = dr["ids"].ToString();
                    //    if (strid == "")
                    //    {
                    //        this.txtMaestroId.Text = "EMP-" + "1";
                    //    }
                    //    else
                    //    {
                    //        myID = Convert.ToInt32(dr["ids"]) + 1;
                    //        this.txtMaestroId.Text = "EMP-" + myID.ToString();
                    //    }

                    //}
                    //dr.Close();
                    //cls_Con.cn.Close();
                    //cmddr.Dispose();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void txtSalery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            clsMaestro Maestro = new clsMaestro();
            Maestro.Maestro = txtMaestro.Text.Trim();
            Maestro.MaestroId = txtMaestroId.Text.Trim();
            Maestro.Guardar();
            limpiar_forma();
            list_Data();
        }
    

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            clsMaestro Maestro = new clsMaestro();
            Maestro.Maestro = txtMaestro.Text.Trim();
            Maestro.MaestroId = txtMaestroId.Text.Trim();
            Maestro.Borrar();
            limpiar_forma();
            list_Data();
        }
    

        private void lstv_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbl_Mode.Text == "Modificando")
            {

                cls_Con.connCheck();
                OleDbCommand cmd = new OleDbCommand("proctMaestroSelect '" + (this.lstv_Employee.Items[lstv_Employee.FocusedItem.Index].SubItems[0].Text.Trim()) + "'"
                    , cls_Con.cn);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.txtMaestroId.Text = dr["MaestroId"].ToString();
                    this.txtMaestro.Text = dr["Maestro"].ToString();
                    editID = Convert.ToInt32 (dr["MaestroId"]);
                }
                cls_Con.cn.Close();
                cmd.Dispose();
                dr.Close();
            }
            else
            {
                return;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            list_Data();
            lstv_Employee.Refresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            this.txt_Find.Focus();
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            if (this.rdo_id.Checked == true)
            {
                this.cls_Con.list_DataView("proctMaestroSearchId '" + this.txt_Find.Text.Trim() + "'", this.lstv_Employee);
            }
            else
                if (this.rdo_Name.Checked == true)
                {
                    this.cls_Con.list_DataView("proctMaestroSearchName '" + this.txt_Find.Text.Trim() + "'", this.lstv_Employee);
                }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            limpiar_forma();
            list_Data();
        }

        
    }


}
