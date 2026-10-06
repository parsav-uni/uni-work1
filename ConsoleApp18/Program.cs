using ConsoleApp18.Teachers;

Teacher Teacher1 = new Teacher();

teacher1.TeacherID = 12345678;
teacher1.FirstName = "Mohammad";
teacher1.LastName = "Ali";
teacher1.FatherName = "Amir";
teacher1.NationalID = 123456789;
teacher1.Age = 35;
teacher1.ClassSubject = "Computer";

GiveExam(teacher1);
GiveScore(teacher1);

static void GiveExam(Teacher teacher)
{
    Console.WriteLine($"{teacher.LastName} is giving an exam.");
}

static void GiveScore(Teacher teacher)
{
    Console.WriteLine($"{teacher.LastName} is giving a score.");
}