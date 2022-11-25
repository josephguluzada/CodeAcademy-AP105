let noInput = document.getElementById("noInput")
let fnInput = document.getElementById("fnInput")
let posInput = document.getElementById("posInput")
let addBtn = document.getElementById("addBtn")
let tableBody = document.getElementById("tableBody")

addBtn.addEventListener("click", function () {
    if (noInput.value != "" && fnInput.value != "" && posInput.value != "") {
        let tr = document.createElement("tr")
        let tdNo = document.createElement("td")
        let tdFn = document.createElement("td")
        let posTd = document.createElement("td")

        tdNo.innerText = noInput.value
        tdFn.innerText = fnInput.value
        posTd.innerText = posInput.value

        tr.appendChild(tdNo)
        tr.appendChild(tdFn)
        tr.appendChild(posTd)

        tableBody.appendChild(tr)

        noInput.value = ""
        fnInput.value = ""
        posInput.value = ""
    } else {
        alert("Input bow ola bilmez deyil!")
    }

})