using PointClassifier.Model;

namespace PointClassifier;

public class VectorHandler
{
    private ThreeDimensionalVector _vector;
    private List<ThreeDimensionalVector> _vectors;

    public VectorHandler()
    {
        _vectors = new List<ThreeDimensionalVector>();
    }

    public void AddVectorToList(ThreeDimensionalVector vector)
    {
        _vectors.Add(vector);
    }

    public void DisplayVectors()
    {
        _vectors.ForEach(vector => Console.WriteLine(vector));
    }

    public List<ThreeDimensionalVector> GetVectors()
    {
        return _vectors;
    }
}