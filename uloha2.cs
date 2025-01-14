  
int radky = 3;
int sloupce = 3;
int[,] matice1 = new int[radky, sloupce];
int[,] matice2 = new int[radky, sloupce];


Console.WriteLine("Zadejte hodnoty pro první matici 3x3:");
for (int i = 0; i < radky; i++)
{
	for (int j = 0; j < sloupce; j++)
	{
		matice1[i, j] = int.Parse(Console.ReadLine());
	}
}

Console.WriteLine("Zadejte hodnoty pro druhou matici 3x3:");
for (int i = 0; i < radky; i++)
{
	for (int j = 0; j < sloupce; j++)
	{
		matice2[i, j] = int.Parse(Console.ReadLine());
	}
}

int[,] matice3 = new int[radky, sloupce];

for (int i = 0; i < radky; i++)
{
	for (int j = 0; j < sloupce; j++)
	{
		matice3[i, j] = matice1[i, j] + matice2[i, j];
	}
}

Console.WriteLine("matice1:");
int radku1 = matice1.GetLength(0);
int sloupcu1 = matice1.GetLength(1);

for (int i = 0; i < radku1; i++)
{
	for (int j = 0; j < sloupcu1; j++)
	{
		Console.Write(matice1[i, j] + " ");
	}
	Console.WriteLine();
}

Console.WriteLine("matice2:");
int radku2 = matice2.GetLength(0);
int sloupcu2 = matice2.GetLength(1);

for (int i = 0; i < radku2; i++)
{
	for (int j = 0; j < sloupcu2; j++)
	{
		Console.Write(matice2[i, j] + " ");
	}
	Console.WriteLine();
}
Console.WriteLine("matice3:");
int radku3 = matice3.GetLength(0);
int sloupcu3 = matice3.GetLength(1);

for (int i = 0; i < radku3; i++)
{
	for (int j = 0; j < sloupcu3; j++)
	{
		Console.Write(matice3[i, j] + " ");
	}
	Console.WriteLine();
}
