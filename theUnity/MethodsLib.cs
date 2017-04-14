namespace theUnity
{
    public interface IMethodsLib
    {
        [Logging]
        string Method1(string param);

        [Logging]
        void Method2();
    }

    public class MethodsLib : IMethodsLib
    {
        public string Method1(string param)
        {
            Method2();
            return "I'm done!";
        }

        //TODO: how to apply same logger to this method?
        public void Method2()
        {

        }
    }
}
