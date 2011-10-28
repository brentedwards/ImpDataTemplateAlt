using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ImpDataConverterAlt.Models
{
	public sealed class CarProduct : Product
	{
		public override string Name
		{
			get
			{
				return string.Format("{0} {1}", Make, Model);
			}
		}

		public string Make { get; set; }
		public string Model { get; set; }
	}
}
