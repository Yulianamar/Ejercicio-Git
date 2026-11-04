/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 04/11/2026
 * Time: 07:46 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_en_equipo
{
	/// <summary>
	/// Description of MenuPrincipal.
	/// </summary>
	public partial class MenuPrincipal : Form
	{
		public MenuPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnConvertirClick(object sender, EventArgs e)
		{
			ConvierteDinero c = new ConvierteDinero();
			this.Hide();
			c.Show();
		}
		
		void BtnDistanciaClick(object sender, EventArgs e)
		{
			Distancia d = new Distancia();
			this.Hide();
			d.Show();
		}
		
		void BtnCoordenadasClick(object sender, EventArgs e)
		{
			Coordenadas coordenadas = new Coordenadas();
			this.Hide();
			coordenadas.Show();
		}
	}
}
