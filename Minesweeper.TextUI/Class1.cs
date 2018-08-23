using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.TextUI
{
    public class Class1
    {
        public void GetCell()
        {
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
