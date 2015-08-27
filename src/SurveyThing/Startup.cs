using Microsoft.Owin.Extensions;
using Nancy.Owin;
using Owin;

namespace SurveyThing
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app
                .UseNancy(new NancyOptions
                {
                    Bootstrapper = new Bootstrapper()
                })
                .UseStageMarker(PipelineStage.MapHandler);
        }
    }
}