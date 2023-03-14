using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    public class Coada<T>
    {
        public int countCurent { get; private set; } = 0;
        private T[] elemente;
        private readonly int capacitate;

        public Coada(int capacitate)
        {
            this.capacitate = capacitate;
            elemente = new T[capacitate];
        }

        public void Enqueue(T elementDeAdaugat)
        {
            if (countCurent == capacitate)
                return;

            elemente[countCurent] = elementDeAdaugat;
            countCurent++;
        }

        public T Dequeue()
        {
            var elementDeScos = elemente.FirstOrDefault();
            elemente = elemente.Where((item, index) => index != 0).ToArray();
            countCurent--;
            return elementDeScos;
        }
    }
}
