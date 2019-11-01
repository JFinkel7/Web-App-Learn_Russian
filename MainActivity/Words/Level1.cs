using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainActivity.Words {
    public class Level1 {
        private const string STRING_ARRAY_ERROR = "-> Length of String Array = 0 OR NULL";
        public string[] RussianWord = {
           "Это София",
           "Я Брайан",
           "Я Брайан, а Это София",
           "мой учитель-Дима",
           "Я русский студент",
           "мой профессор преподает английский",
           "Брайан-мой профессор",
           "Это мой наставник"
        };
        public string[] EnglishWord = {
            "This is Sofia",
            "I am Brian",
            "I am Brian, and this is Sofia",
            "My teacher is Dima",
            "I am a Russian student",
            "My professor teaches English",
            "Brian is my Professor",
            "This is my mentor"
        };
        //=======================================================================================
        //***> 
        //***>
        // Generates Random Words
        public string GenerateRandomWord(string[] array) {
            Random random = new Random();
            int randIndex = random.Next(0, array.Length);
            return (array[randIndex]);
        }

        public bool QuestionIsCorrect(string userInput) {
            for (int i = 0; i < EnglishWord.Length; i++) {
                if (userInput.Equals(EnglishWord[i])) {
                    return (true);
                }
            }
            return (false);
        }
        public int GetRussianIndex(string randomWord) {
            for (int i = 0; i < RussianWord.Length; i++) {
                if (RussianWord[i].Equals(randomWord)) {
                    return (i);
                }
            }
            return (0);
        }
    }
}
