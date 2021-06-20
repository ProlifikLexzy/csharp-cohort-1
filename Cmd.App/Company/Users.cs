using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Company
{
    public class Users : IEnumerable<string>
    {
        private string[] _users = new string[0];

        public Users(string[] users)
        {
            _users = users;
        }
        public IEnumerator<string> GetEnumerator()
        {
            return new UserEnumerator<string>(_users);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class UserEnumerator<T> : IEnumerator<T>
    {
        private T[] _users;
        public UserEnumerator(T[] users)
        {
            _users = users;
        }

        public T Current => _users[counter];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            return;
        }

        private int counter = 0;
        public bool MoveNext()
        {
            counter++;
            return counter < _users.Length;
        }

        public void Reset()
        {
            counter = -1;
        }
    }
}
