﻿
namespace iTin.Core.Hardware.Common
{
    using System.Collections.Generic;

    using iTin.Core.ComponentModel;

    using ComponentModel;

    /// <summary>
    /// Specialization of <see cref="ResultBase{T}"/> interface.<br/>
    /// Where <c>T</c> is <see cref="PropertyItemDictionary"/>.<br/>
    /// Represents result after query operation.
    /// </summary>
    public class QueryPropertyDictionaryResult : ResultBase<PropertyItemDictionary>
    {
        /// <summary>
        /// Returns a new <see cref="QueryPropertyDictionaryResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyDictionaryResult"/> with specified detailed error.
        /// </returns>
        public new static QueryPropertyDictionaryResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="QueryPropertyDictionaryResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="Result">Result Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyDictionaryResult"/> with specified detailed error.
        /// </returns>
        public new static QueryPropertyDictionaryResult CreateErroResult(string message, PropertyItemDictionary Result, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, Result);

        /// <summary>
        /// Returns a new <see cref="QueryPropertyDictionaryResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyDictionaryResult"/> with specified detailed errors collection.
        /// </returns>
        public new static QueryPropertyDictionaryResult CreateErroResult(IResultError[] errors) =>
            new QueryPropertyDictionaryResult
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="QueryPropertyDictionaryResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyDictionaryResult"/> with specified detailed errors collection.
        /// </returns>
        public new static QueryPropertyDictionaryResult CreateErroResult(IResultError[] errors, PropertyItemDictionary Result) =>
            new QueryPropertyDictionaryResult
            {
                Result = Result,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success result.
        /// </summary>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new valid <see cref="QueryPropertyDictionaryResult"/>.
        /// </returns>
        public new static QueryPropertyDictionaryResult CreateSuccessResult(PropertyItemDictionary Result) =>
            new QueryPropertyDictionaryResult
            {
                Result = Result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="QueryPropertyDictionaryResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="QueryPropertyDictionaryResult"/> instance for specified exception.
        /// </returns>
        public new static QueryPropertyDictionaryResult FromException(System.Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="QueryPropertyDictionaryResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new <see cref="QueryPropertyDictionaryResult"/> instance for specified exception.
        /// </returns>
        public new static QueryPropertyDictionaryResult FromException(System.Exception exception, PropertyItemDictionary Result) =>
            new QueryPropertyDictionaryResult
            {
                Result = Result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
