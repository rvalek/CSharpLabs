namespace cpu_model.core {
    internal class Process {
        private static int serialCounter = 000;

        public readonly string Name;
        public readonly int Id;
        public readonly int ArrivalTime;

        public int BurstTime;
        public int Priority;
        public int ExecutionTime = 0;
        public ProcStatus Status = ProcStatus.Ready;
        //public int QueueingTime;
        //public int StandbyTime = 0;


        public Process(int currentClockTime) {
            Name = string.Format("P{0,3}", currentClockTime);
            Id = serialCounter++;
            ArrivalTime = currentClockTime;
        }

        public void SetActive() {
            Status = ProcStatus.Active;
        }

        public void SetReady() {
            Status = ProcStatus.Ready;
        }
    }
}

internal enum ProcStatus {
    Active,
    Ready
}