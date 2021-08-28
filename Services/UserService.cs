using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


using Classes.Repos;
using Classes.Models;

namespace Classes.Services {

    class UserService {

        private readonly StudentRepo student_repo;

        public UserService(StudentRepo s) => student_repo = s;

        public Person Login(string username, string password) {
            return null;

        }


        private string Hash_Password(string password) {

            byte[] raw_string = Encoding.ASCII.GetBytes(password);
            string hash = SHA512.Create().ComputeHash(raw_string).ToString();

            string salt = DateTime.Now.ToString();

            string final = "$" + salt + "$" + hash;

            return final;
            
        }
    }

    
}
