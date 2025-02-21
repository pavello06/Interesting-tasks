namespace Autopark.Car.Regular
{
    public class PassengerCar : RegularCar
    {
        public uint AccidentsCount { get; private set; }

        public PassengerCar(string brand, string model, uint price, EngineType type, uint mileage, uint accidentsCount) : base(brand, model, price, type, mileage)
        {
            AccidentsCount = accidentsCount;
        }

        public void GetIntoAccident()
        {
            AccidentsCount++;
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../Car/Images/PetrolPassenger.jpg" : Engine.Type == EngineType.Gas ? "../../../Car/Images/GasPassenger.jpg" : "../../../Car/Images/ElectricPassenger.jpg");

            var accidentsCount = new Label();
            accidentsCount.AutoSize = true;
            accidentsCount.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            accidentsCount.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            accidentsCount.Text = $"Accidents count: {AccidentsCount}";
            card.Controls.Add(accidentsCount);

            return card;
        }
    }
}