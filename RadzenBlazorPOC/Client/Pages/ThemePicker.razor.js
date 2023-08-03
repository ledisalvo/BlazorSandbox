var theme_one = document.getElementById('theme_one');
var bodyStyles = document.body.style;

console.log('funciona');

theme_one.addEventListener("click", () => {
    console.log('paso por aca');
    bodyStyles.setProperty('--rz-primary', '#ec3225');
});
