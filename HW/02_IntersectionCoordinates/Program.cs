// **Задача 43:** Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
using System;
using static System.Console;

Clear();

WriteLine("Задайте коэффициенты линий, заданных уравнениями  y = k1 * x + b1, y = k2 * x + b2");
Write("Введите коэффициенты k1 b1 k2 b2 через пробел: ");
double[] coef = GetArrayFromString(ReadLine());
double[] coordinate = CoordinatesOfLineIntersection(coef[0], coef[1], coef[2], coef[3]);
WriteLine($"Координаты точки пересечения линий ({coordinate[0]}; {coordinate[1]})");

double[] GetArrayFromString (string arrayStr) {
	string[] arS = arrayStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	double[] result = new double[arS.Length];
	for(int i = 0; i < arS.Length; i ++) {
		result[i]=double.Parse(arS[i]);
	}
	return result;
}

double[] CoordinatesOfLineIntersection (double k1, double b1, double k2, double b2) {
	double[] result = new double[2];
	result[0] = (b2 - b1) / (k1 - k2);
	result[1] = k1 * (b2 - b1) / (k1 - k2) + b1;
	return result;
}