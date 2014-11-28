using System;

namespace Warp.Core.Exceptions.TextResources
{
    public class TextResourceNotFoundException : Exception
    {
        public TextResourceNotFoundException(int textResourceId)
            : base(BuildErrorMessage(textResourceId))
        {
        }

        static string BuildErrorMessage(int textResourceId)
        {
            return String.Concat("Unable to find resource for id: ", textResourceId);
        }
    }
}