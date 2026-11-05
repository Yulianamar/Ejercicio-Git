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
	/// Description of ConvierteDinero.
	/// </summary>
	public partial class ConvierteDinero : Form
	{
		double cambio=18.50;
		
		public ConvierteDinero()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnpesosClick(object sender, EventArgs e)
		{
			double cantidad = Convert.ToDouble(txtCantidad.Text);
			double resultado = cantidad / cambio;
			lblResultado.Text = resultado.ToString();
		}
		
		void BtndolaresClick(object sender, EventArgs e)
		{
			double cantidad = Convert.ToDouble(txtCantidad.Text);
			double resultado = cantidad * cambio;
			lblResultado.Text = resultado.ToString();
		}
		
		void BtnlimpiarClick(object sender, EventArgs e)
		{
			txtCantidad.Clear();
			lblResultado.Text = "Resultado";
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
