/// <summary>

/// The 'ConcreteDecoratorB' class

/// </summary>

class ConcreteDecoratorB : Decorator

{

    public override void Operation()

    {

        base.Operation();

        AddedBehavior();

        Console.WriteLine("ConcreteDecoratorB.Operation()");

    }



    void AddedBehavior()

    {

    }

}