using System.Windows.Forms;

namespace Autopark.Car
{
    public abstract class Car
    {
        protected static uint count = 0;

        protected uint id;
        public string Brand { get; }
        public string Model { get; }
        public uint Price { get; protected set; }
        public Engine Engine { get; protected set; }

        public Car(string brand, string model, uint price, EngineType type)
        {
            count++;

            id = count;
            Brand = brand;
            Model = model;
            Price = price;
            Engine = new Engine(type);
        }

        protected virtual void UpdatePrice(EngineType oldEngineType, EngineType newEngineType)
        {
            Price *= (uint)(Engine.PricesCoefficients[(int)newEngineType] / Engine.PricesCoefficients[(int)oldEngineType]);
        }

        public void ChangeEngine(Engine newEngine)
        {
            UpdatePrice(Engine.Type, newEngine.Type);
            Engine = newEngine;
        }

        public virtual Panel Visualize()
        {
            var card = new Panel();
            card.AutoSize = true;
            card.Location = new Point(0, 0);
            card.BackColor = Color.Pink;

            var photo = new PictureBox();
            photo.Location = new Point(0, 0);
            photo.Size = new Size(200, 200);
            photo.SizeMode = PictureBoxSizeMode.StretchImage;
            card.Controls.Add(photo);

            var brandAndModel = new Label();
            brandAndModel.AutoSize = true;
            brandAndModel.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            brandAndModel.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            brandAndModel.Text = $"{Brand}, {Model}";
            card.Controls.Add(brandAndModel);

            var price = new Label();
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            price.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            price.Text = $"Price: {Price}";
            card.Controls.Add(price);

            var engineType = new Label();
            engineType.AutoSize = true;
            engineType.Font = new Font("Segoe UI", 12.2F, 0, GraphicsUnit.Point, 204);
            engineType.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
            engineType.Text = "Engine type: " + (Engine.Type == EngineType.Petrol ? "Petrol" : Engine.Type == EngineType.Gas ? "Gas" : "Electric");
            card.Controls.Add(engineType);

            return card;
        }
    }
}