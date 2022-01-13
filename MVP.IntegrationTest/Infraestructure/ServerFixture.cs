using System;
using System.Diagnostics;

namespace MVP.IntegrationTest.Infraestructure
{
    public class ServerFixture : IDisposable
    {


        public void Dispose()
        {
            Debug.Write("Disposes only once por test");
        }
    }
}
