namespace EquationSolver
{
    public class ClasseForValues
    {
        public bool Check => string.IsNullOrEmpty(ErrorMessage);
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }
        public int Value5 { get; set; }
        public int Value6 { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public string ErrorMessagex1 { get; internal set; }
    }
}