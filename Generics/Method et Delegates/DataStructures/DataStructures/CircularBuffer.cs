using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataStructures
{
  
    public class Buffer<T> : IBuffer<T>
    {
        protected Queue<T> _queue = new Queue<T>();

        public virtual bool IsEmpty
        {
            get { return _queue.Count == 0; }
        }

        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }

        public virtual T Read()
        {
            return _queue.Dequeue();
        }

        public  IEnumerable<TOuput> AsEnumerableOfInt<TOuput>()
        {
            //converter class give me a converter of a type 
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach(var item in _queue)
            {
                var result = converter.ConvertTo(item, typeof(T));
                yield return (TOuput) result;
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _queue)
            {
                // ...
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
   
    public class CircularBuffer<T>  : Buffer<T>
    {
        int _capacity;
        public CircularBuffer(int capacity = 10)
        {
            _capacity = capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if (_queue.Count > _capacity)
            {
                _queue.Dequeue();
            }
        }

        public bool IsFull { get { return _queue.Count == _capacity; } }

    }
}
