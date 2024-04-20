namespace EasyFundamental;

#region 225. Implement Stack using Queues
/// <summary>
/// 
/// </summary>
public class MyStack
{
    private Queue<int> queue;
    private int topElement;

    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        queue.Enqueue(x);
        topElement = x;
        int size = queue.Count;
        while (size > 1)
        {
            queue.Enqueue(queue.Dequeue());
            size--;
        }
    }

    public int Pop()
    {
        int popped = queue.Dequeue();
        if (queue.Count > 0)
        {
            topElement = queue.Peek();
        }
        return popped;
    }

    public int Top()
        => topElement;

    public bool Empty()
        => queue.Count == 0;
}
#endregion