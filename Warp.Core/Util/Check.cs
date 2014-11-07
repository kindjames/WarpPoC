using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Warp.Core.Util
{
    public class Check
    {
        public static T NotNull<T>(T value, string parameterName) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            return value;
        }

        public static void NotNullAndHasItems<T>(IEnumerable<T> collection, string parameterName) where T : class
        {
            NotNull(collection, parameterName);

            if (collection.Any())
            {
                throw new ArgumentException("Collection has no items.", parameterName);
            }
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
                throw new ArgumentException("String is empty or whitespace -> "+ (object)parameterName);
            }

            return value;
        }
    }
}
