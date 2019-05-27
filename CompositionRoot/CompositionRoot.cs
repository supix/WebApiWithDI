using SimpleInjector;
using System;

namespace CompositionRoot
{
    public static class CompositionRoot
    {
        public static void Initialize(Container container)
        {
            /*{
                container.Register<DomainModel.Servizi.IPersonaSaver,
                    Persistence.InMemory.PersonaSaver>(Lifestyle.Scoped);
                container.Register<
                    DomainModel.Servizi.IGetTutteLePersone,
                    Persistence.InMemory.GetTutteLePersone>(Lifestyle.Scoped);
                container.Register<Persistence.InMemory.DbPersone>(Lifestyle.Singleton);
            }*/
            {
                container.Register<DomainModel.Servizi.IPersonaSaver,
                    Persistence.MongoDB.PersonaSaver>(Lifestyle.Scoped);
                container.Register<
                    DomainModel.Servizi.IGetTutteLePersone,
                    Persistence.MongoDB.GetTutteLePersone>(Lifestyle.Scoped);
                container.Register<Persistence.MongoDB.DbContext>(Lifestyle.Singleton);
            }
        }
    }
}
