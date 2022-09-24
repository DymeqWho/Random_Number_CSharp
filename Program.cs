using static System.Console;
using static System.Convert;

namespace RandomNumberApp
{
    class RandomNumber
    {
        static void Main(string[] args)
        {
            int RandomNumber = GenerateRandomNumber();
            int CloseRange = 3;
            int CloseSmallBorderNumber = RandomNumber - CloseRange;
            int CloseBigBorderNumber = RandomNumber + CloseRange;
            
            Write("Gissa talet\nDu ska nu gissa ett tal mellan 1 och 100, så varsågod...\nSkriv in ett tal\n");
            int Guess = ToInt32(ReadLine());

            if (OutOfRange(Guess))
            {
                Write("Du måste skriva in ett tal mellan 1 och 100!");
            }
            else if (CloseBigEnough(Guess, RandomNumber, CloseRange))
            {
                Write("Dit tal är för stort. Gissa på ett mindre tal\nDu är dock nära och det bränns");
            }       
            else if (CloseSmallEnough(Guess, RandomNumber, CloseRange))
            {
                Write("Dit tal är för litet. Gissa på ett större tal\nDu är dock nära och det bränns");
            }
            else if (TooSmall(Guess, CloseSmallBorderNumber))
            {
                Write("Dit tal är för litet.");
            }
            else if (TooBig(Guess, CloseBigBorderNumber))
            {
                Write("Dit tal är för stort.");
            }
            else
            {
                Write("Du gissade! Grattis!");
            };

            Write("\nProgramet är slut"); 
        }

        private static int GenerateRandomNumber(){
            return new Random().Next(1,100);
        }

        private static bool OutOfRange(int Guess)
        {
            return Guess > 100 | Guess < 1;
        }

        private static bool CloseBigEnough (int Guess, int RandomNumber, int CloseRange)
        { 
            return Guess <= (RandomNumber + CloseRange) & Guess > RandomNumber;
        }
   
        private static bool CloseSmallEnough(int Guess, int RandomNumber, int CloseRange)
        {
            return Guess >= (RandomNumber - CloseRange) & Guess < RandomNumber;
        }

        private static bool TooSmall(int Guess, int CloseSmallBorderNumber){
            return Guess < CloseSmallBorderNumber;
        }

        private static bool TooBig(int Guess, int CloseBigBorderNumber)
        { 
            return Guess > CloseBigBorderNumber;
        }
   
    }
}
