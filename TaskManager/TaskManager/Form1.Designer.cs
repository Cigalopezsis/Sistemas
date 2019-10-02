namespace TaskManager
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
            this.ListadeProcesos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPropiedades = new System.Windows.Forms.Button();
            this.btnComenzarProceso = new System.Windows.Forms.Button();
            this.btnTerminarProceso = new System.Windows.Forms.Button();
            this.btnObtenerProceso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListadeProcesos
            // 
            this.ListadeProcesos.BackColor = System.Drawing.Color.PeachPuff;
            this.ListadeProcesos.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListadeProcesos.FormattingEnabled = true;
            this.ListadeProcesos.ItemHeight = 17;
            this.ListadeProcesos.Location = new System.Drawing.Point(137, 104);
            this.ListadeProcesos.Name = "ListadeProcesos";
            this.ListadeProcesos.Size = new System.Drawing.Size(187, 225);
            this.ListadeProcesos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador de Tareas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnPropiedades);
            this.panel1.Controls.Add(this.btnComenzarProceso);
            this.panel1.Controls.Add(this.btnTerminarProceso);
            this.panel1.Controls.Add(this.btnObtenerProceso);
            this.panel1.Location = new System.Drawing.Point(439, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 225);
            this.panel1.TabIndex = 2;
            // 
            // btnPropiedades
            // 
            this.btnPropiedades.BackColor = System.Drawing.Color.LightCoral;
            this.btnPropiedades.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropiedades.Location = new System.Drawing.Point(40, 165);
            this.btnPropiedades.Name = "btnPropiedades";
            this.btnPropiedades.Size = new System.Drawing.Size(112, 27);
            this.btnPropiedades.TabIndex = 3;
            this.btnPropiedades.Text = "Propiedades";
            this.btnPropiedades.UseVisualStyleBackColor = false;
            this.btnPropiedades.Click += new System.EventHandler(this.btnPropiedades_Click);
            // 
            // btnComenzarProceso
            // 
            this.btnComenzarProceso.BackColor = System.Drawing.Color.LightCoral;
            this.btnComenzarProceso.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzarProceso.Location = new System.Drawing.Point(29, 114);
            this.btnComenzarProceso.Name = "btnComenzarProceso";
            this.btnComenzarProceso.Size = new System.Drawing.Size(140, 24);
            this.btnComenzarProceso.TabIndex = 2;
            this.btnComenzarProceso.Text = "Comenzar Proceso";
            this.btnComenzarProceso.UseVisualStyleBackColor = false;
            this.btnComenzarProceso.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTerminarProceso
            // 
            this.btnTerminarProceso.BackColor = System.Drawing.Color.LightCoral;
            this.btnTerminarProceso.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarProceso.Location = new System.Drawing.Point(40, 68);
            this.btnTerminarProceso.Name = "btnTerminarProceso";
            this.btnTerminarProceso.Size = new System.Drawing.Size(112, 24);
            this.btnTerminarProceso.TabIndex = 1;
            this.btnTerminarProceso.Text = "Terminar Proceso";
            this.btnTerminarProceso.UseVisualStyleBackColor = false;
            // 
            // btnObtenerProceso
            // 
            this.btnObtenerProceso.BackColor = System.Drawing.Color.LightCoral;
            this.btnObtenerProceso.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerProceso.Location = new System.Drawing.Point(40, 20);
            this.btnObtenerProceso.Name = "btnObtenerProceso";
            this.btnObtenerProceso.Size = new System.Drawing.Size(112, 25);
            this.btnObtenerProceso.TabIndex = 0;
            this.btnObtenerProceso.Text = "Obtener Procesos";
            this.btnObtenerProceso.UseVisualStyleBackColor = false;
            this.btnObtenerProceso.Click += new System.EventHandler(this.btnObtenerProceso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListadeProcesos);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Administrador de Tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListadeProcesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPropiedades;
        private System.Windows.Forms.Button btnComenzarProceso;
        private System.Windows.Forms.Button btnTerminarProceso;
        private System.Windows.Forms.Button btnObtenerProceso;
    }
}

