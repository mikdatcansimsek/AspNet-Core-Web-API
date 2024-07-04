using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<String> Errors { get; set; }

        public static CustomResponseDto<T> Success(T data, int statusCode)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statusCode };
        }
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> {StatusCode = statusCode };
        }
        public static CustomResponseDto<T> Fail(List<String> errors, int statusCode)
        {
            return new CustomResponseDto<T> { Errors = errors, StatusCode = statusCode };
        }
        public static CustomResponseDto<T> Fail(String error, int statusCode)
        {
            return new CustomResponseDto<T> { Errors = new List<string> { error}, StatusCode = statusCode };
        }
    }
}
