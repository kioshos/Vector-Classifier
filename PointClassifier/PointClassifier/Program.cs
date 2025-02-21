using PointClassifier;
using PointClassifier.Classifiers;
using PointClassifier.Model;

class Program
{
    public static void Main(string[] args)
    {
        ThreeDimensionalVector vector = new ThreeDimensionalVector(2,3,4);
        ThreeDimensionalVector vector1 = new ThreeDimensionalVector(6,7,8);
        
        ThreeDimensionalVector vector2 = new ThreeDimensionalVector(3,2,2);
        
        Console.WriteLine(vector.ToString());
        Console.WriteLine(vector1.ToString());
        Console.WriteLine("/////");
        
        VectorHandler.DisplayVectors();
        VectorHandler.AddVectorToList(vector);
        VectorHandler.AddVectorToList(vector1);
        VectorHandler.DisplayVectors();

        Console.WriteLine("/////");
        
        Console.WriteLine("/////");
        Console.WriteLine("Distance calculation");
        Console.WriteLine(DistanceCalculator.CalculateEuclidianDistance(vector,vector1));
        Console.WriteLine("/////");;
        VectorHandler.GetVectors();

        ClassifyByEuclidian classifyByEuclidian = new ClassifyByEuclidian(vector2);
        classifyByEuclidian.DisplayProbabilityOfCluster();


    }
}