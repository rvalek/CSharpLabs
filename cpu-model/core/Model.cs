using System;

namespace cpu_model.core {
    internal class Model {
        /// <summary></summary>
        /// Конструктор: создание модели
        /// Аргументы – параметры модели
        /// </summary>
        public Model(double it, int burstMin, int burstMax) {
            // создание компонентов модели
            ClockGen = new ClockGenerator();
            Cpu = new CPU();
            ReadyQueue = new PQHashTable<Process>();
            CpuScheduler = new CPUScheduler(Cpu, ReadyQueue);
            ProcessRand = new Random();
            // сохранение параметров системы
            intensityThreshold = it;
            this.burstMin = burstMin;
            this.burstMax = burstMax;
        }

        /// <summary>
        /// действия модели на такте работы
        /// </summary>
        public void NextTime() {
            ClockGen.NextTime(); // увеличивается номер такта
            if (ProcessRand.NextDouble() > intensityThreshold) {
                // порог интенсивности поступления процессов не превышен

                // создаётся новый процесс
                Process newProcess = new Process(ClockGen.Clock) {
                    // генерируется интервал обслуживания процесса процессором
                    BurstTime = ProcessRand.Next(burstMin, burstMax + 1)
                };
                // и помещается в очередь готовых процессов
                ReadyQueue.Put(newProcess);
            }
            // выполняется шаг работы центрального процессора
            Cpu.NextTime();
            // если требуется перепланировка
            if (RedevelopmentNeed()) {
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
        private bool RedevelopmentNeed() {
            return (Cpu.Free() || Cpu.RunningProcess.WorkTime ==
            Cpu.RunningProcess.BurstTime);
        }


        public ClockGenerator ClockGen {
            get;
        }
        public CPU Cpu {
            get;
        }
        public CPUScheduler CpuScheduler {
            get;
        }
        public PriorityQueue<Process> ReadyQueue {
            get;
        }
        public Random ProcessRand {
            get;
        }

        /// <summary>
        /// параметры модели
        /// </summary>
        /// <summary>
        /// Порог интенсивности поступления процессов
        /// </summary>
        private readonly double intensityThreshold;
        /// <summary>
        /// Минимальная величина интервала обслуживания
        /// </summary>
        private readonly int burstMin;
        /// <summary>
        /// Максимальная величина интервала обслуживания
        /// </summary>
        private readonly int burstMax;
    }
}