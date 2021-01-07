using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class Form1 : Form
	{
		List<string> valutas = new List<string>();

		public Form1()
		{
			InitializeComponent();

			GetValutas();

			for (int i = 0; i < valutas.Count; i++)
			{
				ValutaBox.Items.Add(valutas[i]);
			}

		}

		private void GetValutas()
		{			
			
		}

	}
}
