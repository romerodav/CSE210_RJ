public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private int _hidden;

    public Scripture()
    {
        _words = new List<Word>();
    }

    public Scripture(Reference reference, List<Word> words)
    {
        _words = new List<Word>();
        _reference = reference;
        _words = words;
        _hidden = 0;
    }

    public Scripture(Reference reference, string words)
    {
        _words = new List<Word>();
        _reference = reference;
        string[] each = words.Split(" ");
        for(_hidden = 0; _hidden < each.Length; _hidden++)
        {
            Word word = new Word(each[_hidden]);
            _words.Add(word);
        }
        _hidden = 0;
    }

    public int WordsCount()
    {
        return _words.Count;
    }

    public int WordsShow()
    {
        int aux, count = 0;
        for(aux = 0; aux < _words.Count; aux++) if(_words[aux].IsHidden() == 0) count++;
        return count;
    }

    public void HideWords()
    {
        int rand, count = 0, top = 3;
        Random randomGenerator = new Random();
        do
        {
            rand = randomGenerator.Next(_words.Count);
            if(_words[rand].IsHidden() == 0)
            {
                _words[rand].Hide();
                count++;
            }
            _hidden = 1;
            foreach(Word word in _words)
            {
                if(word.IsHidden() == 0) _hidden = 0;
            }
        }while(count < top & _hidden == 0);
    }

    public void GetRenderedText()
    {
        int count;
        _reference.GetRenderedText();
        for(count = 0; count < _words.Count; count++)
        {
            Console.Write(" ");
            _words[count].GetRenderedText();
        }
    }

    public int IsCompletelyHidden()
    {
        _hidden = 1;
        foreach(Word word in _words)
        {
            if(word.IsHidden() == 0) _hidden = 0;
        }
        return _hidden;
    }   
}