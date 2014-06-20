using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    //all collection need an emurable of collction *** lol
    public interface IBuffer<T> : IEnumerable<T>   
    {
        bool IsEmpty { get; }
        void Write(T value);
        T Read();
       
    }

  
    public class Buffer<T> :  IBuffer<T>  
    {
        protected Queue<T> _queue = new Queue<T>();

        public bool IsEmpty
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

        public IEnumerator <T> GetEnumerator()
        {
            foreach(var item in _queue)
            {
                //....
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    //on peut pas implemeter l'interface ici pour
    //overrider  nos méthodes virtual
    public class CircularBuffer<T> : Buffer<T>
    {
        //prop  
        int _capicity;

        //constructeur
        public CircularBuffer(int capacity =10)
        {
            _capicity = 10;
        }

        /// <summary>
        /// si la taille de notre PILE est > à la capicité  on depile
        /// </summary>
        /// <param name="value"></param>
        public override void Write(T value)
        {
            base.Write(value);
            if (_queue.Count > _capicity)
            {
                _queue.Dequeue();
            }
        }
        public bool IsFull
        {
            get { return _queue.Count == _capicity; }
        }
    }
}
