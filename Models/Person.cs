using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models {

    public abstract class Person {

        protected int id;
        protected string first_name;
        protected string last_name;
        protected string email;
        protected string username;
        protected string password;

        public Person(string user, string pass) => (username, password) = (user, pass);

        public Person(string f, string l, string e, string u, string p) {
            (first_name, last_name, email, username, password) = (f, l, e, u, p);
        }

        public int ID {
            get => id;
            set => id = value;
        }

        public string First_Name {
            get => first_name;
            set => first_name = value;
        }

        public string Last_Name {
            get => last_name;
            set => last_name = value;
        }

        public string Email {
            get => email;
            set => email = value;
        }

        public string Username {
            get => username;
            set => username = value;
        }

        public string Password {
            get => password;
            set => password = value;
        }

        public override bool Equals(object obj) {
            return obj is Person person &&
                   id == person.id &&
                   first_name == person.first_name &&
                   last_name == person.last_name &&
                   email == person.email &&
                   username == person.username &&
                   password == person.password;
        }

        public override string ToString() {
            // FIXME: may have to change this for DB
            return "Person{" +
                "id=" + id +
                ", first_name='" + first_name + '\'' +
                ", last_name='" + last_name + '\'' +
                ", email='" + email + '\'' +
                ", username='" + username + '\'' +
                ", password='" + password + '\'' +
                '}';
        }
    }
}
