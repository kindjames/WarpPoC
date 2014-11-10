using System;
using System.Collections.Generic;
using System.Linq;

namespace Warp.Core.Util
{
    public class CheckArgument
    {
        public static T NotNull<T>(T value, string parameterName) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            return value;
        }

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

        public static T? NotNull<T>(T? value, string parameterName) where T : struct
        {
            if (!value.HasValue)
            {
                throw new ArgumentNullException(parameterName);
            }

            return value;
        }

        public static string NotEmpty(string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Parameter '" + parameterName + "' is null, empty or contains only whitespace.");
            }

            return value;
        }

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
