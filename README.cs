int[,] matice;
matice = new int[2, 3];
matice[0, 1] = Convert.ToInt32(Console.ReadLine());
matice[0, 2] = Convert.ToInt32(Console.ReadLine());
matice[0, 3] = Convert.ToInt32(Console.ReadLine());
matice[1, 1] = Convert.ToInt32(Console.ReadLine());
matice[1, 2] = Convert.ToInt32(Console.ReadLine()); 
matice[1, 3] = Convert.ToInt32(Console.ReadLine());
int radku = matice.GetLength(0);
int sloupcu = matice.GetLength(1);
int soucet = 0;

for (int i = 0; i < radku; i++)
{
	for (int j = 0; j < sloupcu; j++)
	{
		Console.Write(matice[i, j] + " ");
		soucet += matice[i, j];
	}
	Console.WriteLine();
}
Console.WriteLine(soucet);
