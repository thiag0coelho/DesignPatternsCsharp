
namespace Proxy
{
    public class ResponsiblePersonProxy
    {
        private Person person;
        public int Age { get; set; }

        public ResponsiblePersonProxy(Person person)
        {
            this.person = person;
            this.Age = person.Age;
        }

        public string Drink()
        {
            if (Age <= 18)
            {
                return "too young";
            }
            else
            {
                return "drinking";
            }
        }

        public string Drive()
        {
            if (Age <= 16)
            {
                return "too young";
            }
            else
            {
                return "driving";
            }
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}
