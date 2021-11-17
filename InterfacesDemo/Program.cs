using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Iworker[] workkers = new Iworker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };
            foreach (var workers in workkers)
            {
                workers.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eaters in eats)
            {
                eaters.Eat();
            }
            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Worker(),
                new Manager()

            };
            foreach (var salaries in getSalaries)
            {
                salaries.getsalary();
            }



        }

        interface IRobot
        {
            void Work();
        }

        interface IEat
        {
            void Eat();
        }

        interface IGetSalary
        {
            void getsalary();
        }
        interface Iworker
        {
            void Work();

        }

        class Manager : Iworker, IEat, IGetSalary
        {
            public void getsalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
            void IEat.Eat()
            {
                throw new NotImplementedException();
            }
        }

        class Worker : Iworker, IEat, IGetSalary
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
            void IEat.Eat()
            {
                throw new NotImplementedException();
            }
            public void getsalary()
            {
                throw new NotImplementedException();
            }
        }

        class Robot : Iworker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }







    }
}
