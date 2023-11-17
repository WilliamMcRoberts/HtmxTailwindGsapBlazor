using HtmxTailwindGsapBlazor.Helpers;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HtmxTailwindGsapBlazor.Processors;

public class Render : IRender
{
    public IResult Component<TComponent>(object data)
    {
        var componentData = data.ToDictionary();

        return new RazorComponentResult(typeof(TComponent), componentData);
    }
}
