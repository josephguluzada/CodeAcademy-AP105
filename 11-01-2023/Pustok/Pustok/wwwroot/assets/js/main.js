let deleteButtons = document.querySelectorAll(".delete-image-btn");


deleteButtons.forEach(btn => btn.addEventListener("click", function () {
    btn.parentElement.remove();
}))