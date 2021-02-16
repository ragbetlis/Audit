using Audit.Business.Abstract;
using Audit.Business.Concrete;
using Audit.DataAccess.Abstract;
using Audit.DataAccess.Concrete.EntityFramework;
using System;

namespace Audit.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IHealthcareProviderService healthcareProviderService = new HealthcareProviderManager(new EfHealthcareProviderDal());
            //var result = healthcareProviderService.GetAll();
            //Console.WriteLine(result.Message);
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine(item.Name+": "+item.Address);
            //}

            //IPersonService personService = new PersonManager(new EfPersonDal());
            //var result = personService.GetById(8);
            //Console.WriteLine($"{result.Data.FirstName} {result.Data.LastName}: {result.Data.Email}");
            //Console.WriteLine(result.Success+": "+result.Message);


        }
    }
}
