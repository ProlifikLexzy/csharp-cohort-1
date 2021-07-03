using Cmd.App.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Collections
{
    public class MyEnumerator<T> : IEnumerator<T> where T : BaseEntity
    {
        private MyCollections<T> _collection;
        public MyEnumerator(MyCollections<T> collection)
        {
            _collection = collection;
            _index = -1;
            Current = default;
        }

        private int _index;

        public T Current { get; set; }

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_index > _collection.Count)
                return false;

            Current = _collection[++_index];

            return true;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
