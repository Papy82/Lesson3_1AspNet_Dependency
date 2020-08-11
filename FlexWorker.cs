using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_1AspNet_Dependency
{
    class FlexWorker
    {
        private ITool _someTool;

        public FlexWorker(ITool toolToUse)
        {
            _someTool = toolToUse;
        }

        public void DoSomeWork()
        {
            _someTool.UseTool();
        }
    }
}
