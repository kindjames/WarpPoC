using System;

namespace hGem.Core.Exceptions.TextResources
{
    public class TextResourceCodeAlreadyExistsException : Exception
    {
        public TextResourceCodeAlreadyExistsException(string message)
            :base(BuildErrorMessage(message))
        { }

        private static string BuildErrorMessage(string message)
        {
            return String.Concat(string.Format("Text resource code, {0} already exists", message));
        }
    }
}
