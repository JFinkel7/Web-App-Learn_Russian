// NOTE: Current File is Not Being Used Until Updated!
// DOCUMENT ID'S
var soundFile; var audioPath = "C:\Users\User\Documents\7 Projects\Russian Projects\Website Learn Russian\1 - Learn Russian\Version 3.00\LearnRussian\com.jfinkelstudios.web.app.learnrussian\MainActivity\wwwroot\BasicsI\Level1\click_1.wav"
var btnConfirm = document.getElementById("btn-icon-info");
var txtQuestion = document.getElementById("Label-RussianQuestion");
var progressBar = document.getElementById("progressBar");



function setProgressBar(isCorrect) {
    if (isCorrect==="Correct") {
        alert("true"); 
    } else {
        alert("false");
    }
}

function playClickEffect() {
    soundFile = new Audio("Level1/Audio/click_1.wav"); // Buffers When Automatically When created
    if (soundFile != null || soundFile != undefined) {
        soundFile.play();
        console.log("Sound Works");
    }
}
function sendMessage(message) {
    alert(message);
    
}







