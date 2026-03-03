/* =========================
   LA ÎNCĂRCAREA PAGINII
========================= */

window.onload = function() {

    const first = localStorage.getItem("firstName");
    const last = localStorage.getItem("lastName");
    const email = localStorage.getItem("email");

    if (first && last) {
        document.getElementById("profileName").innerText = first + " " + last;
    }

    if (email) {
        document.getElementById("profileEmail").innerText = email;
    }

    showWelcome();
};


/* =========================
   SELECTARE TEMĂ
========================= */

function loadContent(topic) {

    const welcomeBlock = document.getElementById("welcomeBlock");
    const workArea = document.getElementById("workArea");
    const title = document.getElementById("title");
    const resultBox = document.getElementById("resultBox");

    // Ascunde Welcome
    welcomeBlock.style.display = "none";

    // Afișează zona de lucru
    workArea.style.display = "block";

    title.innerText = topic;
    resultBox.innerText = "Selectează o problemă și apasă Calculează.";
}


/* =========================
   FUNCȚIE CALCUL (TEST)
========================= */

function solve() {

    const input = document.getElementById("mathInput").value;
    const resultBox = document.getElementById("resultBox");
    const historyContainer = document.getElementById("historyContainer");
    const title = document.getElementById("title");

    if (input.trim() === "") {
        resultBox.innerText = "Introdu o problemă.";
        return;
    }

    const result = "Rezultat calculat pentru: " + input;
    resultBox.innerText = result;

    // Creează card pentru History
    const historyCard = document.createElement("div");
    historyCard.classList.add("history-card");
    historyCard.innerHTML = `
        <span><strong>${title.innerText}</strong></span>
        <span>${input}</span>
        <span>${result}</span>
    `;

    historyContainer.prepend(historyCard);

    document.getElementById("mathInput").value = "";
}


/* =========================
   WELCOME TEACHMATH
========================= */

function showWelcome() {

    const welcomeBlock = document.getElementById("welcomeBlock");
    const workArea = document.getElementById("workArea");

    welcomeBlock.style.display = "block";
    workArea.style.display = "none";
}


/* =========================
   MERGERE LA PROFILE.HTML
========================= */

function goToProfile() {
    window.location.href = "profile.html";
}
