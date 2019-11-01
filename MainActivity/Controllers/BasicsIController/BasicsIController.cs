using Microsoft.AspNetCore.Mvc;
using MainActivity.Words;
using MainActivity.ViewModels;
namespace Main_Activity.Controllers.BasicsIController {
    public class BasicsIController : Controller {
        //
        private const int WIN_POINTS = 100;
        //
        // * Main Menu *
        public IActionResult MainMenu() {
            return View();
        }

        // * Level 1 *
        [HttpGet]
        public IActionResult Level1(Level1 Lvl1) {
            ShowEnglishTranslation(Lvl1);
            return View();
        }

        [HttpPost]
        public IActionResult Level1(Lvl1_ViewModel ViewBag, Level1 Lvl1) {
            ShowEnglishTranslation(Lvl1);
            if (ModelState.IsValid) {
                string userInput = ViewBag.Input.ToString();
                if (!(string.IsNullOrEmpty(userInput))) {
                    if (Lvl1.QuestionIsCorrect(userInput)) {
                        base.ViewBag.Result = "Correct";

                    } else {
                        base.ViewBag.Result = "Wrong";
                    }
                }
            }
            return View();
        }

        public void ShowEnglishTranslation(Level1 Lvl1) {
            string chosenRandomWord = new Level1().GenerateRandomWord(Lvl1.RussianWord);
            ViewData["GenerateRandomWord"] = chosenRandomWord;
            ViewData["EnglishTranslation"] = Lvl1.EnglishWord[Lvl1.GetRussianIndex(chosenRandomWord)];
        }

        // TO BE  DONE
        // * Level 2 *
        public IActionResult Level2() {
            return View();
        }
    }//END OF CLASS
}
//Learn_A_Language_Web-App
