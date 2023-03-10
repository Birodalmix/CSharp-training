using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceBasic
{
    class TV : ElectricalDevice
    {
        public TV(bool ison, string brand):base(ison,brand)
        {
            IsOn = ison;
            Brand = brand;
        }
        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watch the TV!");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch it on first! ");
            }
        }
    }
}
