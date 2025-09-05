// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        string? test;

        Testing t = new("I love you");
        test = t.Greetings;
        Console.WriteLine(test);
        t.SetGreetings("2WOWOWOW2");
        Console.WriteLine(t.Greetings);

        try
        {
            Console.WriteLine(t.Greetings != null && t.IsPalindrome(t.Greetings));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error {ex.Message}");
        }

        LinkedList head = new();

        head.Insert("Sep Bayot");
        head.Insert("Clarence");
        head.Insert("Mark John");
        head.Insert("Ivan Kanban");
        head.Display();
        head.Reverse();
        head.Display();
        head.Check();


        // BST Root = new BST();

            // Root.Insert("I love you");
            // Root.Insert("I love you not");
            // Root.Insert("I love you please");
            // Root.Insert("I love you beggin");
            // Root.InOrder();
    }
}



public class Testing
{
    public string? Greetings { get; private set; }

    public Testing(string Greetings)
    {
        this.Greetings = Greetings;
    }

    public override string ToString() => $"{Greetings}";

    public void SetGreetings(string newGreetings)
    {
        Greetings = newGreetings;
    }

    public bool IsPalindrome(string word)
    {
        if (word == null) return false;

        for (int i = 0, j = word.Length - 1; i < j; i++, j--)
        {
            if (word[i] != word[j]) return false;
        }
        return true;
    }
}
