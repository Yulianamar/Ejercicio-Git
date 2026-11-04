/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 04/11/2026
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_en_equipo
{
	partial class Distancia
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblX1 = new System.Windows.Forms.Label();
			this.lblX2 = new System.Windows.Forms.Label();
			this.lblY1 = new System.Windows.Forms.Label();
			this.lblY2 = new System.Windows.Forms.Label();
			this.txtx1 = new System.Windows.Forms.TextBox();
			this.txtx2 = new System.Windows.Forms.TextBox();
			this.txty1 = new System.Windows.Forms.TextBox();
			this.txty2 = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblX1
			// 
			this.lblX1.Location = new System.Drawing.Point(23, 39);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(100, 23);
			this.lblX1.TabIndex = 0;
			this.lblX1.Text = "Valor de x1:";
			// 
			// lblX2
			// 
			this.lblX2.Location = new System.Drawing.Point(23, 78);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(100, 23);
			this.lblX2.TabIndex = 1;
			this.lblX2.Text = "Valor de x2:";
			// 
			// lblY1
			// 
			this.lblY1.Location = new System.Drawing.Point(23, 130);
			this.lblY1.Name = "lblY1";
			this.lblY1.Size = new System.Drawing.Size(100, 23);
			this.lblY1.TabIndex = 2;
			this.lblY1.Text = "Valor de y1:";
			// 
			// lblY2
			// 
			this.lblY2.Location = new System.Drawing.Point(23, 168);
			this.lblY2.Name = "lblY2";
			this.lblY2.Size = new System.Drawing.Size(100, 23);
			this.lblY2.TabIndex = 3;
			this.lblY2.Text = "Valor de y2:";
			// 
			// txtx1
			// 
			this.txtx1.Location = new System.Drawing.Point(232, 47);
			this.txtx1.Name = "txtx1";
			this.txtx1.Size = new System.Drawing.Size(100, 20);
			this.txtx1.TabIndex = 4;
			// 
			// txtx2
			// 
			this.txtx2.Location = new System.Drawing.Point(232, 81);
			this.txtx2.Name = "txtx2";
			this.txtx2.Size = new System.Drawing.Size(100, 20);
			this.txtx2.TabIndex = 5;
			// 
			// txty1
			// 
			this.txty1.Location = new System.Drawing.Point(232, 127);
			this.txty1.Name = "txty1";
			this.txty1.Size = new System.Drawing.Size(100, 20);
			this.txty1.TabIndex = 6;
			// 
			// txty2
			// 
			this.txty2.Location = new System.Drawing.Point(247, 168);
			this.txty2.Name = "txty2";
			this.txty2.Size = new System.Drawing.Size(100, 20);
			this.txty2.TabIndex = 7;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(105, 237);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 8;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(23, 301);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(431, 23);
			this.lblRespuesta.TabIndex = 9;
			// 
			// Distancia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 359);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txty2);
			this.Controls.Add(this.txty1);
			this.Controls.Add(this.txtx2);
			this.Controls.Add(this.txtx1);
			this.Controls.Add(this.lblY2);
			this.Controls.Add(this.lblY1);
			this.Controls.Add(this.lblX2);
			this.Controls.Add(this.lblX1);
			this.Name = "Distancia";
			this.Text = "Distancia";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txty2;
		private System.Windows.Forms.TextBox txty1;
		private System.Windows.Forms.TextBox txtx2;
		private System.Windows.Forms.TextBox txtx1;
		private System.Windows.Forms.Label lblY2;
		private System.Windows.Forms.Label lblY1;
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Label lblX1;
	}
}
