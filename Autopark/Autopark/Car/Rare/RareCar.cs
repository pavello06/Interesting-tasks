namespace Autopark.Car.Rare
{
    public class RareCar : Car
    {
        private uint carEvaluationYear;
        public uint Year { get; }
        public string FirstOwner { get; }

        public RareCar(string brand, string model, uint price, EngineType type, uint carEvaluationYear, uint year, string firstOwner) : base(brand, model, price, type)
        {
            this.carEvaluationYear = carEvaluationYear;
            Year = year;
            FirstOwner = firstOwner;
        }

        protected override void UpdatePrice(EngineType oldEngineType, EngineType newEngineType)
        {
            Price = 0;
        }

        public void UpdatePrice()
        {
            Price += (uint)((carEvaluationYear - DateTime.Now.Year) * 100);
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../Car/Images/PetrolRare.jpg" : Engine.Type == EngineType.Gas ? "../../../Car/Images/GasRare.jpg" : "../../../Car/Images/ElectricRare.jpg");

            var year = new Label();
            year.AutoSize = true;
            year.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            year.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            year.Text = $"Year: {Year}";
            card.Controls.Add(year);

            var firstOwner = new Label();
            firstOwner.AutoSize = true;
            firstOwner.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            firstOwner.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            firstOwner.Text = $"First owner: {FirstOwner}";
            card.Controls.Add(firstOwner);

            return card;
        }
    }
}