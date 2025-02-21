using PointClassifier;
using PointClassifier.Model;

class Program
{
    public static void Main(string[] args)
    {
        ThreeDimensionalVector vector = new ThreeDimensionalVector(5,6,7);
        ThreeDimensionalVector vector1 = new ThreeDimensionalVector(7,3,5);
        
        Console.WriteLine(vector.ToString());
        Console.WriteLine(vector1.ToString());
        Console.WriteLine("/////");
        
        VectorHandler handler = new VectorHandler();
        
        handler.AddVectorToList(vector);
        handler.AddVectorToList(vector1);
     
        handler.DisplayVectors();
        
        List<ThreeDimensionalVector> vectors = handler.GetVectors();

        Console.WriteLine("/////");
        
        foreach (ThreeDimensionalVector v in vectors)
        {
            Console.WriteLine(v.ToString());
        }
        
        Console.WriteLine("/////");
        Console.WriteLine("Distance calculation");
        Console.WriteLine(DistanceCalculator.CalculateEuclidianDistance(vector,vector1));
    }
}