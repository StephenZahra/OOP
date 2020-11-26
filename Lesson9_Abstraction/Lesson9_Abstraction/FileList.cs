using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction
{
    class FileList : IList<File>
    {
        public File this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        private List<File> myList;

        public void Add(File item)
        {
            myList.Add(item);
        }

        public void Clear()
        {
            myList.Clear();
        }

        public bool Contains(File item)
        {
            bool found = false;
            int counter = 0;
            do
            {
                if (myList[counter].GetHashCode() == item.GetHashCode())
                {
                    found = true;
                }
                else counter++;

            } while (found == false && counter < myList.Count);
            return found;
        }

        public void CopyTo(File[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<File> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(File item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, File item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(File item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
