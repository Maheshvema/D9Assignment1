using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDisposeAssignment
{
    public class LargeDataCollection : IDisposable
    {
        private List<object> data;

        public LargeDataCollection(IEnumerable<object> initialData)
        {
            data = new List<object>(initialData);
        }

        public void Add(object item)
        {
            data.Add(item);
        }

        public bool Remove(object item)
        {
            return data.Remove(item);
        }

        public object this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        public void Dispose()
        {
            if (data != null)
            {
                foreach (var item in data)
                {
                    (item as IDisposable)?.Dispose();
                }
                data = null;
            }
        }
    }
}