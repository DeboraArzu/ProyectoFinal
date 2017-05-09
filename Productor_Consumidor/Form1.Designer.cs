namespace Productor_Consumidor
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
            this.Origen = new System.Windows.Forms.TextBox();
            this.Destino = new System.Windows.Forms.TextBox();
            this.Informacion = new System.Windows.Forms.Label();
            this.lOrigen = new System.Windows.Forms.Label();
            this.lDestino = new System.Windows.Forms.Label();
            this.dtproducers = new System.Windows.Forms.DataGridView();
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
            this.cpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtproducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtconsumers)).BeginInit();
            this.SuspendLayout();
            // 
            // Origen
            // 
            this.Origen.Location = new System.Drawing.Point(633, 176);
            this.Origen.Margin = new System.Windows.Forms.Padding(4);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(148, 22);
            this.Origen.TabIndex = 0;
            // 
            // Destino
            // 
            this.Destino.Location = new System.Drawing.Point(633, 238);
            this.Destino.Margin = new System.Windows.Forms.Padding(4);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(148, 22);
            this.Destino.TabIndex = 1;
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
            this.lOrigen.Location = new System.Drawing.Point(633, 137);
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
            this.lDestino.Location = new System.Drawing.Point(633, 219);
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
            this.dtproducers.Location = new System.Drawing.Point(17, 59);
            this.dtproducers.Name = "dtproducers";
            this.dtproducers.Size = new System.Drawing.Size(378, 150);
            this.dtproducers.TabIndex = 8;
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
            this.Agregar.Location = new System.Drawing.Point(636, 281);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(129, 28);
            this.Agregar.TabIndex = 10;
            this.Agregar.Text = "ADD";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // btremove
            // 
            this.btremove.AutoSize = true;
            this.btremove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btremove.Location = new System.Drawing.Point(636, 327);
            this.btremove.Margin = new System.Windows.Forms.Padding(4);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(129, 28);
            this.btremove.TabIndex = 11;
            this.btremove.Text = "REMOVE";
            this.btremove.UseVisualStyleBackColor = true;
            this.btremove.Click += new System.EventHandler(this.btremove_Click);
            // 
            // btiniciar
            // 
            this.btiniciar.AutoSize = true;
            this.btiniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btiniciar.Location = new System.Drawing.Point(437, 199);
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
            this.label1.Location = new System.Drawing.Point(434, 137);
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
            this.label2.Location = new System.Drawing.Point(434, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Consumidores";
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(434, 156);
            this.txtprod.Margin = new System.Windows.Forms.Padding(4);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(148, 22);
            this.txtprod.TabIndex = 13;
            this.txtprod.Text = "3";
            // 
            // txtcons
            // 
            this.txtcons.Location = new System.Drawing.Point(434, 94);
            this.txtcons.Margin = new System.Windows.Forms.Padding(4);
            this.txtcons.Name = "txtcons";
            this.txtcons.Size = new System.Drawing.Size(148, 22);
            this.txtcons.TabIndex = 12;
            this.txtcons.Text = "3";
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
            // lbcantidad
            // 
            this.lbcantidad.AutoSize = true;
            this.lbcantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbcantidad.Location = new System.Drawing.Point(633, 55);
            this.lbcantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcantidad.Name = "lbcantidad";
            this.lbcantidad.Size = new System.Drawing.Size(70, 16);
            this.lbcantidad.TabIndex = 18;
            this.lbcantidad.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(633, 94);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(148, 22);
            this.txtcantidad.TabIndex = 17;
            // 
            // fmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(805, 441);
            this.Controls.Add(this.lbcantidad);
            this.Controls.Add(this.txtcantidad);
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
        private System.Windows.Forms.Label lbcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
    }
}

