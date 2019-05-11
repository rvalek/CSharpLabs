using System;

namespace cpu_model.core {
    internal class Model {
        public static int lowestpriority = 0;
        public static int highestPriority = 10;

        public Random Rand {
            get; set;
        }

        /// <summary>
        /// ссылка на приоритетную очередь выбранного типа
        /// </summary>
        public PriorityQueue<int> PriorQueue {
            get; set;
        }

        public Model() {
            PriorQueue = new PQHashTable<int>(lowestpriority, highestPriority);
            Rand = new Random();
        }

    }
}