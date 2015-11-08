using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbDemo.DAL;

namespace DbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoConsole demo = new DemoConsole();
            DeviceCategoryContext DeviceCategory = new DeviceCategoryContext();
            demo.DemoCons(DeviceCategory);
            Console.ReadKey();

        }
        
    }
}
