public class Journal
{
    public List<Entrie> _entries;

    public Journal()
    {
        _entries = new List<Entrie>();
    }

    public Journal(Entrie E)
    {
        _entries = new List<Entrie>();
        _entries.Add(E);
    }

    public void AddEntrie(string Q, string A, string DTT)
    {
        Entrie Ent = new Entrie(Q, A, DTT);
	    _entries.Add(Ent);
    }
}