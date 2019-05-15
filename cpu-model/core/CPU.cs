namespace cpu_model.core {
    internal class CPU {
        public bool IsFree {
            get; internal set;
        }

        public Process RunningProcess {
            get; internal set;
        }

        public CPU() {
            IsFree = true;
        }

        public void NextTime() {
            if (RunningProcess != null) {
                RunningProcess.ExecutionTime += 1;
            }
        }

        public void Clear() {
            RunningProcess = null;
            IsFree = true;
        }
    }
}
