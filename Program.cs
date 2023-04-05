using System;
using System.IO;

class AER0FL0T
{
    public string Destination { get; set; }
    public int FlightNumber { get; set; }
    public string AircraftType { get; set; }

    public AER0FL0T()
    {
        Destination = "";
        FlightNumber = 0;
        AircraftType = "";
    }

    public AER0FL0T(string destination, int flightNumber, string aircraftType)
    {
        Destination = destination;
        FlightNumber = flightNumber;
        AircraftType = aircraftType;
    }

    public void Input()
    {
        Console.Write("Введите пункт назначения: ");
        Destination = Console.ReadLine();

        Console.Write("Введите номер рейса: ");
        FlightNumber = int.Parse(Console.ReadLine());

        Console.Write("Введите тип воздушного судна: ");
        AircraftType = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine("Назначение: {0}", Destination);
        Console.WriteLine("Номер рейса: {0}", FlightNumber);
        Console.WriteLine("Тип воздушного судна: {0}", AircraftType);
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Назначение: {0}", Destination);
            writer.WriteLine("Номер рейса: {0}", FlightNumber);
            writer.WriteLine("Тип воздушного судна: {0}", AircraftType);
        }
    }

    public static void Main()
    {
        AER0FL0T a1 = new AER0FL0T();
        a1.Input();
        a1.Display();
        a1.SaveToFile("рейс.txt");

        AER0FL0T a2 = new AER0FL0T("New York", 123, "Boeing 747");
        a2.Display();
    }
}