using System;
using System.Collections.Generic;
using System.Text;

namespace Day5GameSalesSimulation
{
    class SalesManager
    {
        public void Sale (Members member,Games game,Discounts discount)
        {
            Console.WriteLine(member.Name+ " üyesi " + game.Name + " oyununu " + discount.Name + " indirimle satın aldı." );
        }
        public void Return (Members member,Games game)
        {
            Console.WriteLine(member.Name + " üyesi " + game.Name + " oyununu iade etti " );
        }


    }
}
