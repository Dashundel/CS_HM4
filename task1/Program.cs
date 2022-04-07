//1) Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
  
void printArray(int[] arr)
{
	for(int i = 0; i < arr.Length; i++)
		Console.WriteLine(arr[i] + " ");
}

int elementCount(int[] arr, int type)
{
	int count = 0;
			
	if (type != 1 && type !=0) 
	{
		Console.WriteLine("Неверный тип числа!");	
		return 0;
	}
		
	for(int i = 0; i < arr.Length; i++)
	{
		if (type == 0)
		{
            if (arr[i] % 2 != 0) count++;
        }	
		else if (type == 1)
        {
            if (arr[i] % 2 == 0) count++;		
        }
				
	}	
	return count;
}

Console.WriteLine("Введи размерность массива: ");
int len = int.Parse(Console.ReadLine());

int[] array = new int [len];
Random rnd = new Random();

for(int i = 0; i < array.Length; i++)
	array[i] = rnd.Next(100, 999); 
	
Console.WriteLine("Массив: ");
printArray(array);	

int oddCount = elementCount(array, 0);
Console.WriteLine("Количество нечетных элементов: " + oddCount);

int evenCount = elementCount(array, 1);
Console.WriteLine("Количество четных элементов: " + evenCount);

