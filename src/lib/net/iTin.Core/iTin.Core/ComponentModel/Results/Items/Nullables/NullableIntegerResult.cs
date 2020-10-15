﻿
namespace iTin.Core.ComponentModel.Results
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a nullable integer result.
    /// </summary>
    public class NullableIntegerResult : ResultBase<int?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableIntegerResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableIntegerResult"/> with specified detailed error.
        /// </returns>
        public new static NullableIntegerResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableIntegerResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="value">Result value</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableIntegerResult"/> with specified detailed error.
        /// </returns>
        public new static NullableIntegerResult CreateErroResult(string message, int? value, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, value);

        /// <summary>
        /// Returns a new <see cref="NullableIntegerResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableIntegerResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableIntegerResult CreateErroResult(IResultError[] errors) =>
            new NullableIntegerResult
            {
                Value = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="NullableIntegerResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new invalid <see cref="NullableIntegerResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableIntegerResult CreateErroResult(IResultError[] errors, int? value) =>
            new NullableIntegerResult
            {
                Value = value,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success result.
        /// </summary>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new valid <see cref="NullableIntegerResult"/>.
        /// </returns>
        public new static NullableIntegerResult CreateSuccessResult(int? value) =>
            new NullableIntegerResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableIntegerResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableIntegerResult"/> instance for specified exception.
        /// </returns>
        public new static NullableIntegerResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="NullableIntegerResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new <see cref="NullableIntegerResult"/> instance for specified exception.
        /// </returns>
        public new static NullableIntegerResult FromException(Exception exception, int? value) =>
            new NullableIntegerResult
            {
                Value = value,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
