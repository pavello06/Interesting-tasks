namespace Autopark.Car.Regular
{
    public abstract class RegularCar : Car
    {
        public uint Mileage { get; private set; }

        public RegularCar(string brand, string model, uint price, EngineType type, uint mileage) : base(brand, model, price, type)
        {
            Mileage = mileage;
        }

        public void AddMileage(uint mileage)
        {
            Mileage += mileage;
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            var mileage = new Label();
            mileage.AutoSize = true;
            mileage.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            mileage.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            mileage.Text = $"Mileage: {Mileage}";
            card.Controls.Add(mileage);

            return card;
        }
    }
}