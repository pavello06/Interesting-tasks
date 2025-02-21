namespace Autopark.Car.Race
{
    public class RaceCar : Car
    {
        public uint Acceleration { get; }
        public uint MaxSpeed { get; }

        public RaceCar(string brand, string model, uint price, EngineType type, uint acceleration, uint maxSpeed) : base(brand, model, price, type)
        {
            Acceleration = acceleration;
            MaxSpeed = maxSpeed;
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../Car/Images/PetrolRace.jpg" : Engine.Type == EngineType.Gas ? "../../../Car/Images/GasRace.jpg" : "../../../Car/Images/ElectricRace.jpg");

            var acceleration = new Label();
            acceleration.AutoSize = true;
            acceleration.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            acceleration.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            acceleration.Text = $"Acceleration: {Acceleration}";
            card.Controls.Add(acceleration);

            var maxSpeed = new Label();
            maxSpeed.AutoSize = true;
            maxSpeed.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            maxSpeed.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            maxSpeed.Text = $"Max speed: {MaxSpeed}";
            card.Controls.Add(maxSpeed);

            return card;
        }
    }
}