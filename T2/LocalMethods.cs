using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class LocalMethods
    {
        private string[]? _arrayWords;
        private Dictionary<string, uint>? _mapWords;

        public void DataInput()
        {
            Console.WriteLine("Введите текст: ");
            _arrayWords = Console.ReadLine()?.Split(new char[] { '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public void DataOutput()
        {
            if (_arrayWords != null && _mapWords != null)            {
                               
                var orderedFrequency = from f in _mapWords
                                       orderby f.Value descending
                                       select f;

                foreach (var item in orderedFrequency)
                {
                    Console.WriteLine($"Word {item.Key} ,Frequency  {item.Value / (double)_arrayWords.Length} ");
                    
                }

            }
            else
            {
                Console.WriteLine("Словарь пуст!");
            }
        }

        public void DataExtraction()
        {
            if (_arrayWords != null)
            {
                _mapWords = new Dictionary<string, uint>(StringComparer.OrdinalIgnoreCase);
                foreach (var obj in _arrayWords)
                {
                    if (obj != null)
                    {
                        if (_mapWords.ContainsKey(obj) == false)
                        {
                            _mapWords.Add(obj, 1);
                        }
                        else
                        {
                            _mapWords[obj] += 1;
                        }
                    }
                }
            }
        }
    }
}
