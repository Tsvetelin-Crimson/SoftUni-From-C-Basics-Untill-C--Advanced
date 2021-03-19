using E04_05_06BorderControl_Bday_FoodS.Interfaces;

namespace E04_05_06BorderControl_Bday_FoodS.Models
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }

        public string Birthdate { get; private set; }
    }
}
