using Nancy;

namespace SurveyThing.Features
{
    public class StaticModule : NancyModule
    {
        public StaticModule()
        {
            Get["/"] = _ => Response.AsFile("app/index.html");
        }
    }
}