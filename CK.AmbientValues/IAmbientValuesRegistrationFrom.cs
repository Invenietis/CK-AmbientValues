using System;
using System.Linq.Expressions;

namespace CK.Core
{
    public interface IAmbientValuesRegistrationFrom<T>
    {
        IAmbientValuesProviderConfiguration<T> Select<TProperty>( Expression<Func<T, TProperty>> propertyAccessor ) where TProperty : IComparable;
    }
}
