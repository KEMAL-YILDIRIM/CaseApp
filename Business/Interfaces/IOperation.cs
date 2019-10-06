namespace Business.Interfaces
{
    /// <summary>
    /// The IOperation interface
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TParam"></typeparam>
    public interface IOperation<TResult, TParam>
        where TResult : struct
        where TParam : struct
    {
        string GetOperatorType { get; }

        /// <summary>
        /// Operate given types of parameters with given operation type
        /// </summary>
        /// <param name="parameter1">TParam</param>
        /// <param name="parameter2">TParam</param>
        /// <returns>TResult</returns>
        TResult Operate(in TParam parameter1, in TParam parameter2);
    }
}