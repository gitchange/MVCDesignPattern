using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDesignPattern.Model
{
    public class BeatModel : BeatModelInterface
    {
        ArrayList beatObservers = new ArrayList();
        ArrayList bpmObservers = new ArrayList();
        int bpm = 90;


        public void initialize()
        {
            setUpMidi();
            buildTrackAndStart();
        }

        private void buildTrackAndStart()
        {
            Console.WriteLine("執行了 buildTrackAndStart()");
        }

        private void setUpMidi()
        {
            try
            {
                Console.WriteLine("執行了 setUpMidi()");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void on()
        {
            setBPM(90);
        }

        public void off()
        {
            setBPM(0);
        }

        public void setBPM(int bpm)
        {
            Console.WriteLine("目前 BPM 被設定成 {0}" , bpm);
            notifyBPMObservers();
        }

        private void notifyBPMObservers()
        {
            for(int i =0; i < bpmObservers.Count; i++)
            {
                BPMObserver observer = (BPMObserver)bpmObservers[i];
                observer.updateBPM();
            }
        }

        public int getBPM()
        {
            return bpm;
        }

        void beatEvent()
        {
            notifyBeatObservers();
        }

        private void notifyBeatObservers()
        {
            for (int i = 0; i < beatObservers.Count; i++)
            {
                BeatObserver observer = (BeatObserver)beatObservers[i];
                observer.updateBeat();
            }
        }

        public void registerObserver(BeatObserver o)
        {
            beatObservers.Add(o);
        }

        public void removeObserver(BeatObserver o)
        {
            int i = beatObservers.IndexOf(o);
            if (i >= 0) { beatObservers.Remove(i); }
        }

        public void registerObserver(BPMObserver o)
        {
            bpmObservers.Add(o);
        }

        public void removeObserver(BPMObserver o)
        {
            int i = bpmObservers.IndexOf(o);
            if (i >= 0) { bpmObservers.Remove(i); }
        }
    }
}