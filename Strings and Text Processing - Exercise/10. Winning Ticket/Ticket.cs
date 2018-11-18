using System;
using System.Collections.Generic;
using System.Text;

namespace _10._Winning_Ticket
{
    public class Ticket
    {
        private readonly char[] winningSymbols = new char[] { '@', '#', '$', '^' };

        public Ticket(string value)
        {
            this.Value = value;
            this.IsValid = this.Validate();
            this.IsWinner = this.HasPrize();
            this.HasJackpot = this.CheckForJackpot();
        }
        public string Value { get; private set; }
        public bool IsValid { get; private set; }
        public bool IsWinner { get; private set; }
        public bool HasJackpot { get; private set; }
        public string Match { get; private set; }


        private bool Validate()
        {
            const int MAX_VALUE_LENGTH = 20;
            if (this.Value.Length != MAX_VALUE_LENGTH)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckForJackpot()
        {
            if (this.Match.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool HasPrize()
        {
            int indexOfHalf = this.Value.Length / 2;
            string firstHalf = this.Value.Substring(0, indexOfHalf);
            string secondHalf = this.Value.Substring(indexOfHalf);

            string winStrFirst = CheckHalf(firstHalf);
            string winStrSecond = CheckHalf(secondHalf);
            if (winStrFirst != string.Empty && winStrSecond != string.Empty)
            {
                if (winStrFirst.Length < winStrSecond.Length)
                {
                    this.Match = winStrFirst;
                }
                else
                {
                    this.Match = winStrSecond;
                }

                return true;
            }
            else
            {
                this.Match = string.Empty;
                return false;
            }
        }

        private string CheckHalf(string half)
        {
            const int MIN_LENGTH = 6;

            string winStrAt = new string(this.winningSymbols[0], MIN_LENGTH);
            string winStrHashTag = new string(this.winningSymbols[1], MIN_LENGTH);
            string winStrDollar = new string(this.winningSymbols[2], MIN_LENGTH);
            string winStrXor = new string(this.winningSymbols[3], MIN_LENGTH);

            char winSymbol = default(char);
            if (half.Contains(winStrAt))
            {
                // return @ x realLength
                winSymbol = this.winningSymbols[0];
            }
            else if (half.Contains(winStrHashTag))
            {
                // return # x realLength
                winSymbol = this.winningSymbols[1];
            }
            else if (half.Contains(winStrDollar))
            {
                // return $ x realLength
                winSymbol = this.winningSymbols[2];
            }
            else if (half.Contains(winStrXor))
            {
                // return ^ x realLength
                winSymbol = this.winningSymbols[3];
            }
            else
            {
                return string.Empty;
            }
            
            int count = Count(half, winSymbol);
            return new string(winSymbol, count);
        }

        private int Count(string half, char winSymbol)
        {
            int count = 0;
            foreach (var symbol in half)
            {
                if (symbol == winSymbol)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
