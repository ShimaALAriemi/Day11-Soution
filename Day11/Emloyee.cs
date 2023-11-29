
namespace Day9
{
     class Emloyee
    {
        private int count = 0;
        private int id;
        private string Fname;
        private string Lname;
        private int age;
        private int hours;
        private decimal wags;
        private decimal salary;

        public Emloyee(string Fname, string Lname, int age , int hours, int wags )
        {
            this.id = ++count;
            this.Fname = Fname;
            this.Lname = Lname;
            this.wags = age;
            this.hours = hours;
        }

        public Emloyee()
        {
            this.id = ++count;
        }

        public int getId() => this.id;

        public string FName
        {
            get { return this.Fname; }
            set { this.Fname = value; }
        }
        public string LName
        {
            get { return this.Lname; }
            set { this.Lname = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public int Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }

        public decimal Wags
        {
            get { return this.wags; }
            set { this.wags = value; }
        }


        public decimal getSalary() =>  this.wags * 0.3m * this.hours; 
        

    }
}
