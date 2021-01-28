using System;
using System.Collections.Generic;
using System.Text;

namespace Day4MyDictionary
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] Tkeys;
        Tvalue[] Tvalues;
        Tkey[] TkeysTemp;
        Tvalue[] TvaluesTemp;

        public MyDictionary()
        {
            Tkeys = new Tkey[0];
            Tvalues = new Tvalue[0];
          
        }

        public void Add(Tkey key,Tvalue value)
        {
            TkeysTemp = Tkeys;
            TvaluesTemp = Tvalues;

            Tkeys = new Tkey[Tkeys.Length + 1];
            
            for (int i = 0; i < Tkeys.Length; i++)
            {
                Tkeys[i] = TkeysTemp[i];

            }
            Tkeys[Tkeys.Length - 1] = key;

            Tvalues = new Tvalue[Tvalues.Length + 1];

            for (int i = 0; i < Tvalues.Length; i++)
            {
                Tvalues[i] = TvaluesTemp[i];
            }
            Tvalues[Tvalues.Length - 1] = value;

        }
        public int Length
        {
            get { return Tkeys.Length; }
        }

        public Tkey[] Items
        {
            get { return Tkeys; }
        }









    }


            

}



