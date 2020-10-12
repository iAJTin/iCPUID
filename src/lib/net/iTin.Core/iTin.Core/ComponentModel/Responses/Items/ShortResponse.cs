﻿
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a short response.
    /// </summary>
    public class ShortResponse : ResponseBase<short>
    {
        /// <summary>
        /// Returns a new <see cref="ShortResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="ShortResponse"/> with specified detailed error.
        /// </returns>
        public new static ShortResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="ShortResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="ShortResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static ShortResponse CreateErroResponse(IResponseError[] errors) =>
            new ShortResponse
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
        /// A new valid <see cref="ShortResponse"/>.
        /// </returns>
        public new static ShortResponse CreateSuccessResponse(short value) =>
            new ShortResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="ShortResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="ShortResponse"/> instance for specified exception.
        /// </returns>
        public new static ShortResponse FromException(System.Exception exception) =>
            new ShortResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
