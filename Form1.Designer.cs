namespace PilasDinamicas
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
            this.lblDato = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnERep = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtDts1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(29, 43);
            this.lblDato.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(74, 22);
            this.lblDato.TabIndex = 0;
            this.lblDato.Text = "Dato = ";
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(67, 110);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(171, 41);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "PUSH";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(67, 179);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(171, 41);
            this.btnPop.TabIndex = 3;
            this.btnPop.Text = "POP";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnERep
            // 
            this.btnERep.Location = new System.Drawing.Point(67, 250);
            this.btnERep.Name = "btnERep";
            this.btnERep.Size = new System.Drawing.Size(171, 41);
            this.btnERep.TabIndex = 4;
            this.btnERep.Text = "E.Rep";
            this.btnERep.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(67, 323);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 41);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(382, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 312);
            this.listBox1.TabIndex = 6;
            // 
            // txtDts1
            // 
            this.txtDts1.Location = new System.Drawing.Point(112, 36);
            this.txtDts1.Name = "txtDts1";
            this.txtDts1.Size = new System.Drawing.Size(131, 29);
            this.txtDts1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(841, 444);
            this.ControlBox = false;
            this.Controls.Add(this.txtDts1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnERep);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.lblDato);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnERep;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtDts1;
    }
}

