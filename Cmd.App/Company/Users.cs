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
        public IEnumerator<string> GetEnumerator()
        {
            var users = new string[] { "Prolifik Lexzy", "Scott Hanselman", "Scott Hunter", "Scott Guthrie" };
            return new UserEnumerator<string>(users);
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
            if (counter > _users.Length)
                return false;

            counter++;
            return true;
        }

        public void Reset()
        {
            counter = -1;
        }
    }
}
