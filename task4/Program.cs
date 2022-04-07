//4)Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void printArray(int[] arr)
{
	for(int i = 0; i < arr.Length; i++)
		Console.WriteLine(arr[i] + " ");
}	

int[] elementPairProduct(int[] arr)
{
	int[] product = new int[arr.Length/2];
		
	for(int i = 0; i < arr.Length/2; i++)
		product[i] = arr[i] * arr[arr.Length - i - 1];
	
	return product;
}

Console.WriteLine("Введи размерность массива: ");
int len = int.Parse(Console.ReadLine());

int[] array = new int[len];
Random rnd = new Random();

for(int i = 0; i < array.Length; i++)
	array[i] = rnd.Next(0, 1000); 

Console.WriteLine("Массив: ");
printArray(array);	

int[] product = elementPairProduct(array);
Console.WriteLine("Произведение пар элементов: ");
printArray(product);
