using System;
using System.Threading;

namespace ThreadProject
{
    class Program
    {
        static Object obj = new Object();
        static void Main(string[] args)
        {
            // Microsoft Exemplo
            ThreadPool.QueueUserWorkItem();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();

        }

        private static void ShowThreadInformation(Object state)
        {
            lock (obj)
            {

            }
        }
    }
}
