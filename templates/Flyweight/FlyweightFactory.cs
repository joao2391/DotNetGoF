/// <summary>

/// The 'FlyweightFactory' class

/// </summary>

class FlyweightFactory

{

    private Hashtable flyweights = new Hashtable();



    // Constructor

    public FlyweightFactory()

    {

        flyweights.Add("X", new ConcreteFlyweight());

        flyweights.Add("Y", new ConcreteFlyweight());

        flyweights.Add("Z", new ConcreteFlyweight());

    }



    public Flyweight GetFlyweight(string key)

    {

        return ((Flyweight)flyweights[key]);

    }

}