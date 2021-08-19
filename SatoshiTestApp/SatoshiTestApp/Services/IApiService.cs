using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatoshiTestApp.Services
{
    public interface IApiService
    {
        public Task<T> Get<T>(string endpoint) where T : class, new();
        public Task Post<T>( string endpoint, T myObject);        
    }
}
