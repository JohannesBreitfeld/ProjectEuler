var path = Path.Combine("..", "..", "..", "0067_triangle.txt");

var input = File.ReadAllLines(path);

var triangle = new List<List<int>>();

foreach (var line in input)
{
    var row = line.Split(" ").Select(n => int.Parse(n)).ToList();
    triangle.Add(row);
}

for (int row = triangle.Count - 2; row >= 0; row--)
{
    for (int col = 0; col <= row; col++)
    {
        triangle[row][col] += Math.Max(triangle[row + 1][col], triangle[row + 1][col + 1]);
    }
}

var result = triangle[0][0];
Console.WriteLine(result);
