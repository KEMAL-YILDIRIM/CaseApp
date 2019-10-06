using Business.Exceptions;
using Business.Interfaces;

namespace Business.Logic
{
    public class SumInt : IOperation<int, int>
    {
        public string GetOperatorType { get => "+"; }

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
