const body = document.querySelector("body"),
    sidebar = body.querySelector(".sidebar"),
    toggle = body.querySelector(".toggle"),
    searchBtn = body.querySelector(".search-box");
const logoImage = document.getElementById("logoImage");

    toggle.addEventListener("click", () =>{
        sidebar.classList.toggle("close");

        if (sidebar.classList.contains("close")) {
            // Change the image source to another logo when sidebar is closed
            logoImage.src = "/mini_logo.jpg";
            logoImage.alt = "Mindre logo";
            logoImage.style.width = "60px"; // Adjust the width for the smaller logo
        } else {
            // Change the image source back to the original logo when sidebar is open
            logoImage.src = "/logo_nosted_endrett.jpg";
            logoImage.alt = "logo";
            logoImage.style.width = "200px"; // Adjust the width for the original logo
        }
    });

    
    
    