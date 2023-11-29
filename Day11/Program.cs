using Day10;
using System.Drawing;
using System.Xml.Linq;

namespace Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Human human = new Human("Shiama", 24, "shaima@gmail.com", "Sur, Oman");  
            human.PrintDetails();

            Human human1 = new Human("Sultana", 24, "Sultana@gmail.com", "Rustaq, Oman");
             human1.PrintDetails();

            Console.WriteLine(human1.Name);

            Human human2 = getVal();
            human2.PrintDetails();

           
            human2.setEmail("rrrr@com");
            human2.PrintDetails();
            

            Human human3 = new Human(name:"Sara", age:24, email: "Sara@gmail.com", address:"Ibri, Oman");
            human3.PrintDetails();

            Human human4 = new Human { Name = "Ali", Address ="Sohar, Oman" };
            human4.setAge(24);
            human4.setEmail("fr@kn");
            human4.PrintDetails();



        }

        static Human getVal()
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your age:");
            string age;
            int conInt = 0;
            do
            {
                age = Console.ReadLine();
                 conInt = Convert.ToInt32(age);
                // int checkAge is declared imnside while loop just
            } while (!(int.TryParse(age, out int checkAge) && Human.Validation(checkAge)));
            

            Console.WriteLine("Enter Your Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Your Addrss:");
            string addrss = Console.ReadLine();

            return new Human(name, conInt, email, addrss);
        }
        
    }
}