using System;

namespace Day5GameSalesSimulation
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Members member1 = new Members { Id = 1, Name = "Atilla", Surname = "Çökmez", RTIdNumber="14543442341",Birthday=1987 };
            Members member2 = new Members { Id = 1, Name = "Rumeysa", Surname = "Dogan", RTIdNumber = "32543442341", Birthday = 1992 };
            Discounts discount1 = new Discounts {Id=1,Name="sepette %15",Discount=15 };
            Games game1 = new Games { Id=1,Name="Civilization V", };

            //tüm servisler burda tanımlandı.üye,kampanya, oyun tek yerden eklenip silinebiliyor.
            ServiceManager serviceManager = new ServiceManager(); 
            serviceManager.Add(member1);
            serviceManager.Delete(member2);;
            serviceManager.Update(discount1);

            //Dogrulama için üye göndermek yeterli
            MembersValidate validate = new MembersValidate();
            validate.Check(member1);

            //Satıs, uye entegresyanu aynı anda yapıldı
            SalesManager salesManager = new SalesManager();
            salesManager.Sale(member2,game1,discount1);

        }
    }
}
