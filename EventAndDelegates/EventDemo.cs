﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    public class EventDemo
    {
        
        static void PassMsg()
        {
            Console.WriteLine("Congratulations ! You are pass with good score");
        }
        static void FailMsg()
        {
            Console.WriteLine("OOPs ! You are Fail");
        }
        //static void Main(string[] args)
        //{
        //    Student stud = new Student();
        //    // bind event with delegate / configuration
        //    stud.Pass += new Student.DisplayMessage(PassMsg);
        //    stud.Fail += new Student.DisplayMessage(FailMsg);

        //    stud.AcceptMarks(30);


        //}

    }
}