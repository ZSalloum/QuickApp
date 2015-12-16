using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickApp.Runtime.Common.Models
{
    public abstract class BaseList<K, T> : IList<T>, ILookup<K, T>
    {
        protected List<T> list = new List<T>();

        #region IList<T>
        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
        #endregion #region IList<T>



        public bool Contains(K key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> this[K key]
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerator<IGrouping<K, T>> IEnumerable<IGrouping<K, T>>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
