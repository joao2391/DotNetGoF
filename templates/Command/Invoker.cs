/// <summary>

/// The 'Invoker' class

/// </summary>

class Invoker

{

    private Command _command;



    public void SetCommand(Command command)

    {

        this._command = command;

    }



    public void ExecuteCommand()

    {

        _command.Execute();

    }

}