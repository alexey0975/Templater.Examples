namespace Examples.Xlsx;

public class UnsupportedHyperlinks
{
    public static void Run()
    {
        Engine.Run("Hyperlinks.xlsx", new Dictionary<string, object>()
        {
            { "Cell", "cell name" },
            { "CellLink", "https://cell-example-url.com" },
            { "Shape", "shape name" },
            { "ShapeLink", "https://shape-example-url.com" },
            { "ImageLink", "https://image-example-url.com" }
        });
    }
}