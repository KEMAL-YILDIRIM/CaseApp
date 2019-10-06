namespace Business.Interfaces
{
    public interface IOperation<TResult, TParam>
        where TResult : struct
        where TParam : struct
    {
        string GetOperatorType { get; }
        TResult Operate(in TParam parameter1, in TParam parameter2);
    }
}