using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OsuRanker
{
    public static class PropertyMapper
    {
        public static void copyPropertiesFrom(this object to, object from)
        {
            Type targetType = to.GetType();
            Type sourceType = @from.GetType();

            PropertyInfo[] sourceProps = sourceType.GetProperties();
            foreach (var propInfo in sourceProps)
            {
                //Get the matching property from the target
                PropertyInfo toProp =
                    (targetType == sourceType) ? propInfo : targetType.GetProperty(propInfo.Name);

                //If it exists and it's writeable
                if (toProp != null && toProp.CanWrite)
                {
                    //Copy the value from the source to the target
                    Object value = propInfo.GetValue(@from, null);
                    toProp.SetValue(to, value, null);
                }
            }
        }
    }
}
