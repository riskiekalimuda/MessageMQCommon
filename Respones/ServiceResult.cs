using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.Respones
{
    public class ServiceResult
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;    
        public string ErrorCode { get; set; }   = string.Empty;

        public ServiceResult(bool isSuccess, string errorMessage = "", string errorCode = "")
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
        }

        public static ServiceResult Success() => new ServiceResult(true);
        public static ServiceResult Failure(string errorMessage, string errorCode = "") => new ServiceResult(false, errorMessage, errorCode);   
    }
}
