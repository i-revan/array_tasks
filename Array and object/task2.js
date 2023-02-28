//2. Verilmis ededler siyahisinda reqemlerinin sayi 2-den boyuk olan ededlerin cemini tapan alqoritm

var numbers = [2,7,621,12,28,171,33];
let sum = 0;
for (let i = 0; i < numbers.length; i++) {
    if(numbers[i] > 99){
        sum += numbers[i];
    }    
}
console.log(sum);