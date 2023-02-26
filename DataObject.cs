using System;
using System.IO;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace GPU_Performance_Analysis_Visualization
{
    

    public class DataObject
    {
        //string outFile = "./output/out.txt";
        string outFile1 = "./output/out1.txt";
        List<string> dataObjectProperties = new List<string>();

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


        public void listDataObjectProperties()
        {
            dataObjectProperties.Add("Dispatch: " + this.dispatch);
            dataObjectProperties.Add("GPU ID: " + gpuID);
            dataObjectProperties.Add("Queue ID: " + this.queueID);
            dataObjectProperties.Add("Queue Index: " + this.queueIndex);
            dataObjectProperties.Add("Process ID: " + this.processID);
            dataObjectProperties.Add("Thread ID: " + this.threadID);
            dataObjectProperties.Add("GRD: " + this.grd);
            dataObjectProperties.Add("WGR: " + this.wgr);
            dataObjectProperties.Add("LDS: " + this.lds);
            dataObjectProperties.Add("SCR: " + this.scr);
            dataObjectProperties.Add("Arch VGPR: " + this.archVgpr);
            dataObjectProperties.Add("ACCUM VGPR: " + this.accumVgpr);
            dataObjectProperties.Add("SGPR: " + this.sgpr);
            dataObjectProperties.Add("Wave Size: " + this.waveSize);
            dataObjectProperties.Add("SIG: " + this.sig);
            dataObjectProperties.Add("OBJ: " + this.obj);
            dataObjectProperties.Add("Kernel Name: " + this.kernelName);
            dataObjectProperties.Add("Start Time: " + this.startTime);
            dataObjectProperties.Add("End Time: " + this.endTime);
            dataObjectProperties.Add("SQ Wait Any: " + this.sqWaitAny);
            dataObjectProperties.Add("SQ Wave Cycles: " + this.sqWaveCycles);
            dataObjectProperties.Add("SQ Cycles: " + this.sqCycles);
            dataObjectProperties.Add("GRBM Count: " + this.GRBMCount);
            dataObjectProperties.Add("GRBM GUI Active: " + this.GRBMGUIActive);
        }

        public void writeToFile()
        {
            File.WriteAllLines(outFile1, dataObjectProperties);
        }

        public void ProcessProperties()
        {
            int start = 0;
            int end = 0;
            int length = 0;
            string dispatchValue = "";

            if(dispatch != null)
            {
                start = this.dispatch.IndexOf("[");
                end = this.dispatch.IndexOf("]");
                length = end - start - 1;
                dispatchValue = dispatch.Substring(start + 1, length);
            }
            
            
        }
    }
}

