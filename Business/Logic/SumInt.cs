using Business.Exceptions;
using Business.Interfaces;

namespace Business.Logic
{
    /// <summary>
    /// The sum int class.
    /// </summary>
    public class SumInt : IOperation<int, int>
    {
        // In case of adding new operations it shows the type of operation
        public string GetOperatorType { get => "+"; }

        /// <summary>
        /// The Addition operation for int
        /// </summary>
        /// <param name="parameter1">Int32</param>
        /// <param name="parameter2">Int32</param>
        /// <returns></returns>
        public int Operate(in int parameter1, in int parameter2)
        {
            int result = 0;
            try
            {
                result = parameter1 + parameter2;
            }
            catch (System.Exception)
            {
                throw new OperationException(
                    string.Format("Sum operation has been failed for {0} and {1}."
                    , parameter1
                    , parameter2)
                    );
            }


            return result;
        }
    }
}
