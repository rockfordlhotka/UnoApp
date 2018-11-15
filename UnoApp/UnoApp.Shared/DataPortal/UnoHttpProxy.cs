using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Csla.DataPortalClient;

namespace UnoApp.Shared.DataPortal
{
  public class UnoHttpProxy : HttpProxy
  {
    private static HttpClient _client;

    /// <summary>
    /// Override creation of HttpClient for wasm
    /// so the wasm instance is created based on
    /// the Uno WasmHttpHandler.
    /// </summary>
    /// <returns></returns>
    protected override HttpClient GetClient()
    {
      if (_client == null)
      {
#if __WASM__
        var handler = new Uno.UI.Wasm.WasmHttpHandler();
        _client = new HttpClient(handler);
#else
			_client = new HttpClient();
#endif
      }
      if (this.Timeout > 0)
        _client.Timeout = TimeSpan.FromMilliseconds(this.Timeout);
      return _client;
    }
  }
}
