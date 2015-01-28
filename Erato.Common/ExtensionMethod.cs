using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Erato.Common
{
    public static class ExtensionMethod
    {
        /// <summary>
        /// 显示Display属性值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DisplayName(this Enum value)
        {
            Type enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            MemberInfo member = enumType.GetMember(enumValue)[0];

            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
            if (attrs == null || attrs.Length == 0)
                return value.ToString();

            var outString = ((DisplayAttribute)attrs[0]).Name;

            if (((DisplayAttribute)attrs[0]).ResourceType != null)
            {
                outString = ((DisplayAttribute)attrs[0]).GetName();
            }

            return outString;
        }

        /// <summary>
        /// 短日期格式
        /// </summary>
        /// <param name="date">日期</param>
        /// <returns>返回值如：150125</returns>
        public static string ShortDate(this DateTime date)
        {
            string s = string.Format("{0}{1}{2}", date.Year % 2000, date.Month.ToString().PadLeft(2, '0'), date.Day.ToString().PadLeft(2, '0'));
            return s;
        }
    }
}
