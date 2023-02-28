//4. Verilmis adlar siyahisindaki adi 'A' herfi ile baslayanlarin sayini tapan alqoritm
let names = ["Adil", "Teymur", "Səlim", "Samirə", "Almaz"];
let count = 0;
for (let i = 0; i < names.length; i++) {
    if(names[i][0] == 'A'){
        count++;
    }
}
console.log(count);