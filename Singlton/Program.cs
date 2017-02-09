using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Singlton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.name = "bob";
            Debug.Write("accessed the singleton" + Singleton.Instance.name);
        }
    }
}
