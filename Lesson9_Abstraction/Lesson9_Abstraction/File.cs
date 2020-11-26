using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction
{
    //Definition: The abstract modifier indicates that the thing being modified has a missing or incomplete implementation
    //An abstract class will just give you the method declaration.
    public abstract class File
    {
        public abstract string Load(string filename); //declared method without any implementation
        public abstract void Save(string filename);

        public void Delete(string filename)
        {
            System.IO.File.Delete(filename);
        }
    }
}
