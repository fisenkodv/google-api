using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace GoogleApi.Attributes
{
  internal static class ArrtibutesHelper
  {
    public static CodeAttribute GetEnumCodeAttribute<T>(T language)
      where T : struct, IConvertible
    {
      MemberInfo memberInfo = typeof(T)
        .GetMember(language.ToString(CultureInfo.InvariantCulture))
        .FirstOrDefault();

      CodeAttribute attribute = (CodeAttribute)memberInfo?
        .GetCustomAttributes(typeof(CodeAttribute), false)
        .FirstOrDefault();

      return attribute;
    }
  }
}