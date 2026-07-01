using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaBrasileirao
{
    public static class ApiRotasContoller
    {
        private static readonly string baseUrl = "http://127.0.0.1:5000";
        public static string ConsultarSerieA => $"{baseUrl}/SerieA";
        public static string ConsultarSerieB => $"{baseUrl}/SerieB";
        public static string ConsultarSerieC => $"{baseUrl}/SerieC";
        public static string ConsultarSerieD => $"{baseUrl}/SerieD";
      
    }
}
