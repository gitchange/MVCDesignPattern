using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVCDesignPattern.Model;
using MVCDesignPattern.Controller;

namespace MVCDesignPattern.View
{
    public partial class DJView : System.Web.UI.Page , BeatObserver , BPMObserver
    {
        BeatModelInterface model;
        ControllerInterface controller;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public DJView(ControllerInterface controller,BeatModelInterface model)
        {
            this.controller = controller;
            this.model = model;
            model.registerObserver((BeatObserver)this);
            model.registerObserver((BPMObserver)this);
        }

        public void createView()
        {
            //建立 View 物件
        }

        public void updateBPM()
        {
            int bpm = model.getBPM();
            if (bpm==0)
            {
                lblBPMOutput.Text = "BPM : " + "offline";
            }
            else
            {
                lblBPMOutput.Text = "BPM : " + model.getBPM();
            }
        }

        public void updateBeat()
        {
            txtBar.Text = "bearBar.setValue(100)";
        }


    }
}