using System;

namespace GoogleApi.Attributes
{
  internal class CodeAttribute : Attribute
  {
    public string Code { get; }

    public CodeAttribute(string code)
    {
      Code = code;
    }
  }
}