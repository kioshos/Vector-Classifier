using PointClassifier.Model;

namespace PointClassifier.Classifiers;

public class ClassifierByEuclidianMetric
{
    private List<double> _distanceByEuclidianMetric;
    private ClassifierHandler _classifierHandler;
    public ClassifierByEuclidianMetric(ThreeDimensionalVector vector)
    {
        _classifierHandler = new ClassifierHandler(VectorHandler.GetVectors());
        _distanceByEuclidianMetric = _classifierHandler.GetDistanceByEuclidianMetric(vector);
    }
    
    private List<double> InvertedValues()
    {
        List<double> invertedValues = new List<double>();
        
        foreach (var values in _distanceByEuclidianMetric)
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