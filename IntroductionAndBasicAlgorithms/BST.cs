public class BST
{
    public class Node
    {
        public string Name;
        public Node? Left;
        public Node? Right;

        public Node(string name)
        {
            Name = name;
            Left = Right = null;
        }
    }

    private Node? Root;

    public void Insert(string name)
    {
        Root = InsertRecursive(Root, name);
    }

    private Node InsertRecursive(Node? node, string name)
    {
        if (node == null) return new Node(name);

        if (node.Name.Length >= name.Length)
            node.Left = InsertRecursive(node.Left, name);
        else if (node.Name.Length < name.Length)
            node.Right = InsertRecursive(node.Right, name);

        return node;
    }

    public void InOrder()
    {
        InOrderRecursive(Root);
    }

    private void InOrderRecursive(Node? node)
    {
        if (node == null) return;

        InOrderRecursive(node.Left);
        Console.WriteLine(node.Name + " ");
        InOrderRecursive(node.Right);
    }
}