/// <summary>
/// A 'ConcretePrototype' class 
/// </summary>
class ConcretePrototype2 : Prototype
{
    // Constructor
    public ConcretePrototype2(string id)
      : base(id){}

    // Returns a shallow copy
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }

}
