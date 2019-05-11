using cpu_model.core;
using System;

namespace cpu_model {
    internal static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main() {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            PriorityQueue<int> test1 = new PQHashTable<int>(0, 5);
            Console.WriteLine(test1.Count());
            test1.Put(5);
            test1.Put(5);
            test1.Put(5);
            test1.Remove();
            test1.Clear();
            Console.WriteLine(test1.Count());
            Console.WriteLine(test1.Item());

        }
    }
}
