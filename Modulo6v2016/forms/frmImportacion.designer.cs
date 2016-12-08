namespace Modulo6._forms
{
    partial class frmImportacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbTexto = new System.Windows.Forms.RadioButton();
            this.rdbXls = new System.Windows.Forms.RadioButton();
            this.txtArchivoaImportar = new System.Windows.Forms.TextBox();
            this.dgvPrevio = new System.Windows.Forms.DataGridView();
            this.cmbEntidades = new System.Windows.Forms.ComboBox();
            this.chkPrimeraFila = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.dgvColumnas = new System.Windows.Forms.DataGridView();
            this.dgcOrigen = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcDestino = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.rdbOtro = new System.Windows.Forms.RadioButton();
            this.rdbTab = new System.Windows.Forms.RadioButton();
            this.rdbPuntoComa = new System.Windows.Forms.RadioButton();
            this.gpbEncoding = new System.Windows.Forms.GroupBox();
            this.rdbOEM = new System.Windows.Forms.RadioButton();
            this.rdbUnicode = new System.Windows.Forms.RadioButton();
            this.rdbAnsi = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImportar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnParametrosGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbEncoding.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbTexto
            // 
            this.rdbTexto.AutoSize = true;
            this.rdbTexto.Checked = true;
            this.rdbTexto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTexto.Location = new System.Drawing.Point(6, 13);
            this.rdbTexto.Name = "rdbTexto";
            this.rdbTexto.Size = new System.Drawing.Size(193, 17);
            this.rdbTexto.TabIndex = 0;
            this.rdbTexto.TabStop = true;
            this.rdbTexto.Text = "Archito de Texto (*.txt;*.cvs)";
            this.rdbTexto.UseVisualStyleBackColor = true;
            this.rdbTexto.CheckedChanged += new System.EventHandler(this.rdbTexto_CheckedChanged);
            // 
            // rdbXls
            // 
            this.rdbXls.AutoSize = true;
            this.rdbXls.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXls.Location = new System.Drawing.Point(211, 13);
            this.rdbXls.Name = "rdbXls";
            this.rdbXls.Size = new System.Drawing.Size(161, 17);
            this.rdbXls.TabIndex = 1;
            this.rdbXls.Text = "Archivo de Excel (*.xls)";
            this.rdbXls.UseVisualStyleBackColor = true;
            this.rdbXls.CheckedChanged += new System.EventHandler(this.rdbXls_CheckedChanged);
            // 
            // txtArchivoaImportar
            // 
            this.txtArchivoaImportar.Location = new System.Drawing.Point(6, 36);
            this.txtArchivoaImportar.Name = "txtArchivoaImportar";
            this.txtArchivoaImportar.ReadOnly = true;
            this.txtArchivoaImportar.Size = new System.Drawing.Size(502, 21);
            this.txtArchivoaImportar.TabIndex = 2;
            this.txtArchivoaImportar.TextChanged += new System.EventHandler(this.txtArchivoaImportar_TextChanged);
            // 
            // dgvPrevio
            // 
            this.dgvPrevio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevio.Location = new System.Drawing.Point(3, 158);
            this.dgvPrevio.Name = "dgvPrevio";
            this.dgvPrevio.Size = new System.Drawing.Size(633, 179);
            this.dgvPrevio.TabIndex = 3;
            this.dgvPrevio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrevio_CellContentClick);
            // 
            // cmbEntidades
            // 
            this.cmbEntidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntidades.FormattingEnabled = true;
            this.cmbEntidades.Items.AddRange(new object[] {
            "Periodos",
            "Alumnos",
            "Maestros",
            "Materias",
            "Grupos",
            "Cursos",
            "Claves",
            "Evaluaciones"});
            this.cmbEntidades.Location = new System.Drawing.Point(6, 30);
            this.cmbEntidades.Name = "cmbEntidades";
            this.cmbEntidades.Size = new System.Drawing.Size(206, 21);
            this.cmbEntidades.TabIndex = 4;
            this.cmbEntidades.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chkPrimeraFila
            // 
            this.chkPrimeraFila.AutoSize = true;
            this.chkPrimeraFila.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrimeraFila.Location = new System.Drawing.Point(272, 76);
            this.chkPrimeraFila.Name = "chkPrimeraFila";
            this.chkPrimeraFila.Size = new System.Drawing.Size(265, 17);
            this.chkPrimeraFila.TabIndex = 5;
            this.chkPrimeraFila.Text = "La primera fila tiene nombres de columna";
            this.chkPrimeraFila.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Entidad destino:";
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistaPrevia.Location = new System.Drawing.Point(6, 126);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(293, 23);
            this.btnVistaPrevia.TabIndex = 8;
            this.btnVistaPrevia.Text = "Vista previa de la carga (Primeros 500 registros)";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // dgvColumnas
            // 
            this.dgvColumnas.AllowUserToAddRows = false;
            this.dgvColumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumnas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcOrigen,
            this.dgcDestino});
            this.dgvColumnas.Location = new System.Drawing.Point(6, 66);
            this.dgvColumnas.Name = "dgvColumnas";
            this.dgvColumnas.Size = new System.Drawing.Size(633, 229);
            this.dgvColumnas.TabIndex = 9;
            this.dgvColumnas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColumnas_CellContentClick);
            this.dgvColumnas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvColumnas_DataError);
            // 
            // dgcOrigen
            // 
            this.dgcOrigen.HeaderText = "Columna Origen";
            this.dgcOrigen.Name = "dgcOrigen";
            this.dgcOrigen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcOrigen.ToolTipText = "Columna Origen";
            // 
            // dgcDestino
            // 
            this.dgcDestino.HeaderText = "Columna Destino";
            this.dgcDestino.Name = "dgcDestino";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 363);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSeleccionarArchivo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvPrevio);
            this.tabPage1.Controls.Add(this.rdbTexto);
            this.tabPage1.Controls.Add(this.btnVistaPrevia);
            this.tabPage1.Controls.Add(this.rdbXls);
            this.tabPage1.Controls.Add(this.txtArchivoaImportar);
            this.tabPage1.Controls.Add(this.chkPrimeraFila);
            this.tabPage1.Controls.Add(this.gpbEncoding);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Origen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(515, 36);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(124, 23);
            this.btnSeleccionarArchivo.TabIndex = 10;
            this.btnSeleccionarArchivo.Text = "Seleccionar Archivo";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOtro);
            this.groupBox1.Controls.Add(this.rdbOtro);
            this.groupBox1.Controls.Add(this.rdbTab);
            this.groupBox1.Controls.Add(this.rdbPuntoComa);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separador de Archivo de Texto";
            // 
            // txtOtro
            // 
            this.txtOtro.Location = new System.Drawing.Point(223, 16);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(31, 21);
            this.txtOtro.TabIndex = 3;
            // 
            // rdbOtro
            // 
            this.rdbOtro.AutoSize = true;
            this.rdbOtro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOtro.Location = new System.Drawing.Point(167, 19);
            this.rdbOtro.Name = "rdbOtro";
            this.rdbOtro.Size = new System.Drawing.Size(50, 17);
            this.rdbOtro.TabIndex = 2;
            this.rdbOtro.Text = "Otro";
            this.rdbOtro.UseVisualStyleBackColor = true;
            // 
            // rdbTab
            // 
            this.rdbTab.AutoSize = true;
            this.rdbTab.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTab.Location = new System.Drawing.Point(116, 19);
            this.rdbTab.Name = "rdbTab";
            this.rdbTab.Size = new System.Drawing.Size(45, 17);
            this.rdbTab.TabIndex = 1;
            this.rdbTab.Text = "Tab";
            this.rdbTab.UseVisualStyleBackColor = true;
            // 
            // rdbPuntoComa
            // 
            this.rdbPuntoComa.AutoSize = true;
            this.rdbPuntoComa.Checked = true;
            this.rdbPuntoComa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPuntoComa.Location = new System.Drawing.Point(4, 17);
            this.rdbPuntoComa.Name = "rdbPuntoComa";
            this.rdbPuntoComa.Size = new System.Drawing.Size(106, 17);
            this.rdbPuntoComa.TabIndex = 0;
            this.rdbPuntoComa.TabStop = true;
            this.rdbPuntoComa.Text = "Punto y Coma";
            this.rdbPuntoComa.UseVisualStyleBackColor = true;
            // 
            // gpbEncoding
            // 
            this.gpbEncoding.Controls.Add(this.rdbOEM);
            this.gpbEncoding.Controls.Add(this.rdbUnicode);
            this.gpbEncoding.Controls.Add(this.rdbAnsi);
            this.gpbEncoding.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEncoding.Location = new System.Drawing.Point(403, 65);
            this.gpbEncoding.Name = "gpbEncoding";
            this.gpbEncoding.Size = new System.Drawing.Size(236, 42);
            this.gpbEncoding.TabIndex = 11;
            this.gpbEncoding.TabStop = false;
            this.gpbEncoding.Text = "Codificacion";
            this.gpbEncoding.Visible = false;
            // 
            // rdbOEM
            // 
            this.rdbOEM.AutoSize = true;
            this.rdbOEM.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOEM.Location = new System.Drawing.Point(138, 19);
            this.rdbOEM.Name = "rdbOEM";
            this.rdbOEM.Size = new System.Drawing.Size(50, 17);
            this.rdbOEM.TabIndex = 2;
            this.rdbOEM.Text = "OEM";
            this.rdbOEM.UseVisualStyleBackColor = true;
            // 
            // rdbUnicode
            // 
            this.rdbUnicode.AutoSize = true;
            this.rdbUnicode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUnicode.Location = new System.Drawing.Point(62, 19);
            this.rdbUnicode.Name = "rdbUnicode";
            this.rdbUnicode.Size = new System.Drawing.Size(70, 17);
            this.rdbUnicode.TabIndex = 1;
            this.rdbUnicode.Text = "Unicode";
            this.rdbUnicode.UseVisualStyleBackColor = true;
            // 
            // rdbAnsi
            // 
            this.rdbAnsi.AutoSize = true;
            this.rdbAnsi.Checked = true;
            this.rdbAnsi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnsi.Location = new System.Drawing.Point(6, 19);
            this.rdbAnsi.Name = "rdbAnsi";
            this.rdbAnsi.Size = new System.Drawing.Size(54, 17);
            this.rdbAnsi.TabIndex = 0;
            this.rdbAnsi.TabStop = true;
            this.rdbAnsi.Text = "ANSI";
            this.rdbAnsi.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnParametrosGuardar);
            this.tabPage2.Controls.Add(this.btnImportar);
            this.tabPage2.Controls.Add(this.dgvColumnas);
            this.tabPage2.Controls.Add(this.cmbEntidades);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Destino";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(465, 301);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(174, 23);
            this.btnImportar.TabIndex = 10;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Modulo6.Properties.Resources.title_form;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblEntidad);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(10, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 44);
            this.panel3.TabIndex = 30;
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.lblEntidad.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEntidad.Location = new System.Drawing.Point(113, 21);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(78, 23);
            this.lblEntidad.TabIndex = 10;
            this.lblEntidad.Text = "Entidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(-2, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Importacion:";
            // 
            // btnParametrosGuardar
            // 
            this.btnParametrosGuardar.Location = new System.Drawing.Point(256, 301);
            this.btnParametrosGuardar.Name = "btnParametrosGuardar";
            this.btnParametrosGuardar.Size = new System.Drawing.Size(194, 23);
            this.btnParametrosGuardar.TabIndex = 11;
            this.btnParametrosGuardar.Text = "Guardar Parametros de Carga";
            this.btnParametrosGuardar.UseVisualStyleBackColor = true;
            this.btnParametrosGuardar.Click += new System.EventHandler(this.btnParametrosGuardar_Click);
            // 
            // frmImportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(672, 419);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmImportacion";
            this.Text = "Asistente para importación de datos";
            this.Load += new System.EventHandler(this.frmImportacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbEncoding.ResumeLayout(false);
            this.gpbEncoding.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTexto;
        private System.Windows.Forms.RadioButton rdbXls;
        private System.Windows.Forms.TextBox txtArchivoaImportar;
        private System.Windows.Forms.DataGridView dgvPrevio;
        private System.Windows.Forms.ComboBox cmbEntidades;
        private System.Windows.Forms.CheckBox chkPrimeraFila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.DataGridView dgvColumnas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.RadioButton rdbTab;
        private System.Windows.Forms.RadioButton rdbPuntoComa;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.GroupBox gpbEncoding;
        private System.Windows.Forms.RadioButton rdbOEM;
        private System.Windows.Forms.RadioButton rdbUnicode;
        private System.Windows.Forms.RadioButton rdbAnsi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcOrigen;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcDestino;
        private System.Windows.Forms.Button btnParametrosGuardar;
    }
}

