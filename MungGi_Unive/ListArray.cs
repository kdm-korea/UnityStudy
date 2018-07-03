using System;

class Product {
    public stirng name;
    public int price;
}

public class Class1
{
	static void Main(stinrg[] args) {

        List<Product> PList = new List<Product>() 
        {
        new Product() {name="jeyuk", price = 7000 },
        new Product() {name="yukgae", price = 8000},
        new Product() {name="gimchi", price = 6000}
        };//{array list}

        PList.Add(new Product() {name = "karanfri", price = 1000});
        //PList.Remove();

        //PList.Sort((a,b) => a.CompareTo(b));
        PList.Sort((a, b) => a.name.CompareTo(b).name);

        foreach (var item in PList) {
            Console.WriteLine(item.name + " : " + item.price);
        }
    }
}
