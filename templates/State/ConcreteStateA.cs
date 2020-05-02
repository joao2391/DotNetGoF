/// <summary>

/// A 'ConcreteState' class

/// </summary>

class ConcreteStateA : State

{

    public override void Handle(Context context)

    {

        context.State = new ConcreteStateB();

    }

}
