using PointClassifier.Model;

namespace PointClassifier.Classifiers;
// TODO-02212025 перейменувати методи і вдосконалити код (почистити)
public class ClassifyByEuclidian
{
    private List<double> _distancesByEuclidian;
    private ClassifierHandler _classifierHandler;
    public ClassifyByEuclidian(ThreeDimensionalVector vector)
    {
        _classifierHandler = new ClassifierHandler(VectorHandler.GetVectors());
        _distancesByEuclidian = _classifierHandler.GetDistanceByEuclidian(vector);
    }

    private List<double> InvertedValues()
    {
        List<double> invertedValues = new List<double>();
        
        foreach (var values in _distancesByEuclidian)
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