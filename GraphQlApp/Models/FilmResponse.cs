using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GraphQlApp.Models
{

    public class Film
    {
        public string title { get; set; }
        public string director { get; set; }
    }
}

