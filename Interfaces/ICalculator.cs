using System.Numerics;

namespace Module10;

internal interface ICalculator<T>
{
    internal void Add(T a, T b);

    internal void Subtract(T a, T b);

    internal void Divide(T a, T b);

    internal void Multiply(T a, T b);

}