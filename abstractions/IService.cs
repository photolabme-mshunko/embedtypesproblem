namespace Abstractions
{
    public interface IService<T> where T:Enum
    {
        T Value { get; set; }
        void Test();
    }
}