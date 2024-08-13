using Microsoft.JSInterop;

namespace SqlQueryFromNaturallanguage.Services
{
     
    public class ClipBoardService : IClipBoardService
    {
        private readonly IJSRuntime _jsInterop;

        public ClipBoardService(IJSRuntime jsInterop)
        {
            _jsInterop = jsInterop;
        }

        public async Task CopyToClipboard(string text)
        {
            await _jsInterop.InvokeVoidAsync("navigator.clipboard.writeText", text);
        }
    }
}
