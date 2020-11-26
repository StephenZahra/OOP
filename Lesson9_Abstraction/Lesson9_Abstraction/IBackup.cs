using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction
{
    //Both interfaces and abstract classes enforce implementation of 
    //their members upon inherited classes

    //In an interface you do not implement
    //--> you just declare methods
    //In an abstract class you can have a mix

    //What are the differences between interfaces and abstract classes?
    //When to use one and not the other?

    //1. A class can inherit more than ONE interface, but it can inherit ONLY ONE Abstract Class
    //2. An Abstract Class can be composed of non-implemented methods but also implemented ones
    public interface IBackup
    {
        void Backup();
    }
}
