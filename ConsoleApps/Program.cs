using System;
using System.Collections.Generic;

interface IMessageReceiver
{
    void ReceiveMessage(string message);
}

class MessageBoard
{
    private List<IMessageReceiver> receivers = new List<IMessageReceiver>();

    public void AddReceiver(IMessageReceiver receiver)
    {
        receivers.Add(receiver);
    }

    public void RemoveReceiver(IMessageReceiver receiver)
    {
        receivers.Remove(receiver);
    }

    public void SendMessage(string message)
    {
        foreach (var receiver in receivers)
        {
            receiver.ReceiveMessage(message);
        }
    }
}

class Subscriber : IMessageReceiver
{
    private string name;

    public Subscriber(string name)
    {
        this.name = name;
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{name} отримав повідомлення: {message}");
    }
}

class Program
{
    static void Main()
    {
        MessageBoard board = new MessageBoard();

        Subscriber subscriber1 = new Subscriber("Підписник 1");
        Subscriber subscriber2 = new Subscriber("Підписник 2");

        board.AddReceiver(subscriber1);
        board.AddReceiver(subscriber2);

        board.SendMessage("Привіт усім!");

        board.RemoveReceiver(subscriber2);

        board.SendMessage("Вітаю нових підписників!");

        Console.ReadLine();
    }
}