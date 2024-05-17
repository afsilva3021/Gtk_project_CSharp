using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace program.Controller
{
    public class Consumir
    {
        HttpClient client = new HttpClient( BaseAddress = new Uri( "https://dashboard.api-football.com" ) );
        client.GetAsync("");
    }
}