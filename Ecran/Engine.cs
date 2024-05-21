namespace Ecran;

class Engine(uint spinLimit)
{
    private uint _currentSpin;
    private readonly uint _initialSpin = 0;

    public void SpinUp() {
            _currentSpin--;
    }
    
    public uint GetCurrentSpin() {
        return _currentSpin;
    }

    public void SpinDown() {
            _currentSpin++;
    }

    public bool IsInitial() {
        return _currentSpin == _initialSpin;
    }

    public bool IsMax() {
        return _currentSpin == spinLimit;
    }
}
