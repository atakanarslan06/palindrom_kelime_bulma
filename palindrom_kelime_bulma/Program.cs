internal class Program
{
    private static void Main(string[] args)
    {

        StackYapisi st = new StackYapisi();
        QueueYapisi qu = new QueueYapisi();

        String kelime;
        Console.WriteLine("POLİNDROM KELİME BULMA UYGULAMASI \n");
        Console.Write("kelime girin : ");
        kelime = Console.ReadLine();

        for (int i = 0; i < kelime.Length; i++)
        {
            st.push(kelime[i]);
            qu.enQueue(kelime[i]);

        }

        bool sonuc = true;
        while ( ! qu.isEmpty())
        {
            if (qu.deQueue () == st.pop())
            {
                sonuc = false;
                break;
            }
        }
        if (sonuc)
        {
            Console.WriteLine(kelime + "Palindromdur");
        }
        else
        {
            Console.WriteLine(kelime + "Palindrom değildir");
            Console.ReadKey();
        }
        

    }
}

 public class Node
{
    public Node next;
    public char data;
    public Node(char data)
    {
        this.data = data;
        next = null;
    }
}

   public class StackYapisi
    {
        public Node top;
        public StackYapisi()
        {
            top = null;
        }

        bool isEmpty()
        {
            return top == null;
        }

        public void push (char data)
        {
            Node eleman = new Node(data);
            if (isEmpty())
            {
                top = eleman;

            }
            else
            {
                eleman.next = top;
                top = eleman;
            }
        }
        public char pop()
        {
            char ch;
            if (isEmpty())
            {
                ch = 's';
            }
            else
            {
                ch = top.data;
                top = top.next;
            }
              return ch;  
        }
    } 
    class QueueYapisi
    {
        public Node front, rear;

        public QueueYapisi()
        {
            this.front = null;
            this.rear = null;
        }
        public bool isEmpty()
        {
            return front == null;
        }

        public void enQueue(char data)
        {
            Node eleman = new Node(data);

            if (isEmpty())
            {
                front = rear = eleman;
            }
            else
            {
                rear.next = eleman;
                rear = eleman;
            }
        }
        public char deQueue ()
        {
            char ch;
            if (isEmpty())
            {
                ch = 'q';
            }
            else
            {
                ch = front.data;
                front = front.next;
            }
            return ch;
        }
    }