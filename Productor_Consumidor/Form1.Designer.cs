﻿namespace Productor_Consumidor
{
    partial class fmWorker
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
            this.components = new System.ComponentModel.Container();
            this.Origen = new System.Windows.Forms.TextBox();
            this.Destino = new System.Windows.Forms.TextBox();
            this.Informacion = new System.Windows.Forms.Label();
            this.lOrigen = new System.Windows.Forms.Label();
            this.lDestino = new System.Windows.Forms.Label();
            this.dtproducers = new System.Windows.Forms.DataGridView();
            this.cpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtconsumers = new System.Windows.Forms.DataGridView();
            this.Cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.Button();
            this.btremove = new System.Windows.Forms.Button();
            this.btiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.txtcons = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtworker = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtproducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtconsumers)).BeginInit();
            this.SuspendLayout();
            // 
            // Origen
            // 
            this.Origen.Location = new System.Drawing.Point(627, 176);
            this.Origen.Margin = new System.Windows.Forms.Padding(4);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(148, 22);
            this.Origen.TabIndex = 1;
            // 
            // Destino
            // 
            this.Destino.Location = new System.Drawing.Point(627, 238);
            this.Destino.Margin = new System.Windows.Forms.Padding(4);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(148, 22);
            this.Destino.TabIndex = 2;
            // 
            // Informacion
            // 
            this.Informacion.AutoSize = true;
            this.Informacion.Location = new System.Drawing.Point(14, 23);
            this.Informacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(88, 16);
            this.Informacion.TabIndex = 5;
            this.Informacion.Text = "Informacion";
            // 
            // lOrigen
            // 
            this.lOrigen.AutoSize = true;
            this.lOrigen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lOrigen.Location = new System.Drawing.Point(627, 137);
            this.lOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOrigen.Name = "lOrigen";
            this.lOrigen.Size = new System.Drawing.Size(54, 16);
            this.lOrigen.TabIndex = 6;
            this.lOrigen.Text = "Origen";
            // 
            // lDestino
            // 
            this.lDestino.AutoSize = true;
            this.lDestino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lDestino.Location = new System.Drawing.Point(627, 219);
            this.lDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDestino.Name = "lDestino";
            this.lDestino.Size = new System.Drawing.Size(61, 16);
            this.lDestino.TabIndex = 7;
            this.lDestino.Text = "Destino";
            // 
            // dtproducers
            // 
            this.dtproducers.AllowUserToAddRows = false;
            this.dtproducers.AllowUserToDeleteRows = false;
            this.dtproducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtproducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpName,
            this.cpEstado,
            this.cpCantidad});
            this.dtproducers.GridColor = System.Drawing.SystemColors.MenuText;
            this.dtproducers.Location = new System.Drawing.Point(17, 48);
            this.dtproducers.Name = "dtproducers";
            this.dtproducers.Size = new System.Drawing.Size(378, 150);
            this.dtproducers.TabIndex = 8;
            // 
            // cpName
            // 
            this.cpName.HeaderText = "Name";
            this.cpName.Name = "cpName";
            this.cpName.ReadOnly = true;
            // 
            // cpEstado
            // 
            this.cpEstado.HeaderText = "Estado";
            this.cpEstado.Name = "cpEstado";
            this.cpEstado.ReadOnly = true;
            // 
            // cpCantidad
            // 
            this.cpCantidad.HeaderText = "Cantidad";
            this.cpCantidad.Name = "cpCantidad";
            this.cpCantidad.ReadOnly = true;
            // 
            // dtconsumers
            // 
            this.dtconsumers.AllowUserToAddRows = false;
            this.dtconsumers.AllowUserToDeleteRows = false;
            this.dtconsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtconsumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cname,
            this.Cestado,
            this.Ccantidad});
            this.dtconsumers.GridColor = System.Drawing.SystemColors.MenuText;
            this.dtconsumers.Location = new System.Drawing.Point(17, 234);
            this.dtconsumers.Name = "dtconsumers";
            this.dtconsumers.Size = new System.Drawing.Size(378, 150);
            this.dtconsumers.TabIndex = 9;
            // 
            // Cname
            // 
            this.Cname.HeaderText = "Name";
            this.Cname.Name = "Cname";
            // 
            // Cestado
            // 
            this.Cestado.HeaderText = "Estado";
            this.Cestado.Name = "Cestado";
            // 
            // Ccantidad
            // 
            this.Ccantidad.HeaderText = "Cantidad";
            this.Ccantidad.Name = "Ccantidad";
            // 
            // Agregar
            // 
            this.Agregar.AutoSize = true;
            this.Agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Agregar.Location = new System.Drawing.Point(630, 281);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(129, 28);
            this.Agregar.TabIndex = 3;
            this.Agregar.Text = "ADD";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            this.Agregar.MouseLeave += new System.EventHandler(this.Agregar_MouseLeave);
            // 
            // btremove
            // 
            this.btremove.AutoSize = true;
            this.btremove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btremove.Location = new System.Drawing.Point(630, 327);
            this.btremove.Margin = new System.Windows.Forms.Padding(4);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(129, 28);
            this.btremove.TabIndex = 4;
            this.btremove.Text = "REMOVE";
            this.btremove.UseVisualStyleBackColor = true;
            this.btremove.Click += new System.EventHandler(this.btremove_Click);
            this.btremove.MouseLeave += new System.EventHandler(this.btremove_MouseLeave);
            // 
            // btiniciar
            // 
            this.btiniciar.AutoSize = true;
            this.btiniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btiniciar.Location = new System.Drawing.Point(434, 281);
            this.btiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.Size = new System.Drawing.Size(129, 28);
            this.btiniciar.TabIndex = 16;
            this.btiniciar.Text = "Iniciar";
            this.btiniciar.UseVisualStyleBackColor = true;
            this.btiniciar.Click += new System.EventHandler(this.btiniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(431, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Productores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(431, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Consumidores";
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(431, 87);
            this.txtprod.Margin = new System.Windows.Forms.Padding(4);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(148, 22);
            this.txtprod.TabIndex = 13;
            this.txtprod.Text = "3";
            // 
            // txtcons
            // 
            this.txtcons.Location = new System.Drawing.Point(434, 159);
            this.txtcons.Margin = new System.Windows.Forms.Padding(4);
            this.txtcons.Name = "txtcons";
            this.txtcons.Size = new System.Drawing.Size(148, 22);
            this.txtcons.TabIndex = 12;
            this.txtcons.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(630, 94);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 22);
            this.TxtCantidad.TabIndex = 0;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCantidad.Location = new System.Drawing.Point(624, 59);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(70, 16);
            this.lbCantidad.TabIndex = 19;
            this.lbCantidad.Text = "Cantidad";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(14, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Consumidores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(14, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Productores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(431, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Worker";
            // 
            // txtworker
            // 
            this.txtworker.Location = new System.Drawing.Point(434, 234);
            this.txtworker.Margin = new System.Windows.Forms.Padding(4);
            this.txtworker.Name = "txtworker";
            this.txtworker.Size = new System.Drawing.Size(148, 22);
            this.txtworker.TabIndex = 22;
            this.txtworker.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(756, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tamaño Cola";
            // 
            // txtCola
            // 
            this.txtCola.Location = new System.Drawing.Point(762, 94);
            this.txtCola.Name = "txtCola";
            this.txtCola.Size = new System.Drawing.Size(100, 22);
            this.txtCola.TabIndex = 24;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // fmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(953, 457);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtworker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.txtcons);
            this.Controls.Add(this.btremove);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dtconsumers);
            this.Controls.Add(this.dtproducers);
            this.Controls.Add(this.lDestino);
            this.Controls.Add(this.lOrigen);
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.Origen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmWorker";
            this.Text = "Worker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtproducers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtconsumers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Origen;
        private System.Windows.Forms.TextBox Destino;
        private System.Windows.Forms.Label Informacion;
        private System.Windows.Forms.Label lOrigen;
        private System.Windows.Forms.Label lDestino;
        private System.Windows.Forms.DataGridView dtproducers;
        private System.Windows.Forms.DataGridView dtconsumers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button btremove;
        private System.Windows.Forms.Button btiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.TextBox txtcons;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtworker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Timer timer2;
    }
}

