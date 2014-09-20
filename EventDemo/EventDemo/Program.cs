using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Process process = new Process();
            Boss boss = new Boss("Joe");
            Boss bossOfBoss = new Boss("Steve");
            boss.init(process);
            bossOfBoss.init(process, new BossDoneHandler());

            process.step(10, "test");
            process.step(20, "implement");
            process.step(30, "review");
            process.step(50, "repair");
            process.step(10, "refactor");

            Console.ReadKey();
        }
    }
}
