function switchTheme() {
    const theme = document.getElementById("theme");
    const currentTheme = theme.getAttribute("href");
  
    if (currentTheme === "light.css") {
      theme.href = "dark.css";
    } else {
      theme.href = "light.css";
    }
  }
  