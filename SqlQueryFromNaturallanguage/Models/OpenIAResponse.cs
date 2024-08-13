using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SqlQueryFromNaturallanguage
{
    public class OpenIAResponse
    {
        public string? id { get; set; }
        public string? @object {get;set;}
        public long  created {  get; set; }
        public string? model { get; set; }
        public List<Choice>? choices { get; set; }
        public Usage? usage {  get; set; }
        public string? system_fingerprint { get; set; }
        public ErrorResponse? error { get; set; }
    }
}
