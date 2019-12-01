namespace StormyCommerce.Core.Models
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        protected Result(bool success, string error)
        {
            Success = success;
            Message = error;
        }

        public static Result Fail(string error)
        {
            return new Result(false, error);
        }

        public static Result Ok()
        {
            return new Result(true, null);
        }

        public static Result<TValue> Ok<TValue>(TValue value)
        {
            return new Result<TValue>(value, true, null);
        }

        public static Result<TValue> Fail<TValue>(string error,TValue errorObject)
        {
            return new Result<TValue>(errorObject, false, error);
        }
    }
}
