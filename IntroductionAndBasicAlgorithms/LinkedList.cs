public class Node
{
    public string Name;
    public Node? Next;

    public Node(string name)
    {
        Name = name;
        Next = null;
    }
}

public class LinkedList
{
    private Node? head;
    public void Insert(string name)
    {
        Node newNode = new(name);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Reverse()
    {
        Node? prev = null;
        Node? current = head;
        Node? next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        head = prev;
    }

    public void Check()
    {
        Node? temp = head;
        while (temp != null)
        {
            Console.WriteLine(IsPalindrome(temp.Name));
            Console.WriteLine(IsFirstLetterConsonantOrVowel(temp.Name));
            temp = temp.Next;
        }
    }

    public bool IsPalindrome(string name)
    {
        if (name == null) return false;

        for (int i = 0, j = name.Length - 1; i < j; i++, j++)
        {
            if (name[i] != name[j])
                return false;

        }
            return true;
    }

    public string IsFirstLetterConsonantOrVowel(string name)
    {
        string word;

        if (name == null) return word = "Empty";
        if (!Char.IsLetter(name[0])) return word = "Not an Alphabit";

        string temp = name.ToLower();
        word = (temp[0] == 'a' || temp[0] == 'e' || temp[0] == 'i' || temp[0] == 'o' || temp[0] == 'u') ? "Is Vowel" : "Is Consonant";

        return word;
    }

    public void Display()
    {
        Node? current = head;
        while (current != null)
        {
            Console.WriteLine(current.Name);
            current = current.Next;
        }
    }
}