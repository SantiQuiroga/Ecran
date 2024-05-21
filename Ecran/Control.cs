namespace Ecran;

class Control {
    private Options _options = Options.Stop;
    
    public Options GetOption() {
        return _options;
    }

    public void SetOption(Options options) {
        _options = options;
    }
}
