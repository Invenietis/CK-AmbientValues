using System;

namespace CK.Core
{
    public interface IAmbientValuesProviderConfiguration<T>
    {
        IAmbientValuesProviderConfiguration<T> Configure( Action<IConfigurableAmbientValueProviderDescriptor> configure );

        IAmbientValuesRegistrationFrom<T> ProvidedBy<TProvider>() where TProvider : class, IAmbientValueProvider;
    }
}
