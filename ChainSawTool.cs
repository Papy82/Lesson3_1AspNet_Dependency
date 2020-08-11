using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_1AspNet_Dependency
{
    class ChainsawTool : ITool
    {
        public void UseTool()
        {
            Console.Write("The Chainsaw tool is put to work!");
        }
    }
}
