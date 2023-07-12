public class Video
{
    private string _title, _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title = "", string author = "", int length = 0)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Init(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public int CommentQuant()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void AddComments(List<Comment> comments)
    {
        _comments.AddRange(comments);
    }

    public void Show()
    {
        Console.WriteLine($"{_title} video by {_author} has {_length} seconds");
        if(_comments.Count > 0)
        {
            Console.WriteLine("Comments:");
            foreach(Comment comment in _comments) comment.Show();
        }
    }
}