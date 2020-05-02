/// <summary>

/// A 'ConcretePrototype' class 

/// </summary>

class ConcretePrototype1 : Prototype

{

    // Constructor

    public ConcretePrototype1(string id)

      : base(id)

    {

    }



    // Returns a shallow copy

    public override Prototype Clone()

    {

        return (Prototype)this.MemberwiseClone();

    }

}
