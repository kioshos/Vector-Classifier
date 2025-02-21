using PointClassifier;
using PointClassifier.Model;

class Program
{
    public static void Main(string[] args)
    {
        ThreeDimensionalVector vector = new ThreeDimensionalVector(5,6,7);
        ThreeDimensionalVector vector1 = new ThreeDimensionalVector(7,3,5);
        
        ThreeDimensionalVector vector2 = new ThreeDimensionalVector(4,5,6);
        
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

        
    }
}