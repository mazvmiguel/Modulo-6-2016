using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Modulo6._forms
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        DAL.clsODBC cls_ODBC=new Modulo6.DAL.clsODBC() ;
        _forms.MDIParent mdi_Parent = new MDIParent();
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            this.com_uName.Focus();
            index_Load();
            setUserName();
            
        }
        #region <=== Index Region ====>
        private void index_Load()
        {
            this.com_uName.TabIndex = 0;
            this.txtPass.TabIndex = 1;
            this.btn_Login.TabIndex = 2;
            this.button2.TabIndex = 3;
            
        }
        #endregion

        #region <=== Add Users in ComboBox ===>
        private void setUserName()
        {

            try
            {
                if (cls_ODBC.cn.State == ConnectionState.Open)
                {
                    cls_ODBC.cn.Close();
                   
                }
                
                cls_ODBC.cn.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter("select u_id from user_", cls_ODBC.cn);
                da.Fill(ds, "user_");                
                this.com_uName.DataSource = ds.Tables["user_"];                
                this.com_uName.DisplayMember = "u_id";
                this.com_uName.ValueMember = "u_id";
                cls_ODBC.cn.Close();

                cls_ODBC.comboFill(this.cmbPeriodo, "select PeriodoId,Periodo from tPeriodo order by 2", "tPeriodo", "Periodo", "PeriodoId");

                

            }



            catch (Exception exp)
            {
                MessageBox.Show(exp.Message );
            }
        }
        #endregion

        
        #region <=== Check Valid User ===>
private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {

                if(cmbPeriodo.SelectedIndex<0)
                {

                    MessageBox.Show("Debe seleccionar un Periodo", "Periodo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                OleDbCommand  cmdlogin = new OleDbCommand("select * from user_ where u_id='" + this.com_uName .SelectedValue + "' and pw='" + this.txtPass .Text.Trim() + "'", this.cls_ODBC .cn);
                if (cls_ODBC.cn.State == ConnectionState.Open)
                {
                    cls_ODBC.cn.Close();
                }
                cls_ODBC.cn.Open();
               OleDbDataReader  drpassword = cmdlogin.ExecuteReader();
                if (drpassword.Read())
                {

                    Program.Usuario = com_uName.SelectedValue.ToString();
                    Program.PeriodoTrabajoId = cmbPeriodo.SelectedValue.ToString();
                    Program.UsuarioNombre = drpassword["u_name"].ToString();
                    Program.PerfilId= Int16.Parse(drpassword["perfilid"].ToString());

                    cls_ODBC.cn.Close();
                    drpassword.Close();
                    cmdlogin.Dispose();
                    this.Dispose(true);

                    mdi_Parent.Show();                    
                }
                else
                {
                    MessageBox.Show("Usuario or Password no valido", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message );
            }
        }


        #endregion
    }
    }
