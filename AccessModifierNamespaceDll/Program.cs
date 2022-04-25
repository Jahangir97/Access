using System;

namespace AccessModifierNamespaceDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("23aa", 2);
            Console.WriteLine("Group No: 23aa\n");

            Student student1 = new Student("Cahangir", "Nagiz");
            Student student2 = new Student("Arzu", "Rehmanova");
            Student student3 = new Student("Resul", "Cunayev");

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.GetStudents();
        }
    }
}
