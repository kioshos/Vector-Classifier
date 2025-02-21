using System.Drawing;
using PointClassifier.Model;

namespace PointClassifier;

public class ClassifierHandler
{
    private List<ThreeDimensionalVector> _vectors;
    
    public ClassifierHandler(List<ThreeDimensionalVector> vectors)
    {
        _vectors = vectors;
    }

    public ClassifierHandler()
    {
        
    }

    public List<double> GetDistanceByEuclidian(ThreeDimensionalVector vectorToCalculateDistance)
    {
        List<double> distance = new List<double>();
        
        foreach (ThreeDimensionalVector vector in _vectors)
        {
            distance.Add(DistanceCalculator.CalculateEuclidianDistance(vectorToCalculateDistance, vector));
        }
        return distance;
    }
    
    public List<double> GetDistanceByEuclidianMetric(ThreeDimensionalVector vectorToCalculateDistance)
    {
        List<double> distance = new List<double>();
        
        foreach (ThreeDimensionalVector vector in _vectors)
        {
            distance.Add(DistanceCalculator.CalculateEuclidianMetricDistance(vectorToCalculateDistance, vector));
        }
        return distance;
    }
    public List<double> GetDistanceByManhattanMethod(ThreeDimensionalVector vectorToCalculateDistance)
    {
        List<double> distance = new List<double>();
        
        foreach (ThreeDimensionalVector vector in _vectors)
        {
            distance.Add(DistanceCalculator.CalculateManhattanDistance(vectorToCalculateDistance, vector));
        }
        return distance;
    }
    
}