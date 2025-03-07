using TrainWith.Interfaces;

namespace TrainWith.Entity; 
public class Result<T>
{
    // Property
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }

    // Constructor 
    public Result(bool isSuccess, string message, T data)
    {
        IsSuccess = isSuccess;
        Message = message;
        Data = data;
    }

    // Methods
    public static Result<T> SuccessResult(T Data, string message = "عملیات موفقیت‌آمیز بود.")
    {
        return new Result<T>(isSuccess: true, message: message, data: Data);
    }

    public static Result<T> FailureResult(T data, string message = "عملیات موفقیت‌آمیز نبود.")
    {
        return new Result<T>(isSuccess: false, message: message, data: data);
    }
}
