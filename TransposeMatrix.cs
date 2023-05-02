namespace algorithmic_solutions
{
    internal class TransposeMatrix
    {
        static int[,] matris = new int[5, 5]; // 10x10 bir matris oluşturduk
        static int temp = 0;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.Next(1000); //Matrise rastgele değerler yerleştirdik
                    Console.Write(matris[i, j] + " ");// ana matrisi yazdırıyoruz
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < matris.GetLength(1); j++)
                    if (i >= j)
                        Swap(i, j);
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Transpose matris:");
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine("");
            }

        }
        static void Swap(int i, int j)// Elemanları yer değiştireceğimiz swap metodu
        {
            temp = matris[i, j];
            matris[i, j] = matris[j, i];
            matris[j, i] = temp;
        }
    }
}