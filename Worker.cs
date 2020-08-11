using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_1AspNet_Dependency
{
    class Worker
    {
        private ShovelTool _shovel;

        public Worker()
        {
            _shovel = new ShovelTool();
        }

        public void UseShovel()
        {
            _shovel.UseTool();
        }
    }
}
