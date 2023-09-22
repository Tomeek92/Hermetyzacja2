using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hermetyzacja2
{
    public class Użytkownik
    {
        public string imie;
       private int wiek;
        
     
        

        public int wiekProp
        {
            get
            {
                
                return wiek;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nieprawidłowa wartośc ");
                }
                else if (value >= 130)
                {
                    Console.WriteLine("Nikt nie żyje tyle lat!");
                }
                else if (value >= 0 && value <= 129) 
                wiek = value;
            }
        }

    }
}
