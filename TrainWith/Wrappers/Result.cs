using TrainWith.Interfaces;

namespace TrainWith.Wrappers;

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

    //Please Use DRY Pricciple -> Change SuccessResult To Success
    // Methods
    public static Result<T> Success(T Data, string message = "عملیات موفقیت‌آمیز بود.")
    {
        //Create an object and pass data to constructor

        // NameParametr : Your value
        return new Result<T>(isSuccess: true, message: message, data: Data);
    }

    public static Result<T> Failure(string message = "عملیات موفقیت‌آمیز نبود.")
    {
        return new Result<T>(isSuccess: false, message: message, data: default);
    }
}
