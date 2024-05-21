namespace Ecran;

class Ecran
{
    private readonly byte _width;
    private readonly byte _height;
    private readonly string[] _ecran;
    
    public Ecran (byte width, byte height)
    {
        _width = width;
        _height = height;
        _ecran = GetEcran();
    }

    public string this[uint index] => _ecran[index]; 
    private String[] GetEcran() {
        String[] ecran = new String[_height];

        for (int i = 0; i < _height; i++) {
            if (i == 0 || i == _height - 1) {
                ecran[i] = new String('*', _width);
            } else {
                ecran[i] = "*" + new String(' ', _width - 2) + "*";
            }
        }
        return ecran;
    }
}
