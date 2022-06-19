namespace QuadraticEquationByDelegate
{
    public delegate string RootEquation(int a, int b, int c);
    internal class Root
    {
        public string GetRoot(int a, int b, int c)
        {
            double Diskriminant = Math.Pow(b, 2) - (4 * a * c);
            if (Diskriminant > 0)
            {
                double X1 = (-b - Math.Sqrt(Diskriminant)) / (2 * a);
                double X2 = (-b + Math.Sqrt(Diskriminant)) / (2 * a);
                return "Уравнение имеет два корня: X1 = " + Math.Round(X1, 2) + " и X2 = " + Math.Round(X2, 2);
            }
            else if (Diskriminant == 0)
            {
                double X = (-b ) / (2 * a);
                return "Уравнение имеет один корень X = " + X ;
            }
            else
                return "Уравнение не имеет корней";
        }
    }
}
