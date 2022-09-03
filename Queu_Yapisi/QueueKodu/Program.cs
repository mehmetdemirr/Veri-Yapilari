namespace QueueKodu
{
    class Program
    {
        public static void Main()
        {
            QueueYapisi ky=new QueueYapisi();
            ky.enque(33);
            ky.enque(44);
            ky.enque(55);
            ky.enque(66);
            ky.yazdir();
            

        }
    }

    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    class QueueYapisi
    {
        Node rear, front;
        public QueueYapisi()
        {
            this.rear = null;
            this.front = null;
        }

        public void enque(int data)
        {
            Node eleman=new Node(data);
            if (front == null)
            {
                front =rear= eleman;
                Console.WriteLine("ilk eleman eklendi.");
            }
            else
            {
                rear.next = eleman;
                rear = eleman;
                Console.WriteLine("eleman eklendi");
            }
        }
        public void deque()
        {
            if(front == null)
            {
                Console.WriteLine("Queue boştur.");
            }
            else
            {
                int fdata = front.data;
                front =front.next;
                Console.WriteLine(fdata+" Kuyruktan çıkarıldı");
            }
        }

        public void yazdir()
        {
            if (front == null)
            {
                Console.WriteLine("Kuyruk boştur.");
            }
            else
            {
                Node temp = front;
                Console.WriteLine("baş ");
                while (front != null)
                {
                    Console.Write(temp.data+"<-");
                    temp=temp.next;
                }
                Console.WriteLine("son");
            }
        }
    }

}