using Business.Concrete;
using Entities.Concrete;

namespace WorkSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "RIFAT";
            p.Surname = "İŞLER";
            p.DateOfBirthDate = 1996;
            p.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(p);
        }
    }

   
}
