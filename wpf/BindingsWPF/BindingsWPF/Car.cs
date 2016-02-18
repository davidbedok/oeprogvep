using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingsWPF
{
	public class Car : INotifyPropertyChanged
	{
		private readonly Brand brand;
		private String model;
		private int engineCapacity;

		public event PropertyChangedEventHandler PropertyChanged;

		public Brand Brand
		{
			get { return this.brand; }
		}

		public String Model
		{
			get { return this.model; }
		}

		public int EngineCapacity {
			get { return this.engineCapacity; }
			set { 
				this.engineCapacity = value; 
			
				if (PropertyChanged != null)
				{
                    PropertyChanged(this, new PropertyChangedEventArgs("EngineCapacity"));
				}
			}
		}

		public Car(Brand brand, String model, int engineCapacity)
		{
			this.brand = brand;
			this.model = model;
			this.engineCapacity = engineCapacity;
		}

		public override string ToString()
		{
			return this.brand + " " + this.model + " ("+this.engineCapacity+" kw)";
		}

		
	}
}
