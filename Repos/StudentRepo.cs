using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Classes.Models;


namespace Classes.Repos {

    public class StudentRepo : ICrudRepo<Person> {
        public void Create(Person new_user) {
            throw new NotImplementedException();
        }

        public Person Find_By_String(string username) {
            throw new NotImplementedException();
        }

        public void Update(Person person) {
            throw new NotImplementedException();
        }

        public void Delete(Person person) {

        }
    }
}
