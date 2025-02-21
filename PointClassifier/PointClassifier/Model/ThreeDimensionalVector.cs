namespace PointClassifier.Model;

public struct ThreeDimensionalVector
{
    private static int _vectorsNumber;
    private string _name;
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public ThreeDimensionalVector(double x, double y, double z)
    {
        _vectorsNumber++;
        _name = $"Vector {_vectorsNumber}";
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return $"Vector: {_name}, X: {X}, Y: {Y}, Z: {Z}";
    }
}