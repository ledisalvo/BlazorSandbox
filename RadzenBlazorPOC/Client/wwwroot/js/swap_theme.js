export function setTheme(themeName) {
    var head = document.getElementsByTagName("head")[0];
    head.querySelector("#theme").remove();

    var newLink = document.createElement("link");
    newLink.setAttribute("id", "theme");
    newLink.setAttribute("rel", "stylesheet");
    newLink.setAttribute("type", "text/css");
    newLink.setAttribute("href", `/css/theme-${themeName}.css`);
        
    head.appendChild(newLink);
}
