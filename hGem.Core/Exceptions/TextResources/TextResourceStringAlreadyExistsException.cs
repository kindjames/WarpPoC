using System;

namespace hGem.Core.Exceptions.TextResources
{
    public class TextResourceStringAlreadyExistsException : Exception
    {
        public TextResourceStringAlreadyExistsException(string message)
            : base(BuildErrorMessage(message))
        { }

        private static string BuildErrorMessage(string message)
        {
            return String.Format("Text resource string, {0} already exists", message);
        }
    }
}
