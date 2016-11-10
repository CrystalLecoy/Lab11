using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClasses
{
    public class Person
    {
        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        private string Name;
        //
        private string Address;
        //
        public string getAddress()
        {
            return Address;
        }
     
        public string getName()
        {
            return Name;
        }

        public void setAddress(string Address)
        {
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"Person[Name = {Name}, Address = {Address}]";
        }
    }

    public class Student : Person
    {
        public Student(string Name, string Address, string Program, int Year, double Fee) : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        private string Program;
        //public string program
        //{
        //    get { return Program; }
        //    set { Program = value; }
        //}

        public string getProgram()
        {
            return Program;
        }
        public void setProgram(string Program)
        {
            this.Program = Program;
        }

        private int Year;
        //public int year
        //{
        //    get { return Year; }
        //    set { Year = value; }
        //}

        public int getYear()
        {
            return Year;
        }
        public void setYear(int Year)
        {
            this.Year = Year;
        }

        private double Fee;
        //public double fee
        //{
        //    get { return Fee; }
        //    set { Fee = value; }
        //}

        public double getFee()
        {
            return Fee;
        }
        public void setFee(double Fee)
        {
            this.Fee = Fee;
        }

        public override string ToString()
        {
            return $"Student[{base.ToString()} Program = {Program}, Year = {Year}, Fee = {Fee}]";
        }

    }

    public class Staff : Person
    {
        public Staff(string Name, string Address, string School, double Pay) : base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        private string School;
        //public string school
        //{
        //    get { return School; }
        //    set { School = value; }
        //}

        public string getSchool()
        {
            return School;
        }
        public void setSchool(string School)
        {
            this.School = School;
        }

        private double Pay;
        //public double pay
        //{
        //    get { return Pay; }
        //    set { Pay = value; }
        //}

        public double getPay()
        {
            return Pay;
        }
        public void setPay(double Pay)
        {
            this.Pay = Pay;
        }

        public override string ToString()
        {
            return $"Staff[{base.ToString()} School = {School}, Pay = {Pay}]";
        }
    }
}

