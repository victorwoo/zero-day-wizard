using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZeroDayWizard.Properties;

namespace ZeroDayWizard
{
    public static class ContentType
    {
        private static IEnumerable<string> _contentTypes;

        public static void Load()
        {
            var contentTypesString = Resource.ContentType;
            _contentTypes = contentTypesString.Split('\n').Select(item => item.Split(',').First().Trim().Replace(' ', '.'));
        }

        public static bool Contains(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            return _contentTypes.Any(item => String.Equals(item, value.Trim(), StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
