/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 04/11/2026
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_en_equipo
{
	/// <summary>
	/// Description of Distancia.
	/// </summary>
	public partial class Distancia : Form
	{
		public Distancia()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double lblX1 = Convert.ToDouble(txtx1.Text);
			double lblX2 = Convert.ToDouble(txtx2.Text);
			double lblY1 = Convert.ToDouble(txty1.Text);
			double lblY2 = Convert.ToDouble(txty2.Text);
			double d = 0.0;
			
			d = Math.Sqrt(((lblX1 - lblX2) * (lblX1 - lblX2)) + ((lblY1 - lblX2) * (lblY1 - lblY2)));
			              
			lblRespuesta.Text = "La distancia entre los dos puntos es de: " + d;
		}
	}
}
