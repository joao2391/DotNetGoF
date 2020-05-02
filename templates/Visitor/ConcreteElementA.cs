/// <summary>

/// A 'ConcreteElement' class

/// </summary>

class ConcreteElementA : Element

{

    public override void Accept(Visitor visitor)

    {

        visitor.VisitConcreteElementA(this);

    }



    public void OperationA()

    {

    }

}
