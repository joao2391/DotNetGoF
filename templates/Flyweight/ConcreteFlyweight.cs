/// <summary>

/// The 'ConcreteFlyweight' class

/// </summary>

class ConcreteFlyweight : Flyweight

{

    public override void Operation(int extrinsicstate)

    {

        Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);

    }

}