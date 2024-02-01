using static System.Console;


int n = Convert.ToInt32(ReadLine());
int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] row = ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        int num = 0;

        if (!int.TryParse(row[j], out num))
        {
            WriteLine($"Invalid number entered. Input: {row[j]}");
            break;
        }

        if (!(-100 <= num && num <= 100))
        {
            WriteLine("Number out of range. Number must be within -100 to 100");
            break;
        }
            
            
        matrix[i, j] = num;
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