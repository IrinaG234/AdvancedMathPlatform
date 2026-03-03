function showWelcome() {
    document.getElementById("welcomeBlock").style.display = "block";
    document.getElementById("workArea").style.display = "none";
}

function loadContent(topic) {
    document.getElementById("welcomeBlock").style.display = "none";
    document.getElementById("workArea").style.display = "block";

    document.getElementById("title").innerText = topic;
    document.getElementById("resultBox").innerText =
        "Selectează o problemă și apasă Calculează.";
}

function solve() {

    const input = document.getElementById("mathInput").value;

    if (input.trim() === "") {
        document.getElementById("resultBox").innerText = "Introdu o problemă.";
        return;
    }

    document.getElementById("resultBox").innerText =
        "Rezultat pentru: " + input;
}
