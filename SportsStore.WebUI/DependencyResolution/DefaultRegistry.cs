

namespace SportsStore.WebUI.DependencyResolution {
    using SportsStore.Domain.Abstract;
    using SportsStore.Domain.Concrete;
    using StructureMap;
	
    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
					scan.With(new ControllerConvention());
                });
            For<IProductRepository>().Use<EFProductRepository>();
            //For<IExample>().Use<Example>();
        }

        #endregion
    }
}