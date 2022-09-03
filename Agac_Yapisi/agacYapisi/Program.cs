namespace kod
{
    class Program
    {
        static void Main()
        {
            Tree bst=new Tree();
            bst.root = bst.insert(bst.root, 52);
            bst.root = bst.insert(bst.root, 37);
            bst.root = bst.insert(bst.root, 70);
            bst.root = bst.insert(bst.root, 33);
            bst.root = bst.insert(bst.root, 28);
            bst.root = bst.insert(bst.root, 34);
            bst.root = bst.insert(bst.root, 29);
            bst.root = bst.insert(bst.root, 65);
            bst.root = bst.insert(bst.root, 83);
            bst.root = bst.insert(bst.root, 61);
            bst.root = bst.insert(bst.root, 82);
            bst.root = bst.insert(bst.root, 89);


            Console.WriteLine("in");
            bst.inOrder(bst.root);
            Console.WriteLine("\n");
            Console.WriteLine("pre");
            bst.preOrder(bst.root);
            Console.WriteLine( "\n");
            Console.WriteLine("post");
            bst.postOrder(bst.root);
           

         }
    }

    class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
            right = null;
            left = null;
        }
    }

    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        
        public Node NewNode(int data)
        {
            root=new Node(data);
            return root;
        }

        public Node insert(Node root,int data)
        {
            Node eleman = new Node(data);
            if(root != null)
            {
                if (root.data < data)
                {
                    root.right=insert(root.right, data);
                }
                else
                {
                    root.left=insert(root.left, data);
                }
            }
            else
            {
                root = eleman;
            }
            return root;
        }

        public void preOrder(Node root) //  root-sol düğüm-sağ düğüm
        {
            if(root != null)
            {
               // Console.Write("\n pre order sıralama:");
                Console.Write(root.data+" ");
                preOrder(root.left);
                preOrder(root.right);
            }    
        }

        public void inOrder(Node root)   // sol düğüm-root-sağ düğüm
        {
            if (root != null)
            {
                //Console.Write("\n in order sıralama:");
                inOrder(root.left);
                Console.Write(root.data + " ");
                inOrder(root.right);
            }
        }

        public void postOrder(Node root)   // sol düğüm-sağ düğüm-root
        {
            if (root != null)
            {
               // Console.Write("\n post order sıralama:");
                postOrder(root.left);
                postOrder(root.right);
                Console.Write(root.data + " ");
            }
        }

    }


}