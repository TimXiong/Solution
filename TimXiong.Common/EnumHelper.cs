using System;
using System.ComponentModel;
using System.Reflection;

namespace TimXiong.Common
{
    /// <summary>
    /// 
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TEnum? SafeParse<TEnum>(string value)
            where TEnum : struct
        {
            TEnum enumValue = default(TEnum);
            if (!Enum.TryParse<TEnum>(value, out enumValue))
            {
                return null;
            }
            return enumValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumObject"></param>
        /// <param name="member">
        /// Ture  : Enum member description 
        /// False : Enum description
        /// </param>
        /// <returns></returns>
        public static string ShowDescription(this Enum enumObject, bool member = true)
        {
            string description = string.Empty;
            if (enumObject == null)
            {
                return description;
            }
            Type type = enumObject.GetType();
            if (type == null)
            {
                return description;
            }
            DescriptionAttribute descriptionAttribute = null;
            if (member)
            {
                string enumName = Enum.GetName(type, enumObject);
                if (!string.IsNullOrWhiteSpace(enumName))
                {
                    FieldInfo field = type.GetField(enumName);
                    if (field != null)
                    {
                        descriptionAttribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute), false) as DescriptionAttribute;
                    }
                }
            }
            else
            {
                descriptionAttribute = Attribute.GetCustomAttribute(type, typeof(DescriptionAttribute)) as DescriptionAttribute;
            }
            if (descriptionAttribute != null && !string.IsNullOrWhiteSpace(descriptionAttribute.Description))
            {
                description = descriptionAttribute.Description;
            }
            return description;
        }
    
    }
}
