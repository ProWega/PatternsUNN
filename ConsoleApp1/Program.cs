// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
SimpleVector v1 = new SimpleVector(4, new List<double> { 1.0, 2.0, 3.0, 4.0 });
SimpleVector v2 = new SimpleVector(4, new List<double> { 5.0, 6.0, 7.0, 8.0 });

SimpleMatrix m = new SimpleMatrix(2, 4);
m.Write(new List<IVector> { v1, v2 });
m.Read();

// Инициализация плотной матрицы
SimpleMatrix simpleMatrix = new SimpleMatrix(3, 4);
MatrixInitializer.InitializeSimpleMatrix(simpleMatrix);
simpleMatrix.Read();
MatrixStatistics simpleStats = new MatrixStatistics(simpleMatrix);
Console.WriteLine("Плотная матрица:");
Console.WriteLine($"Сумма всех значений: {simpleStats.Sum}");
Console.WriteLine($"Среднее значение: {simpleStats.Average}");
Console.WriteLine($"Максимальное значение: {simpleStats.MaxValue}");
Console.WriteLine($"Число ненулевых значений: {simpleStats.NonZeroCount}");

SparseMatrix sparseMatrix = new SparseMatrix(3, 4);
MatrixInitializer.InitializeSparseMatrix(sparseMatrix);
sparseMatrix.Read();
MatrixStatistics sparseStats = new MatrixStatistics(sparseMatrix);
Console.WriteLine("Разреженная матрица:");
Console.WriteLine($"Сумма всех значений: {sparseStats.Sum}");
Console.WriteLine($"Среднее значение: {sparseStats.Average}");
Console.WriteLine($"Максимальное значение: {sparseStats.MaxValue}");
Console.WriteLine($"Число ненулевых значений: {sparseStats.NonZeroCount}");

public class MatrixInitializer
{
    private static Random _random = new Random();

    internal static void InitializeSimpleMatrix(SimpleMatrix matrix)
    {
        foreach (var vector in matrix.Elements)
        {
            for (int i = 0; i < matrix.Columns_count; i++)
            {
                vector.SetElement(i, _random.NextDouble() * 10);
            }
        }
    }

    internal static void InitializeSparseMatrix(SparseMatrix matrix, double sparsity = 0.8)
    {
        foreach (var vector in matrix.Elements)
        {
            for (int i = 0; i < matrix.Columns_count; i++)
            {
                if (_random.NextDouble() > sparsity)
                {
                    vector.SetElement(i, _random.NextDouble() * 10);
                }
            }
        }
    }
}