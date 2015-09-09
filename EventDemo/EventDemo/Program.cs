using EventDemo.Common;
using EventDemo.Sugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //testBoss();
            // TestMultiTask();
            TestSugarTask();

            Console.ReadKey();
        }

        private static void testBoss()
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
        }

        /*
        private static void TestSimpleTask()
        {
            Task task = new Task();
            task.BindStatusChangeEvent(new StatusChangeHandler("INFO"));
            Console.WriteLine(task.DoIt(30));
            Console.WriteLine(task.DoIt(20));
            Console.WriteLine(task.DoIt(50));
        }
         * */

        /*
        private static void TestMultiTask()
        {
            Task task = new Task();
            task.BindStatusChangeEvent(new StatusChangeHandler("INFO"));
            task.BindStatusChangeEvent(new StatusChangeHandler("DEBUG"));
            task.BindStatusChangeEvent(new StatusChangeEmailHandler("admin@qwaevisz.hu", "David"));
            Console.WriteLine(task.DoIt(30));
            Console.WriteLine(task.DoIt(20));
            Console.WriteLine(task.DoIt(50));
        }
         * */

        private static void TestSugarTask()
        {
            Task task = new Task();
            task.statusChangeEvent += new StatusChangeHandler("INFO").OnChange;
            task.statusChangeEvent += new StatusChangeHandler("DEBUG").OnChange;
            task.statusChangeEvent += new StatusChangeEmailHandler("admin@qwaevisz.hu", "David").OnChange;
            task.statusChangeEvent += LocalStatusChangeEventHandler;
            Console.WriteLine(task.DoIt(30));
            Console.WriteLine(task.DoIt(20));
            Console.WriteLine(task.DoIt(50));
        }

        private static void LocalStatusChangeEventHandler(TaskStatus status, int progress)
        {
            Console.WriteLine("Change status to " + status + " (" + progress + "%)");
        }

    }
}
