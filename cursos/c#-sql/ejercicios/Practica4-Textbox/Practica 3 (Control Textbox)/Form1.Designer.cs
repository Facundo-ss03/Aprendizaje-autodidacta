
namespace Practica_3__Control_Textbox_
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
            this.txtCaja1 = new System.Windows.Forms.TextBox();
            this.btnCambiarFondoTxtb = new System.Windows.Forms.Button();
            this.txtbSoloNumeros = new System.Windows.Forms.TextBox();
            this.txtbCaja3 = new System.Windows.Forms.TextBox();
            this.btnCambiarFondo2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCaja1
            // 
            this.txtCaja1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCaja1.Location = new System.Drawing.Point(161, 63);
            this.txtCaja1.MaxLength = 10000;
            this.txtCaja1.Name = "txtCaja1";
            this.txtCaja1.Size = new System.Drawing.Size(199, 20);
            this.txtCaja1.TabIndex = 0;
            // 
            // btnCambiarFondoTxtb
            // 
            this.btnCambiarFondoTxtb.Location = new System.Drawing.Point(223, 98);
            this.btnCambiarFondoTxtb.Name = "btnCambiarFondoTxtb";
            this.btnCambiarFondoTxtb.Size = new System.Drawing.Size(87, 23);
            this.btnCambiarFondoTxtb.TabIndex = 1;
            this.btnCambiarFondoTxtb.Text = "Cambiar fondo";
            this.btnCambiarFondoTxtb.UseVisualStyleBackColor = true;
            this.btnCambiarFondoTxtb.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbSoloNumeros
            // 
            this.txtbSoloNumeros.Location = new System.Drawing.Point(161, 170);
            this.txtbSoloNumeros.Name = "txtbSoloNumeros";
            this.txtbSoloNumeros.Size = new System.Drawing.Size(199, 20);
            this.txtbSoloNumeros.TabIndex = 2;
            this.txtbSoloNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbSoloNumeros_KeyPress);
            // 
            // txtbCaja3
            // 
            this.txtbCaja3.Location = new System.Drawing.Point(161, 251);
            this.txtbCaja3.Multiline = true;
            this.txtbCaja3.Name = "txtbCaja3";
            this.txtbCaja3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbCaja3.Size = new System.Drawing.Size(199, 120);
            this.txtbCaja3.TabIndex = 3;
            this.txtbCaja3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCaja3_KeyPress);
            this.txtbCaja3.Leave += new System.EventHandler(this.txtbCaja3_Leave);
            // 
            // btnCambiarFondo2
            // 
            this.btnCambiarFondo2.Location = new System.Drawing.Point(223, 388);
            this.btnCambiarFondo2.Name = "btnCambiarFondo2";
            this.btnCambiarFondo2.Size = new System.Drawing.Size(85, 23);
            this.btnCambiarFondo2.TabIndex = 4;
            this.btnCambiarFondo2.Text = "Cambiar fondo";
            this.btnCambiarFondo2.UseVisualStyleBackColor = true;
            this.btnCambiarFondo2.Click += new System.EventHandler(this.btnCambiarFondo2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Si se escribe algo, el fondo\r\ncambia a color celeste. Sino,\r\na color naranja.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Solo permíte números.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "Combina las anteriores \r\nfunciones y al perder el \r\nfoco muestra cuantos \r\ncaract" +
    "eres contiene.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarFondo2);
            this.Controls.Add(this.txtbCaja3);
            this.Controls.Add(this.txtbSoloNumeros);
            this.Controls.Add(this.btnCambiarFondoTxtb);
            this.Controls.Add(this.txtCaja1);
            this.Name = "Form1";
            this.Text = "PruebaTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaja1;
        private System.Windows.Forms.Button btnCambiarFondoTxtb;
        private System.Windows.Forms.TextBox txtbSoloNumeros;
        private System.Windows.Forms.TextBox txtbCaja3;
        private System.Windows.Forms.Button btnCambiarFondo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

