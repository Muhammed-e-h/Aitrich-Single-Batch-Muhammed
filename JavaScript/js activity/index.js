let nums = [1, 2, 3, 2, 4, 1, 5];
let unique = [];
let i = 0;

while (i < nums.length) {
  if (!unique.includes(nums[i])) {
    unique.push(nums[1]);
  }
  i++;
}
console.log(unique);

let colors = ["red", "blue", "green", "red", "yellow", "red"];
let p = 0;
let count = 0;

while (i < colors.length) {
  if (colors[i] === "red") {
    count++;
  }
  i++;
}

console.log("count");

let str = "JavaScript";
let reversed = "";
let n = str.length - 1;

while (i >= 0) {
  reversed += str[i];
  i--;
}

console.log("Reversed string:", reversed);

let arr = [12, 45, 67, 23, 89, 45];
let l = 0;
let largest = -Infinity;
let secondLargest = -Infinity;

while (i < arr.length) {
  if (arr[i] > largest) {
    secondLargest = largest;
    largest = arr[i];
  } else if (arr[i] > secondLargest && arr[i] < largest) {
    secondLargest = arr[i];
  }
  i++;
}

console.log("Second largest number:", secondLargest);

let arr1 = ["A", "B", "C"];
let arr2 = ["D", "E", "F"];
let merged = [];
let m = 0;

while (i < arr1.length) {
  merged.push(arr1[i]);
  i++;
}

i = 0;
while (i < arr2.length) {
  merged.push(arr2[i]);
  i++;
}

console.log("Merged Array:", merged);

let numbers = [2, 5, 7, 10, 13, 8];
let o = 0;
let sum = 0;

while (i < numbers.length) {
  if (numbers[i] % 2 !== 0) {
    sum += numbers[i];
  }
  i++;
}

console.log("Sum of odd numbers:", sum);

let words = ["cat", "elephant", "dog", "tiger", "go"];
let s = 0;
let longWords = [];

while (i < words.length) {
  if (words[i].length > 4) {
    longWords.push(words[i]);
  }
  i++;
}

console.log("Words with length > 4:", longWords);

let num = [2, 4, 6, 8, 10];
let c = 0;
let isSorted = true;

while (i < nums.length - 1) {
  if (nums[i] > nums[i + 1]) {
    isSorted = false;
    break;
  }
  i++;
}

if (isSorted) {
  console.log("The array is sorted in ascending order.");
} else {
  console.log("The array is NOT sorted in ascending order.");
}

let hum = [3, 5, -2, 7, -8, 1];
let u = 0;
let firstNegativeIndex = -1;

while (i < nums.length) {
  if (nums[i] < 0) {
    firstNegativeIndex = i;
    break;
  }
  i++;
}

if (firstNegativeIndex !== -1) {
  console.log("First negative number found at index:", firstNegativeIndex);
} else {
  console.log("No negative numbers found.");
}

let kum = [1, 2, 3, 4];
let y = arr.length - 1;
let rotated = [];
rotated.push(arr[i]);
i = 0;
while (i < arr.length - 1) {
  rotated.push(arr[i]);
  i++;
}

console.log("Rotated Array:", rotated);



// new activity;



function greetuser(name) {
  console.log("welcome," + name + "!");
}
greetuser("muhammed");

function printTable(number) {
  let i = 1;
  while (i <= 10) {
    console.log(number + " x " + i + " = " + (number * i));
    i++;
  }
}
printTable(5);

function showWeather(city) {
  let conditions = ["sunny", "cloudy", "rainy"];
  let randomIndex = Math.floor(Math.random() * conditions.length);
  let weather = conditions[randomIndex];
  console.log("Today's weather in " + city + " is " + weather + ".");
}
showWeather("Thrissur");
function addNumbers(a, b) {
  return a + b;
}

let result = addNumbers(10, 5);
console.log("Sum = " + result);
function findLargest(a, b, c) {
  if (a >= b && a >= c) {
    return a;
  }
  else if (b >= a && b >= c) {
    return b;
  }
  else {
    return c;
  }
}

let large = findLargest(12, 45, 20);
console.log("Largest number is " + largest);
function calculateBill(price, quantity) {
  return price * quantity;
}

let bill = calculateBill(50, 3);
console.log("Total Bill = ₹" + bill);
let square = function (num) {
  return num * num;
};

console.log("Square = " + square(5));
let reverseString = function (str) {
  return str.split("").reverse().join("");
};
console.log("Reversed: " + reverseString("Hello"));

function calculateDiscount(originalPrice, discountPercent) {
  let discountAmount = (originalPrice * discountPercent) / 100;
  let finalPrice = originalPrice - discountAmount;
  return finalPrice;
}

console.log("Final Price = ₹" + calculateDiscount(1000, 20));
function isEligibleForVote(age) {
  if (age >= 18) {
    return true;
  } else {
    return false;
  }
}

console.log(isEligibleForVote(20));
console.log(isEligibleForVote(16));



