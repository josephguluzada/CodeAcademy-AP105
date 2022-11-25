

let car = { brand: "Mercedes", model: "E220", color: "Black", year: "2019" }

console.log(car.brand + " " + car.model + " " + car.color + " " + car.year)

let counter = 0;
let cars =
    [
        { brand: "Mercedes", model: "E220", color: "Black", year: 2019 },
        { brand: "BMW", model: "F10", color: "Grey", year: 2016 },
        { brand: "Toyoto", model: "Prius", color: "Red", year: 2028 },
        { brand: "Hyundai", model: "Sonata", color: "White", year: 2021 }
    ]


for (let i = 0; i < cars.length; i++) {
    if (cars[i].color == "Red") {
        console.log(cars[i].brand);
    }
}

for (let i = 0; i < cars.length; i++) {
    if (cars[i].year >= 2019) {
        counter++;
        console.log("Ili yeni olanlarin brandi: " + cars[i].brand);
    }

}

console.log("Yeni masinlarin sayi: " + counter);