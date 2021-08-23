using System;


namespace Classes.Windows {
    public abstract class Window : System.Windows.Window {

        private readonly string name;
        private readonly string route;

        public Window(string name, string route) {
            this.name = name;
            this.route = route;
        }

        public new string Name => name;

        public string Route => route;

    }
}
