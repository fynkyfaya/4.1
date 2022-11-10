﻿var firstArray = new double[7];
var secondArray = new double[9];

for (var i = 0; i < firstArray.Length; i++)
    firstArray[i] = double.Parse(Console.ReadLine());

for (var i = 0; i < secondArray.Length; i++) 
    secondArray[i] = double.Parse(Console.ReadLine());

var thirdArray = new double[firstArray.Length + secondArray.Length];

for (var i = 0; i < firstArray.Length; i++) {
    thirdArray[i] = firstArray[i];
}

for (var i = firstArray.Length; i < thirdArray.Length; i++) {
    thirdArray[i] = secondArray[i - firstArray.Length];
}

double temperance;
for (var write = 0; write < thirdArray.Length; write++) {
    for (var sort = 0; sort < thirdArray.Length - 1; sort++) {
        if (thirdArray[sort] < thirdArray[sort + 1]) {
            temperance = thirdArray[sort + 1];
            thirdArray[sort + 1] = thirdArray[sort];
            thirdArray[sort] = temperance;
        }
    }
}

for (var i = 0; i < thirdArray.Length; i++)
    Console.Write($"{thirdArray[i]} ");