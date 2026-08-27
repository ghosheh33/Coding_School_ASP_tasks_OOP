public class Car
{
    public string make { get; set; }
    public int year { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }
    public string model { get; set; }
    public string Pallet_No {get; set;}
    public string color { get; set; }

    public Car(string make,int year,string type,double price,string model, string Pallet_No,string color)
    {
        this.make = make;
        this.year = year;
        this.Type= type;
        this.Price = price;
        this.model = model;
        this.Pallet_No = Pallet_No;
        this.color = color;
    }

    private static bool isEngineRunning = false;
    public void engine()
    {
        isEngineRunning = !isEngineRunning;
    }

    public String ToString(){
        return "make = "+ make
            + "\nyear = "+ year
            + "\nType = "+ Type
            + "\nPrice = "+Price
            + "\nmodel = "+ model
            + "\nPallet No = "+ Pallet_No
            + "\ncolor = "+ color;
    }

}

public class ElectricCar :Car
{
    public int Battery_size { get; set; }

    public ElectricCar(string make, int year, string type, double price, string model, string palletNo, string color, int Battery_size)
        : base(make, year, type, price, model, palletNo, color)
    {
        Battery_size = Battery_size;
    }
}