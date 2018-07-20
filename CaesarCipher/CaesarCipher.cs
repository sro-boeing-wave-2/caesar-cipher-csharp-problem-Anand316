using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            StringBuilder caesar = new StringBuilder();
            int x;
            foreach(char c in text)
            {
                if(Char.IsLetter(c))
                {
                    x = Char.IsUpper(c) ? ((c + shiftKey - 'A') % 26) +'A' : ((c + shiftKey - 'a') % 26)+'a';
                    caesar.Append((char)x);
                }
                else
                {
                    caesar.Append(c);
                }
            }
            return caesar.ToString();
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
