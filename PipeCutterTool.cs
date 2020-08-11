using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_1AspNet_Dependency
{
    class PipeCutterTool : ITool
    {
        public void UseTool()
        {
            Console.WriteLine("The PipeCutterTool cuts the Pipe");
        }
    }

}
