namespace Proyecto_Final.Forms
{
    partial class Crear_Materia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.Btn_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Semestre = new System.Windows.Forms.ComboBox();
            this.Gb_Acciones = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Dgv_Materias = new System.Windows.Forms.DataGridView();
            this.Gb_Datos.SuspendLayout();
            this.Gb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.Btn_Nombre);
            this.Gb_Datos.Controls.Add(this.Txt_Nombre);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.Controls.Add(this.Txt_Semestre);
            this.Gb_Datos.ForeColor = System.Drawing.Color.White;
            this.Gb_Datos.Location = new System.Drawing.Point(160, 306);
            this.Gb_Datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Datos.Size = new System.Drawing.Size(286, 116);
            this.Gb_Datos.TabIndex = 24;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos de la Materia ";
            // 
            // Btn_Nombre
            // 
            this.Btn_Nombre.AutoSize = true;
            this.Btn_Nombre.Location = new System.Drawing.Point(8, 28);
            this.Btn_Nombre.Name = "Btn_Nombre";
            this.Btn_Nombre.Size = new System.Drawing.Size(56, 16);
            this.Btn_Nombre.TabIndex = 0;
            this.Btn_Nombre.Text = "Nombre";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.Txt_Nombre.Location = new System.Drawing.Point(12, 46);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(146, 22);
            this.Txt_Nombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Semestre";
            // 
            // Txt_Semestre
            // 
            this.Txt_Semestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Txt_Semestre.ForeColor = System.Drawing.Color.White;
            this.Txt_Semestre.FormattingEnabled = true;
            this.Txt_Semestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Txt_Semestre.Location = new System.Drawing.Point(165, 46);
            this.Txt_Semestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Semestre.Name = "Txt_Semestre";
            this.Txt_Semestre.Size = new System.Drawing.Size(108, 24);
            this.Txt_Semestre.TabIndex = 8;
            // 
            // Gb_Acciones
            // 
            this.Gb_Acciones.Controls.Add(this.Btn_Cancelar);
            this.Gb_Acciones.Controls.Add(this.Btn_Nuevo);
            this.Gb_Acciones.Controls.Add(this.Btn_Eliminar);
            this.Gb_Acciones.Controls.Add(this.Btn_Agregar);
            this.Gb_Acciones.ForeColor = System.Drawing.Color.White;
            this.Gb_Acciones.Location = new System.Drawing.Point(468, 306);
            this.Gb_Acciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Acciones.Name = "Gb_Acciones";
            this.Gb_Acciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Acciones.Size = new System.Drawing.Size(220, 116);
            this.Gb_Acciones.TabIndex = 22;
            this.Gb_Acciones.TabStop = false;
            this.Gb_Acciones.Text = "Acciones";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Cancelar.Location = new System.Drawing.Point(110, 66);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Cancelar.TabIndex = 17;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Nuevo.Location = new System.Drawing.Point(5, 28);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(100, 34);
            this.Btn_Nuevo.TabIndex = 16;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Eliminar.Location = new System.Drawing.Point(5, 66);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Eliminar.TabIndex = 15;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Agregar.Location = new System.Drawing.Point(110, 27);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Agregar.TabIndex = 12;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Dgv_Materias
            // 
            this.Dgv_Materias.AllowUserToAddRows = false;
            this.Dgv_Materias.AllowUserToDeleteRows = false;
            this.Dgv_Materias.AllowUserToOrderColumns = true;
            this.Dgv_Materias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Materias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Materias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Materias.EnableHeadersVisualStyles = false;
            this.Dgv_Materias.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_Materias.Location = new System.Drawing.Point(12, 11);
            this.Dgv_Materias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Materias.Name = "Dgv_Materias";
            this.Dgv_Materias.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Materias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Materias.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Dgv_Materias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Materias.RowTemplate.Height = 28;
            this.Dgv_Materias.Size = new System.Drawing.Size(836, 242);
            this.Dgv_Materias.TabIndex = 25;
            // 
            // Crear_Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.Dgv_Materias);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.Gb_Acciones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Crear_Materia";
            this.Text = "Crear_Materia";
            this.Load += new System.EventHandler(this.Crear_Materia_Load);
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            this.Gb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.Label Btn_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Txt_Semestre;
        private System.Windows.Forms.GroupBox Gb_Acciones;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DataGridView Dgv_Materias;
    }
}