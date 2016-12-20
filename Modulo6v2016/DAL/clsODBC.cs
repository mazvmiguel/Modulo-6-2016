using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
namespace Modulo6.DAL
{
    class clsODBC
    {
      //  public string str = "";//get the value for form what do Modify/Add

        /*================================================================
          * ***************************************************************/
        OleDbCommand cmdStock = new OleDbCommand();
        OleDbDataAdapter  daStock;
        //public static  OdbcDataReader drStock;
        /*================================================================
         * **************************************************************/

        public OleDbConnection cn = new OleDbConnection(@"Provider=SQLNCLI11;Data Source=(LocalDB)\MODULO62016;Database=MODULO62016;Integrated Security=SSPI");
        public SqlConnection cnsql = new SqlConnection(@"Server=(LocalDB)\MODULO62016;Database=MODULO62016;Trusted_Connection=True;");

        //public OleDbConnection cn = new OleDbConnection(@"Provider=SQLNCLI11;Data Source=SICH;Database=MODULO_6X;Integrated Security=SSPI");
        //public SqlConnection cnsql = new SqlConnection(@"Server=SICH;Database=MODULO_6X;Trusted_Connection=True;");

        public void connCheck()
        {

            try
            {

                
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        public void connSQLCheck()
        {

            try
            {


                if (cnsql.State == ConnectionState.Open)
                {
                    cnsql.Close();
                }
                cnsql.Open();


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        public void dataGridFill(string strQry, DataGridView dGV, string strTable)
        {
            try
            {


                connCheck();
                DataSet ds = new DataSet();
                ds.Clear();
                cmdStock = new OleDbCommand();
                cmdStock.Connection = cn;
                cmdStock.CommandText = strQry;
                daStock = new OleDbDataAdapter (strQry, cn);
                daStock.Fill(ds, strTable);
                dGV.DataSource = ds.Tables[strTable];
                cn.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }

        }
        public void cmdOpen(OleDbCommand  cmdFunction)
        {

            connCheck();
            cmdFunction.Connection = cn;

        }
      
        public void cmdSQLOpen(SqlCommand cmdFunction)
        {

            connSQLCheck();
            cmdFunction.Connection = cnsql;

        }

        public void cmdClose(OleDbCommand cmdFunction)
        {

            cmdFunction.ExecuteNonQuery();
            cmdFunction.Parameters.Clear();
            cmdFunction.Connection.Close();
            cn.Close();

        }


        public void cmdSQLClose(SqlCommand cmdFunction)
        {

            cmdFunction.ExecuteNonQuery();
            cmdFunction.Parameters.Clear();
            cmdFunction.Connection.Close();
            cnsql.Close();

        }


        public void comboFill(ComboBox cmb, string strSQL, string dTable, string dDisplay, string dValue)
        {
            try
            {
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                //OleDbCommand cmd = new OleDbCommand();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, cn);
                da.Fill(ds, dTable);
                cmb.DataSource = ds.Tables[dTable].DefaultView;
                cmb.DisplayMember = dDisplay;
                cmb.ValueMember = dValue;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
        public void listboxfill(ListBox lstbx, string strSQL, string dTable, string dDisplay, string dValue)
        {
            try
            {
                
                //OleDbCommand cmd = new OleDbCommand();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, cn);
                da.Fill(ds, dTable);
                lstbx.DataSource = ds.Tables[dTable].DefaultView;
                lstbx.DisplayMember = dDisplay;
                lstbx.ValueMember = dValue;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        public void chklistfill( CheckedListBox lstbx, string strSQL, string dTable, string dDisplay, string dValue)
        {
            try
            {

                //OleDbCommand cmd = new OleDbCommand();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, cn);
                da.Fill(ds, dTable);
                lstbx.DataSource = ds.Tables[dTable].DefaultView;
                lstbx.DisplayMember = dDisplay;
                lstbx.ValueMember = dValue;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        public  void list_DataView(string strSQL, ListView myList)
        {
            myList.Items.Clear();
            try
            {
                OleDbCommand cmd = new OleDbCommand(strSQL, cn);
                cn.Open();
                OleDbDataReader  dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem lItem = new ListViewItem(dr[0].ToString());
                    for (int i = 1; i <= dr.FieldCount - 1; i++)
                    {
                        lItem.SubItems.Add(dr[i].ToString());
                    }
                    myList.Items.Add(lItem);
                    int rCount = myList.Items.Count;
                    if (rCount % 2 == 1)
                    {
                        //lItem.BackColor = Color.WhiteSmoke;
                        lItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(189))))); 
                    }
                    else
                    {
                        lItem.BackColor = Color.White;
                    }
                }
                cn.Close();
                cmd.Dispose();
                dr.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
        public void textClear(Form frm)
        {
            foreach (Control ctl in frm.Controls)
            {
                if (ctl is TextBox)
                    ctl.Text = "";
            }
        }

    }
}
