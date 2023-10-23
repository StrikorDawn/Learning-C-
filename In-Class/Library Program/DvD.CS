public class DvD : Loanable
{
        private string _title;

    public DvD(string title)
    {
        _title = title;
    }

    public override void Display()
    {
        Console.WriteLine($"Title: {_title}");
        base.Display();
    }
}