﻿using System.Collections.Generic;
using System.Linq;

namespace Adverts.Application.Common.Models
{
    public class BaseResponse<T>
    {
        public BaseResponse()
        {
            Errors = new List<ErrorResponse>();
        }

        public bool HasError => Errors.Any();
        public T Result { get; set; }
        public int Total { get; set; }
        public List<ErrorResponse> Errors { get; set; }
    }
}
