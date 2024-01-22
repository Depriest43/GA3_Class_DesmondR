using System;

namespace GA3_Class_DesmondR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine("Student 1:");
            student1.DisplayInfo();

            Student student2 = new Student("Desmond R.", 30, "Csi");
            Console.WriteLine("Information about the second student:");
            student2.DisplayInfo();

            Professor professor1 = new Professor();
            Console.WriteLine("Professor 1:");
            professor1.DisplayInfo();
        }
    }
}

