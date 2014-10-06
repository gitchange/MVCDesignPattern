using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern.Controller
{
    interface ControllerInterface
    {
        void start();
        void stop();
        void increaseBPM();
        void decreaseBPM();
        void setBPM();
    }
}
