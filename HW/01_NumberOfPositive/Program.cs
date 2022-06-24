// **Задача 41:** Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
using System;
using static System.Console;

Clear();
Write("Введите числа через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(", ", array)}] -> Количество положительных чисел = {NumberOfPositive(array)}");

int[] GetArrayFromString (string arrayStr) {
	string[] arS = arrayStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	int[] result = new int[arS.Length];
	for(int i = 0; i < arS.Length; i ++) {
		result[i]=int.Parse(arS[i]);
	}
	return result;
}

int NumberOfPositive (int[] _array) {
	int result = 0;
	for (int i = 0; i < _array.Length; i ++) {
		if (_array[i] > 0)	result ++;
	}
	return result;
}
