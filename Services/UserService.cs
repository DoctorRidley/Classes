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

            string hash = Hash_Password(password);

            return null;
        }


        public string Hash_Password(string password) {

            byte[] raw_string = Encoding.ASCII.GetBytes(password);
            byte[] raw_hash = SHA512.Create().ComputeHash(raw_string);

            string str_hash = BitConverter.ToString(raw_hash).Replace("-", "").ToLower();

            string salt = DateTime.Now.ToString();

            string final = "$" + salt + "$" + str_hash;

            return str_hash;
            
        }
    }

    
}
