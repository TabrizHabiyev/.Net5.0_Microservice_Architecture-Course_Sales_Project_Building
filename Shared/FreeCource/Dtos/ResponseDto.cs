using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FreeCource.Shared.Dtos
{
    public class ResponseDto<T>
    {
        public T Data { get;private set; }

        [JsonIgnore]
        public int StatusCode { get;private set; }

        [JsonIgnore]
        public bool IsSucccessful { get;private set; }

        public static ResponseDto<T> Successful(T data, int StatusCode)
        {
            return new ResponseDto<T> { Data = data, StatusCode = StatusCode ,IsSucccessful = true };
        }

        public List<string> Errors { get; set; }

        public static ResponseDto<T> Successful(int StatusCode)
        {
            return new ResponseDto<T> { Data = default(T), StatusCode = StatusCode, IsSucccessful = true };
        }

        public static ResponseDto<T> Fail(List<string> errors,int StatusCode) 
        {
            return new ResponseDto<T>
            {
                Errors = errors,
                StatusCode = StatusCode,
                IsSucccessful = true
            };
        }

        public static ResponseDto<T> Fail(string error, int statusCode)
        {
            return new ResponseDto<T> { Errors = new List<string>() { error }, StatusCode = statusCode,IsSucccessful = true };
        }
    }
}
