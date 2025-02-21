using Autopark.Car;
using Autopark.Car.Race;
using Autopark.Car.Rare;
using Autopark.Car.Regular;

namespace Autopark
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            var cars = new Cars("Pasha");
            cars.Add([new RaceCar("BMW", "S21", 10, Car.EngineType.Gas, 10, 15),
                      new RaceCar("KIA", "W44", 33, Car.EngineType.Electric, 20, 35),
                      new RaceCar("RENO", "J0", 32, Car.EngineType.Petrol, 63, 95),
                      new RareCar("WER", "S21", 10, Car.EngineType.Gas, 10, 15, "Vanya"),
                      new RareCar("HAT", "W44", 33, Car.EngineType.Electric, 20, 35, "Pavel"),
                      new RareCar("RAT", "J0", 32, Car.EngineType.Petrol, 63, 95, "Pasha"),
                      new PassengerCar("QER", "S21", 10, Car.EngineType.Gas, 10, 15),
                      new PassengerCar("EQT", "W44", 33, Car.EngineType.Electric, 20, 35),
                      new PassengerCar("OPT", "J0", 32, Car.EngineType.Petrol, 63, 95),
                      new Truck("QER", "S21", 10, Car.EngineType.Gas, 10, 15),
                      new Truck("EQT", "W44", 33, Car.EngineType.Electric, 20, 35),
                      new Truck("OPT", "J0", 32, Car.EngineType.Petrol, 63, 95),
                      new Bus("QER", "S21", 10, Car.EngineType.Gas, 10, 15),
                      new Bus("EQT", "W44", 33, Car.EngineType.Electric, 20, 35),
                      new Bus("OPT", "J0", 32, Car.EngineType.Petrol, 63, 95)]);

            int previousX = 0;
            int previousWidth = 0;
            InitializeComponent();
            for (int i = 0; i < cars.Count; i++)
            {                
                var card = cars[i].Visualize();
                foreach (Control control in card.Controls)
                {
                    card.Width = Math.Max(card.Width, control.Width);
                }
                card.Location = new Point(previousX + previousWidth + 10, 0);
                previousX = card.Location.X;
                previousWidth = card.Width;
                CarsPanel.Controls.Add(card);
            }  
        }
    }
}
