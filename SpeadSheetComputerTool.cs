using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_1AspNet_Dependency
{
    class SpreadSheetComputerTool : ITool
    {
        public void UseTool()
        {
            Console.WriteLine("The SpreadSheet is very useful to the company!");
        }
    }
}
