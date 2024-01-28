using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestionsMadeClear.IsUnique
{
    internal class IsUnique
    {

        
        public static bool check(string MyString) {

            if (MyString.Length > 128) return false;

            bool []memory  = new bool[128];// just ascii 

            foreach (int c in MyString) {

                if (memory[c] == true) {
                    return false; // we have seen it 
                }

                memory[c] = true;

            }

            return true;
           
        }

        public static bool isUniqueHash(string MyString) { 
        
            
            HashSet<char> memory = new HashSet<char>();

            foreach (char ch in MyString)
            {

                if (memory.Contains(ch))
                {
                    return false;
                }
                memory.Add(ch);
                
                 

            }

            return true;

        }

    }
}
