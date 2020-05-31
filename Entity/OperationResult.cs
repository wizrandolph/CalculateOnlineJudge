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
}
