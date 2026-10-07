using ConsoleApp18.Teachers;
Teacher Teacher1 = new Teacher();

Teacher1.TeacherID = 12345678;
Teacher1.FirstName = "Mohammad";
Teacher1.LastName = "Ali";
Teacher1.FatherName = "Amir";
Teacher1.NationalID = 123456789;
Teacher1.Age = 35;
Teacher1.ClassSubject = "Computer";

Console.WriteLine($"{Teacher1.LastName} is giving an exam.");
Console.WriteLine($"{Teacher1.LastName} is giving a score.");

using ConsoleApp18.Customers;
Customer Customer1 = new Customer();

Customer1.CustomerID = 12345;
Customer1.FirstName = "Mohammad";
Customer1.LastName = "Ali";
Customer1.NationalID = 123456789;
Customer1.Address = "Narges Street"
Customer1.EmailAddress = "example@gmail.com";
Customer1.PhoneNumber = 1112223333;

Console.WriteLine($"{Customer1.CustomerID} has placed an order");
Console.WriteLine($"{Customer1.CustomerID} has cancelled an order");

using ConsoleApp18.Students;
Student Student1 = new Student();

Student1.StudentID = 12345678;
Student1.FirstName = "Mohammad";
Student1.LastName = "Ali";
Student1.FatherName = "Amir";
Student1.NationalID = 123456789;
Student1.Age = 16;
Student1.Major = "Math";

Console.WriteLine($"{Student1.LastName}'s score is 20.");
Console.WriteLine($"{Student1.LastName} is in class.");

using ConsoleApp18.Employees;
Employee Employee1 = new Employee();

Employee1.EmployeeID = 12345678;
Employee1.FirstName = "Mohammad";
Employee1.LastName = "Ali";
Employee1.NationalID = 123456789;
Employee1.Job = "Server Maintenance";

Console.WriteLine($"{Employee1.LastName} has worked for 72 hours in total.");
Console.WriteLine($"{Employee1.LastName} is paid 300$ weekly");

using ConsoleApp18.Rectangle;
Rectangle Rectangle1 = new Rectangle();

Rectangle1.X = 4;
Rectangle1.Y = 8;
Rectangle1.Area = 32;
Rectangle1.Perimeter = 24;

Console.WriteLine($"This Rectangle's Area is {Rectangle1.Area}");
Console.WriteLine($"This Rectangle's Perimeter is {Rectangle1.Perimeter}");

using ConsoleApp18.Square;
Square Square1 = new Square();

Square1.X = 4;
Square1.Angle = 360;
Square1.Sides = 4;

Console.WriteLine($"This Square's X is {Square1.X}");
Console.WriteLine($"This Square's Total Angle is {Square1.Angle}");

using ConsoleApp18.Dogs;
Dog Dog1 = new Dog();

Dog1.Name = "Ghahvei"
Dog1.BreedType = "Shepard";
Dog1.OwnerFirstName = "Mohammad";
Dog1.OwnerLastName = "Ali";
Dog1.Age = 2;

Console.WriteLine($"{Dog1.Name} is Healthy.");
Console.WriteLine($"{Dog1.Name} is Sleeping.");

using ConsoleApp18.Cats;
Cat Cat1 = new Cat();

Cat1.Name = "Narenji"
Cat1.BreedType = "Orange Tabby";
Cat1.OwnerFirstName = "Mohammad";
Cat1.OwnerLastName = "Ali";
Cat1.Age = 1;

Console.WriteLine($"{Cat1.Name} is Healthy.");
Console.WriteLine($"{Cat1.Name} is Sleeping.");

