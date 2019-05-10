using System;

namespace cpu_model.core {
    internal class Model {
        public Random Rand {
            get; set;
        }

        public Model() {
            PriorQueue = null; /*new PriorityQueueArray<int>();*/
            Rand = new Random();
        }

        /// <summary>
        /// ссылка на приоритетную очередь выбранного типа
        /// </summary>
        public PriorityQueue<int> PriorQueue {
            get; set;
        }
    }
}