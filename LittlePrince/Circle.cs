public struct Circle
{
    public Dot Center {get; set;}
    public double Radius {get; set;}

    public Circle() : this(new Dot(), 0.0) { }

    public Circle(Dot center, double radius)
        => (Center, Radius) = (center, radius);

    public readonly bool IsInCircle(Dot dot) => Center.DistanceTo(dot) < Radius;

}