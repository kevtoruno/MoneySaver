using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core
{
    public class Result<T>
    {
        public bool IsSucess { get; private set; }
        public T Value { get; private set; }
        public string ErrorMessage { get; private set; } = "";
        public string UrlToRedirectTo { get; private set; } = "";
        public bool ResourceCreated { get; set; }
        public string CreatedMessage { get; private set; } = "";
        public static Result<T> Success(T value) => new Result<T> { IsSucess = true, Value = value };

        public static Result<T> FailureWithResult (string errorMessage, T value) => new Result<T> { IsSucess = false, ErrorMessage = errorMessage, Value = value };

        public static Result<T> Failure(string errorMessage) => new Result<T> { IsSucess = false, ErrorMessage = errorMessage };

        public static Result<T> Created(T value, string createdMessage) => new Result<T> { ResourceCreated = true, Value = value, CreatedMessage = createdMessage };

        public static Result<T> NoAction (T value) => new Result<T> { Value = value , IsSucess = true};

    }
}
