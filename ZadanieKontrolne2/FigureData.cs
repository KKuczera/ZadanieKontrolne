using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieKontrolne2
{
    internal class FigureData
    {
        public static float lengthA, lengthB, lengthC, lengthH, lengthR;

        public static bool isLengthA, isLengthB, isLengthC, isLengthH;

        public static void insertLengthA()
        {
            Console.WriteLine("\nPodaj długość boku: ");
            var lengthASquare = Console.ReadLine();
            isLengthA = short.TryParse(lengthASquare, out var aLength);

            while (!isLengthA)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową długość boku");
                Console.WriteLine("\nPodaj długość boku: ");
                lengthASquare = Console.ReadLine();
                isLengthA = short.TryParse(lengthASquare, out aLength);
            }

            if (isLengthA)
            {
                lengthA = aLength;
            }
        }

        public static void insertLengthB()
        {
            Console.WriteLine("\nPodaj długość boku: ");
            var lengthBSquare = Console.ReadLine();
            isLengthB = short.TryParse(lengthBSquare, out var bLength);

            while (!isLengthB)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową długość boku");
                Console.WriteLine("\nPodaj długość boku: ");
                lengthBSquare = Console.ReadLine();
                isLengthB = short.TryParse(lengthBSquare, out bLength);
            }

            if (isLengthB)
            {
                lengthB = bLength;
            }
        }

        public static void insertLengthC()
        {
            Console.WriteLine("\nPodaj długość boku: ");
            var lengthBSquare = Console.ReadLine();
            isLengthC = short.TryParse(lengthBSquare, out var cLength);

            while (!isLengthC)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową długość boku");
                Console.WriteLine("\nPodaj długość boku: ");
                lengthBSquare = Console.ReadLine();
                isLengthC = short.TryParse(lengthBSquare, out cLength);
            }

            if (isLengthC)
            {
                lengthC = cLength;
            }
        }

        public static void insertLengthH()
        {
            Console.WriteLine("\nPodaj długość boku: ");
            var lengthOfH = Console.ReadLine();
            isLengthH = short.TryParse(lengthOfH, out var hLength);

            while (!isLengthH)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową długość boku");
                Console.WriteLine("\nPodaj długość boku: ");
                lengthOfH = Console.ReadLine();
                isLengthH = short.TryParse(lengthOfH, out hLength);
            }

            if (isLengthH)
            {
                lengthH = hLength;
            }
        }

        public static void insertLengthR()
        {
            Console.WriteLine("\nPodaj długość promienia: ");
            var lengthOfR = Console.ReadLine();
            isLengthA = short.TryParse(lengthOfR, out var rLength);

            while (!isLengthA)
            {
                Console.WriteLine("Wprowadzono nieprawidłową wartość!\nProszę " +
                                  "wprowadzić prawidłową długość boku");
                Console.WriteLine("\nPodaj długość boku: ");
                lengthOfR = Console.ReadLine();
                isLengthA = short.TryParse(lengthOfR, out rLength);
            }

            if (isLengthA)
            {
                lengthR = rLength;
            }
        }
    }
}
