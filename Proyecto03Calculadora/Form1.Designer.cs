
namespace Proyecto03Calculadora
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btclear = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.btpo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(156, 24);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(31, 23);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 27);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(11, 73);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(36, 24);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 3;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(34, 70);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(72, 118);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(28, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "-------";
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(193, 24);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(31, 23);
            this.btnResta.TabIndex = 6;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(193, 63);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(31, 23);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(156, 63);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(31, 23);
            this.btnMulti.TabIndex = 7;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado:";
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(286, 24);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(75, 23);
            this.btclear.TabIndex = 10;
            this.btclear.Text = "Borrar";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(286, 149);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(75, 23);
            this.btclose.TabIndex = 11;
            this.btclose.Text = "CERRAR";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btpo
            // 
            this.btpo.Location = new System.Drawing.Point(156, 92);
            this.btpo.Name = "btpo";
            this.btpo.Size = new System.Drawing.Size(75, 23);
            this.btpo.TabIndex = 12;
            this.btpo.Text = "Potencia";
            this.btpo.UseVisualStyleBackColor = true;
            this.btpo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(369, 184);
            this.Controls.Add(this.btpo);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnSuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Button btpo;
    }
}

