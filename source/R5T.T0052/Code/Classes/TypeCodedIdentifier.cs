using System;

using R5T.Stagira;


namespace R5T.T0052
{
    /// <summary>
    /// Example: EX-3a0af49f-2f01-43b9-8238-d834452661db as the identity that uniquely identifies and experiment with the "EX" identifier type code.
    /// </summary>
    public class TypeCodedIdentifier : TypedString
    {
        public TypeCodedIdentifier(string value)
            : base(value)
        {
        }
    }
}
