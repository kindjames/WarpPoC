using System;

namespace Warp.Core.Exceptions.TextResources
{
    public class TextResourceNotFoundException : Exception
    {
        public TextResourceNotFoundException(string textResourceCode)
            : base(BuildErrorMessage(textResourceCode))
        {
        }

        static string BuildErrorMessage(string textResourceCode)
        {
            return String.Concat("Unable to find resource for code: ", textResourceCode);
        }
    }
}