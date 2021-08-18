using System;
using System.Collections.Generic;

using Classes.Windows;


namespace Classes {

    namespace Utilities {
        public class Router {



            private Window_State current_page;

            private readonly Stack<Window> history = new();
            private readonly List<Window> windows = new();

            public Router() {
                
            }

            public void Add_Window(Window w) { windows.Add(w); }


            public void Navigate(string route) {

                // push current page to history

            }

            public void Previous_Window() {
                //FIXME: handle empty history
                Navigate(history.Pop().Route);
            }
        }

    }

}
