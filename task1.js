let arr = [52, 95, 32, 53, 13, 21];
let min = arr[0];

for (let i = 1; i < arr.length; i++) {
   if (arr[i] < min) {
      min = arr[i];
   }
}

console.log(min);