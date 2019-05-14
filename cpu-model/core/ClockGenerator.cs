using System.Diagnostics.Contracts;

namespace cpu_model.core {
    internal class ClockGenerator {
        public int CurrentTime {
            get; internal set;
        }

        public ClockGenerator() {
            //Contract.Requires<QueueException>(CurrentTime == 0, "Нарушение контракта: текущий такт не нулевой при создании таймера.");
            CurrentTime = 0;
        }

        public void NextTime() {
            Contract.Ensures(CurrentTime == Contract.OldValue<int>(CurrentTime) + 1);

            CurrentTime += 1;
        }

        public void Clear() {
            CurrentTime = 0;
        }


    }
}
