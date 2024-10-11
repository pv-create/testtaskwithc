public sealed class MathService:IMathService
{
    [System.Runtime.InteropServices.DllImport("../../CppLib/build/libproject.dylib")]
    public static extern int fibonacci(int n);
    public int GetFibonachi(int n)
    {
        return fibonacci(n);
    }
}