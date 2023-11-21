using System.ComponentModel;

namespace HtmxTailwindGsapBlazor.Helpers;

public static class Extensions
{
    public static Dictionary<string, object?> ToDictionary(this object values)
    {
        var dict = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

        if (values != null)
        {
            foreach (PropertyDescriptor propertyDescripter in TypeDescriptor.GetProperties(values))
            {
                object obj = propertyDescripter.GetValue(values);
                dict.Add(propertyDescripter.Name, obj);
            }
        }
        return dict;
    }
}
