using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.IO;
using Modulo6.BUL;
using Modulo6.DAL;

namespace Modulo6._forms

{
    public partial class frmImportacion : Form
    {
        public frmImportacion()
        {
            InitializeComponent();
           
         }

        public string EntidadACargar = "";
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private int rowCount;
         private string[] columnafuente;
        private string[] columnadestino;

        DAL.cls_myFunctions clsmyFunction = new Modulo6.DAL.cls_myFunctions();

        private string fileCSV;     //Nombre de Archivo Completo
        private string dirCSV;      //Directorio del Archivo
        private string fileNevCSV;  //Nombre del Archivo con extension

        public string FileNevCSV    //name (with extension) of file to import - property
        {
            get { return fileNevCSV; }
            set { fileNevCSV = value; }
        }

        private string strFormat;   //CSV CaracterSeparador
        private string strEncoding; //Codificacion


        static T[] Redim<T>(T[] arr, bool preserved)
        {
            int arrLength = arr.Length;
            T[] arrRedimed = new T[arrLength + 1];
            if (preserved)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    arrRedimed[i] = arr[i];
                }
            }
            return arrRedimed;
        }
           

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCSV = new OpenFileDialog();

            openFileDialogCSV.InitialDirectory = Application.ExecutablePath.ToString();

            if (this.rdbTexto.Checked ==true )
            {
                openFileDialogCSV.Filter = "CSV Archivos(*.csv)|*.csv|TXT Archivos(*.txt)|*.txt";
            }
            if (this.rdbXls.Checked == true)
            {
                openFileDialogCSV.Filter = "XLS Archivos(*.xls)|*.xls";
            }
            openFileDialogCSV.FilterIndex = 1;
            openFileDialogCSV.RestoreDirectory = true;

            if (openFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                this.txtArchivoaImportar.Text = openFileDialogCSV.FileName.ToString();
            }



        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {

            if (this.rdbTexto.Checked)
            {
                VistaPrevia(500);
            }
            if (this.rdbXls.Checked)
            {
                VistaPreviaXls(500);
            }



        }
        private void VistaPreviaXls(int TopRegistros)
        {
            try
            {
              
                this.dgvPrevio.DataSource = CargaXLS(500);
                this.dgvPrevio.DataMember = "xls";
                ColumnasFuente();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error - Carga Previa Xls ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Carga en el Data Grid.
      */

        private void VistaPrevia(int TopRegistros)
        {
            try
            {
                // select format, encoding, an write the schema file
                Formato();
                Codificacion();
                Esquema();

                // loads the first 500 rows from CSV file, and fills the
                // DataGridView control.
                this.dgvPrevio.DataSource = CargaCSV(500);
                this.dgvPrevio.DataMember = "csv";
                ColumnasFuente();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error - Carga Previa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()
        {
            try
            {

                if (rdbPuntoComa.Checked)
                {
                    strFormat = "Delimited(;)";
                }
                else if (rdbTab.Checked)
                {
                    strFormat = "TabDelimited";
                }
                else if (rdbOtro.Checked)
                {
                    strFormat = "Delimited(" + txtOtro.Text.Trim() + ")";
                }
                else
                {
                    strFormat = "Delimited(;)";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Formato");
            }
            finally
            {
            }
        }

        private void Codificacion()
        {
            try
            {

                if (rdbAnsi.Checked)
                {
                    strEncoding = "ANSI";
                }
                else if (rdbUnicode.Checked)
                {
                    strEncoding = "Unicode";
                }
                else if (rdbOEM.Checked)
                {
                    strEncoding = "OEM";
                }
                else
                {
                    strEncoding = "ANSI";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Codificacion");
            }
            finally
            {
            }
        }
        private void Esquema()
        {
            try
            {
                FileStream fsOutput = new FileStream(this.dirCSV + "\\schema.ini", FileMode.Create, FileAccess.Write);
                StreamWriter srOutput = new StreamWriter(fsOutput);
                string s1, s2, s3, s4, s5;

                s1 = "[" + this.FileNevCSV + "]";
                s2 = "ColNameHeader=" + chkPrimeraFila.Checked.ToString();
                s3 = "Format=" + this.strFormat;
                s4 = "MaxScanRows=25";
                s5 = "CharacterSet=" + this.strEncoding;

                srOutput.WriteLine(s1.ToString() + "\r\n" + s2.ToString() + "\r\n" + s3.ToString() + "\r\n" + s4.ToString() + "\r\n" + s5.ToString());
                srOutput.Close();
                fsOutput.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Esquema");
            }
            finally
            { }
        }

        public DataSet CargaXLS(int numberOfRows)
        {
            DataSet ds = new DataSet();
            try
            {

                string filePath = fileCSV;
                string extension = Path.GetExtension(filePath);
                string header = chkPrimeraFila.Checked ? "YES" : "NO";
                string conStr, sheetName;

                conStr = string.Empty;
                switch (extension)
                {

                    case ".xls": //Excel 97-03
                        conStr = string.Format(Excel03ConString, filePath, header);
                        break;

                    case ".xlsx": //Excel 07
                        conStr = string.Format(Excel07ConString, filePath, header);
                        break;
                }

                //Obtener el nombre de la primera hoja
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }

                //Leer Datos de la Primera Hoja

                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            DataTable dt = new DataTable();
                            if (numberOfRows > 0)
                            {
                                cmd.CommandText = "SELECT TOP " + numberOfRows.ToString() + " * From [" + sheetName + "]";
                            }
                            else
                            {
                                cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            }

                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();
                            //Populate Data Set.
                            dt.TableName = "xls";
                            ds.Tables.Add(dt);


                        }
                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error - Carga Previa Xls", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
        }
      
        public DataSet CargaCSV(int numberOfRows)
        {
            DataSet ds = new DataSet();
            try
            {
                // Creates and opens an ODBC connection
                string strConnString = "Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=" + this.dirCSV.Trim() + ";Extensions=asc,csv,tab,txt;Persist Security Info=False";
                string sql_select;
                OdbcConnection conn;
                conn = new OdbcConnection(strConnString.Trim());
                conn.Open();

                //Creates the select command text
                if (numberOfRows == -1)
                {
                    sql_select = "select * from [" + this.FileNevCSV.Trim() + "]";
                }
                else
                {
                    sql_select = "select top " + numberOfRows + " * from [" + this.FileNevCSV.Trim() + "]";
                }

                //Creates the data adapter
                OdbcDataAdapter obj_oledb_da = new OdbcDataAdapter(sql_select, conn);

                //Fills dataset with the records from CSV file
                obj_oledb_da.Fill(ds, "csv");

                //closes the connection
                conn.Close();
            }
            catch (Exception e) //Error
            {
                MessageBox.Show(e.Message, "Error - CargaCSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
        }

        private void txtArchivoaImportar_TextChanged(object sender, EventArgs e)
        {
            // full file name
            this.fileCSV = this.txtArchivoaImportar.Text;

            // creates a System.IO.FileInfo object to retrive information from selected file.
            System.IO.FileInfo fi = new System.IO.FileInfo(this.fileCSV);
            // retrives directory
            this.dirCSV = fi.DirectoryName.ToString();
            // retrives file name with extension
            this.FileNevCSV = fi.Name.ToString();

            // database table name
            //this.txtTableName.Text = fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length).Replace(" ", "_");
        }
        private void ColumnasFuente()
        {
            int columnas = 0;
            columnas = dgvPrevio.Columns.Count;

            dgvColumnas.Rows.Clear();
            dgcOrigen.Items.Clear();
            dgcOrigen.Items.Add("<Omitir>");
            for (int i = 0; i < columnas; i++)
            {
                dgcOrigen.Items.Add(dgvPrevio.Columns[i].HeaderText);
            }

            for (int i = 0; i < columnas; i++)
            {
                dgvColumnas.Rows.Add(dgvPrevio.Columns[i].HeaderText);
            }

        }

        private void dgvPrevio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            EntidadACargar = (string)cmbEntidades.SelectedItem;
            lblEntidad.Text = EntidadACargar;
            ColumnasDestino_llenar();
        }

        private void ColumnasDestino_llenar()
        {

           dgcDestino.Items.Clear();

            switch (EntidadACargar)
            {

                case "Periodos":
                    dgcDestino.Items.Add("<Omitir>");
                    dgcDestino.Items.Add("PeriodoId");
                    dgcDestino.Items.Add("Periodo");
                    dgcDestino.Items.Add("FechaInicio");
                    dgcDestino.Items.Add("FechaFin");
                    dgcDestino.Items.Add("PlanId");

                    break;

                case "Alumnos":
                    dgcDestino.Items.Add("<Omitir>");
                    dgcDestino.Items.Add("Matricula");
                    dgcDestino.Items.Add("Nombre");
                    break;

                case "Maestros":
                    dgcDestino.Items.Add("<Omitir>");
                    dgcDestino.Items.Add("MaestroId");
                    dgcDestino.Items.Add("MaestroNombre");
                    break;
                case "Grupos":
                    dgcDestino.Items.Add("<Omitir>");
                    dgcDestino.Items.Add("GrupoId");
                    dgcDestino.Items.Add("GrupoNombre");
                    break;
                case "Materias":
                    dgcDestino.Items.Add("<Omitir>");
                    dgcDestino.Items.Add("MateriaId");
                    dgcDestino.Items.Add("MateriaNombre");
                    dgcDestino.Items.Add("PlanId");
                    break;
                case "Cursos":
                    dgcDestino.Items.Add("<Omitir>");
                    dgcDestino.Items.Add("Curso Id");
                    dgcDestino.Items.Add("Maestro Id");
                    dgcDestino.Items.Add("Materia Id");
                    dgcDestino.Items.Add("Grupo Id");
                    break;
                case "Claves":
                    dgcDestino.Items.Add("<Omitir>");
                    dgcDestino.Items.Add("ClaveId");
                    dgcDestino.Items.Add("MateriaId");
                    dgcDestino.Items.Add("PreguntasCantidad");
                    dgcDestino.Items.Add("DistractoresCantidad");
                    dgcDestino.Items.Add("Campo Inicial de Respuestas");
                    dgcDestino.Items.Add("Campo Final de Respuestas");
                    break;
                case "Evaluaciones":
                    dgcDestino.Items.Add("<Omitir>");
                    dgcDestino.Items.Add("ClaveId");
                    dgcDestino.Items.Add("GrupoId");
                    dgcDestino.Items.Add("Matricula");
                    dgcDestino.Items.Add("Campo Inicial de Respuestas");
                    dgcDestino.Items.Add("Campo Final de Respuestas");

                    //for (int i = 1; i <= 100; i++)
                    //{
                    //    dgcDestino.Items.Add("Respuesta " + i.ToString());
                    //}
                    //break;
                    break;


            }

        }

        private void dgvColumnas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvColumnas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            //dejar esta linea en blanco... se necesita para capturar errores al repopular el combo de entidades
        }


        //validacion por tipo de entidad
        private void button2_Click(object sender, EventArgs e)
        {
            if ( validar())
            { 
            guardar();
            }
        }
       
        private bool validar()
        {
            bool validacion = true;
            columnafuente =new string[1];
            columnadestino = new string[1];
            columnafuente[0] = "columnafuente";
            columnadestino[0] = "columnadestino";

            int i = 0;
            foreach (DataGridViewRow dr in dgvColumnas.Rows)
            {
                string colfuente = dr.Cells[0].Value.ToString();
                string coldestino = "";
                if (dr.Cells[1].Value == null)
                {

                    coldestino = "";

                }
                else
                {
                    coldestino = dr.Cells[1].Value.ToString();
                }

                if (coldestino.Trim().Length > 0 && coldestino != "<Omitir>")
                {
                    i = i + 1;
                    Array.Resize(ref columnafuente, columnafuente.Length + 1);
                    columnafuente[i] = colfuente;
                    Array.Resize(ref columnadestino, columnadestino.Length + 1);
                    columnadestino[i] = coldestino;
                }

            }

            // deben de haber N campos +1 encabezado
            int camposaelegir = 0;
            switch (EntidadACargar)
            {
                case "Alumnos":
                    camposaelegir = 3;
                    break;
                case "Maestros":
                    camposaelegir = 3;
                    break;
                case "Materias":
                    camposaelegir = 4;
                    break;
                case "Grupos":
                    camposaelegir = 3;
                    break;
                case "Evaluaciones":
                    camposaelegir = 6;
                    break;
                case "Claves":
                    camposaelegir = 7;
                    break;

            }

            if (columnadestino.Length == camposaelegir) //deben de haber N campos + 1 encabezado
            {

                if (columnadestino.Length != columnadestino.Distinct().Count())
                {
                    clsmyFunction.setMessageBox("Eligio un campo mas de una vez", 3);
                    validacion = false; //hay duplicados
                }
                else
                {
                    validacion = true;
                }
            }
            else
            {
                clsmyFunction.setMessageBox("No sen han elegido todos los campos destino", 3);
                validacion = false;
            }
           
            return validacion;

        }
        
        private void guardar()
        {
            try
            {
                if (fileCheck())
                {
                    DataSet ds =new DataSet();
                    if (this.rdbTexto.Checked)
                    {
                        
                        ds = CargaCSV(-1);
                    }
                    if (this.rdbXls.Checked)
                    {
                        
                        ds = CargaXLS(-1);
                    }
                    // gets the number of rows
                    this.rowCount = ds.Tables[0].Rows.Count;
                    //emparentando la nueva tabla con las columnas fuentes y destinos
                    DataSet dsnew = new DataSet();
                    dsnew.Tables.Add("carga");
                    //agregando los campos de la nueva tabla

                    //se realiza un ciclo especial si la entidad es una clave o evaluacion.
                    // esto se hace para ver el campo inicial o campo final
                     
                    switch (EntidadACargar)
                    {
                       case "Evaluaciones":
                       case "Claves":
                            string columnainicialrespuestas = columnafuente[Array.IndexOf(columnadestino, "Campo Inicial de Respuestas")];
                            string columnafinalrespuestas = columnafuente[Array.IndexOf(columnadestino, "Campo Final de Respuestas")];

                            if (ds.Tables[0].Columns[columnainicialrespuestas].Ordinal > ds.Tables[0].Columns[columnafinalrespuestas].Ordinal)
                            {
                                clsmyFunction.setMessageBox("La columna final de respuestas debe ser una columna igual o posterior a la inicial", 3);
                                return;
                            }

                            DataColumn Soluciones = new DataColumn();
                            Soluciones.DataType = System.Type.GetType("System.String");
                            Soluciones.ColumnName = "SolRConcentrado";
                            Soluciones.Expression = "";

                            if (ds.Tables[0].Columns[columnainicialrespuestas].Ordinal == ds.Tables[0].Columns[columnafinalrespuestas].Ordinal)
                                {
                                // es un solo campo para respuestas
                                Soluciones.Expression = ds.Tables[0].Columns[columnainicialrespuestas].ColumnName;

                            }
                                else
                                {
                                // son varios campos para las respuestas utilizo una columna derivada o
                                // del tipo expresion para concatenarlas

                                    for (int i = ds.Tables[0].Columns[columnainicialrespuestas].Ordinal; i <= ds.Tables[0].Columns[columnafinalrespuestas].Ordinal; i++)
                                    {
                                        if (Soluciones.Expression.Length == 0)
                                        {
                                        Soluciones.Expression = "ISNULL(" + ds.Tables[0].Columns[i].ColumnName +",' ')";
                                        }
                                        else
                                        {
                                        Soluciones.Expression = Soluciones.Expression + "+" + "ISNULL(" + ds.Tables[0].Columns[i].ColumnName + ",' ')";
                                        }
                                    }

                                   }

                            //agregar el campo de Soluciones

                            ds.Tables[0].Columns.Add(Soluciones);

                            Array.Resize(ref columnafuente, columnafuente.Length + 1);
                            columnafuente[columnafuente.Length-1] = "SolRConcentrado";
                            Array.Resize(ref columnadestino, columnadestino.Length + 1);
                            columnadestino[columnadestino.Length-1] = "SolRConcentrado";

                            break;
                          

                    }

                    


                    for (int i = 1; i<=columnadestino.Length-1; i++ )
                    {
                        if (columnadestino[i]=="Campo Inicial de Respuestas" || columnadestino[i] == "Campo Final de Respuestas") 
                        {
                            //omito los campos de control
                        }
                        else
                        {
                            dsnew.Tables["carga"].Columns.Add(columnadestino[i]);
                        }
                        
                    }

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        
                        DataRow rowdestino = dsnew.Tables["carga"].Rows.Add(); 
                        
                        for (int i = 1; i <= columnadestino.Length-1; i++)
                        {
                            if (columnadestino[i] == "Campo Inicial de Respuestas" || columnadestino[i] == "Campo Final de Respuestas")
                            {
                                //omito los campos de control
                            }
                            else
                            { 

                            rowdestino[columnadestino[i]] = row[columnafuente[i]] ;

                            }
                        }
                        
                    }
                    //
                    //cargamos
                    switch (EntidadACargar)
                    {
                        case "Alumnos":
                            clsAlumno alumno = new clsAlumno();
                            alumno.CargaMasiva(dsnew);
                            break;
                        case "Maestros":
                            clsMaestro Maestro = new clsMaestro();
                            Maestro.CargaMasiva(dsnew);
                            break;
                        case "Materias":
                            clsMateria Materia= new clsMateria();
                            Materia.CargaMasiva(dsnew);
                            break;
                        case "Grupos":
                            clsGrupo Grupo = new clsGrupo();
                            Grupo.CargaMasiva(dsnew);
                            break;
                        case "Claves":
                            clsClave Clave= new clsClave();
                            Clave.CargaMasiva(dsnew);
                            break;
                        case "Evaluaciones":
                            clsEvaluacion Evaluacion = new clsEvaluacion();
                            Evaluacion.CargaMasiva(dsnew);
                            break;


                    }
                   
                   
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error - SaveToDatabase_withDataSet. " + e.Message , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool fileCheck()
        {
            if ((fileCSV == "") || (fileCSV == null) || (dirCSV == "") || (dirCSV == null) || (FileNevCSV == "") || (FileNevCSV == null))
            {
                MessageBox.Show("Seleccione un archivo o muestre prevista para cargar primero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmImportacion_Load(object sender, EventArgs e)
        {
            if (EntidadACargar.Length > 0)
            {
                cmbEntidades.Text = EntidadACargar;
                cmbEntidades.Enabled = false;
                lblEntidad.Text = EntidadACargar;
            }

        }

        private void rdbTexto_CheckedChanged(object sender, EventArgs e)
        {
            fileCSV = "";
        }

        private void rdbXls_CheckedChanged(object sender, EventArgs e)
        {
            fileCSV = "";
        }
    }
}
