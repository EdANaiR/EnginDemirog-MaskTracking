using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class Program
    {

        Person person1 = new Person();

            person1.FirstName = "Eda";
            person1.LastName = "Nair";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 96547854;

            Person person2 = new Person();
            person2.FirstName = "Hüseyin";

            



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();




            static void Main(string[] args)
            {
            Person person = new Person();
            }
    }
}
