namespace Penguin.SystemExtensions.Abstractions.Interfaces
{
    public interface IConvertible<T>
    {
        T Convert();

        void Convert(T fromT);
    }
}