namespace Productor_Consumidor
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
            this.btConsumer = new System.Windows.Forms.Button();
            this.btproducer = new System.Windows.Forms.Button();
            this.Origen = new System.Windows.Forms.TextBox();
            this.Destino = new System.Windows.Forms.TextBox();
            this.Informacion = new System.Windows.Forms.Label();
            this.lOrigen = new System.Windows.Forms.Label();
            this.lDestino = new System.Windows.Forms.Label();
            this.dtproducers = new System.Windows.Forms.DataGridView();
            this.dtconsumers = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtproducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtconsumers)).BeginInit();
            this.SuspendLayout();
            // 
            // btConsumer
            // 
            this.btConsumer.AutoSize = true;
            this.btConsumer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btConsumer.Location = new System.Drawing.Point(568, 59);
            this.btConsumer.Margin = new System.Windows.Forms.Padding(4);
            this.btConsumer.Name = "btConsumer";
            this.btConsumer.Size = new System.Drawing.Size(129, 28);
            this.btConsumer.TabIndex = 2;
            this.btConsumer.Text = "Add Consumer";
            this.btConsumer.UseVisualStyleBackColor = true;
            this.btConsumer.Click += new System.EventHandler(this.btConsumer_Click);
            // 
            // btproducer
            // 
            this.btproducer.AutoSize = true;
            this.btproducer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btproducer.Location = new System.Drawing.Point(568, 132);
            this.btproducer.Margin = new System.Windows.Forms.Padding(4);
            this.btproducer.Name = "btproducer";
            this.btproducer.Size = new System.Drawing.Size(123, 28);
            this.btproducer.TabIndex = 3;
            this.btproducer.Text = "Add Producer";
            this.btproducer.UseVisualStyleBackColor = true;
            this.btproducer.Click += new System.EventHandler(this.btproducer_Click);
            // 
            // Origen
            // 
            this.Origen.Location = new System.Drawing.Point(728, 62);
            this.Origen.Margin = new System.Windows.Forms.Padding(4);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(148, 22);
            this.Origen.TabIndex = 0;
            // 
            // Destino
            // 
            this.Destino.Location = new System.Drawing.Point(728, 135);
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
            this.lOrigen.Location = new System.Drawing.Point(728, 23);
            this.lOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOrigen.Name = "lOrigen";
            this.lOrigen.Size = new System.Drawing.Size(54, 16);
            this.lOrigen.TabIndex = 6;
            this.lOrigen.Text = "Origen";
            // 
            // lDestino
            // 
            this.lDestino.AutoSize = true;
            this.lDestino.Location = new System.Drawing.Point(728, 116);
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
            this.Name,
            this.Estado,
            this.Cantidad});
            this.dtproducers.Location = new System.Drawing.Point(17, 59);
            this.dtproducers.Name = "dtproducers";
            this.dtproducers.ReadOnly = true;
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
            this.dtconsumers.Location = new System.Drawing.Point(17, 234);
            this.dtconsumers.Name = "dtconsumers";
            this.dtconsumers.ReadOnly = true;
            this.dtconsumers.Size = new System.Drawing.Size(378, 150);
            this.dtconsumers.TabIndex = 9;
            // 
            // Name
            // 
            this.Name.HeaderText = "cName";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Cestado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Ccantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Cname
            // 
            this.Cname.HeaderText = "Name";
            this.Cname.Name = "Cname";
            this.Cname.ReadOnly = true;
            // 
            // Cestado
            // 
            this.Cestado.HeaderText = "Estado";
            this.Cestado.Name = "Cestado";
            this.Cestado.ReadOnly = true;
            // 
            // Ccantidad
            // 
            this.Ccantidad.HeaderText = "Cantidad";
            this.Ccantidad.Name = "Ccantidad";
            this.Ccantidad.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(956, 441);
            this.Controls.Add(this.dtconsumers);
            this.Controls.Add(this.dtproducers);
            this.Controls.Add(this.lDestino);
            this.Controls.Add(this.lOrigen);
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.Origen);
            this.Controls.Add(this.btproducer);
            this.Controls.Add(this.btConsumer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Worker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtproducers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtconsumers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConsumer;
        private System.Windows.Forms.Button btproducer;
        private System.Windows.Forms.TextBox Origen;
        private System.Windows.Forms.TextBox Destino;
        private System.Windows.Forms.Label Informacion;
        private System.Windows.Forms.Label lOrigen;
        private System.Windows.Forms.Label lDestino;
        private System.Windows.Forms.DataGridView dtproducers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridView dtconsumers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
    }
}

