using Nancy;
using Nancy.Conventions;

namespace SurveyThing
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            Conventions.StaticContentsConventions.Clear();
            Conventions.StaticContentsConventions.AddDirectory("/", "app");

            base.ConfigureConventions(nancyConventions);
        }
    }
}