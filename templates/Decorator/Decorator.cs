/// <summary>

/// The 'Decorator' abstract class

/// </summary>

abstract class Decorator : Component

{

    protected Component component;



    public void SetComponent(Component component)

    {

        this.component = component;

    }



    public override void Operation()

    {

        if (component != null)

        {

            component.Operation();

        }

    }

}
