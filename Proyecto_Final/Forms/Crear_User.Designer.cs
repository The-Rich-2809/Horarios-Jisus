namespace Proyecto_Final.Forms
{
    partial class Crear_User
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Rol = new System.Windows.Forms.ComboBox();
            this.Gb_Acciones = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Mod = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Dgv_Profes = new System.Windows.Forms.DataGridView();
            this.Gb_Datos.SuspendLayout();
            this.Gb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Profes)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.textBox2);
            this.Gb_Datos.Controls.Add(this.label1);
            this.Gb_Datos.Controls.Add(this.textBox1);
            this.Gb_Datos.Controls.Add(this.Btn_Nombre);
            this.Gb_Datos.Controls.Add(this.Txt_Nombre);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.Controls.Add(this.Txt_Rol);
            this.Gb_Datos.ForeColor = System.Drawing.Color.White;
            this.Gb_Datos.Location = new System.Drawing.Point(69, 286);
            this.Gb_Datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Datos.Size = new System.Drawing.Size(411, 130);
            this.Gb_Datos.TabIndex = 21;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos del Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.textBox2.Location = new System.Drawing.Point(199, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '♥';
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.textBox1.Location = new System.Drawing.Point(12, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 11;
            // 
            // Btn_Nombre
            // 
            this.Btn_Nombre.AutoSize = true;
            this.Btn_Nombre.Location = new System.Drawing.Point(8, 28);
            this.Btn_Nombre.Name = "Btn_Nombre";
            this.Btn_Nombre.Size = new System.Drawing.Size(146, 16);
            this.Btn_Nombre.TabIndex = 0;
            this.Btn_Nombre.Text = "Nombre (p.ej. Arturo D.)";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Txt_Nombre.Location = new System.Drawing.Point(12, 46);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(180, 22);
            this.Txt_Nombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puesto";
            // 
            // Txt_Rol
            // 
            this.Txt_Rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Txt_Rol.FormattingEnabled = true;
            this.Txt_Rol.Items.AddRange(new object[] {
            "Prefecto",
            "Administrador"});
            this.Txt_Rol.Location = new System.Drawing.Point(212, 46);
            this.Txt_Rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Rol.Name = "Txt_Rol";
            this.Txt_Rol.Size = new System.Drawing.Size(108, 24);
            this.Txt_Rol.TabIndex = 8;
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
            this.Gb_Acciones.Location = new System.Drawing.Point(499, 270);
            this.Gb_Acciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Acciones.Name = "Gb_Acciones";
            this.Gb_Acciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Acciones.Size = new System.Drawing.Size(220, 154);
            this.Gb_Acciones.TabIndex = 19;
            this.Gb_Acciones.TabStop = false;
            this.Gb_Acciones.Text = "Acciones";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Cancelar.Location = new System.Drawing.Point(110, 102);
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
            this.Btn_Eliminar.Location = new System.Drawing.Point(5, 102);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Eliminar.TabIndex = 15;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Mod.Location = new System.Drawing.Point(110, 66);
            this.Btn_Mod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(100, 34);
            this.Btn_Mod.TabIndex = 14;
            this.Btn_Mod.Text = "Actualizar";
            this.Btn_Mod.UseVisualStyleBackColor = false;
            this.Btn_Mod.Click += new System.EventHandler(this.Btn_Mod_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Modificar.Location = new System.Drawing.Point(5, 66);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Modificar.TabIndex = 13;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
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
            this.Dgv_Profes.Size = new System.Drawing.Size(844, 242);
            this.Dgv_Profes.TabIndex = 24;
            // 
            // Crear_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(868, 438);
            this.Controls.Add(this.Dgv_Profes);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.Gb_Acciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Crear_User";
            this.Text = "Crear_User";
            this.Load += new System.EventHandler(this.Crear_User_Load);
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            this.Gb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Profes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.Label Btn_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Txt_Rol;
        private System.Windows.Forms.GroupBox Gb_Acciones;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Mod;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView Dgv_Profes;
    }
}