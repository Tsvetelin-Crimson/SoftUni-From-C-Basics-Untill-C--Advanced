namespace E04_05_06BorderControl_Bday_FoodS
{
    public class Robot : IIdentifiable
    {

        public Robot(string model, string id)
        {
            this.Model = model;
            this.ID = id;
        }

        public string Model { get; set; }

        public string ID { get; private set; }
    }
}
