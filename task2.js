let arr = [53, 33, 99, 3, 12, 5];
let counter = 0;

for (let i = 0; i < arr.length; i++) {
   if (arr[i] >= 0 && arr[i] < 10) {
      counter++;
   }
}
console.log(counter);