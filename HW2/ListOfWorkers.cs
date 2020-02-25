using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class ListOfWorkers : IEnumerable, IEnumerator
    {
        Workers[] workers;
        Random rand = new Random();
        
        private int _i = -1;
       
        public IEnumerator GetEnumerator()
        {
            return this;
        }
                
        public bool MoveNext()
        {
            if (_i == workers.Length - 1)
            {
                Reset();
                return false;
            }
            _i++;
            return true;
        }
        
        public void Reset()
        {
            _i = -1;
        }

        public object Current => workers[_i];
                
        public void Sort()
        {
            Array.Sort(workers);
        }
                
        public void Print()
        {
            foreach (Workers worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
        }
               
        public void Init(int numberOfWorkers)
        {
            workers = new Workers[numberOfWorkers];
            for (int i = 0; i < numberOfWorkers; i++)
            {
                switch (rand.Next(0, 2))
                {
                    case 0:
                        workers[i] = new HourlyPay("Имя_" + i, "Фамилия_" + i, Convert.ToSByte(rand.Next(18, 65)));
                        break;
                    case 1:
                        workers[i] = new FixedPay("Имя_" + i, "Фамилия_" + i, Convert.ToSByte(rand.Next(18, 65)));
                        break;
                }

                if (workers[i] is HourlyPay)
                    workers[i].CountSalary(rand.NextDouble() * (1000 - 150) + 150);
                else if (workers[i] is FixedPay)
                    workers[i].CountSalary(rand.NextDouble() * (150000 - 30000) + 30000);
            }
        }

    }
}
