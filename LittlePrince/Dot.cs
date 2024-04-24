public struct Dot
{
    public int X { get; set; }
    public int Y { get; set; }

    public Dot(int x, int y)
        => (X, Y) = (x, y);
    public readonly double DistanceTo(Dot dot)
    {
        int xDiff = X - dot.X;
        int yDiff = Y - dot.Y;

        return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
    }
}