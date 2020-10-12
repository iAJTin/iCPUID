﻿
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains an object response.
    /// </summary>
    public class ObjectResponse : ResponseBase<object>
    {
        /// <summary>
        /// Returns a new <see cref="ObjectResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="ObjectResponse"/> with specified detailed error.
        /// </returns>
        public new static ObjectResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="ObjectResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="ObjectResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static ObjectResponse CreateErroResponse(IResponseError[] errors) =>
            new ObjectResponse
            {
                Value = default,
                Success = false,
                Errors = (IResponseError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success response.
        /// </summary>
        /// <param name="value">Response value</param>
        /// <returns>
        /// A new valid <see cref="ObjectResponse"/>.
        /// </returns>
        public new static ObjectResponse CreateSuccessResponse(object value) =>
            new ObjectResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="ObjectResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="ObjectResponse"/> instance for specified exception.
        /// </returns>
        public new static ObjectResponse FromException(System.Exception exception) =>
            new ObjectResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
