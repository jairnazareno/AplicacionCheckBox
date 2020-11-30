namespace AplicacionCheckBox
{
    partial class frmInverso
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE UN NUMERO";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(42, 118);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(58, 13);
            this.lblRespuesta.TabIndex = 1;
            this.lblRespuesta.Text = "Respuesta";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(187, 58);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(328, 55);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(75, 23);
            this.btnInvertir.TabIndex = 3;
            this.btnInvertir.Text = "INVERTIR";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // frmInverso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 225);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.label1);
            this.Name = "frmInverso";
            this.Text = "frmInverso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnInvertir;
    }
}