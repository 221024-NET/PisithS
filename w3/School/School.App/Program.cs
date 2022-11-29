using System;
using School.DataInfrastructure;
using School.Logic;

//! Namespaces are vital in our class organizations. We simply can create a new class with a different namespace through our Solution, clicking on add new project. Adding a new item will simply create one within whatever project that we are in. Which is fine if you want to encompass whatever class we made within the same project. So for example we have a School.cs file within the same namespace, that is because it handles calling to the methods within the other classes without it being within this Program.cs so basically it's for managing and structuring our files and folder.
namespace School.App
{
    /* This is the starting program hence the name Program.cs in which we will demonstrate a small demo of what we have learned so far. Including SQL, Unit Testing and Structures. PLEASE USE THIS as a guide for the P1 Project. My comment will include a brief detailed descriptions of parts of what each lines of code does and how to possibly utilize it within my own Project and Personal Project. This program NEEDS to be understood on some level in order to properly implement and retain the idea of all that we have been taught so far within our training course.
     */
    class Program
    {
        static void Main()
        {
            //    Console.WriteLine("Hello Again!");

            //    Student temp = new Student(123, "Jonathan");
            //    Console.WriteLine(temp.Introduce());

            //    Teacher temp2 = new Teacher(098, "Brian");
            //    Console.WriteLine(temp2.Introduce());

            //! This will pull our connection string that we have within a file. The connection CAN be inserted our program BUT in order to practice proper security measures within our projects, it is BEST PRACTICE to have it within a separate textfile or possibly within our gitignore file; if I know how to do that properly
            //? See if it is possible to insert the connection string into our gitignore file and pull it properly
            string connectionString = File.ReadAllText(@"/Revature/ConnectionStrings/220307-DB.txt") ; //CONNECTION STRING GOES HERE!!!!!

            //!We are simply creating a IRepository and the reason we have it set it equal to a SqlRepository is to fulfil the contract the the IRepository is asking for beccause within our SqlRepository we have already established the connection that a SqlRepository will fulfil the contract the Repository has. SqlRepository.cs Line 6
            IRepository repo = new SqlRepository(connectionString);

            //!We are creating a new School object with the parameters of the repo we established above. We can sort of think of this class as a way to handle most of the method that we will be using without having it within our Program.cs file. More information will be within the School.cs file
            School mySchool = new School(repo);

            //! We are creating a Student object as we give it a value of mySchool.GetStudent(4). This is doing a number of things, first off this is calling the method GetStudent to our School object with the parameters of the StudentId being 4. So we want the student with the Id of 4. So without going into details, this calls to the method within the School object which then also calls to a method within our SqlRepository and it pulls properly the data we are asking for. More information can be found in SqlRepository.cs and School.cs
            Student tmpStudent = mySchool.GetStudent(4);

            //! After finding out our student of the table, we are then calling the method Introduce()  to simply write to the console.
            Console.WriteLine(tmpStudent.Introduce());

            //! Much like line 32 we are calling a method which then in turn calls to another method which BTW is handling all of "talking" to the database. After which getting the proper value we fix up what will be written to the console along with the proper information.
            Console.WriteLine(mySchool.IntroduceAllTeachers());

            ////Teacher NewTeacher = repo.CreateNewTeacher("Jerome");
            ////Console.WriteLine(NewTeacher.Introduce());


            //Console.WriteLine(repo.GetStudentName(4));




        }



 
    }
}