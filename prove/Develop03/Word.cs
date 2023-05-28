public class Word
{
    private string _word, _show;
    private int _hid;

    public Word()
    {
    }

    public Word(string word)
    {
        _word = word;
        _show = _word;
        _hid = 0;
    }

    public Word(string word, int hid)
    {
        int count;
        _word = word;
        _hid = hid;
        if(_hid == 1)
        {
            _show = "";
            for(count = 0; count < _word.Length; count++ ) _show += "_";
        }
        else _show = _word;
    }

    public void WordSet(string word)
    {
        _word = word;
        _show = _word;
        _hid = 0;
    }
    
    public void Hide()
    {
        int count;
        _show = "";
        for(count = 0; count < _word.Length; count++ ) _show += "_";
        _hid = 1;
    }

    public void Show()
    {
        _show = _word;
        _hid = 0;
    }

    public int IsHidden()
    {
        if(_hid == 1) return 1;
        else return 0;
    }

    public void GetRenderedText()
    {
        Console.Write(_show);
    }
}