using System;

namespace GPU_Performance_Analysis_Visualization
{
    public class DataObject
    {
        public string? dispatch { get; set; }
        public string? gpuID { get; set; }
        public string? queueID { get; set; }
        public string? queueIndex { get; set; }
        public string? processID { get; set; }
        public string? threadID { get; set; }
        public string? grd { get; set; }
        public string? wgr { get; set; }
        public string? lds { get; set; }
        public string? scr { get; set; }
        public string? archVgpr { get; set; }
        public string? accumVgpr { get; set; }
        public string? sgpr { get; set; }
        public string? waveSize { get; set; }
        public string? sig { get; set; }
        public string? obj { get; set; }
        public string? kernelName { get; set; }
        public string? startTime { get; set; }
        public string? endTime { get; set; }
        public string? sqWaitAny { get; set; }
        public string? sqWaveCycles { get; set; }
        public string? sqCycles { get; set; }
        public string? GRBMCount { get; set; }
        public string? GRBMGUIActive { get; set; }


        public void print()
        {

            Console.WriteLine("Dispatch: " + this.dispatch);
            Console.WriteLine("GPU ID: " + this.gpuID);
            Console.WriteLine("Queue ID: " + this.queueID);
            Console.WriteLine("Queue Index: " + this.queueIndex);
            Console.WriteLine("Process ID: " + this.processID);
            Console.WriteLine("Thread ID: " + this.threadID);
            Console.WriteLine("GRD: " + this.grd);
            Console.WriteLine("WGR: " + this.wgr);
            Console.WriteLine("LDS: " + this.lds);
            Console.WriteLine("SCR: " + this.scr);
            Console.WriteLine("Arch VGPR: " + this.archVgpr);
            Console.WriteLine("ACCUM VGPR: " + this.accumVgpr);
            Console.WriteLine("SGPR: " + this.sgpr);
            Console.WriteLine("Wave Size: " + this.waveSize);
            Console.WriteLine("SIG: " + this.sig);
            Console.WriteLine("OBJ: " + this.obj);
            Console.WriteLine("Kernel Name: " + this.kernelName);
            Console.WriteLine("Start Time: " + this.startTime);
            Console.WriteLine("End Time: " + this.endTime);
            Console.WriteLine("SQ Wait Any: " + this.sqWaitAny);
            Console.WriteLine("SQ Wave Cycles: " + this.sqWaveCycles);
            Console.WriteLine("SQ Cycles: " + this.sqCycles);
            Console.WriteLine("GRBM Count: " + this.GRBMCount);
            Console.WriteLine("GRBM GUI Active: " + this.GRBMGUIActive);

        }
    }
}

