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
    public partial class frmGrupo : Form
    {
        public frmGrupo()
        {
            InitializeComponent();
        }
        public string str, strEdit;
        DAL.clsODBC cls_Con = new Modulo6.DAL.clsODBC();
        OleDbCommand cmdForm = new OleDbCommand();
        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        private void frmStudent_Load(object sender, EventArgs e)
        {
            this.panel3.Visible = false;// hide the search panel 
            // =============== Load Tools ==================
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
            // =========================================

            tab_Index();
            limpiar_forma();
            list_Load();

        }
        private void list_Load()
        {
            cls_Con.list_DataView("proctGrupoList", this.lstv_Student);
        }
        private void tab_Index()
        {
            this.txtGrupoId.TabIndex = 0;
            this.txtGrupo.TabIndex = 1;
        }

      


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            limpiar_forma();
            list_Load();
        }



        private void btn_Add_Click_1(object sender, EventArgs e)
        {

            clsGrupo Grupo = new clsGrupo();
            Grupo.Grupo = txtGrupo.Text.Trim();
            Grupo.GrupoId = txtGrupoId.Text.Trim();
            Grupo.Guardar();
            limpiar_forma();
            list_Load();

        }

        private void limpiar_forma()
        {
            this.txtGrupoId.Text = "";
            this.txtGrupo.Text = "";
            this.txtGrupoId.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            limpiar_forma();
            list_Load();
        }




        private void com_cName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Disable typing on combo Box
            e.Handled = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = true;
            this.txt_Find.Focus();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel3.Visible = false;
        }


        
        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            limpiar_forma();
            list_Load();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            clsGrupo Grupo = new clsGrupo();
            Grupo.Grupo = txtGrupo.Text.Trim();
            Grupo.GrupoId = txtGrupoId.Text.Trim();
            Grupo.Guardar();
            limpiar_forma();
            list_Load();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            clsGrupo Grupo = new clsGrupo();
            Grupo.Grupo = txtGrupo.Text.Trim();
            Grupo.GrupoId = txtGrupoId.Text.Trim();
            Grupo.Borrar();
            limpiar_forma();
            list_Load();
        }


        private void txt_Find_TextChanged(object sender, EventArgs e)
        {

            this.cls_Con.list_DataView("select GrupoId, Grupo from tGrupo where  Grupo Like '%" + this.txt_Find.Text.Trim() + "%'  ORDER BY Grupo", this.lstv_Student);
        }

        private void lstv_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            
                 this.txt_Rollno.Text = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[1].Text.Trim());
                 this.txt_Sname.Text = (this.lstv_Student .Items [lstv_Student .FocusedItem .Index ].SubItems [2].Text.Trim ());

                 this.com_cName.SelectedText = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[3].Text.Trim());
                 this.txtAddress .Text = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[4].Text.Trim());
                 this.txtContact.Text  = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[5].Text.Trim());
                 this.txt_Fname .Text  = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[6].Text.Trim());
                 this.txtAge .Text = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[7].Text.Trim());
                 dp_Student.Value  = Convert.ToDateTime (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[8].Text.Trim());
                 this.com_Sex .Text = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[9].Text.Trim());
                 this.txtRemarks.Text =  (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[10].Text.Trim());*/

            if (str == "Modificando")
            {
                limpiar_forma();

                cls_Con.connCheck();
                OleDbCommand cmd = new OleDbCommand("proctGrupoSelect '" + (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[0].Text.Trim()) + "'", cls_Con.cn);

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    strEdit = dr["GrupoId"].ToString();
                    txtGrupoId.Text = dr["GrupoId"].ToString();
                    txtGrupo.Text = dr["Grupo"].ToString();


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




    }


        
        //*CODIGO QUE SOLO PRESIONA NUMEROS PUEDE AYUDAR*
        //private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //    base.OnKeyPress(e);
        //}

       
    }
