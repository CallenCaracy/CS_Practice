public class ArrayList
{
    public string[] name;
    public int count;

    public ArrayList(int capacity)
    {
        name = new string[capacity];
        count = 0;
    }

    public int GetCount => count; 
}