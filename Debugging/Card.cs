using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Card
    {
        private int _suit = 4;
        private int _value = 1;

        private bool ValidCard()
        {
            return _value >= 1 && _value <= 13 && _suit >= 1 && _suit <= 4;
        }

        public Card()
        {
            _suit = 4;
            _value = 1;
        }
        public Card(int suit, int value)
        {
            _suit = suit;
            _value = value;
        }

        public void print()
        {
            if (!ValidCard())
            {
                Console.WriteLine("This is not a valid card! :(");
            }

            Console.Write("This is the:  ");

            switch (_value)
            {
                case 1:
                    Console.Write("Ace ");
                    break;
                case 11:
                    Console.Write("Jack ");
                    break;
                case 12:
                    Console.Write("Queen ");
                    break;
                case 13:
                    Console.Write("King ");
                    break;
                default:
                    Console.Write(_value + " ");
                    break;
            }

            switch (_suit)
            {
                case 1:
                    Console.WriteLine("of Clubs");
                    break;
                case 2:
                    Console.WriteLine("of Diamonds ");
                    break;
                case 3:
                    Console.WriteLine("of Hearts ");
                    break;
                case 4:
                    Console.WriteLine("of Spades ");
                    break;
                default:
                    Console.WriteLine("invalid suit ");
                    break;

            }
        }

        int GetSuit()
        {
            return _suit;
        }

        int GetValue()
        {
            return _value;
        }

        void SetSuit(int suit)
        {
            _suit = suit;
        }
        void SetValue(int value)
        {
            _value = value;
        }

        private bool ValidCard()
        {
            return _value >= 1 && _value <= 13 && _suit >= 1 && _suit <= 4;
        }

        public Card()
        {
            _suit = 4;
            _value = 1;
        }
        public Card(int suit, int value)
        {
            _suit = suit;
            _value = value;
        }

        public void print()
        {
            if (!ValidCard())
            {
                Console.WriteLine("This is not a valid card! :(");
            }

            Console.Write("This is the:  ");

            switch (_value)
            {
                case 1:
                    Console.Write("Ace ");
                    break;
                case 11:
                    Console.Write("Jack ");
                    break;
                case 12:
                    Console.Write("Queen ");
                    break;
                case 13:
                    Console.Write("King ");
                    break;
                default:
                    Console.Write(_value + " ");
                    break;
            }

            switch (_suit)
            {
                case 1:
                    Console.WriteLine("of Clubs") ;
                    break;
                case 2:
                    Console.WriteLine("of Diamonds ");
                    break;
                case 3:
                    Console.WriteLine("of Hearts ");
                    break;
                case 4:
                    Console.WriteLine("of Spades ");
                    break;
                default:
                    Console.WriteLine("invalid suit ");
                    break;

            }
        }

        int GetSuit()
        {
            return _suit;
        }

        int GetValue()
        {
            return _value;
        }

        void SetSuit(int suit)
        {
            _suit = suit;
        }
        void SetValue(int value)
        {
            _value = value;
        }

    }
}
