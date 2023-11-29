
using System.Reflection.Metadata.Ecma335;

namespace Day10
{
    internal class Human
    {
        private static int con;
        private int id;
        private string name;
        private int age;
        private string email;
        private string address;

        public Human()
        {
            id= ++con;
        }
        public Human(string name, int age, string email, string address)
        {
            id = ++con;
            this.name = name;
            this.age = age;
            this.email = email;
            this.address = address;
        }

        public static int getCon() => con;

        public int getID() => id;

        public string Name
        {
            get { return this.name; }

            set { this.name = value; }
        }

        public int getAge() => age;
        public void setAge(int age) => this.age = age;

        public string getEmail() => email;
        public void setEmail(string email) => this.email = email;


        public string Address
        {
            get{ return this.address; }

            set{  this.address = value; }
        }


        public void PrintDetails() =>
        
            Console.WriteLine("_________________________________\n"+
            $"|Human ID: {id}\n" +
                $"|Human Name: {this.name}\n" +
                $"|Human Email: {this.email}\n" +
                $"|Human Address: {this.address}\n");
        

        public static bool Validation(int age) => (age <=0 || age>=100)?  false : true;

            

        

    }
}
