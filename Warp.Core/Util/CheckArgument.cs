using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Warp.Core.Util
{
    /// <summary>
    /// Utility class for checking parameters passed into a method.
    /// </summary>
    public class CheckArgument
    {
        /// <summary>
        /// Checks that the parameter is not null.
        /// </summary>
        [DebuggerHidden]
        public static T NotNull<T>(T value, string parameterName) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            return value;
        }

        /// <summary>
        /// Checks that the parameter is not null and have at least one item.
        /// </summary>
        [DebuggerHidden]
        public static IEnumerable<T> NotNullAndHasItems<T>(IEnumerable<T> collection, string parameterName) where T : class
        {
            NotNull(collection, parameterName);

            var enumerable = collection as List<T> ?? collection.ToList();
            
            if (!enumerable.Any())
            {
                throw new ArgumentException("Collection has no items.", parameterName);
            }

            return enumerable;
        }

        /// <summary>
        /// Checks that the parameter is not null.
        /// </summary>
        [DebuggerHidden]
        public static T? NotNull<T>(T? value, string parameterName) where T : struct
        {
            if (!value.HasValue)
            {
                throw new ArgumentNullException(parameterName);
            }

            return value;
        }

        /// <summary>
        /// Checks that the parameter has some text.
        /// </summary>
        [DebuggerHidden]
        public static string NotEmpty(string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Parameter '" + parameterName + "' is null, empty or contains only whitespace.");
            }

            return value;
        }

        /// <summary>
        /// Checks that the parameter is not zero - useful for checking an Id has been specified.
        /// </summary>
        [DebuggerHidden]
        public static int NotZero(int value, string parameterName)
        {
            if (value == 0)
            {
                throw new ArgumentException("Parameter '"+ parameterName + "' cannot be zero.");
            }

            return value;
        }
    }
}