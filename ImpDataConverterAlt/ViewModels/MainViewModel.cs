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
using ImpDataConverterAlt.Models;
using System.Collections.ObjectModel;

namespace ImpDataConverterAlt.ViewModels
{
	public sealed class MainViewModel : ViewModelBase
	{
		public MainViewModel()
		{
			Products = new ObservableCollection<Product>();

			GetProducts();
		}

		public ObservableCollection<Product> Products { get; set; }

		private Product _selectedProduct;
		public Product SelectedProduct
		{
			get { return _selectedProduct; }
			set
			{
				_selectedProduct = value;
				NotifyPropertyChanged("SelectedProduct");
			}
		}

		private void GetProducts()
		{
			Products.Add(new CarProduct { Id = Guid.NewGuid(), Make = "Chevrolet", Model = "Corvette" });
			Products.Add(new CarProduct { Id = Guid.NewGuid(), Make = "Ford", Model = "Mustang" });
			Products.Add(new BikeProduct { Id = Guid.NewGuid(), Manufacturer = "Gary Fisher", Model = "Wahoo", Type = "Mountain", NumberOfGears = 24 });
			Products.Add(new BikeProduct { Id = Guid.NewGuid(), Manufacturer = "Schwinn", Model = "Fastback", Type = "Road", NumberOfGears = 8 });
		}
	}
}
