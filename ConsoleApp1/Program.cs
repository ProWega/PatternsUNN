// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

// Создаем обычную и разреженную матрицы
IMatrix regularMatrix = new RegularMatrix(5, 5);
SparseMatrix sparseMatrix = new SparseMatrix(5, 5, 0.4); // 40% ненулевых элементов

// Заполняем обычную матрицу случайными значениями
MatrixInitializer.FillMatrix(regularMatrix, 100);

// Заполняем разреженную матрицу случайными значениями с учетом разреженности
sparseMatrix.PopulateWithSparsity(100);

// Выводим обычную матрицу
Console.WriteLine("Обычная матрица:");
regularMatrix.PrintMatrix();

// Выводим разреженную матрицу
Console.WriteLine("Разреженная матрица:");
sparseMatrix.PrintMatrix();

// Получаем статистику для обычной матрицы
MatrixStatistics regularStats = new MatrixStatistics(regularMatrix);
Console.WriteLine("Статистика обычной матрицы:");
Console.WriteLine($"Сумма: {regularStats.Sum}");
Console.WriteLine($"Среднее: {regularStats.Average}");
Console.WriteLine($"Максимальное значение: {regularStats.MaxValue}");
Console.WriteLine($"Количество ненулевых элементов: {regularStats.NonZeroCount}");

// Получаем статистику для разреженной матрицы
MatrixStatistics sparseStats = new MatrixStatistics(sparseMatrix);
Console.WriteLine("Статистика разреженной матрицы:");
Console.WriteLine($"Сумма: {sparseStats.Sum}");
Console.WriteLine($"Среднее: {sparseStats.Average}");
Console.WriteLine($"Максимальное значение: {sparseStats.MaxValue}");
Console.WriteLine($"Количество ненулевых элементов: {sparseStats.NonZeroCount}");

public static class MatrixInitializer
{
    private static readonly Random _random = new Random();

    public static void FillMatrix(IMatrix matrix, double maxValue)
    {
        int rows = matrix.Rows;
        int cols = matrix.Columns;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double value = Math.Round(_random.NextDouble() * maxValue, 2);
                matrix.SetValue(i, j, value);
            }
        }
    }
}
