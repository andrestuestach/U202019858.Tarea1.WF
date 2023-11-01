namespace U202019858.Tarea1.WF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cb_lugar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lugar";
            // 
            // cb_lugar
            // 
            this.cb_lugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lugar.FormattingEnabled = true;
            this.cb_lugar.Items.AddRange(new object[] {
            "La Molina",
            "La Victoria",
            "San Isidro",
            "Los Olivos"});
            this.cb_lugar.Location = new System.Drawing.Point(97, 27);
            this.cb_lugar.Name = "cb_lugar";
            this.cb_lugar.Size = new System.Drawing.Size(179, 24);
            this.cb_lugar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(443, 27);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(152, 27);
            this.txt_descripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "fecha";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "dd/MMM/yy";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(97, 80);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(179, 22);
            this.dtp_fecha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "hora";
            // 
            // txt_hora
            // 
            this.txt_hora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora.Location = new System.Drawing.Point(351, 80);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(82, 27);
            this.txt_hora.TabIndex = 7;
            this.txt_hora.Text = "13";
            this.txt_hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hora_KeyPress);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(454, 75);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(141, 37);
            this.btn_registrar.TabIndex = 8;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lugar,
            this.Descripcion,
            this.Fecha,
            this.Hora});
            this.dgv_tabla.Location = new System.Drawing.Point(16, 135);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.RowHeadersWidth = 51;
            this.dgv_tabla.RowTemplate.Height = 24;
            this.dgv_tabla.Size = new System.Drawing.Size(579, 315);
            this.dgv_tabla.TabIndex = 9;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.MinimumWidth = 6;
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            this.Lugar.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 462);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_lugar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_lugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
    }
}

