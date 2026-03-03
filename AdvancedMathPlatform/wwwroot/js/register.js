function register() {

    const first = document.getElementById("regFirst").value;
    const last = document.getElementById("regLast").value;
    const email = document.getElementById("regEmail").value;
    const password = document.getElementById("regPassword").value;

    if (!first || !last || !email || !password) {
        alert("Completează toate câmpurile!");
        return;
    }

    const user = {
        firstName: first,
        lastName: last,
        email: email,
        password: password
    };

    localStorage.setItem("user", JSON.stringify(user));

    alert("Cont creat cu succes!");
    window.location.href = "login.html";
}


function login() {

    const email = document.getElementById("loginEmail").value;
    const password = document.getElementById("loginPassword").value;

    const storedUser = JSON.parse(localStorage.getItem("user"));

    if (!storedUser) {
        alert("Nu există utilizator!");
        return;
    }

    if (email === storedUser.email && password === storedUser.password) {

        localStorage.setItem("isLoggedIn", "true");

        alert("Login reușit!");
        window.location.href = "AMP_index.html";

    } else {
        alert("Email sau parolă greșită!");
    }
}


function logout() {
    localStorage.removeItem("isLoggedIn");
    window.location.href = "login.html";
}
