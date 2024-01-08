namespace Proyecto_Final.Forms
{
    partial class Prefecto
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
            this.Gb_Acciones = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Reporte = new System.Windows.Forms.TextBox();
            this.Dtp_DiaReporte = new System.Windows.Forms.DateTimePicker();
            this.Cb_Materia = new System.Windows.Forms.ComboBox();
            this.Cb_Turno = new System.Windows.Forms.ComboBox();
            this.Cb_Grupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_Reportes = new System.Windows.Forms.DataGridView();
            this.Gb_Acciones.SuspendLayout();
            this.Gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_Acciones
            // 
            this.Gb_Acciones.Controls.Add(this.Btn_Cancelar);
            this.Gb_Acciones.Controls.Add(this.Btn_Nuevo);
            this.Gb_Acciones.Controls.Add(this.Btn_Eliminar);
            this.Gb_Acciones.Controls.Add(this.Btn_Agregar);
            this.Gb_Acciones.ForeColor = System.Drawing.Color.White;
            this.Gb_Acciones.Location = new System.Drawing.Point(927, 320);
            this.Gb_Acciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Acciones.Name = "Gb_Acciones";
            this.Gb_Acciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Acciones.Size = new System.Drawing.Size(220, 111);
            this.Gb_Acciones.TabIndex = 19;
            this.Gb_Acciones.TabStop = false;
            this.Gb_Acciones.Text = "Acciones";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Cancelar.Location = new System.Drawing.Point(111, 65);
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
            this.Btn_Eliminar.Location = new System.Drawing.Point(5, 66);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(100, 33);
            this.Btn_Eliminar.TabIndex = 15;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
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
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.label4);
            this.Gb_Datos.Controls.Add(this.Txt_Reporte);
            this.Gb_Datos.Controls.Add(this.Dtp_DiaReporte);
            this.Gb_Datos.Controls.Add(this.Cb_Materia);
            this.Gb_Datos.Controls.Add(this.Cb_Turno);
            this.Gb_Datos.Controls.Add(this.Cb_Grupo);
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.label1);
            this.Gb_Datos.Controls.Add(this.label3);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.ForeColor = System.Drawing.Color.White;
            this.Gb_Datos.Location = new System.Drawing.Point(11, 320);
            this.Gb_Datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Datos.Size = new System.Drawing.Size(870, 230);
            this.Gb_Datos.TabIndex = 20;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos del Reporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reporte";
            // 
            // Txt_Reporte
            // 
            this.Txt_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Txt_Reporte.Location = new System.Drawing.Point(506, 38);
            this.Txt_Reporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Reporte.Multiline = true;
            this.Txt_Reporte.Name = "Txt_Reporte";
            this.Txt_Reporte.Size = new System.Drawing.Size(343, 179);
            this.Txt_Reporte.TabIndex = 22;
            // 
            // Dtp_DiaReporte
            // 
            this.Dtp_DiaReporte.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.Dtp_DiaReporte.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dtp_DiaReporte.Location = new System.Drawing.Point(12, 102);
            this.Dtp_DiaReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_DiaReporte.Name = "Dtp_DiaReporte";
            this.Dtp_DiaReporte.Size = new System.Drawing.Size(299, 22);
            this.Dtp_DiaReporte.TabIndex = 21;
            // 
            // Cb_Materia
            // 
            this.Cb_Materia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Cb_Materia.ForeColor = System.Drawing.Color.White;
            this.Cb_Materia.FormattingEnabled = true;
            this.Cb_Materia.Location = new System.Drawing.Point(316, 47);
            this.Cb_Materia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Materia.Name = "Cb_Materia";
            this.Cb_Materia.Size = new System.Drawing.Size(147, 24);
            this.Cb_Materia.TabIndex = 19;
            this.Cb_Materia.SelectedIndexChanged += new System.EventHandler(this.Cb_Clase_SelectedIndexChanged);
            // 
            // Cb_Turno
            // 
            this.Cb_Turno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Cb_Turno.ForeColor = System.Drawing.Color.White;
            this.Cb_Turno.FormattingEnabled = true;
            this.Cb_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.Cb_Turno.Location = new System.Drawing.Point(12, 47);
            this.Cb_Turno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Turno.Name = "Cb_Turno";
            this.Cb_Turno.Size = new System.Drawing.Size(147, 24);
            this.Cb_Turno.TabIndex = 18;
            this.Cb_Turno.SelectedIndexChanged += new System.EventHandler(this.Cb_Turno_SelectedIndexChanged);
            // 
            // Cb_Grupo
            // 
            this.Cb_Grupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Cb_Grupo.ForeColor = System.Drawing.Color.White;
            this.Cb_Grupo.FormattingEnabled = true;
            this.Cb_Grupo.Location = new System.Drawing.Point(164, 47);
            this.Cb_Grupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Grupo.Name = "Cb_Grupo";
            this.Cb_Grupo.Size = new System.Drawing.Size(147, 24);
            this.Cb_Grupo.TabIndex = 17;
            this.Cb_Grupo.SelectedIndexChanged += new System.EventHandler(this.Cb_Grupo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Materia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dia de Reporte";
            // 
            // Dgv_Reportes
            // 
            this.Dgv_Reportes.AllowUserToAddRows = false;
            this.Dgv_Reportes.AllowUserToDeleteRows = false;
            this.Dgv_Reportes.AllowUserToOrderColumns = true;
            this.Dgv_Reportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Reportes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Reportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Reportes.EnableHeadersVisualStyles = false;
            this.Dgv_Reportes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_Reportes.Location = new System.Drawing.Point(11, 10);
            this.Dgv_Reportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Reportes.Name = "Dgv_Reportes";
            this.Dgv_Reportes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Reportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Reportes.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Dgv_Reportes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Reportes.RowTemplate.Height = 28;
            this.Dgv_Reportes.Size = new System.Drawing.Size(1137, 294);
            this.Dgv_Reportes.TabIndex = 18;
            // 
            // Prefecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1158, 560);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.Gb_Acciones);
            this.Controls.Add(this.Dgv_Reportes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prefecto";
            this.Text = "Prefecto";
            this.Load += new System.EventHandler(this.Prefecto_Load);
            this.Gb_Acciones.ResumeLayout(false);
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Gb_Acciones;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_Materia;
        private System.Windows.Forms.ComboBox Cb_Turno;
        private System.Windows.Forms.ComboBox Cb_Grupo;
        private System.Windows.Forms.DateTimePicker Dtp_DiaReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Reporte;
        private System.Windows.Forms.DataGridView Dgv_Reportes;
    }
}