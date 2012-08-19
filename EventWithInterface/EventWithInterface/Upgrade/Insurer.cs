using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWithInterface.Upgrade
{
    public class Insurer
    {

        private List<Car> cars;

        public Insurer()
        {
            this.cars = new List<Car>();
        }

        public void addCar(Car item)
        {
            if (!this.cars.Contains(item))
            {
                item.bindHandler(new ReportAccidentEventHandler());
                this.cars.Add(item);
            }
        }

    }
}
