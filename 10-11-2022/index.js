// // console.log(a);
// // console.log(b);
// // console.log(c);

// // var a = 5;
// // let b = 6;
// // const c = 7;
// // console.log(a);
// // b = 8;
// // c = 9;

// // console.log(b);
// // console.log(c);

// // let name = "Eli";

// // console.log(typeof name);

// // let number = 99;
// // let number2 = 99.3;

// // console.log(typeof number);
// // console.log(typeof number2);

// // let check = false;

// // console.log(typeof check);

// // let arr = [98, "Yusif"]

// // console.log(typeof arr);

// // let obj = { color: "black" }

// // console.log(typeof obj);

// // let und = undefined;

// // console.log(typeof und);

// // let nullValue = null;

// // console.log(typeof nullValue);

// // let notANumber = "Name" / 3;
// // console.log(notANumber);

// // console.log(typeof notANumber);


// // let obj = { name: "Kamil" };

// // if (obj.name) {
// //     console.log("Var");
// // } else {
// //     console.log("Yoxdur");
// // }

// // let checkVariable = "";
// // if (checkVariable) {
// //     console.log("True");
// // } else {
// //     console.log("False");
// // }


// // function Sum(a, b) {
// //     return a + b;
// // }

// // function Divide(a, b) {
// //     console.log(a / b);
// // }

// // let sum = Sum(5, 8);

// // console.log(sum);

// // Divide(12, 4)


let number = 50;
let person = { name: "Vasif" }

function Check(params) {
    if (params.name) {
        params.name = "Eli"
        console.log(params);
    } else {
        params = 60;
        console.log(params);
    }
}


Check(number);
Check(person);

console.log("number", number);
console.log("person", person);

// // console.log(person.name);

// // function Test() {
// //     let a = 5;
// //     return a;
// // }


// // let a = Test();

// // console.log(a);
// // console.log(b);

// // console.log(Multiply);
// // console.log(word);
// // console.log(word2);


// // function Multiply(a, b) {
// //     return a * b
// // }

// // let word = function () {
// //     return "Hello,AP105"
// // }

// // let word2 = () => {
// //     return "Hello, AP105 2" // Arrow
// // }

// // let word3 = () => "Hello, AP105 2" // Arrow

// // let sum = function (a, b) {
// //     return a + b;
// // }

// // console.log(sum(5, 7));
// // console.log(word());
// // console.log(word2());


// // let paragraph = document.getElementById("paragraph")
// // let pElements = document.getElementsByClassName("text")
// // let heading = document.querySelector(".heading")
// // let paragraph2 = document.querySelector("#paragraph")
// // let pElements2 = document.querySelectorAll(".text")

// // console.log(paragraph);

// // console.log(pElements);
// // console.log(heading);
// // console.log(paragraph2);
// // console.log(pElements2);


let input = document.getElementById("text");
let btn = document.querySelector("#addBtn")
let list = document.getElementById("textList")

btn.addEventListener("click", function () {
    // create li element
    let li = document.createElement("li");
    // li 'nin icerisine yazi yazdirdiq
    li.innerText = input.value
    // append li element to ul
    list.appendChild(li);
})

// let paragraphElem = document.getElementById("pElement");

// // paragraphElem.innerText = "<span>Yusif</span>"
// // paragraphElem.innerHTML = "<span>Yusif</span>"




// const div = document.getElementsByClassName("city")
// console.log(div);

// function changeColor(element, color) {
//     element.style.background = color
// }

// // Array.from(div, el => {
// //     changeColor(el, "green")
// // })

// Array.from(div, el => {

// })