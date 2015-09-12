using Ninject;
using RepositorySample.Configuration.Modules;

namespace RepositorySample.Configuration.Factories
{
    public static class Factory
    {
        public static StandardKernel StandardKernel { get; set; }

        static Factory()
        {
            var modules = new MainModule();
            StandardKernel = new StandardKernel(modules);
        }

        public static TEntity Get<TEntity>()
        {
            return StandardKernel.Get<TEntity>();
        }

        public static TEntity Get<TEntity>(string mappingName)
        {
            return StandardKernel.Get<TEntity>(mappingName);
        }
    }
}
