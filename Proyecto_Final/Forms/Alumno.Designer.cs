namespace Proyecto_Final.Forms
{
    partial class Alumno
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
            this.Turno = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_Semestre = new System.Windows.Forms.ComboBox();
            this.Rb_Vespertino = new System.Windows.Forms.RadioButton();
            this.Rb_Matutino = new System.Windows.Forms.RadioButton();
            this.Cb_Grupo = new System.Windows.Forms.CheckBox();
            this.Cb_Materia = new System.Windows.Forms.CheckBox();
            this.Cb_Profesor = new System.Windows.Forms.CheckBox();
            this.Ctxt_Grupo = new System.Windows.Forms.ComboBox();
            this.Ctxt_Materia = new System.Windows.Forms.ComboBox();
            this.Ctxt_Profesor = new System.Windows.Forms.ComboBox();
            this.Cb_Filtros = new System.Windows.Forms.CheckBox();
            this.Gb_Filtros = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Dgv_Horario = new System.Windows.Forms.DataGridView();
            this.Turno.SuspendLayout();
            this.Gb_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horario)).BeginInit();
            this.SuspendLayout();
            // 
            // Turno
            // 
            this.Turno.Controls.Add(this.label1);
            this.Turno.Controls.Add(this.Cb_Semestre);
            this.Turno.Controls.Add(this.Rb_Vespertino);
            this.Turno.Controls.Add(this.Rb_Matutino);
            this.Turno.ForeColor = System.Drawing.Color.White;
            this.Turno.Location = new System.Drawing.Point(20, 10);
            this.Turno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Turno.Name = "Turno";
            this.Turno.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Turno.Size = new System.Drawing.Size(201, 155);
            this.Turno.TabIndex = 1;
            this.Turno.TabStop = false;
            this.Turno.Text = "Turno y Semestre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Semestre";
            // 
            // Cb_Semestre
            // 
            this.Cb_Semestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Cb_Semestre.ForeColor = System.Drawing.Color.White;
            this.Cb_Semestre.FormattingEnabled = true;
            this.Cb_Semestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Cb_Semestre.Location = new System.Drawing.Point(20, 113);
            this.Cb_Semestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Semestre.Name = "Cb_Semestre";
            this.Cb_Semestre.Size = new System.Drawing.Size(155, 24);
            this.Cb_Semestre.TabIndex = 2;
            this.Cb_Semestre.SelectedIndexChanged += new System.EventHandler(this.Cb_Semestre_SelectedIndexChanged);
            // 
            // Rb_Vespertino
            // 
            this.Rb_Vespertino.AutoSize = true;
            this.Rb_Vespertino.Location = new System.Drawing.Point(15, 65);
            this.Rb_Vespertino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rb_Vespertino.Name = "Rb_Vespertino";
            this.Rb_Vespertino.Size = new System.Drawing.Size(93, 20);
            this.Rb_Vespertino.TabIndex = 1;
            this.Rb_Vespertino.TabStop = true;
            this.Rb_Vespertino.Text = "Vespertino";
            this.Rb_Vespertino.UseVisualStyleBackColor = true;
            this.Rb_Vespertino.CheckedChanged += new System.EventHandler(this.Rb_Vespertino_CheckedChanged);
            // 
            // Rb_Matutino
            // 
            this.Rb_Matutino.AutoSize = true;
            this.Rb_Matutino.Location = new System.Drawing.Point(15, 40);
            this.Rb_Matutino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rb_Matutino.Name = "Rb_Matutino";
            this.Rb_Matutino.Size = new System.Drawing.Size(78, 20);
            this.Rb_Matutino.TabIndex = 0;
            this.Rb_Matutino.TabStop = true;
            this.Rb_Matutino.Text = "Matutino";
            this.Rb_Matutino.UseVisualStyleBackColor = true;
            this.Rb_Matutino.CheckedChanged += new System.EventHandler(this.Rb_Matutino_CheckedChanged);
            // 
            // Cb_Grupo
            // 
            this.Cb_Grupo.AutoSize = true;
            this.Cb_Grupo.Location = new System.Drawing.Point(15, 24);
            this.Cb_Grupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Grupo.Name = "Cb_Grupo";
            this.Cb_Grupo.Size = new System.Drawing.Size(66, 20);
            this.Cb_Grupo.TabIndex = 2;
            this.Cb_Grupo.Text = "Grupo";
            this.Cb_Grupo.UseVisualStyleBackColor = true;
            this.Cb_Grupo.CheckedChanged += new System.EventHandler(this.Cb_Grupo_CheckedChanged);
            // 
            // Cb_Materia
            // 
            this.Cb_Materia.AutoSize = true;
            this.Cb_Materia.Location = new System.Drawing.Point(15, 83);
            this.Cb_Materia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Materia.Name = "Cb_Materia";
            this.Cb_Materia.Size = new System.Drawing.Size(74, 20);
            this.Cb_Materia.TabIndex = 3;
            this.Cb_Materia.Text = "Materia";
            this.Cb_Materia.UseVisualStyleBackColor = true;
            this.Cb_Materia.CheckedChanged += new System.EventHandler(this.Cb_Materia_CheckedChanged);
            // 
            // Cb_Profesor
            // 
            this.Cb_Profesor.AutoSize = true;
            this.Cb_Profesor.Location = new System.Drawing.Point(15, 145);
            this.Cb_Profesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Profesor.Name = "Cb_Profesor";
            this.Cb_Profesor.Size = new System.Drawing.Size(80, 20);
            this.Cb_Profesor.TabIndex = 4;
            this.Cb_Profesor.Text = "Profesor";
            this.Cb_Profesor.UseVisualStyleBackColor = true;
            this.Cb_Profesor.CheckedChanged += new System.EventHandler(this.Cb_Profesor_CheckedChanged);
            // 
            // Ctxt_Grupo
            // 
            this.Ctxt_Grupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Ctxt_Grupo.ForeColor = System.Drawing.Color.White;
            this.Ctxt_Grupo.FormattingEnabled = true;
            this.Ctxt_Grupo.Location = new System.Drawing.Point(15, 48);
            this.Ctxt_Grupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ctxt_Grupo.Name = "Ctxt_Grupo";
            this.Ctxt_Grupo.Size = new System.Drawing.Size(279, 24);
            this.Ctxt_Grupo.TabIndex = 5;
            // 
            // Ctxt_Materia
            // 
            this.Ctxt_Materia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Ctxt_Materia.ForeColor = System.Drawing.Color.White;
            this.Ctxt_Materia.FormattingEnabled = true;
            this.Ctxt_Materia.Location = new System.Drawing.Point(15, 107);
            this.Ctxt_Materia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ctxt_Materia.Name = "Ctxt_Materia";
            this.Ctxt_Materia.Size = new System.Drawing.Size(279, 24);
            this.Ctxt_Materia.TabIndex = 6;
            // 
            // Ctxt_Profesor
            // 
            this.Ctxt_Profesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Ctxt_Profesor.ForeColor = System.Drawing.Color.White;
            this.Ctxt_Profesor.FormattingEnabled = true;
            this.Ctxt_Profesor.Location = new System.Drawing.Point(15, 169);
            this.Ctxt_Profesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ctxt_Profesor.Name = "Ctxt_Profesor";
            this.Ctxt_Profesor.Size = new System.Drawing.Size(279, 24);
            this.Ctxt_Profesor.TabIndex = 7;
            // 
            // Cb_Filtros
            // 
            this.Cb_Filtros.AutoSize = true;
            this.Cb_Filtros.ForeColor = System.Drawing.Color.White;
            this.Cb_Filtros.Location = new System.Drawing.Point(295, 11);
            this.Cb_Filtros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Filtros.Name = "Cb_Filtros";
            this.Cb_Filtros.Size = new System.Drawing.Size(65, 20);
            this.Cb_Filtros.TabIndex = 8;
            this.Cb_Filtros.Text = "Filtros";
            this.Cb_Filtros.UseVisualStyleBackColor = true;
            this.Cb_Filtros.CheckedChanged += new System.EventHandler(this.Filtros_CheckedChanged);
            // 
            // Gb_Filtros
            // 
            this.Gb_Filtros.Controls.Add(this.Ctxt_Grupo);
            this.Gb_Filtros.Controls.Add(this.Cb_Grupo);
            this.Gb_Filtros.Controls.Add(this.Ctxt_Profesor);
            this.Gb_Filtros.Controls.Add(this.Cb_Profesor);
            this.Gb_Filtros.Controls.Add(this.Ctxt_Materia);
            this.Gb_Filtros.Controls.Add(this.Cb_Materia);
            this.Gb_Filtros.ForeColor = System.Drawing.Color.White;
            this.Gb_Filtros.Location = new System.Drawing.Point(258, 35);
            this.Gb_Filtros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Filtros.Name = "Gb_Filtros";
            this.Gb_Filtros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Filtros.Size = new System.Drawing.Size(318, 206);
            this.Gb_Filtros.TabIndex = 9;
            this.Gb_Filtros.TabStop = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Btn_Buscar.Location = new System.Drawing.Point(444, 10);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(107, 29);
            this.Btn_Buscar.TabIndex = 10;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Dgv_Horario
            // 
            this.Dgv_Horario.AllowUserToAddRows = false;
            this.Dgv_Horario.AllowUserToDeleteRows = false;
            this.Dgv_Horario.AllowUserToOrderColumns = true;
            this.Dgv_Horario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Horario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Horario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Horario.EnableHeadersVisualStyles = false;
            this.Dgv_Horario.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_Horario.Location = new System.Drawing.Point(12, 259);
            this.Dgv_Horario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Horario.Name = "Dgv_Horario";
            this.Dgv_Horario.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Horario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Horario.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Dgv_Horario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Horario.RowTemplate.Height = 28;
            this.Dgv_Horario.Size = new System.Drawing.Size(1211, 362);
            this.Dgv_Horario.TabIndex = 21;
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1232, 632);
            this.Controls.Add(this.Dgv_Horario);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Gb_Filtros);
            this.Controls.Add(this.Cb_Filtros);
            this.Controls.Add(this.Turno);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Alumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.Turno.ResumeLayout(false);
            this.Turno.PerformLayout();
            this.Gb_Filtros.ResumeLayout(false);
            this.Gb_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Turno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_Semestre;
        private System.Windows.Forms.RadioButton Rb_Vespertino;
        private System.Windows.Forms.RadioButton Rb_Matutino;
        private System.Windows.Forms.CheckBox Cb_Grupo;
        private System.Windows.Forms.CheckBox Cb_Materia;
        private System.Windows.Forms.CheckBox Cb_Profesor;
        private System.Windows.Forms.ComboBox Ctxt_Grupo;
        private System.Windows.Forms.ComboBox Ctxt_Materia;
        private System.Windows.Forms.ComboBox Ctxt_Profesor;
        private System.Windows.Forms.CheckBox Cb_Filtros;
        private System.Windows.Forms.GroupBox Gb_Filtros;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.DataGridView Dgv_Horario;
    }
}