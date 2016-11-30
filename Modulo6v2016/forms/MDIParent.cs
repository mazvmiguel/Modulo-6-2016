using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Modulo6._forms
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }
        DAL.cLsImageList cLsImage_List = new Modulo6.DAL.cLsImageList();
        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        

        

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {

           
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Periodos", 0, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Alumnos", 1, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Maestros", 2, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Materias", 3, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Grupos", 4, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Cursos", 7, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Claves", 9, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Evaluaciones", 10, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Calidad de Evaluaciones", 11, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Cargas Masivas", 8, i64x64);
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts, "Salir", 5, i64x64);

            
            //Contents For Report List
            Modulo6.DAL.cLsImageList.SetListView(lvShortcuts2, "Reporte de Alumnos", 6, this.i64x64);
           
           


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lvShortcuts_DoubleClick(object sender, EventArgs e)
        {
            switch (lvShortcuts.Items[lvShortcuts.FocusedItem.Index].SubItems[0].Text)
            {
                case "Periodos":
                    //frmQPeriodo frm_QPeriodo = new frmQPeriodo();
                    //frm_QPeriodo.Show();
                    frmPeriodo Periodo = new frmPeriodo();
                    Periodo.str = "Modificando";
                    Periodo.Show();
                    break;
                case "Alumnos":
                    //frmQstudent frm_Qstudent = new frmQstudent();
                    //frm_Qstudent.Show();
                    frmAlumno Alumno = new frmAlumno();
                    Alumno.str = "Modificando";
                    Alumno.Show();

                    break;

                case "Materias":
                    //frmQMateria frm_QMateria = new frmQMateria();
                    //frm_QMateria.Show();
                    frmMateria Materia = new frmMateria();
                    Materia.str = "Modificando";
                    Materia.Show();
                    break;

                case "Maestros":
                    //frmQMaestro frm_qMas = new frmQMaestro();
                    //frm_qMas.Show ();
                    frmMaestro Maestro = new frmMaestro();
                    Maestro.str = "Modificando";
                    Maestro.Show();
                    break;

                case "Grupos":
                    //frmQGrupo frm_qGru = new frmQGrupo();
                    //frm_qGru.Show();
                    frmGrupo Grupo = new frmGrupo();
                    Grupo.str = "Modificando";
                    Grupo.Show();
                    break;

                case "Cursos":
                    //frmQCurso frm_qcur = new frmQCurso();
                    //frm_qcur.Show();
                    frmCurso Curso = new frmCurso();
                    Curso.str = "Modificando";
                    Curso.Show();
                    break;

                case "Cargas Masivas":
                    frmImportacion frm_imp = new frmImportacion();
                    frm_imp.Show();

                    break;



                case "Salir":
                    
                    DialogResult ret;
                    ret = MessageBox.Show("Desea Salir?", "Salir".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (ret == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        return;
                    }
                    break;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAboutUs frm_Abouus = new frmAboutUs();
            frm_Abouus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();
            
        }

        private void MDIParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
