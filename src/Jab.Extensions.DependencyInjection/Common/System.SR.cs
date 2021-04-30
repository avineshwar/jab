// <auto-generated>
using System.Reflection;

namespace FxResources.Microsoft.Extensions.DependencyInjection
{
    internal static class SR { }
}
namespace System
{
    internal static partial class SR
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(FxResources.Microsoft.Extensions.DependencyInjection.SR)));

        /// <summary>Unable to activate type '{0}'. The following constructors are ambiguous:</summary>
        internal static string @AmbiguousConstructorException => GetResourceString("AmbiguousConstructorException", @"Unable to activate type '{0}'. The following constructors are ambiguous:");
        /// <summary>Unable to resolve service for type '{0}' while attempting to activate '{1}'.</summary>
        internal static string @CannotResolveService => GetResourceString("CannotResolveService", @"Unable to resolve service for type '{0}' while attempting to activate '{1}'.");
        /// <summary>A circular dependency was detected for the service of type '{0}'.</summary>
        internal static string @CircularDependencyException => GetResourceString("CircularDependencyException", @"A circular dependency was detected for the service of type '{0}'.");
        /// <summary>No constructor for type '{0}' can be instantiated using services from the service container and default values.</summary>
        internal static string @UnableToActivateTypeException => GetResourceString("UnableToActivateTypeException", @"No constructor for type '{0}' can be instantiated using services from the service container and default values.");
        /// <summary>Open generic service type '{0}' requires registering an open generic implementation type.</summary>
        internal static string @OpenGenericServiceRequiresOpenGenericImplementation => GetResourceString("OpenGenericServiceRequiresOpenGenericImplementation", @"Open generic service type '{0}' requires registering an open generic implementation type.");
        /// <summary>Arity of open generic service type '{0}' does not equal arity of open generic implementation type '{1}'.</summary>
        internal static string @ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation => GetResourceString("ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation", @"Arity of open generic service type '{0}' does not equal arity of open generic implementation type '{1}'.");
        /// <summary>Cannot instantiate implementation type '{0}' for service type '{1}'.</summary>
        internal static string @TypeCannotBeActivated => GetResourceString("TypeCannotBeActivated", @"Cannot instantiate implementation type '{0}' for service type '{1}'.");
        /// <summary>A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor.</summary>
        internal static string @NoConstructorMatch => GetResourceString("NoConstructorMatch", @"A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor.");
        /// <summary>Cannot consume {2} service '{0}' from {3} '{1}'.</summary>
        internal static string @ScopedInSingletonException => GetResourceString("ScopedInSingletonException", @"Cannot consume {2} service '{0}' from {3} '{1}'.");
        /// <summary>Cannot resolve '{0}' from root provider because it requires {2} service '{1}'.</summary>
        internal static string @ScopedResolvedFromRootException => GetResourceString("ScopedResolvedFromRootException", @"Cannot resolve '{0}' from root provider because it requires {2} service '{1}'.");
        /// <summary>Cannot resolve {1} service '{0}' from root provider.</summary>
        internal static string @DirectScopedResolvedFromRootException => GetResourceString("DirectScopedResolvedFromRootException", @"Cannot resolve {1} service '{0}' from root provider.");
        /// <summary>Constant value of type '{0}' can't be converted to service type '{1}'</summary>
        internal static string @ConstantCantBeConvertedToServiceType => GetResourceString("ConstantCantBeConvertedToServiceType", @"Constant value of type '{0}' can't be converted to service type '{1}'");
        /// <summary>Implementation type '{0}' can't be converted to service type '{1}'</summary>
        internal static string @ImplementationTypeCantBeConvertedToServiceType => GetResourceString("ImplementationTypeCantBeConvertedToServiceType", @"Implementation type '{0}' can't be converted to service type '{1}'");
        /// <summary>'{0}' type only implements IAsyncDisposable. Use DisposeAsync to dispose the container.</summary>
        internal static string @AsyncDisposableServiceDispose => GetResourceString("AsyncDisposableServiceDispose", @"'{0}' type only implements IAsyncDisposable. Use DisposeAsync to dispose the container.");
        /// <summary>GetCaptureDisposable call is supported only for main scope</summary>
        internal static string @GetCaptureDisposableNotSupported => GetResourceString("GetCaptureDisposableNotSupported", @"GetCaptureDisposable call is supported only for main scope");
        /// <summary>Invalid service descriptor</summary>
        internal static string @InvalidServiceDescriptor => GetResourceString("InvalidServiceDescriptor", @"Invalid service descriptor");
        /// <summary>Requested service descriptor doesn't exist.</summary>
        internal static string @ServiceDescriptorNotExist => GetResourceString("ServiceDescriptorNotExist", @"Requested service descriptor doesn't exist.");
        /// <summary>Call site type {0} is not supported</summary>
        internal static string @CallSiteTypeNotSupported => GetResourceString("CallSiteTypeNotSupported", @"Call site type {0} is not supported");

    }
}