using System;
using System.Collections.Generic;
using System.Text;

namespace Tuinen // the name of the class = name of it's namespace
{
    class Tuin // creating a class
    {
        public string locality; // future properties
        public short registerNumber;
        public float squareMeters;

        public DateTime wereCleaned;

        public void Descript() // the methids of the class which does not contain parameters as they are gicen in the body of class description
        {
            Console.WriteLine($"The garden is located in {locality}.\nIt's {squareMeters} m2 wide" +
                $"\nand has already a legel register nummer: {registerNumber}");
            if (wereCleaned != DateTime.MinValue)
            {
                Console.WriteLine($"It was cleaned {wereCleaned}");
            }
            
        }
         public Tuin(string localityInput, short registerNumberInput, float squareMetersInput) // the same class bu using the input for its parameters
        {
            locality = localityInput;
            registerNumber = registerNumberInput;
            squareMeters = squareMetersInput;
        }

        public Tuin(string localityInput, short registerNumberInput, float squareMetersInput, DateTime wereCleanedInput) // the same class bu using the input for its parameters 
            //and also does more because of additional parameters
            : this(localityInput, registerNumberInput, squareMetersInput)
        {
            wereCleaned = wereCleanedInput;
        }

    }
}
