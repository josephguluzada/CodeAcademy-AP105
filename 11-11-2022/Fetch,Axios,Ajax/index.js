// fetch("https://jsonplaceholder.typicode.com/todos/1")
//     .then(res => res.json())
//     .then(data => console.log(data))


// fetch("https://api.tvmaze.com/shows/2")
//     .then(res => res.json())
//     .then(data => {
//         let img = document.createElement("img");
//         img.setAttribute("src", data.image.medium)

//         document.querySelector("body").appendChild(img)
//     })


// fetch("https://api.tvmaze.com/shows")
//     .then(res => res.json())
//     .then(data => {
//         for (let i = 0; i < data.length; i++) {
//             let img = document.createElement("img");
//             img.setAttribute("src", data[i].image.medium)

//             document.querySelector("body").appendChild(img)
//         }
//     }).catch(err => console.log(err))


// fetch("https://api.tvmaze.com/shows")
//     .then(res => res.json())
//     .then(data => {
//         console.log(data);
//         let ul = document.createElement("ul");

//         for (let i = 0; i < data.length; i++) {
//             let li = document.createElement("li")

//             li.innerText = data[i].name + " " + data[i].id + " " + data[i].language

//             ul.appendChild(li)

//         }
//         document.querySelector("body").appendChild(ul)
//     }).catch(err => console.log(err))



// Axios

// axios.get("https://api.tvmaze.com/shows")
//     .then(res => {
//         for (let i = 0; i < res.data.length; i++) {
//             let img = document.createElement("img");
//             img.setAttribute("src", res.data[i].image.medium)

//             document.querySelector("body").appendChild(img)
//         }
//     })


// AJAX

// $.ajax({
//     method: "GET",
//     url: "https://api.tvmaze.com/shows",
//     type: JSON
// }).done(data => {
//     for (let i = 0; i < data.length; i++) {
//         let img = document.createElement("img");
//         img.setAttribute("src", data[i].image.medium)

//         document.querySelector("body").appendChild(img)
//     }
// })