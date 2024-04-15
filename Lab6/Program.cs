public abstract class Transport
{
    public abstract string Speed { get; }//скорость
    public abstract string CarryingCapacity { get; }//грузоподЪёмность
    public abstract string DistanceRange { get; }// Дальность Расстояния 

    public abstract string GetSpeed();//получить Скор
    public abstract string GetCarryingCapacity();//Получить Грузоп
    public abstract string GetDistanceRange();//Дальность Растоян
}


public abstract class Car : Transport
{
    public override string Speed { get { return "1000 км/ч"; } }
    public override string CarryingCapacity { get { return "1 тонна"; } }
    public override string DistanceRange { get { return "500 km"; } }

    public override string GetSpeed()
    {
        return $"Автомобиль имеет скорость {Speed}";
    }

    public override string GetCarryingCapacity()
    {
        return $"Автомобиль с грузоподъемностью  {CarryingCapacity}";
    }

    public override string GetDistanceRange()
    {
        return $"Автомобиль может проехать  {DistanceRange}";
    }
}


public class Kamaz : Car
{
    public string BodyType { get { return "самосвал"; } }

    public string GetInformation()
    {
        return $"Камаз - {BodyType} грузоподъемностью в {CarryingCapacity} может проехать  {DistanceRange}";
    }
}

class Program
{
    static void Main()
    {
        Car a = new Kamaz(); 
        Kamaz kamaz = new Kamaz();
        Console.WriteLine(kamaz.GetInformation());
    }
}

