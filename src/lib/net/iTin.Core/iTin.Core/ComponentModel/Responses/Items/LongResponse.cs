﻿
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a long response.
    /// </summary>
    public class LongResponse : ResponseBase<long>
    {
        /// <summary>
        /// Returns a new <see cref="LongResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="LongResponse"/> with specified detailed error.
        /// </returns>
        public new static LongResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="LongResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="LongResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static LongResponse CreateErroResponse(IResponseError[] errors) =>
            new LongResponse
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
        /// A new valid <see cref="LongResponse"/>.
        /// </returns>
        public new static LongResponse CreateSuccessResponse(long value) =>
            new LongResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="LongResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="LongResponse"/> instance for specified exception.
        /// </returns>
        public new static LongResponse FromException(System.Exception exception) =>
            new LongResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
