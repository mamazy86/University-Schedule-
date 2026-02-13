using Assignment;

List<double> student01Grades = new()
{
    17, 18, 15
};
List<string> student01Courses = new()
{
"Mathematics","Chemistry","Biology"
};
List<string> student01Teachers = new()
{
"Ali Najarian","MohamadMahdi Saeidi","Farhad Nasirloo"
};
Student student01 = new(student01Grades)
{
    FirstName = "AmirHossein",
    LastName = "Bayat",
    nationalCode = NationalCode.Create("0151416139"),
    StudentCode = StudentCode.Create("04213246678420"),
    Studentcourses = student01Courses,
    Teachers = student01Teachers,
};


List<double> student02Grades = new()
{
    16, 18.5, 14.5
};
List<string> student02Courses = new()
{
"Mathematics","Chemistry","Programming"
};
List<string> student02Teachers = new()
{
"Ali Najarian","MohamadMahdi Saeidi","Ali Hafezi"
};
Student student02 = new(student02Grades)
{
    FirstName = "Artin",
    LastName = "Khaleghi",
    nationalCode = NationalCode.Create("0151673022"),
    StudentCode = StudentCode.Create("04214568233920"),
    Studentcourses = student02Courses,
    Teachers = student02Teachers,
};


List<double> student03Grades = new()
{
    16.5, 19, 17
};
List<string> student03Courses = new()
{
"Biology","Chemistry","Programming"
};
List<string> student03Teachers = new()
{
"Farhad Nasirloo","MohamadMahdi Saeidi","Ali Hafezi"
};
Student student03 = new(student03Grades)
{
    FirstName = "MohamadReza",
    LastName = "Panahandeh",
    nationalCode = NationalCode.Create("0151434050"),
    StudentCode = StudentCode.Create("04267754239820"),
    Studentcourses = student03Courses,
    Teachers = student03Teachers,
};


List<string> teacher01Courses = new()
{
"Programming"
};
Teacher teacher01 = new()
{
    FirstName = "Ali",
    LastName = "Hafezi",
    nationalCode = NationalCode.Create("0026768532"),
    TeacherCode = TeacherCode.Create("09856781"),
    Teachercourses = teacher01Courses,
};


List<string> teacher02Courses = new()
{
"Biology","Chemistry"
};
Teacher teacher02 = new()
{
    FirstName = "Farhad",
    LastName = "Nasirloo",
    nationalCode = NationalCode.Create("0026473554"),
    TeacherCode = TeacherCode.Create("09834457"),
    Teachercourses = teacher02Courses,
};

List<string> teacher03Courses = new()
{
"Physics","Mathematics"
};
Teacher teacher03 = new()
{
    FirstName = "MohamadMahdi",
    LastName = "Saeidi",
    nationalCode = NationalCode.Create("0028243310"),
    TeacherCode = TeacherCode.Create("09874512"),
    Teachercourses = teacher03Courses,
};


List<double> class01grades = new()
{
    17.5,18
};
List<Student> class01presentstudents = new List<Student>()
{
    student01, student02
};
Random random01 = new();
int class01year = 2025;
int class01month = 8;
int class01day = random01.Next(1, 29);
DateOnly class01date = new DateOnly(class01year, class01month, class01day);
UniversityClass class01 = new(class01grades)
{
    taughtCourse = UniversityClass.CreateCourse("Biology"),
    Time = class01date,
    presentStudents = class01presentstudents,
    presentTeacher = teacher01,
    classCode = ClassCode.Create("27443"),
};

List<double> class02grades = new()
{
    16,18.5
};
List<Student> class02presentstudents = new List<Student>()
{
    student01, student03
};
Random random02 = new();
int class02year = 2025;
int class02month = 8;
int class02day = random02.Next(1, 29);
DateOnly class02date = new DateOnly(class02year, class02month, class02day);
UniversityClass class02 = new(class02grades)
{
    taughtCourse = UniversityClass.CreateCourse("Mathematics"),
    Time = class02date,
    presentStudents = class02presentstudents,
    presentTeacher = teacher03,
    classCode = ClassCode.Create("27123"),
};

List<double> class03grades = new()
{
    17,14
};
List<Student> class03presentstudents = new List<Student>()
{
    student02, student03
};
Random random03 = new();
int class03year = 2025;
int class03month = 8;
int class03day = random02.Next(1, 29);
DateOnly class03date = new DateOnly(class03year, class03month, class03day);
UniversityClass class03 = new(class03grades)
{
    taughtCourse = UniversityClass.CreateCourse("Programming"),
    Time = class03date,
    presentStudents = class03presentstudents,
    presentTeacher = teacher01,
    classCode = ClassCode.Create("27239"),
};

Console.WriteLine("enter your code :");
string? input = Console.ReadLine()?.Trim();


if (input?.Length == 14)
{
    switch (input)
    {
        case "04213246678420":
            Console.WriteLine(student01);
            Console.WriteLine($"\vcourses :");
            foreach (var item in student01.Studentcourses)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\vteachers :");
            foreach (var item in student01.Teachers)
            {
                Console.WriteLine(item);
            }
            break;
        case "04214568233920":
            Console.WriteLine(student02);
            Console.WriteLine($"\vcourses :");
            foreach (var item in student02.Studentcourses)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\vteachers :");
            foreach (var item in student02.Teachers)
            {
                Console.WriteLine(item);
            }
            break;
        case "04267754239820":
            Console.WriteLine(student03);
            Console.WriteLine($"\vcourses :");
            foreach (var item in student03.Studentcourses)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\vteachers :");
            foreach (var item in student03.Teachers)
            {
                Console.WriteLine(item);
            }
            break;
    }
}

else if (input?.Length == 8)
{
    switch (input)
    {
        case "09856781":
            Console.WriteLine(teacher01);
            Console.WriteLine($"\vcourses :");
            foreach (var item in teacher01.Teachercourses)
            {
                Console.WriteLine(item);
            }
            break;
        case "09834457":
            Console.WriteLine(teacher02);
            Console.WriteLine($"\vcourses :");
            foreach (var item in teacher02.Teachercourses)
            {
                Console.WriteLine(item);
            }
            break;
        case "09874512": 
            Console.WriteLine(teacher03);
            Console.WriteLine($"\vcourses :");
            foreach (var item in teacher03.Teachercourses)
            {
                Console.WriteLine(item);
            }
            break;
    }
}

else if (input?.Length == 5)
{
    switch (input)
    {
        case "27443":
            Console.WriteLine(class01);
            Console.WriteLine("\vpresent students :");
            foreach (var item in class01.presentStudents)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            break;
        case "27123":
            Console.WriteLine(class02);
            Console.WriteLine("\vpresent students :");
            foreach (var item in class02.presentStudents)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            break;
        case "27239":
            Console.WriteLine(class03);
            Console.WriteLine("\vpresent students :");
            foreach (var item in class03.presentStudents)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            break;
    }
}
else
{
    Console.WriteLine("invalid input!");
}




