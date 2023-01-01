using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class LocalMethods
    {
        private List<int>? _collection;
        private List<int>? _resultCollection;

        public void DataInput()
        {
            Console.Write("Введите количество человек: ");
            if(!uint.TryParse(Console.ReadLine(), out uint _countPerson))
            {
                throw new InvalidCastException();
            }
            _collection = Enumerable.Range(1, (int)_countPerson).ToList();
            _resultCollection = new List<int>((int)_countPerson);
        }

        public void DataOutput()
        {
            if (_resultCollection != null)
            {
                _resultCollection.ForEach(item =>
                {
                    Console.Write(item + " ");
                });
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Коллекция пуста.");
            }
        }


        public void StartAlgorithm()
        {
            if(_collection != null && _resultCollection != null)
            {
                var list = new Queue<int>(_collection);
                while (list.Count != 1)
                {
                    ProcessModeling(list);
                    list.Enqueue(list.Dequeue());
                    ProcessModeling(list);
                    _resultCollection.Add(list.Dequeue());
                }
                _resultCollection.Add(list.Dequeue());
            }
        }

        private void ProcessModeling(Queue<int> obj)
        {
            obj.ToList().ForEach(item =>
            {
                Console.Write(item + " ");
            });
            Console.WriteLine();
        }
    }
}
