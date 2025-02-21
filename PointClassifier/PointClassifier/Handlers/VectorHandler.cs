using PointClassifier.Model;

namespace PointClassifier;

public static class VectorHandler
{
    private static List<ThreeDimensionalVector> _vectors;
    static VectorHandler()
    {
        _vectors = new List<ThreeDimensionalVector>();
    }

    public static void AddVectorToList(ThreeDimensionalVector vector)
    {
        _vectors.Add(vector);
    }

    public static void DisplayVectors()
    {
        _vectors.ForEach(vector => Console.WriteLine(vector));
    }

    public static List<ThreeDimensionalVector> GetVectors()
    {
        return _vectors;
    }
}