using System.Diagnostics.Contracts;

namespace cpu_model.core {
    internal class CPU {
        public bool IsFree {
            get; internal set;
        }

        public Process RunningProcess {
            get; internal set;
        }

        public CPU() {
        }

        public void NextTime() {
            Contract.Requires<QueueException>(!IsFree, "Нарушение контракта: процессор свободен при выполнении очередного шага.");
            Contract.Ensures(RunningProcess.ExecutionTime == Contract.OldValue<int>(RunningProcess.ExecutionTime) + 1);

            RunningProcess.ExecutionTime += 1;
        }

        public void Clear() {
            RunningProcess = null;
            IsFree = true;
        }
    }
}
