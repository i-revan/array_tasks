//1. Verilmis ededler siyahisindaki 3-e bolunen ededlerin ededi oratsini tapan alqoritm

var numbers = [2,7,6,12,28,71,33];
let sum = 0;
let count = 0;
for (let i = 0; i < numbers.length; i++) {
    if (numbers[i] % 3 == 0) {
        sum += numbers[i];
        count += 1;
    }
}
console.log(sum/count);