namespace algoDat_impl_library.Benchmark;

public class RandomIntArrayGenerator : IArrayGenerator<int>
{
    private int _min = 0;
    private int _max = 0;
    private int _numberOfElements = 0;
    
    public RandomIntArrayGenerator(int min, int max, int numberOfElements)
    {
        (_min, _max, _numberOfElements) = (min, max + 1, numberOfElements);
    }

    public int[] Generate()
    {
        var generated = new int[_numberOfElements];
        var getRandomNumberFrom = new Random();

        for (int newElementI = 0; newElementI < generated.Length; newElementI++)
        {
            generated[newElementI] = getRandomNumberFrom.Next(_min, _max);
        }

        return generated;
    }
}