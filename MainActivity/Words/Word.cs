using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainActivity.Words {
    public class Word {
        public string getRandomWords(Level1 level1) {
            return ((string)level1.GenerateRandomWord(level1.RussianWord));
        }
    }
}
