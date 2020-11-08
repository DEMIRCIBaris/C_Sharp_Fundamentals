using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = false)]//AttributeTargets özelliği class,metot vb... nerede kullanılacağını belirler
    public class RequiredPropertyAttribute:Attribute
    {
    }
}
