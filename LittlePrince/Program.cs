int testCases = int.Parse(Console.ReadLine());

while(testCases-- > 0)
{
    int crossingCount = 0;

    var coordinatesOfPrinceAndPrincess = Console.ReadLine()
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

    var prince = new Dot(coordinatesOfPrinceAndPrincess[0], coordinatesOfPrinceAndPrincess[1]);
    var princess = new Dot(coordinatesOfPrinceAndPrincess[2], coordinatesOfPrinceAndPrincess[3]);

    int planetCount = int.Parse(Console.ReadLine());

    while(planetCount-- > 0)
    {
        var coordinatesOfPlanet = Console.ReadLine()
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

        var center = new Dot(coordinatesOfPlanet[0], coordinatesOfPlanet[1]);
        var planet = new Circle(center, coordinatesOfPlanet[2]);

        if(planet.IsInCircle(prince) != planet.IsInCircle(princess))
            crossingCount++;

    }

    Console.WriteLine(crossingCount);
}