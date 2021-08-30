using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Classes.Models;

namespace Classes.Repos {
    
    public interface ICrudRepo<T> {

        public void Create(T new_user);

        public T Find_By_String(string username);

        public void Update(T person);

        public void Delete(T person);

        

    }
}
