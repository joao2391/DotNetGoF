/// <summary>

/// The 'Singleton' class

/// </summary>

class Singleton

{

    private static Singleton _instance;



    // Constructor is 'protected'

    protected Singleton()

    {

    }



    public static Singleton Instance()

    {

        // Uses lazy initialization.

        // Note: this is not thread safe.

        if (_instance == null)

        {

            _instance = new Singleton();

        }



        return _instance;

    }

}