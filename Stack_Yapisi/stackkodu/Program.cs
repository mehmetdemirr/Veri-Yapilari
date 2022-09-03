namespace stackkodu
{
    class Program
    {
        static void Main()
        {
            StackYapisi stc=new StackYapisi();
            int sonuc = menu();
            try
            {
                while (sonuc != 5)
                {
                    switch (sonuc)
                    {
                        case 1:
                            Console.Write("Eleman Giriniz:");
                            int sayi = int.Parse(Console.ReadLine());
                            stc.push(sayi);
                            break;
                        case 2:
                            stc.pop();
                            Console.WriteLine(stc.topPrint + " eleman çıkarıldı.");
                            break;
                        case 3:
                            stc.print();
                            break;
                        case 4:
                            stc.topPrint();
                            break;
                        default:
                            Console.WriteLine("Geçerli rakamı tuşlayınız!");
                            break;
                    }
                    sonuc = menu();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("hatalandınız!!!!");
            }
        
        }
        public static int  menu()
        {
            Console.WriteLine("1-eleman ekle");
            Console.WriteLine("2-eleman çıkar");
            Console.WriteLine("3-stack yazdir");
            Console.WriteLine("4-top dönder");
            Console.WriteLine("5-çıkış yap");
            Console.Write("Yapacağınız işlemi seçiniz:");
            int sonuc = int.Parse(Console.ReadLine());
            return sonuc;
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
    class StackYapisi
    {
        Node top;
        public StackYapisi()
        {
            top = null;
        }

        public void push(int data)
        {
            Node eleman = new Node(data);
            if(top == null)
            {
                top=eleman;
                Console.WriteLine("stack oluştu ilk elemn yerleşti");
            }
            else
            {
                eleman.next = top;
                top = eleman;
                Console.WriteLine("eleman eklendi");
            }
        }

        public void pop()
        {
            if(top == null) 
            {
                Console.WriteLine("stack boş");
            }
            else
            {
                int sayi =top.data;
                top=top.next;
                Console.WriteLine(sayi+" stackten çıkarıldı");
            }
        }
        public void print()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Boştur");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write(temp.data+"||");
                    temp=temp.next;
                }
            }
        }
        public void topPrint()
        {
            if( top == null)
            {
                Console.WriteLine("Hiç eleman yok!");
            }
            else
            {
                Console.WriteLine(top.data);
            }
        }
    }
}