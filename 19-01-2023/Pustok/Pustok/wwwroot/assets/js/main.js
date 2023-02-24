// Multiple image file delete (one by one)
let deleteButtons = document.querySelectorAll(".delete-image-btn");


deleteButtons.forEach(btn => btn.addEventListener("click", function () {
    btn.parentElement.remove();
}))


// Delete Item in Admin Panel

let itemDeleteBtns = document.querySelectorAll(".item-delete");

itemDeleteBtns.forEach(btn => btn.addEventListener("click", function (e) {
    e.preventDefault();

    Swal.fire({
        title: 'Əminsiniz mi?',
        text: "Geri qaytara bilməyəksiniz!",
        icon: 'question',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Bəli, sil onu!',
        cancelButtonText: 'Imtina'
    }).then((result) => {
        if (result.isConfirmed) {
            let url = btn.getAttribute("href");

            fetch(url)
                .then(response => {
                    if (response.status == 200) {
                        window.location.reload(true);
                    } else {
                        alert("silmek istediyiniz item tapilmadi!")
                    }
                })
        }
    })
}))


// Addtobasket fetch

let addToBasketBtns = document.querySelectorAll(".add-to-basket-btn");

addToBasketBtns.forEach(btn => btn.addEventListener("click", function (e) {
    e.preventDefault();

    let url = btn.getAttribute("href");

    fetch(url)
        .then(response => {
            if (response.status == 200) {
                alert("Added in to basket")
            } else {
                alert("Error!")
            }
        })


}))