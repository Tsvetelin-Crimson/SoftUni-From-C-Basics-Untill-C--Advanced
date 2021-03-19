using E04_05_06BorderControl_Bday_FoodS.Interfaces;

namespace E04_05_06BorderControl_Bday_FoodS
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string ID { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
