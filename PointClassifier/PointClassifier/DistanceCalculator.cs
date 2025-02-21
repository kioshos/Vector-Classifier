using PointClassifier.Model;

namespace PointClassifier;

public static class DistanceCalculator
{

    public static double CalculateEuclidianDistance(ThreeDimensionalVector vector1, ThreeDimensionalVector vector2)
    {
        double distance = Math.Sqrt(
            Math.Pow(vector1.X - vector2.X, 2) +
            Math.Pow(vector1.Y - vector2.Y, 2) +
            Math.Pow(vector1.Z - vector2.Z, 2)
        );
        return distance;
    }

    public static double CalculateEuclidianMetricDistance(ThreeDimensionalVector vector1,
        ThreeDimensionalVector vector2)
    {
        double distance =
            Math.Pow(vector1.X - vector2.X, 2) +
            Math.Pow(vector1.Y - vector2.Y, 2) +
            Math.Pow(vector1.Z - vector2.Z, 2);
        
        return distance;
    }

    public static double CalculateManhattanDistance(ThreeDimensionalVector vector1, ThreeDimensionalVector vector2)
    {
        double distance =
            Math.Abs(vector1.X - vector2.X) +
            Math.Abs(vector1.Y - vector2.Y) +
            Math.Abs(vector1.Z - vector2.Z);
        
        return distance;
    }
}