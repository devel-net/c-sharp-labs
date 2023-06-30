using System;

interface IPlayable
{
    void Play();
    void Pause();
    void Stop();
}

class AudioPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Відтворення аудіо");
    }

    public void Pause()
    {
        Console.WriteLine("Пауза аудіо");
    }

    public void Stop()
    {
        Console.WriteLine("Зупинка аудіо");
    }
}

class VideoPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Відтворення відео");
    }

    public void Pause()
    {
        Console.WriteLine("Пауза відео");
    }

    public void Stop()
    {
        Console.WriteLine("Зупинка відео");
    }
}

class Program3
{
    static void Main()
    {
        IPlayable[] players = new IPlayable[2];
        players[0] = new AudioPlayer();
        players[1] = new VideoPlayer();

        foreach (var player in players)
        {
            player.Play();
            player.Pause();
            player.Stop();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}