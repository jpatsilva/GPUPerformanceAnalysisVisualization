using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace GPU_Performance_Analysis_Visualization
{
    public class ProcessData
    {
        DataObject dataObj = new DataObject();
        string rawPropertyFile = "./output/raw.txt";
        string valuePropertyFile = "./output/values.txt";

        public void ProcessDataObject()
        {
            string data = OpenRead();
            string[] parsedData = data.Split(',');

            dataObj.dispatch = parsedData[0];
            dataObj.gpuID = parsedData[1];
            dataObj.queueID = parsedData[2];
            dataObj.queueIndex = parsedData[3];
            dataObj.processID = parsedData[4];
            dataObj.threadID = parsedData[5];
            dataObj.grd = parsedData[6];
            dataObj.wgr = parsedData[7];
            dataObj.lds = parsedData[8];
            dataObj.scr = parsedData[9];
            dataObj.archVgpr = parsedData[10];
            dataObj.accumVgpr = parsedData[11];
            dataObj.sgpr = parsedData[12];
            dataObj.waveSize = parsedData[13];
            dataObj.sig = parsedData[14];
            dataObj.obj = parsedData[15];
            dataObj.kernelName = parsedData[16];
            dataObj.startTime = parsedData[17];
            dataObj.endTime = parsedData[18];
            dataObj.sqWaitAny = parsedData[19];
            dataObj.sqWaveCycles = parsedData[20];
            dataObj.sqCycles = parsedData[21];
            dataObj.GRBMCount = parsedData[22];
            dataObj.GRBMGUIActive = parsedData[23];

        }

        public string OpenRead()
        {
            try
            {
                string text = System.IO.File.ReadAllText("./data/288440_results.txt");
                return text;
            }
            catch (Exception e)
            {
                Console.Write("Error: " + e);
            }
            return "Error";
        }

        public void WriteDataObjectToFile()
        {
            dataObj.listDataObjectProperties();
            dataObj.ParseProperties();
            dataObj.WriteToFile(rawPropertyFile, dataObj.dataObjectProperties);
            dataObj.WriteToFile(valuePropertyFile, dataObj.dataObjectValues);
        }
    }
}