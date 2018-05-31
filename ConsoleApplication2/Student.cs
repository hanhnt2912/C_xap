namespace ConsoleApplication2
{
    public class Student
    {
        private string name;
        private string rollnumber;
        private string email;
        private string phone;

        public Student()
        {
        }

        public Student(string name, string rollnumber, string email, string phone)
        {
            this.name = name;
            this.rollnumber = rollnumber;
            this.email = email;
            this.phone = phone;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Rollnumber
        {
            get { return rollnumber; }
            set { rollnumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public override string ToString()
        {
            return this.Name + this.Rollnumber + this.Email + this.Phone;
        }
    }
}