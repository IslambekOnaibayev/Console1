using System.Threading.Channels;

namespace Console1
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var tom = new Person("Tomas", 32);
            Console.WriteLine(tom.Name);    //Tomas
            var bob = (Person)tom.Clone();
            bob.Name = "Bobas";
            Console.WriteLine(bob.Name);    //Bobas
            Console.WriteLine(tom.Name);    //Bobas

        }
    }

    public class Person: ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }


}






