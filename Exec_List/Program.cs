internal class Program
{
    private static void Main(string[] args)
    {
        //宣告一個List<product>變數，存放多筆購買產品
        List<product> products = new List<product>();
        products.Add(new product() { productName = "apple" });
        products.Add(new product() { productName = "banana" });
        products.Add(new product() { productName = "orange" });

    }
}
class product
{
    public string? productName { get; set; }
}