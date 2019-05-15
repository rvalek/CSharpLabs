using System;

namespace cpu_model.core {
    internal class Model {
        private static readonly Random rand = new Random();

        public readonly ClockGenerator ClockGen;
        public readonly CPU Cpu;
        public readonly PriorityQueue<Process> ReadyQueue;

        private readonly CPUScheduler CpuScheduler;
        private readonly double intensityThreshold;
        private readonly int burstMin;
        private readonly int burstMax;
        private readonly int priorityMin;
        private readonly int priorityMax;

        /// <summary></summary>
        /// Конструктор: создание модели
        /// Аргументы – параметры модели
        /// </summary>
        public Model(double _intensityThreshold, int _burstMin, int _burstMax, int _priorityMin, int _priorityMax) {
            // создание компонентов модели
            ClockGen = new ClockGenerator();
            Cpu = new CPU();
            ReadyQueue = new PQHashTable<Process>(_priorityMin, _priorityMax);
            CpuScheduler = new CPUScheduler(Cpu, ReadyQueue);

            intensityThreshold = _intensityThreshold;
            burstMin = _burstMin;
            burstMax = _burstMax;
            priorityMin = _priorityMin;
            priorityMax = _priorityMax;
        }

        /// <summary>
        /// действия модели на такте работы
        /// </summary>
        public void NextTime() {
            ClockGen.NextTime(); // увеличивается номер такта

            // eсли порог интенсивности поступления процессов не превышен
            if (rand.NextDouble() > intensityThreshold) {
                // создаётся новый процесс
                // и помещается в очередь готовых процессов
                ReadyQueue.Put(new Process(ClockGen.CurrentTime) {
                    // генерируется интервал обслуживания процесса процессором
                    BurstTime = rand.Next(burstMin, burstMax + 1),
                    // и приоритет
                    Priority = rand.Next(priorityMin, priorityMax + 1)
                });
            }

            // выполняется шаг работы центрального процессора
            Cpu.NextTime();

            // если требуется перепланировка
            if (RedevelopmentNeeded()) {
                // вызвается планировщик центрального процессора
                CpuScheduler.NextTime();
            }
        }
        public void Clear() {
            ClockGen.Clear();
            Cpu.Clear();
            ReadyQueue.Clear();
        }

        // вспомогательный метод, определяющий, требуется ли перепланировка
        private bool RedevelopmentNeeded() {
            return (Cpu.IsFree ||
                Cpu.RunningProcess.ExecutionTime == Cpu.RunningProcess.BurstTime);
        }
    }
}