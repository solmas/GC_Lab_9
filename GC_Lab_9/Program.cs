using System;
using System.Collections.Generic;

namespace GC_Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question:  Do lists have to live in the main string?  Would a list in a function instantiate itself multiple times?
            List<string> studentName = new List<string>();
            studentName.Add("Cyan Garamonde");
            studentName.Add("Locke Cole");
            studentName.Add("Celes Chere");
            studentName.Add("Terra Branford");
            studentName.Add("Sabin Fiagro");
            studentName.Add("Relm Arrowny");


            List<string> favoriteFood = new List<string>();
            favoriteFood.Add("Unpoisoned Water");
            favoriteFood.Add("Lucky Charms");
            favoriteFood.Add("Fresh fish");
            favoriteFood.Add("Magi-tek-i-o's");
            favoriteFood.Add("Dried meat");
            favoriteFood.Add("Marshmallows");


            List<string> hometown = new List<string>();
            hometown.Add("Kingdom of Doma");
            hometown.Add("Rachel's House");
            hometown.Add("Gestahlian Empire");
            hometown.Add("Esper World");
            hometown.Add("Figaro Castle");
            hometown.Add("Thamasa Village");

            List<string> specialAbility = new List<string>();
            specialAbility.Add("SwdTechs");
            specialAbility.Add("Steal");
            specialAbility.Add("Runic Blade");
            specialAbility.Add("Morph");
            specialAbility.Add("Blitz");
            specialAbility.Add("Sketch");

            bool anotherStudent = true;

            Console.WriteLine("Hello and welcome to our C# class!");

            while (anotherStudent == true)
            {
                //int addNew;
                //string newStudent;
                //int newStudentInfo;

                //Console.WriteLine("Which student would you like to learn about? (Select a number beteween 0 and 5)");
                //string existing = Console.ReadLine();
                //Int32.TryParse(existing, out addNew);

                //while (addNew == 2)
                //{
                //    Console.WriteLine("Please enter student's name.");
                //    newStudent = Console.ReadLine(studentName.Add());
                //    Int32.TryParse(newStudent, out newStudentInfo);

                //    Console.WriteLine("Please enter" + studentName(newStudentInfo) + "'s favorite food.");
                //    Console.ReadLine(favoriteFood.Add());
                //    Console.WriteLine("Plese enter" + studentName(newStudentInfo) + "'s home town.");
                //    Console.ReadLine(hometown.Add());
                //    Console.WriteLine("Please enter" + studentName(newStudentInfo) + "'s special ability.");
                //    Console.ReadLine(specialAbility.Add());

                //    Console.WriteLine("Would you like to: \n (1) add another student or \n (2) look up an existing student?");
                //    newStudent = Console.ReadLine();
                //    Int32.TryParse(newStudent, out addNew);
                //}
                int studentSelectionIndex;
                string studentSelection = Console.ReadLine();
                Int32.TryParse(studentSelection, out studentSelectionIndex);
                studentSelectionIndex = StudentSelection();
                while(studentSelectionIndex > studentName.Count || studentSelectionIndex < 0)
                {
                    Console.WriteLine("I'm sorry, that student does not exist.  Please enter a valid student number.");
                    studentSelectionIndex = StudentSelection();
                }
                Console.WriteLine(studentName[studentSelectionIndex]);

                int studentInfoIndex = StudentInfoIndex();


                if (studentInfoIndex == 0)
                {
                    Console.WriteLine(favoriteFood[studentSelectionIndex] + " is " + (studentName[studentSelectionIndex]) + "'s favorite food, yummy!");
                }
                else if (studentInfoIndex == 1)
                {
                    Console.WriteLine(hometown[studentSelectionIndex] + " is " + (studentName[studentSelectionIndex]) + "'s hometown!");
                }
                else if (studentInfoIndex == 2)
                {
                    Console.WriteLine(specialAbility[studentSelectionIndex] + " is " + (studentName[studentSelectionIndex]) + "'s special ability, kick ass!");
                }

                anotherStudent = AnotherStudent();

                if(anotherStudent == true)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }


        public static int StudentSelection()
        {
            int studentSelectionIndex;
            int addNew;

            Console.WriteLine("Which student would you like to learn about? (Select a number beteween 0 and 5)");
            //string existing = Console.ReadLine();
            //Int32.TryParse(existing, out addNew);
            //if (addNew == 2)
            //{
            //    Console.WriteLine("Please enter student's name.");
            //    Console.ReadLine(studentName.Add(""));
            //}
            string studentSelection = Console.ReadLine();
            Int32.TryParse(studentSelection, out studentSelectionIndex);

            return studentSelectionIndex;
        }

        public static int StudentInfoIndex()
        {
            int studentInfoIndex;

            Console.WriteLine("Would you like to know their (0)favorite food, (1)hometown, or (2)special ability?");
            string studentInfo = Console.ReadLine();
            Int32.TryParse(studentInfo, out studentInfoIndex);

            return studentInfoIndex;
        }

        public static bool AnotherStudent()
        {
            bool anotherStudent;
            Console.WriteLine("Would you like to know about another student? (Y or N)");
            string moreInfo = Console.ReadLine();

            if(moreInfo == "Y" || moreInfo == "y")
            {
                anotherStudent = true;
            }
            else
            {
                anotherStudent = false;
            }
            
            return anotherStudent;
        }

        public static bool SameStudent()
        {
            bool sameStudent = false;
            Console.WriteLine("Would you like to know more about this student? (Y or N)");
            string moreInfo = Console.ReadLine();


            if (moreInfo == "Y" || moreInfo == "y")
            {
                sameStudent = true;
            }
            else
            {
                sameStudent = false;
            }
            return sameStudent;
        }

    }
}
