/// <summary>

/// A 'ConcreteCreator' class

/// </summary>

class ConcreteCreatorB : Creator

{

    public override Product FactoryMethod()

    {

        return new ConcreteProductB();

    }

}