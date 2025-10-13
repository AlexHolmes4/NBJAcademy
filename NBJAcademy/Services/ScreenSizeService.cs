using Microsoft.JSInterop;

namespace NBJAcademy.Services;

public class ScreenSizeService
{
    private readonly IJSRuntime jsRuntime;
    public ScreenDimensions Dimensions { get; private set; } = new ScreenDimensions();
    public event Action OnScreenSizeChanged;

    public ScreenSizeService(IJSRuntime JSRuntime)
    {
        jsRuntime = JSRuntime;
        _ = UpdateScreenDimensions();
    }

    public async Task UpdateScreenDimensions()
    {
        Dimensions = await jsRuntime.InvokeAsync<ScreenDimensions>("getWindowDimensions");
        OnScreenSizeChanged?.Invoke();
    }

    public async ValueTask RegisterResizeCallbackAsync()
    {
        await jsRuntime.InvokeVoidAsync("registerResizeCallback", DotNetObjectReference.Create(this));
    }

    /// <summary>
    /// Called by the JavaScript file resize.js when the browser is resized.
    /// </summary>
    /// <returns></returns>
    [JSInvokable]
    public async Task OnBrowserResize()
    {
        await UpdateScreenDimensions();
    }
}

public class ScreenDimensions
{
    public int Width { get; set; }
    public int Height { get; set; }
}