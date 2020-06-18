using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.Entity
{
    public struct OperationResult
    {
        private string prompt;
        private bool isSuccess;

        public OperationResult(string prompt, bool isSuccess)
        {
            this.prompt = prompt;
            this.isSuccess = isSuccess;
        }

        public string Prompt { get => prompt;}
        public bool IsSuccess { get => isSuccess;}

        public static implicit operator bool(OperationResult operationResult)
        {
            return operationResult.isSuccess;
        }
    }
    public struct OperationResult<T>
    {
        private string prompt;
        private bool isSuccess;
        private T result;



        public OperationResult(string prompt, bool isSuccess, T result)
        {
            this.prompt = prompt;
            this.isSuccess = isSuccess;
            this.result = result;
        }

        public string Prompt { get => prompt;}
        public bool IsSuccess { get => isSuccess;}
        public T Result { get => result;}

        public static implicit operator bool(OperationResult<T> operationResult)
        {
            return operationResult.isSuccess;
        }
    }
}
