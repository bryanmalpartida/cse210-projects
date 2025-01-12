using System;

class Program
{
    static void Main(string[] args)
    {
        //INPUT QUESTION
        Console.Write("What is your grade percentage? ");

        //VARIABLES 

        //grade is an int variable which comes from response to question above
        string gradeinput=Console.ReadLine();
        int grade = int.Parse(gradeinput);

        //last digit  = last digit of grade
        int lastdigit = grade%10;

        //letter assigned
        string letter="";

        string simbol="";

        //CONDITIONALS
        if (grade >= 90)
        {
            letter="A";
        }

         else if (grade >= 80 && grade<90)
        {
            letter="B";
        }

        else if (grade >= 70 && grade<80)
        {
            letter="C";
        }

        else if (grade >= 60 && grade<70)
        {
            letter="D";
        }

        else
        {
            letter="F";
        }


        //conditional for simbols

        if (lastdigit>=7)
        {
            simbol="+";
        }

        else if (lastdigit<3)
        {
            simbol="-";
        }

        else
        {
            simbol="";
        }

        //EXCEPTIONS FOR SIMBOLS

        if (grade>=93)
        {
            simbol="";
        }

         if (letter=="F")
        {
            simbol="";
        }



        //PRINTING RESULTS

        Console.WriteLine($"Your letter grade is: {letter}{simbol}");

        //print + conditional. different message depending if student passed or not

        if (grade>=70)
        {
            Console.WriteLine("Congratulations! You have passed the course!");
        }

        else
        {
            Console.WriteLine("You have not passed the course.");
        }

        if (gradeinput)
    }
}