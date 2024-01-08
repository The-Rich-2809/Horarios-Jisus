namespace Proyecto_Final.Forms
{
    partial class Crear_Prof
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
            this.Btn_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CTxt_Turno = new System.Windows.Forms.ComboBox();
            this.CTxt_Semestre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Gb_Acciones = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Mod = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Txt_1Apellido = new System.Windows.Forms.TextBox();
            this.Txt_2Apellido = new System.Windows.Forms.TextBox();
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.Dgv_Profes = new System.Windows.Forms.DataGridView();
            this.Gb_Acciones.SuspendLayout();
            this.Gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Profes)).BeginInit();
            this.SuspendLayout();
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
            this.Txt_Nombre.Location = new System.Drawing.Point(12, 47);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(147, 22);
            this.Txt_Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turno";
            // 
            // CTxt_Turno
            // 
            this.CTxt_Turno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.CTxt_Turno.ForeColor = System.Drawing.Color.White;
            this.CTxt_Turno.FormattingEnabled = true;
            this.CTxt_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.CTxt_Turno.Location = new System.Drawing.Point(248, 102);
            this.CTxt_Turno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CTxt_Turno.Name = "CTxt_Turno";
            this.CTxt_Turno.Size = new System.Drawing.Size(108, 24);
            this.CTxt_Turno.TabIndex = 7;
            // 
            // CTxt_Semestre
            // 
            this.CTxt_Semestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.CTxt_Semestre.ForeColor = System.Drawing.Color.White;
            this.CTxt_Semestre.FormattingEnabled = true;
            this.CTxt_Semestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CTxt_Semestre.Location = new System.Drawing.Point(135, 102);
            this.CTxt_Semestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CTxt_Semestre.Name = "CTxt_Semestre";
            this.CTxt_Semestre.Size = new System.Drawing.Size(108, 24);
            this.CTxt_Semestre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Semestre";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Agregar.Location = new System.Drawing.Point(111, 27);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(100, 33);
            this.Btn_Agregar.TabIndex = 12;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Gb_Acciones
            // 
            this.Gb_Acciones.Controls.Add(this.Btn_Cancelar);
            this.Gb_Acciones.Controls.Add(this.Btn_Nuevo);
            this.Gb_Acciones.Controls.Add(this.Btn_Eliminar);
            this.Gb_Acciones.Controls.Add(this.Btn_Mod);
            this.Gb_Acciones.Controls.Add(this.Btn_Modificar);
            this.Gb_Acciones.Controls.Add(this.Btn_Agregar);
            this.Gb_Acciones.ForeColor = System.Drawing.Color.White;
            this.Gb_Acciones.Location = new System.Drawing.Point(559, 271);
            this.Gb_Acciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Acciones.Name = "Gb_Acciones";
            this.Gb_Acciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Acciones.Size = new System.Drawing.Size(220, 154);
            this.Gb_Acciones.TabIndex = 14;
            this.Gb_Acciones.TabStop = false;
            this.Gb_Acciones.Text = "Acciones";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Cancelar.Location = new System.Drawing.Point(111, 102);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 33);
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
            this.Btn_Nuevo.Size = new System.Drawing.Size(100, 33);
            this.Btn_Nuevo.TabIndex = 16;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Eliminar.Location = new System.Drawing.Point(5, 102);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(100, 33);
            this.Btn_Eliminar.TabIndex = 15;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Mod.Location = new System.Drawing.Point(111, 65);
            this.Btn_Mod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(100, 33);
            this.Btn_Mod.TabIndex = 14;
            this.Btn_Mod.Text = "Actualizar";
            this.Btn_Mod.UseVisualStyleBackColor = false;
            this.Btn_Mod.Click += new System.EventHandler(this.Btn_Mod_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Modificar.Location = new System.Drawing.Point(5, 65);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(100, 33);
            this.Btn_Modificar.TabIndex = 13;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Txt_1Apellido
            // 
            this.Txt_1Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Txt_1Apellido.ForeColor = System.Drawing.Color.White;
            this.Txt_1Apellido.Location = new System.Drawing.Point(164, 47);
            this.Txt_1Apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_1Apellido.Name = "Txt_1Apellido";
            this.Txt_1Apellido.Size = new System.Drawing.Size(147, 22);
            this.Txt_1Apellido.TabIndex = 15;
            // 
            // Txt_2Apellido
            // 
            this.Txt_2Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Txt_2Apellido.ForeColor = System.Drawing.Color.White;
            this.Txt_2Apellido.Location = new System.Drawing.Point(316, 47);
            this.Txt_2Apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_2Apellido.Name = "Txt_2Apellido";
            this.Txt_2Apellido.Size = new System.Drawing.Size(147, 22);
            this.Txt_2Apellido.TabIndex = 16;
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.CTxt_Turno);
            this.Gb_Datos.Controls.Add(this.Btn_Nombre);
            this.Gb_Datos.Controls.Add(this.Txt_2Apellido);
            this.Gb_Datos.Controls.Add(this.Txt_Nombre);
            this.Gb_Datos.Controls.Add(this.Txt_1Apellido);
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.label3);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.Controls.Add(this.label4);
            this.Gb_Datos.Controls.Add(this.CTxt_Semestre);
            this.Gb_Datos.ForeColor = System.Drawing.Color.White;
            this.Gb_Datos.Location = new System.Drawing.Point(71, 287);
            this.Gb_Datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Datos.Size = new System.Drawing.Size(469, 129);
            this.Gb_Datos.TabIndex = 18;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos del profesor";
            // 
            // Dgv_Profes
            // 
            this.Dgv_Profes.AllowUserToAddRows = false;
            this.Dgv_Profes.AllowUserToDeleteRows = false;
            this.Dgv_Profes.AllowUserToOrderColumns = true;
            this.Dgv_Profes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Profes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Profes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Profes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Profes.EnableHeadersVisualStyles = false;
            this.Dgv_Profes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_Profes.Location = new System.Drawing.Point(12, 11);
            this.Dgv_Profes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Profes.Name = "Dgv_Profes";
            this.Dgv_Profes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Profes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Profes.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Dgv_Profes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Profes.RowTemplate.Height = 28;
            this.Dgv_Profes.Size = new System.Drawing.Size(837, 242);
            this.Dgv_Profes.TabIndex = 23;
            // 
            // Crear_Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(860, 449);
            this.Controls.Add(this.Dgv_Profes);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.Gb_Acciones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Crear_Prof";
            this.Text = "Crear_Prof";
            this.Load += new System.EventHandler(this.Crear_Prof_Load);
            this.Gb_Acciones.ResumeLayout(false);
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Profes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Btn_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CTxt_Turno;
        private System.Windows.Forms.ComboBox CTxt_Semestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.GroupBox Gb_Acciones;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Mod;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.TextBox Txt_1Apellido;
        private System.Windows.Forms.TextBox Txt_2Apellido;
        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.DataGridView Dgv_Profes;
    }
}