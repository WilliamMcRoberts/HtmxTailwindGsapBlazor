
namespace HtmxTailwindGsapBlazor.Processors;

public interface IRender
{
    IResult Component<TComponent>(object data);
}