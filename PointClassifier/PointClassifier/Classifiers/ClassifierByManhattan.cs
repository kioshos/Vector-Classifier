using PointClassifier.Model;

namespace PointClassifier.Classifiers;

public class ClassifierByManhattan
{
    private List<double> _distanceByManhattan;
    private ClassifierHandler _classifierHandler;
    public ClassifierByManhattan(ThreeDimensionalVector vector)
    {
        _classifierHandler = new ClassifierHandler(VectorHandler.GetVectors());
        _distanceByManhattan = _classifierHandler.GetDistanceByEuclidianMetric(vector);
    }
    
    private List<double> InvertedValues()
    {
        List<double> invertedValues = new List<double>();
        
        foreach (var values in _distanceByManhattan)
        {
            invertedValues.Add(1/values);
        }
        return invertedValues;
    }

    private double SumOfInvertedValues()
    {
        double sum = 0;
        foreach (var value in InvertedValues())
        {
            sum += value;
        }
        return sum;
    }

    private List<double> ProbabilityOfClusterProximity()
    {
        List<double> probability = new List<double>();
        foreach (var value in InvertedValues())
        {
            probability.Add(value / SumOfInvertedValues());
        }
        return probability;
    }

    public double SumOfProbability()
    {
        double sum = 0;
        foreach (var value in ProbabilityOfClusterProximity())
        {
            sum += value;
        }
        return sum;
    }
    public void DisplayProbabilityOfCluster()
    {
        int clusterCount = 1;
        foreach (var probability in ProbabilityOfClusterProximity())
        {
            Console.WriteLine($"For cluster: {clusterCount}. Probability: {probability}");
            clusterCount++;
        }
    }
}