using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databinding.ViewModels
{
    public class Example
    {

        public string HeaderMessage { get; set; }

        public List<OfThese> mooos = new List<OfThese>();


        public Example()
        {
               HeaderMessage = "hi from a c# file";
        }


        public void ChangePage()
        {
            System.Diagnostics.Debugger.Launch();
        }
        
        
    }

    public class OfThese
    {
        public string Name { get; set; }

        
        public void Moo()
        {
            Console.WriteLine($"One of them ({Name}) says hi");
        }
    }
}
