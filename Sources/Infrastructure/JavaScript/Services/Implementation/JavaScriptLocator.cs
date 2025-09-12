using Microsoft.AspNetCore.Components;

namespace BlazorPlayground.Infrastructure.JavaScript.Services.Implementation
{
    public class JavaScriptLocator : IJavaScriptLocator
    {

        public async Task<string> LocateJsFilePathAsync<T>() where T : ComponentBase
        {
            var type = typeof(T);

            var assemblyFullName = type.Assembly.FullName;
            var assemblyName = type.Assembly.FullName!.Substring(0, assemblyFullName!.IndexOf(','));
            var relativeNamespace = type.FullName!.Replace(assemblyName, string.Empty);

            if (type.IsGenericType)
            {
                relativeNamespace = relativeNamespace.Substring(0, relativeNamespace.IndexOf('`'));
            }

            var path = relativeNamespace.Replace(".", "/");
            path += ".razor.js";
            return path;
        }


    }
}