using Microsoft.AspNetCore.Components;

namespace BlazorPlayground.Infrastructure.JavaScript.Services
{
    public interface IJavaScriptLocator
    {
        Task<string> LocateJsFilePathAsync<T>()
            where T : ComponentBase;
    }
}