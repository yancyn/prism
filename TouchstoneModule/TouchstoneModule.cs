using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace TouchstoneModule
{
    public class TouchstoneModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;
        public TouchstoneModule(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }
        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion("ToolbarRegion", typeof(TouchstoneView));
        }
    }
}