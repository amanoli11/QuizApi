using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApi.Helpers.Enums;

namespace QuizApi.Helpers.Dtos
{
    public class ResponseDto<T>
    {
        public string message { get; set; }
        public T data { get; set; }
        public ResponseStatusCodeOption responseStatusCode { get; set; }
    }
}