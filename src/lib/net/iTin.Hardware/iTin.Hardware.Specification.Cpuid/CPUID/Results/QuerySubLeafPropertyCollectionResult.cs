
using System;
using System.Collections.Generic;

using iTin.Core.ComponentModel;

namespace iTin.Hardware.Specification.Cpuid;

/// <summary>
/// Specialization of <see cref="ResultBase{T}"/> interface.<br/>
/// Where <c>T</c> is <see cref="CpuidSubLeafDictionary"/>.<br/>
/// Represents result after query operation.
/// </summary>
public class QuerySubLeafPropertyCollectionResult : ResultBase<CpuidSubLeafDictionary>
{
    /// <summary>
    /// Returns a new <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed error.
    /// </summary>
    /// <param name="message">Error message</param>
    /// <param name="code">Error code</param>
    /// <returns>
    /// A new invalid <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed error.
    /// </returns>
    public new static QuerySubLeafPropertyCollectionResult CreateErrorResult(string message, string code = "") => CreateErrorResult(
        [new ResultError { Code = code, Message = message }]);

    /// <summary>
    /// Returns a new <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed error.
    /// </summary>
    /// <param name="message">Error message</param>
    /// <param name="result">Result Result</param>
    /// <param name="code">Error code</param>
    /// <returns>
    /// A new invalid <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed error.
    /// </returns>
    public new static QuerySubLeafPropertyCollectionResult CreateErrorResult(string message, CpuidSubLeafDictionary result, string code = "") => CreateErrorResult(
        [new ResultError { Code = code, Message = message }], result);

    /// <summary>
    /// Returns a new <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed errors' collection.
    /// </summary>
    /// <param name="errors">A errors collection</param>
    /// <returns>
    /// A new invalid <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed errors' collection.
    /// </returns>
    public new static QuerySubLeafPropertyCollectionResult CreateErrorResult(IResultError[] errors) => new()
    {
        Result = default,
        Success = false,
        Errors = (IResultError[])errors.Clone()
    };

    /// <summary>
    /// Returns a new <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed errors' collection.
    /// </summary>
    /// <param name="errors">A errors collection</param>
    /// <param name="result">Result Result</param>
    /// <returns>
    /// A new invalid <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed errors' collection.
    /// </returns>
    public new static QuerySubLeafPropertyCollectionResult CreateErrorResult(IResultError[] errors, CpuidSubLeafDictionary result) => new()
    {
        Result = result,
        Success = false,
        Errors = (IResultError[])errors.Clone()
    };

    /// <summary>
    /// Returns a new success result.
    /// </summary>
    /// <param name="result">Result Result</param>
    /// <returns>
    /// A new valid <see cref="QuerySubLeafPropertyCollectionResult"/>.
    /// </returns>
    public new static QuerySubLeafPropertyCollectionResult CreateSuccessResult(CpuidSubLeafDictionary result) => new()
    {
        Result = result,
        Success = true,
        Errors = Array.Empty<IResultError>()
    };

    /// <summary>
    /// Creates a new <see cref="QuerySubLeafPropertyCollectionResult"/> instance from known exception.
    /// </summary>
    /// <param name="exception">Target exception.</param>
    /// <returns>
    /// A new <see cref="QuerySubLeafPropertyCollectionResult"/> instance for specified exception.
    /// </returns>
    public new static QuerySubLeafPropertyCollectionResult FromException(Exception exception) => 
        FromException(exception, default);

    /// <summary>
    /// Creates a new <see cref="QuerySubLeafPropertyCollectionResult"/> instance from known exception.
    /// </summary>
    /// <param name="exception">Target exception.</param>
    /// <param name="result">Result Result</param>
    /// <returns>
    /// A new <see cref="QuerySubLeafPropertyCollectionResult"/> instance for specified exception.
    /// </returns>
    public new static QuerySubLeafPropertyCollectionResult FromException(Exception exception, CpuidSubLeafDictionary result) => new()
    {
        Result = result,
        Success = false,
        Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
    };
}
