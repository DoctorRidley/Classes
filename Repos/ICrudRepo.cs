using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Classes.Models;

namespace Classes.Repos {
    
    public interface ICrudRepo {

        public void Create(Person new_user);

        public Person Find_By_Username(string username);

        public void Update(Person person);

        public void Delete(Person person);

        

    }
}
