using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gtk;
using program.Controllers;
using UI = Gtk.Builder.ObjectAttribute;


namespace program.Controllers
{
    public class Dashboard : Window
    {
        public Dashboard() : this(new Builder("WindowDashboard.glade")) { }

        public Dashboard(Builder builder) : base(builder.GetRawOwnedObject("WindowDashboard"))
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            

        }


        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

    }
}