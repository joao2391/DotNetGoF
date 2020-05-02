/// <summary>

/// The 'AbstractClass' abstract class

/// </summary>

abstract class AbstractClass

{

    public abstract void PrimitiveOperation1();

    public abstract void PrimitiveOperation2();



    // The "Template method"

    public void TemplateMethod()

    {

        PrimitiveOperation1();

        PrimitiveOperation2();

        Console.WriteLine("");

    }

}