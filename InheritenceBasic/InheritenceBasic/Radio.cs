using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceBasic
{
     class Radio : ElectricalDevice
    {
        public Radio(bool ison, string brand):base(ison,brand)
        {
            this.IsOn = ison;
            this.Brand = brand;
        }
        public void ListenRadio() 
        {
            if (IsOn)
            {
                Console.WriteLine("Listen to the radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first! ");
            }
        }
    }
}
