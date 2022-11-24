
namespace Parcial_1
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar_Modificar = new System.Windows.Forms.Button();
            this.txtBuscar_Modificar = new System.Windows.Forms.TextBox();
            this.txtNombre_editar = new System.Windows.Forms.TextBox();
            this.txtEdad_Editar = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.txtEdad_Editar);
            this.groupBox1.Controls.Add(this.txtNombre_editar);
            this.groupBox1.Controls.Add(this.txtBuscar_Modificar);
            this.groupBox1.Controls.Add(this.btnBuscar_Modificar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar dato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el codigo a consultar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de estudiante :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad de estudiante :";
            // 
            // btnBuscar_Modificar
            // 
            this.btnBuscar_Modificar.Location = new System.Drawing.Point(272, 19);
            this.btnBuscar_Modificar.Name = "btnBuscar_Modificar";
            this.btnBuscar_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar_Modificar.TabIndex = 3;
            this.btnBuscar_Modificar.Text = "Buscar";
            this.btnBuscar_Modificar.UseVisualStyleBackColor = true;
            this.btnBuscar_Modificar.Click += new System.EventHandler(this.btnBuscar_Modificar_Click);
            // 
            // txtBuscar_Modificar
            // 
            this.txtBuscar_Modificar.Location = new System.Drawing.Point(161, 45);
            this.txtBuscar_Modificar.Name = "txtBuscar_Modificar";
            this.txtBuscar_Modificar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar_Modificar.TabIndex = 4;
            // 
            // txtNombre_editar
            // 
            this.txtNombre_editar.Location = new System.Drawing.Point(129, 87);
            this.txtNombre_editar.Name = "txtNombre_editar";
            this.txtNombre_editar.Size = new System.Drawing.Size(176, 20);
            this.txtNombre_editar.TabIndex = 5;
            // 
            // txtEdad_Editar
            // 
            this.txtEdad_Editar.Location = new System.Drawing.Point(117, 126);
            this.txtEdad_Editar.Name = "txtEdad_Editar";
            this.txtEdad_Editar.Size = new System.Drawing.Size(38, 20);
            this.txtEdad_Editar.TabIndex = 6;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(272, 157);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 224);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtEdad_Editar;
        private System.Windows.Forms.TextBox txtNombre_editar;
        private System.Windows.Forms.TextBox txtBuscar_Modificar;
        private System.Windows.Forms.Button btnBuscar_Modificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}