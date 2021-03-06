﻿namespace BlogEngine.ClientServices.Common.Models
{
    public class EncrypterOperationResult
    {
        public EncrypterOperationResult()
        { }

        public EncrypterOperationResult(string result, bool success)
        {
            Result = result;
            Success = success;
        }

        public string Result { get; set; }
        public bool Success { get; set; }
    }
}