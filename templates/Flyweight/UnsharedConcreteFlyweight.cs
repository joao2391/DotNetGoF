/// <summary>

/// The 'UnsharedConcreteFlyweight' class

/// </summary>

class UnsharedConcreteFlyweight : Flyweight

{

    public override void Operation(int extrinsicstate)

    {

        Console.WriteLine("UnsharedConcreteFlyweight: " +

          extrinsicstate);

    }

}