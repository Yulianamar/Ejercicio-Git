/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 04/11/2026
 * Time: 07:46 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_en_equipo
{
	partial class MenuPrincipal
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
			this.btnConvertir = new System.Windows.Forms.Button();
			this.btnDistancia = new System.Windows.Forms.Button();
			this.btnCoordenadas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnConvertir
			// 
			this.btnConvertir.Location = new System.Drawing.Point(12, 27);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(286, 23);
			this.btnConvertir.TabIndex = 0;
			this.btnConvertir.Text = "Convierte dólares a pesos y pesos a dólares.";
			this.btnConvertir.UseVisualStyleBackColor = true;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// btnDistancia
			// 
			this.btnDistancia.Location = new System.Drawing.Point(12, 110);
			this.btnDistancia.Name = "btnDistancia";
			this.btnDistancia.Size = new System.Drawing.Size(286, 23);
			this.btnDistancia.TabIndex = 1;
			this.btnDistancia.Text = "Calcula la distancia entre dos puntos.";
			this.btnDistancia.UseVisualStyleBackColor = true;
			this.btnDistancia.Click += new System.EventHandler(this.BtnDistanciaClick);
			// 
			// btnCoordenadas
			// 
			this.btnCoordenadas.Location = new System.Drawing.Point(12, 206);
			this.btnCoordenadas.Name = "btnCoordenadas";
			this.btnCoordenadas.Size = new System.Drawing.Size(479, 23);
			this.btnCoordenadas.TabIndex = 2;
			this.btnCoordenadas.Text = "Recibe las coordenadas de un punto y te indica en que cuadrante se encuentra ese " +
			"punto.";
			this.btnCoordenadas.UseVisualStyleBackColor = true;
			this.btnCoordenadas.Click += new System.EventHandler(this.BtnCoordenadasClick);
			// 
			// MenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 293);
			this.Controls.Add(this.btnCoordenadas);
			this.Controls.Add(this.btnDistancia);
			this.Controls.Add(this.btnConvertir);
			this.Name = "MenuPrincipal";
			this.Text = "MenuPrincipal";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCoordenadas;
		private System.Windows.Forms.Button btnDistancia;
		private System.Windows.Forms.Button btnConvertir;
	}
}
