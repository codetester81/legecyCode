public class BinarySearchTree<T> where T : IComparable<T>
{
    private Node<T> root;

    public void Insert(T value)
    {
        if (root == null)
        {
            root = new Node<T>(value);
            return;
        }

        Insert(root, value);
    }

    private void Insert(Node<T> node, T value)
    {
        if (value.CompareTo(node.Value) < 0)
        {
            if (node.Left == null)
            {
                node.Left = new Node<T>(value);
                return;
            }

            Insert(node.Left, value);
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new Node<T>(value);
                return;
            }

            Insert(node.Right, value);
        }
    }

    public bool Search(T value)
    {
        if (root == null)
        {
            return false;
        }

        return Search(root, value);
    }

    private bool Search(Node<T> node, T value)
    {
        if (value.CompareTo(node.Value) == 0)
        {
            return true;
        }
        else if (value.CompareTo(node.Value) < 0)
        {
            if (node.Left == null)
            {
                return false;
            }

            return Search(node.Left, value);
        }
        else
        {
            if (node.Right == null)
            {
                return false;
            }

            return Search(node.Right, value);
        }
    }

    public void Delete(T value)
    {
        if (root == null)
        {
            return;
        }

        Delete(root, value);
    }

    private void Delete(Node<T> node, T value)
    {
        if (value.CompareTo(node.Value) == 0)
        {
            if (node.Left == null && node.Right == null)
            {
                node = null;
            }
            else
 
if (node.Left == null)
            {
                node = node.Right;
            }
            else
 
if (node.Right == null)
            {
                node = node.Left;
            }
            else
            {
                Node<T> minNode = MinNode(node.Right);
                node.Value = minNode.Value;
                Delete(node.Right, minNode.Value);
            }
        }
        else if (value.CompareTo(node.Value) < 0)
        {
            if (node.Left == null)
            {
                return;
            }

            Delete(node.Left, value);
        }
        else
        {
            if (node.Right == null)
            {
                return;
            }

            Delete(node.Right, value);
        }
    }

    private Node<T> MinNode(Node<T> node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }

        return node;
    }

    public
 
void
 
InOrderTraversal()
    {
        InOrderTraversal(root);
    }

    private
 
void
 
InOrderTraversal(Node<T> node)
    {
        if (node == null)
        {
            return;
        }

        InOrderTraversal(node.Left);
        Console.WriteLine(node.Value);
        InOrderTraversal(node.Right);
    }

    private class
 
Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public
 
Node(T value)
        {
            Value = value;
        }
    }
}