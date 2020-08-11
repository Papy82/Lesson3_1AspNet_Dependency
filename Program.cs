using System;

namespace Lesson3_1AspNet_Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Worker myWorker = new Worker();
            myWorker.UseShovel();

            FlexWorker officeWorker = new FlexWorker(new SpreadSheetComputerTool());
            officeWorker.DoSomeWork();

            FlexWorker plumber = new FlexWorker(new PipeCutterTool());
            plumber.DoSomeWork();

            FlexWorker leatherFace = new FlexWorker(new ChainsawTool());
            leatherFace.DoSomeWork();


        }
    }
}
