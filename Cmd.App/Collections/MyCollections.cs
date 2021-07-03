using Cmd.App.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Collections
{
    public class MyCollections<T> : ICollection<T> where T : BaseEntity
    {
        private ArrayList _innerArray;
        public MyCollections(ArrayList innerArray = null)
        {
            _innerArray = innerArray ?? new ArrayList();
        }

        public int Count => _innerArray.Count;

        public bool IsReadOnly => _innerArray.IsReadOnly;

        public T this[int index]
        {
            get
            {
                return (T)_innerArray[index];
            }
        }

        public void Add(T item)
        {
            _innerArray.Add(item);
        }

        public void Clear()
        {
            _innerArray.Clear();
        }

        public bool Contains(T item)
        {
            return _innerArray.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _innerArray.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(this);
        }

        public bool Remove(T item)
        {
            _innerArray.Remove(item);
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
