using System;

namespace Lab12
{
    class Program
    {
        /*
         Scrieti o clasa care va implementa o structura de date generica de tipul coada. (queue)
         Coada va functiona pe principiul FIFO (first in first out) si va avea urmatoarele metode si proprietati:
            • Enqueue – va adauga un element la capatul cozii
            • Dequeue – va extrage primul element din coada si il va returna ca rezultat
            • Count – va returna numarul de elemente din coada.
         La initializarea cozii va fi stabilita capacitatea maxima a cozii.
         In interiorul clasei, folositi o structura de tip vector pentru a stoca datele.
         Initializati mai multe cozi (intregi, obiecte), adaugati elemente, extrageti elemente, afisati-le.
        */
        static void Main(string[] args)
        {
            Coada<int> coada1 = new Coada<int>(3);
            Coada<string> coada2 = new Coada<string>(4);
            Coada<Dog> coada3 = new Coada<Dog>(3);

            //adaugam 3 elemente in coada de numere intregi
            coada1.Enqueue(1);
            coada1.Enqueue(2);
            coada1.Enqueue(3);

            Console.WriteLine($"Coada 1 are {coada1.countCurent} elemente adaugate");

            //adaugam 4 elemente in coada de string
            coada2.Enqueue("john");
            coada2.Enqueue("matilda");
            coada2.Enqueue("donald");
            coada2.Enqueue("alicia");

            Console.WriteLine($"Coada 2 are {coada2.countCurent} elemente adaugate");

            //adaugam 3 elemente in coada ce contine obiecte de tip Dog 
            coada3.Enqueue(new Dog() { Rasa = "Bichon" });
            coada3.Enqueue(new Dog() { Rasa = "Labrador" });
            coada3.Enqueue(new Dog() { Rasa = "Shih Tzu" });

            Console.WriteLine($"Coada 3 are {coada3.countCurent} elemente adaugate");

            Console.WriteLine();

            //scoatem cele 3 elemente din coada de numere intregi, pe baza principiului FIFO
            var element1coada1 = coada1.Dequeue();
            Console.WriteLine($"Am scos elementul {element1coada1} din coada de numere intregi");
            var element2coada1 = coada1.Dequeue();
            Console.WriteLine($"Am scos elementul {element2coada1} din coada de numere intregi");
            var element3coada1 = coada1.Dequeue();
            Console.WriteLine($"Am scos elementul {element3coada1} din coada de numere intregi");

            Console.WriteLine();

            //scoatem cele 4 elemente din coada de string, pe baza principiului FIFO
            var element1coada2 = coada2.Dequeue();
            Console.WriteLine($"Am scos elementul {element1coada2} din coada de string");
            var element2coada2 = coada2.Dequeue();
            Console.WriteLine($"Am scos elementul {element2coada2} din coada de string");
            var element3coada2 = coada2.Dequeue();
            Console.WriteLine($"Am scos elementul {element3coada2} din coada de string");
            var element4coada2 = coada2.Dequeue();
            Console.WriteLine($"Am scos elementul {element4coada2} din coada de string");

            Console.WriteLine();

            //scoatem cele 3 elemente din coada de obiecte de tip Dog, pe baza principiului FIFO
            var element1coada3 = coada3.Dequeue();
            Console.WriteLine($"Am scos elementul {element1coada3} din coada de obiecte de tip Dog");
            var element2coada3 = coada3.Dequeue();
            Console.WriteLine($"Am scos elementul {element2coada3} din coada de obiecte de tip Dog");
            var element3coada3 = coada3.Dequeue();
            Console.WriteLine($"Am scos elementul {element3coada3} din coada de obiecte de tip Dog");

            Console.WriteLine();

            Console.WriteLine($"Coada 1 are {coada1.countCurent} elemente adaugate");
            Console.WriteLine($"Coada 2 are {coada2.countCurent} elemente adaugate");
            Console.WriteLine($"Coada 3 are {coada3.countCurent} elemente adaugate");

        }
    }
}
