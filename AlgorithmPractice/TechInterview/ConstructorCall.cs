using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.TechInterview
{
    public class School
    {
        public School() // 3
        {
            Console.WriteLine("Inside Public School");
        }

        static School() //2
        {
            Console.WriteLine("Inside Static School");
        }


    }

    public class University : School
    {
        public University() //4
        {
            Console.WriteLine("Inside Public University");
        }

        static University() //1
        {
            Console.WriteLine("Inside Static University");
        }

    }


}
