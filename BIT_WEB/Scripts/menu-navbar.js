const menuBtn = document.querySelector(".menu-icon span");
const powerBtn = document.querySelector(".logout-icon");
const cancelBtn = document.querySelector(".cancel-icon");
const items = document.querySelector(".nav-items");
menuBtn.onclick = () => {
    items.classList.add("active");
    menuBtn.classList.add("hide");
    powerBtn.classList.add("hide");
    cancelBtn.classList.add("show");
}
cancelBtn.onclick = () => {
    items.classList.remove("active");
    menuBtn.classList.remove("hide");
    powerBtn.classList.remove("hide");
    cancelBtn.classList.remove("show");
}
