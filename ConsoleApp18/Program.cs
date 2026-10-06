using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClasses
{
    public  class Customer
    {
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public int NationalID { get; set; }
        public int PhoneNumber { get; set; }
    }
    public class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public int NationalID { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
    }
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public int NationalID { get; set; }
        public int Age { get; set; }
        public string ClassSubject { get; set; }
    }
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalID { get; set; }
        public string Job { get; set; }
        public int EmployedDate { get; set; }
    }
    public class Rectangle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
    }
    public class Square
    {
        public double Angle { get; set; }
        public int Sides { get; set; }
        public double X { get; set; }
    }
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public int Age { get; set; }
    }
    public class Cat
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public int Age { get; set; }
    }
}
