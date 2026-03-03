window.onload = function() {
    if (localStorage.getItem("isLoggedIn") !== "true") {
    window.location.href = "login.html";
}

    // Încarcă datele din localStorage
    const first = localStorage.getItem("firstName");
    const last = localStorage.getItem("lastName");
    const email = localStorage.getItem("email");
    const phone = localStorage.getItem("phone");

    if (first) document.getElementById("firstName").value = first;
    if (last) document.getElementById("lastName").value = last;
    if (email) document.getElementById("email").value = email;
    if (phone) document.getElementById("phone").value = phone;
};

function saveProfile() {

    const first = document.getElementById("firstName").value;
    const last = document.getElementById("lastName").value;
    const email = document.getElementById("email").value;
    const phone = document.getElementById("phone").value;

    localStorage.setItem("firstName", first);
    localStorage.setItem("lastName", last);
    localStorage.setItem("email", email);
    localStorage.setItem("phone", phone);

    alert("Profil salvat cu succes!");
}

function goBack() {
    window.location.href = "AMP_index.html";
}
