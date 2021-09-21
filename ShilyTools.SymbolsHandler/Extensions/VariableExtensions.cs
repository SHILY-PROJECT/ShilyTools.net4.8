using System.Collections.Generic;

namespace ShilyTools.SymbolsHandler.Extensions
{
    public static class VariableExtensions
    {
        public static string Replace(this string text, List<(string oldValue, string newValue)> listOldValueNewValue)
        {
            listOldValueNewValue.ForEach(x => text = text.Replace(x.oldValue, x.newValue));
            return text;
        }
    }
}
