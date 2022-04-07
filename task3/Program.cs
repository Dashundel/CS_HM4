//3)Найти сумму чисел одномерного массива стоящих на нечетной позиции

void printArray(int[] arr)
{
	for(int i = 0; i < arr.Length; i++)
		Console.WriteLine(arr[i] + " ");
}

int sumNumberOddPosition(int[] arr)
{
	int sum = 0;
	for(int i = 1; i < arr.Length; i += 2)
		 sum += arr[i];

	return sum;
}
int[] array = new int[10];

Random rnd = new Random();

for(int i = 0; i < array.Length; i++)
	array[i] = rnd.Next(-10, 11);
	
Console.WriteLine("Массив: ");
printArray(array);	
Console.WriteLine("Сумма равна: " + sumNumberOddPosition(array));

