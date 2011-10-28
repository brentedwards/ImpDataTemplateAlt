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
	public sealed class BikeProduct : Product
	{
		public override string Name
		{
			get
			{
				return string.Format("{0} {1}", Manufacturer, Model);
			}
		}

		public string Manufacturer { get; set; }
		public string Model { get; set; }
		public string Type { get; set; }
		public int NumberOfGears { get; set; }
	}
}
