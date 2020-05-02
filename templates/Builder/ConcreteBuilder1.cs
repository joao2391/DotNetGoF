/// <summary>
/// The 'ConcreteBuilder1' class
/// </summary>
class ConcreteBuilder1 : Builder
{

    private Product _product = new Product();



    public override void BuildPartA()

    {

        _product.Add("PartA");

    }



    public override void BuildPartB()

    {

        _product.Add("PartB");

    }



    public override Product GetResult()

    {

        return _product;

    }

}
