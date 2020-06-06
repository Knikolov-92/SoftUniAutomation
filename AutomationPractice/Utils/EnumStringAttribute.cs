using System;

namespace AutomationPractice.Utils
{
    public class EnumStringAttribute : Attribute
    {
        public string Name { get; }

        public EnumStringAttribute(string name)
        {
            this.Name = name;
        }
    }
}
