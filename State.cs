using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Classes.Windows;

namespace Classes {

    namespace Utilities {
     
        class State {

            private bool app_running;
            private readonly Router router = new Router();







            public State() {
                app_running = true;
                router.Add_Window(new WelcomeWindow());
            }




            private Window Get_Window(Window_State e) {

                Window w = null;

                switch (e) {
                    case Window_State.WELCOME:
                        //w = WelcomeWindow;
                        break;
                    case Window_State.LOGIN:
                        break;
                    case Window_State.REGISTER:
                        break;
                    case Window_State.DASHBOARD:
                        break;
                    case Window_State.PROFILE:
                        break;
                    case Window_State.ADD_CLASS:
                        break;
                    default:
                        break;
                }


                return null;
            }


            public void Terminate() {
                app_running = false;
            }



        }
    }
}
