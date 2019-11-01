// NOTE: Current File is Not Being Used Until Updated!
// DOCUMENT ID'S
var btnConfirm = document.getElementById("btn-icon-info");
var txtQuestion = document.getElementById("Label-RussianQuestion");
var progressBar = document.getElementById("progressBar");

let RUSSIAN_WORD = [
    "Это София",
    "Я Брайан",
    "Я Брайан, а Это София",
    "мой учитель-Дима",
    "Я русский студент",
    "мой профессор преподает английский",
    "Брайан-мой профессор",
    "Это мой наставник"
]


function sendMessage(message) {
    alert(message);
}
function setProgressBar(result) {
    var startProgress = 0;
    if (result === "Correct") {
        progressBar.style.width = `${10}%`;
    } else {
        progressBar.style.width = 0;
    }
}

function generateRandomQuestion() {
    // Generates A Random Question On Load 
    randomRussianQuestion = setRandomIndex(russianQuestion);
    txtQuestion.textContent = randomRussianQuestion;

}




