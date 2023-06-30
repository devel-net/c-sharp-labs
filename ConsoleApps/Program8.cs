using System;

class TemperatureSensor
{
    private float[] temperatures;

    public TemperatureSensor(int size)
    {
        temperatures = new float[size];
    }

    public float this[int index]
    {
        get
        {
            if (index >= 0 && index < temperatures.Length)
                return temperatures[index];
            else
                throw new IndexOutOfRangeException("Недійсний індекс");
        }
        set
        {
            if (index >= 0 && index < temperatures.Length)
                temperatures[index] = value;
            else
                throw new IndexOutOfRangeException("Недійсний індекс");
        }
    }

    public int Length
    {
        get { return temperatures.Length; }
    }

    public delegate void TemperatureChangedDelegate(float temperature);
    public event TemperatureChangedDelegate TemperatureChanged;

    public void RecordTemperature(float temperature)
    {
        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = temperature;
            TemperatureChanged?.Invoke(temperature);
        }
    }
}

class Display
{
    public void ShowTemperature(float temperature)
    {
        Console.WriteLine($"Поточна температура: {temperature} °C");
    }
}

class Program8
{
    static void Main()
    {
        TemperatureSensor sensor = new TemperatureSensor(5);
        Display display = new Display();

        sensor.TemperatureChanged += display.ShowTemperature;

        sensor.RecordTemperature(25.5f);

        Console.ReadLine();
    }
}