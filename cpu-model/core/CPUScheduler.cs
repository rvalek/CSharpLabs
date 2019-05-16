namespace cpu_model.core {
    internal class CPUScheduler {
        private readonly CPU Cpu;
        private readonly PriorityQueue<Process> ProcessQueue;

        public CPUScheduler(CPU cpu, PriorityQueue<Process> processQueue) {
            Cpu = cpu;
            ProcessQueue = processQueue;
        }

        public void NextTime() {
            if (!ProcessQueue.Empty()) {
                Cpu.IsFree = false;
                Cpu.RunningProcess = ProcessQueue.Item();
                Cpu.RunningProcess.SetActive();
                ProcessQueue.Remove();
            } else {
                Cpu.Clear();
            }
        }

    }
}
