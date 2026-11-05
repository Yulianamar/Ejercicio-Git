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
	partial class ConvierteDinero
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
			this.btnpesos = new System.Windows.Forms.Button();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btndolares = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnpesos
			// 
			this.btnpesos.Location = new System.Drawing.Point(31, 106);
			this.btnpesos.Name = "btnpesos";
			this.btnpesos.Size = new System.Drawing.Size(100, 23);
			this.btnpesos.TabIndex = 0;
			this.btnpesos.Text = "Dolares a Pesos";
			this.btnpesos.UseVisualStyleBackColor = true;
			this.btnpesos.Click += new System.EventHandler(this.BtnpesosClick);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(31, 67);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 20);
			this.txtCantidad.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "CONVERTIDOR";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 11);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cantidad";
			// 
			// btndolares
			// 
			this.btndolares.Location = new System.Drawing.Point(31, 136);
			this.btndolares.Name = "btndolares";
			this.btndolares.Size = new System.Drawing.Size(100, 23);
			this.btndolares.TabIndex = 5;
			this.btndolares.Text = "Peso a Dolares";
			this.btndolares.UseVisualStyleBackColor = true;
			this.btndolares.Click += new System.EventHandler(this.BtndolaresClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(31, 162);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 6;
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.Location = new System.Drawing.Point(31, 199);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnlimpiar.TabIndex = 7;
			this.btnlimpiar.Text = "Limpiar";
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Click += new System.EventHandler(this.BtnlimpiarClick);
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(128, 199);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(75, 23);
			this.btnsalir.TabIndex = 8;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.BtnsalirClick);
			// 
			// ConvierteDinero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 244);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btndolares);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.btnpesos);
			this.Name = "ConvierteDinero";
			this.Text = "ConvierteDinero";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button btnlimpiar;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btndolares;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Button btnpesos;
	}
}
