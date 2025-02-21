namespace Autopark.Car.Regular
{
    public class Bus : RegularCar
    {
        public uint MaxPassengersCount { get; }

        public Bus(string brand, string model, uint price, EngineType type, uint mileage, uint maxPassengersCount) : base(brand, model, price, type, mileage)
        {
            MaxPassengersCount = maxPassengersCount;
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../Car/Images/PetrolBus.jpg" : Engine.Type == EngineType.Gas ? "../../../Car/Images/GasBus.jpg" : "../../../Car/Images/ElectricBus.jpg");

            var maxPassengersCount = new Label();
            maxPassengersCount.AutoSize = true;
            maxPassengersCount.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            maxPassengersCount.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            maxPassengersCount.Text = $"Max passenger count: {MaxPassengersCount}";
            card.Controls.Add(maxPassengersCount);

            return card;
        }
    }
}