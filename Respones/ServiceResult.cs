using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.Respones
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;    
        public string ErrorCode { get; set; }   = string.Empty;
        public T Data { get; set; } = default(T);
        
        public ServiceResult(bool isSuccess, string errorMessage = "", string errorCode = "")
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
        }

        public static ServiceResult<T> Success() => new ServiceResult<T>(true);
        public static ServiceResult<T> Failure(string errorMessage, string errorCode = "") => new ServiceResult<T>(false, errorMessage, errorCode);   
    }
}
