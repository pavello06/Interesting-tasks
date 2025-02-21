namespace Autopark.Car.Regular
{
    public class Truck : RegularCar
    {
        public uint MaxWeight { get; }

        public Truck(string brand, string model, uint price, EngineType type, uint mileage, uint maxWeight) : base(brand, model, price, type, mileage)
        {
            MaxWeight = maxWeight;
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../Car/Images/PetrolTruck.jpg" : Engine.Type == EngineType.Gas ? "../../../Car/Images/GasTruck.jpg" : "../../../Car/Images/ElectricTruck.jpg");

            var maxWeight = new Label();
            maxWeight.AutoSize = true;
            maxWeight.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            maxWeight.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            maxWeight.Text = $"Max weight: {MaxWeight}";
            card.Controls.Add(maxWeight);

            return card;
        }
    }
}