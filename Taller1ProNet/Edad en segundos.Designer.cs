namespace Taller1ProNet
{
    partial class OpcionEdadEnSegundos
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.lblsegundos = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mishmash BRK", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad en segundos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su año de nacimiento:";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(48, 232);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(122, 24);
            this.lbledad.TabIndex = 3;
            this.lbledad.Text = "Su edad es:";
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(473, 145);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(367, 147);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(100, 20);
            this.txtaño.TabIndex = 5;
            // 
            // lblsegundos
            // 
            this.lblsegundos.AutoSize = true;
            this.lblsegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundos.Location = new System.Drawing.Point(48, 275);
            this.lblsegundos.Name = "lblsegundos";
            this.lblsegundos.Size = new System.Drawing.Size(250, 24);
            this.lblsegundos.TabIndex = 6;
            this.lblsegundos.Text = "Su edad en segundos es:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(473, 382);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // OpcionEdadEnSegundos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblsegundos);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OpcionEdadEnSegundos";
            this.Text = "Edad en segundos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.Label lblsegundos;
        private System.Windows.Forms.Button btncancelar;
    }
}

