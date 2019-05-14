namespace cpu_model.core {
    internal class CPUScheduler {
        private readonly CPU Cpu;
        private readonly PriorityQueue<Process> ProcessQueue;

        public CPUScheduler(CPU cpu, PriorityQueue<Process> processQueue) {
            Cpu = cpu;
            ProcessQueue = processQueue;
        }

        public void NextTime() {
            ProcessQueue.Remove();

            if (!ProcessQueue.Empty()) {
                Cpu.RunningProcess = ProcessQueue.Item();
                Cpu.RunningProcess.SetActive();
            } else {
                Cpu.Clear();
            }

            // update all waiting processes ?
            //for (int i = ProcessQueue.Count() - 1; i >= 0; i -= 1) {

            //}
        }

    }
}
