using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace CSBANet.Trade
{
    public partial class Trading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RadDock dock = CreateRadDock();
            RadDockLayout1.Controls.Add(dock);
            dock.Dock(RadDockZone1);
        }


        private RadDock CreateRadDock()
        {
            int docksCount = CurrentDockStates.Count;
            RadDock dock = new RadDock();
            dock.ID = string.Format("RadDock{0}", docksCount);
            dock.Title = string.Format("Dock {0}", docksCount);
            dock.Text = string.Format("Added at {0}", DateTime.Now);
            dock.UniqueName = Guid.NewGuid().ToString();
            dock.Width = Unit.Pixel(300);
            return dock;
        }

        private List<DockState> CurrentDockStates
        {
            //Store the info about the added docks in the session.
            private List<DockState> CurrentDockStates
            {
                get
              {
                    List<DockState> _currentDockStates = (List<DockState>)Session["CurrentDockStates"];
                    if (Object.Equals(_currentDockStates, null))
                    {
                        _currentDockStates = new List<DockState>();
                        Session["CurrentDockStates"] = _currentDockStates;
                    }
                    return _currentDockStates;
                }
                set
              {
                    Session["CurrentDockStates"] = value;
                }
            }
        }
    }
}