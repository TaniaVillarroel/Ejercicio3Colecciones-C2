namespace Ejercicio3LILO
{
    partial class Form1
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
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.lstSueldo = new System.Windows.Forms.ListBox();
            this.lstNuevoSueldo = new System.Windows.Forms.ListBox();
            this.btnAumento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(23, 26);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(73, 108);
            this.lstEmpleados.TabIndex = 0;
            // 
            // lstSueldo
            // 
            this.lstSueldo.FormattingEnabled = true;
            this.lstSueldo.Location = new System.Drawing.Point(118, 26);
            this.lstSueldo.Name = "lstSueldo";
            this.lstSueldo.Size = new System.Drawing.Size(73, 108);
            this.lstSueldo.TabIndex = 1;
            // 
            // lstNuevoSueldo
            // 
            this.lstNuevoSueldo.FormattingEnabled = true;
            this.lstNuevoSueldo.Location = new System.Drawing.Point(266, 26);
            this.lstNuevoSueldo.Name = "lstNuevoSueldo";
            this.lstNuevoSueldo.Size = new System.Drawing.Size(73, 108);
            this.lstNuevoSueldo.TabIndex = 2;
            this.lstNuevoSueldo.SelectedIndexChanged += new System.EventHandler(this.lstNuevoSueldo_SelectedIndexChanged);
            // 
            // btnAumento
            // 
            this.btnAumento.Location = new System.Drawing.Point(195, 78);
            this.btnAumento.Name = "btnAumento";
            this.btnAumento.Size = new System.Drawing.Size(65, 23);
            this.btnAumento.TabIndex = 3;
            this.btnAumento.Text = "Aumento";
            this.btnAumento.UseVisualStyleBackColor = true;
            this.btnAumento.Click += new System.EventHandler(this.btnAumento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo Sueldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sueldos";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(197, 52);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(63, 20);
            this.txtPorcentaje.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(303, 138);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(36, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAumento);
            this.Controls.Add(this.lstNuevoSueldo);
            this.Controls.Add(this.lstSueldo);
            this.Controls.Add(this.lstEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.ListBox lstSueldo;
        private System.Windows.Forms.ListBox lstNuevoSueldo;
        private System.Windows.Forms.Button btnAumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

