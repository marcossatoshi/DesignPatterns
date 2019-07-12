using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Subject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("Subject: Foi feito um request.");
        }
    }
}
