using System;
using System.Collections.Generic;

using Classes.Windows;


namespace Classes.Utilities {


    enum Window_State { WELCOME, LOGIN, REGISTER, DASHBOARD, PROFILE, STUDENT_CLASS, FACULTY_CLASS };


    public class Router {

        private Window_State current_page;

        private readonly Stack<Window> history = new();
        private readonly List<Window> windows = new();

        public Router() {

        }

        public void Add_Window(Window w) { windows.Add(w); }

        public Window Get_Current_Page() => windows[(int)current_page];


        // foreach Window_State, return the corresponding Window in windows<>
        private Window Get_Window(Window_State e) => windows[(int)e];


        public void Navigate(string route) {

            // push current page to history

        }

        public void Previous_Window() {
            //FIXME: handle empty history
            Navigate(history.Pop().Route);
        }
    }
}
