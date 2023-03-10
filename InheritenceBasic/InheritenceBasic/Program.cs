using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false,"Sony");
            //method of a base class
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false,"Samsung");
            //method of a base class
            myTV.SwitchOn();
            myTV.WatchTV();
        
        }
    }
}
