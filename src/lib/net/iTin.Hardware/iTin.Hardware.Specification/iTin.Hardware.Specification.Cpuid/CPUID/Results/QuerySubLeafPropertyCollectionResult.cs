
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Collections.Generic;

    using iTin.Core.ComponentModel;

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
        public new static QuerySubLeafPropertyCollectionResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="value">Result value</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed error.
        /// </returns>
        public new static QuerySubLeafPropertyCollectionResult CreateErroResult(string message, CpuidSubLeafDictionary value, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, value);

        /// <summary>
        /// Returns a new <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed errors collection.
        /// </returns>
        public new static QuerySubLeafPropertyCollectionResult CreateErroResult(IResultError[] errors) =>
            new QuerySubLeafPropertyCollectionResult
            {
                Value = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new invalid <see cref="QuerySubLeafPropertyCollectionResult"/> with specified detailed errors collection.
        /// </returns>
        public new static QuerySubLeafPropertyCollectionResult CreateErroResult(IResultError[] errors, CpuidSubLeafDictionary value) =>
            new QuerySubLeafPropertyCollectionResult
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
        /// A new valid <see cref="QuerySubLeafPropertyCollectionResult"/>.
        /// </returns>
        public new static QuerySubLeafPropertyCollectionResult CreateSuccessResult(CpuidSubLeafDictionary value) =>
            new QuerySubLeafPropertyCollectionResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="QuerySubLeafPropertyCollectionResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="QuerySubLeafPropertyCollectionResult"/> instance for specified exception.
        /// </returns>
        public new static QuerySubLeafPropertyCollectionResult FromException(System.Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="QuerySubLeafPropertyCollectionResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new <see cref="QuerySubLeafPropertyCollectionResult"/> instance for specified exception.
        /// </returns>
        public new static QuerySubLeafPropertyCollectionResult FromException(System.Exception exception, CpuidSubLeafDictionary value) =>
            new QuerySubLeafPropertyCollectionResult
            {
                Value = value,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
