using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


using Classes.Repos;
using Classes.Models;

namespace Classes.Services {

    public class UserService {

        private readonly StudentRepo student_repo;

        public UserService(StudentRepo s) => student_repo = s;

        public Person Login(string username, string password) {

            
            string hash = Hash_Password("temp", password);

            return null;
        }


        private string Hash_Password(string salt, string password) {

            byte[] raw_string = Encoding.ASCII.GetBytes(salt + password + salt);
            byte[] raw_hash = SHA512.Create().ComputeHash(raw_string);

            return BitConverter.ToString(raw_hash).Replace("-", "");
        }
    }

    
}
