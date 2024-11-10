function toggleTheme() {
    document.body.classList.toggle("dark-mode");
    const themeButton = document.querySelector(".toggle-theme");
    if (document.body.classList.contains("dark-mode")) {
        themeButton.textContent = "☀️ Modo Claro";
    } else {
        themeButton.textContent = "🌙 Modo Escuro";
    }
}
