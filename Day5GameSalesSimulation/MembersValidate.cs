using System;
using System.Collections.Generic;
using System.Text;

namespace Day5GameSalesSimulation
{
    class MembersValidate
    {
        public void Check(Members member)
        {
            Members dbMember1 = new Members { Id = 1, Name = "Atilla", Surname = "Çökmez", RTIdNumber = "14543442341", Birthday = 1987 };

            if (member.Id == dbMember1.Id) 
            { 
                Console.WriteLine("Kullanıcı doğrulama yapıldı"); 
            }else
            {
                Console.WriteLine("Kullanıcı doğrulama yapılamadı");
            }

            
        }
    }
}
