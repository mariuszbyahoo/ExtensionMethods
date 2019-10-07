using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Library
{
    public static class TargetExtensions
    {
        // You cannot extend an Internal classes in another assembly, when extending, you need to make the methods internal
        internal static void ExtendInternal(this InternalTarget target)
        {
            //TODO
        }

        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();
        }
    }
}
