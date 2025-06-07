using Microsoft.Extensions.DependencyInjection;

namespace LinkedHeap
{
  /// <summary>
  /// Extension methods for <see cref="IServiceCollection"/> to register LinkedHeap services.
  /// </summary>
  public static class LinkedHeapServiceCollectionExtensions
  {
    /// <summary>
    /// Registers <see cref="LinkedHeapService{T}"/> (heap, stack, queue) as singletons
    /// in the service collection. Also maps <see cref="IHeap{T}"/>,
    /// <see cref="IStack{T}"/>, and <see cref="IQueue{T}"/> to those instances.
    /// </summary>
    /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to extend.</param>
    /// <returns>The same <see cref="IServiceCollection"/>, for chaining.</returns>
    public static IServiceCollection AddLinkedHeapServices<T>(this IServiceCollection services)
        where T : unmanaged
    {
      services.AddSingleton<LinkedHeapService<T>>();
      services.AddSingleton(sp => sp.GetRequiredService<LinkedHeapService<T>>().Heap);
      services.AddSingleton(sp => sp.GetRequiredService<LinkedHeapService<T>>().Stack);
      services.AddSingleton(sp => sp.GetRequiredService<LinkedHeapService<T>>().Queue);

      return services;
    }
  }
}
