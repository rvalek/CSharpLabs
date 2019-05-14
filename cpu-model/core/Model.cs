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

        private readonly int processPriorityMin = 0;
        private readonly int processPriorityMax = 9;

        /// <summary></summary>
        /// Конструктор: создание модели
        /// Аргументы – параметры модели
        /// </summary>
        public Model(double _intensityThreshol, int _burstMin, int _burstMax) {
            // создание компонентов модели
            ClockGen = new ClockGenerator();
            Cpu = new CPU();
            ReadyQueue = new PQHashTable<Process>(processPriorityMin, processPriorityMax);
            CpuScheduler = new CPUScheduler(Cpu, ReadyQueue);

            // сохранение параметров системы
            intensityThreshold = _intensityThreshol;
            burstMin = _burstMin;
            burstMax = _burstMax;
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
                    Priority = rand.Next(processPriorityMin, processPriorityMax + 1)
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