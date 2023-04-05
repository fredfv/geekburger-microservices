using GeekBurger.Queue;

internal class Program
{
    private static void Main(string[] args)
    {
        var queueManager = new QueueController();

        if (args.Length <= 0 || args[0] == "sender")
        {
            queueManager.SendMessagesAsync().GetAwaiter().GetResult();
            Console.WriteLine("messages were sent");
        }
        else if (args[0] == "receiver")
        {
            queueManager.ReceiveMessagesAsync().GetAwaiter().GetResult();
            Console.WriteLine("messages were received");
        }
        else
            Console.WriteLine("nothing to do");

        Console.ReadLine();
    }
}