using static System.Console;


int n = Convert.ToInt32(ReadLine());
int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] row = ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        if (!int.TryParse(row[j], out _))
        {
            WriteLine($"Invalid number entered. Input: {row[j]}");
            break;
        }
            
        matrix[i, j] = int.Parse(row[j]);
    }
}

WriteLine(DiagonalDifference(matrix, n));

static int DiagonalDifference(int[,] arr, int n)
{
    int sum1 = 0;
    int sum2 = 0;

    for (int i = 0; i < n; i++)
    {
        sum1 += arr[i, i];
        sum2 += arr[i, n - i - 1];
    }
    return Math.Abs(sum1 - sum2);
}