using GPU_Performance_Analysis_Visualization;

internal class Program
{
    private static void Main(string[] args)
    {
        ProcessData pd = new ProcessData();
        pd.ProcessDataObject();
        pd.printDataObject();

        //var builder = WebApplication.CreateBuilder(args);
        //var app = builder.Build();

        //app.MapGet("/", () => "Hello World!");

        //app.Run();
    }
}