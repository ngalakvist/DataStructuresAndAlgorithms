namespace ConsoleApp3
{
  /// <summary>
  /// Ngala Linked List
  /// </summary>
  public class LinkedList
  {
    private Node head;
    public int Count { get; private set; } = 1;

    /// <summary>
    /// Append
    /// </summary>
    /// <param name="data"></param>
    public void Append(int data)
    {
      if (head == null)
      {
        head = new Node(data);
        return;
      }
      Node curr = head;
      while (curr.next != null)
      {
        curr = curr.next;
      }
      curr.next = new Node(data);
      Count++;
    }

    /// <summary>
    /// Prepend
    /// </summary>
    /// <param name="data"></param>
    public void Prepend(int data)
    {
      var newHead = new Node(data);
      newHead.next = head;
      head = newHead;
      Count++;
    }


    /// <summary>
    /// Delete
    /// </summary>
    /// <param name="data"></param>
    public void Remove(int data)
    {  // validate the head
      if (head == null)
        return;
      if (head.Data == data)
      {
        head = head.next;
        return;
      }
      Node curr = head;
      while (curr.next != null)
      {
        if (curr.next.Data == data)
        {
          curr.next = curr.next.next;
          Count--;
          return;
        }
        curr = curr.next;
      }
    }

    /// <summary>
    /// Print
    /// </summary>
    public void Print()
    {
      Node current = head;
      while (current.next != null)
      {
        System.Console.Write($"{current.Data}, ");
        current = current.next;
      }
      System.Console.Write($"{current.Data}, ");
      System.Console.WriteLine($"Total on the list: {Count}");
    }
  }
}
