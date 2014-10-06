using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern.Model
{
    interface BeatModelInterface
    {
        void initialize();
        void on();
        void off();
        void setBPM(int bpm);
        int getBPM();
        void registerObserver(BeatObserver o);
        void removeObserver(BeatObserver o);
        void registerObserver(BPMObserver o);
        void removeObserver(BPMObserver o);
    }
}
