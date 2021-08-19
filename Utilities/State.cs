using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Classes.Windows;

namespace Classes.Utilities {

    class State {

        private bool app_running;
        private readonly Router router = new();

        public State() {
            app_running = true;
            //router.Add_Window(new Welcome());
        }




        public void Terminate() {
            app_running = false;
        }



    }
}
