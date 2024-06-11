using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Blazing.Frontend.BusinessObjects.Options
{
    public class BlazingPizzaOptions
    {
         public const string SectionKey = nameof(BlazingPizzaOptions);
        public string WebApiBaseAddress { get; set; }
    }
}
