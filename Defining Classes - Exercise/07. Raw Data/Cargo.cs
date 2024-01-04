

namespace RawData;

public class Cargo
{
    public Cargo(int weigth,string type)
    {
        Weight = weigth;
        Type = type;
    }

    public int Weight { get;set; }
    public string Type { get; set; }
}
