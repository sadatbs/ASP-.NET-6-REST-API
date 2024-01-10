namespace Averages;

public static class AverageCalculator {
    public static double ArithmeticMean(string[] args) {
        if(args.Length <= 0) {
            return -1.0;
        }
        return args.Select( numText => double.Parse(numText)).Average();
    }
}