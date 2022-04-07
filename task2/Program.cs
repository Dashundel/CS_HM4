//2) В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void printArray(int[] arr)
{
	for(int i = 0; i < arr.Length; i++)
		Console.WriteLine(arr[i] + " ");
}

int elementCount(int[] arr)
{
	int count = 0;
		
	for(int i = 0; i < 123; i++)
        if(arr[i] >= 10 && arr[i] <= 99) count++;

	return count;
}

int[] array = new int[123];
Random rnd = new Random();

for(int i = 0; i < array.Length; i++)
	array[i] = rnd.Next(0, 1000); 

Console.WriteLine("Массив: ");
printArray(array);	

int count = elementCount(array);
Console.WriteLine("Количество элементов: " + count);


