using PointClassifier;
using PointClassifier.Classifiers;
using PointClassifier.Model;

class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        for (int i = 0; i < 10000; i++)
        {
            int x = rand.Next(1, 1000000); 
            int y = rand.Next(1, 1000000); 
            int z = rand.Next(1, 1000000);
            ThreeDimensionalVector vector = new ThreeDimensionalVector(x, y, z);
            
            VectorHandler.AddVectorToList(vector);
        }
        
        ThreeDimensionalVector vector2 = new ThreeDimensionalVector(5,6,6);
        
        Console.WriteLine("/////");

        VectorHandler.DisplayVectors();

        Console.WriteLine("/////");
        
        Console.WriteLine("/////");
        Console.WriteLine("Distance calculation");
        //Console.WriteLine(DistanceCalculator.CalculateEuclidianDistance(vector,vector1));
        Console.WriteLine("/////");;
        VectorHandler.GetVectors();

        ClassifyByEuclidian classifyByEuclidian = new ClassifyByEuclidian(vector2);
        classifyByEuclidian.DisplayProbabilityOfCluster();
        Console.WriteLine(classifyByEuclidian.SumOfProbability());


    }
}