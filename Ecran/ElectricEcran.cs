namespace Ecran;

class ElectricEcran(byte width, byte height)
{
    readonly Ecran _ecran = new(width, height);
    readonly Engine _engine = new(height);
    readonly Control _control = new();

    public void ShowEcran() {
       _control.SetOption(Options.Down);

       while (_control.GetOption() == Options.Down)
       {
           _engine.SpinDown();
           
           PrintEcran();
           
           if (_engine.IsMax()) {
               _control.SetOption(Options.Stop);
           }
       }
    }

    public void HideEcran() {
        _control.SetOption(Options.Up);

        while (_control.GetOption() == Options.Up)
        {
            _engine.SpinUp();
           
            PrintEcran();
           
            if (_engine.IsInitial()) {
                _control.SetOption(Options.Stop);
            }
        }
    }

    private void PrintEcran()
    {
        Console.Clear();
        

        uint currentSpin = _engine.GetCurrentSpin();
        
        for(uint i = (height - currentSpin); i < height; i++)
        {
               Console.WriteLine(_ecran[i]);
        }
        
        Thread.Sleep(1000);
    }
}
