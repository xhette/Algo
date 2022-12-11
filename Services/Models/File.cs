using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class File
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? FullPath { get; set; }
        public string? UrlPath { get; set; }
        public long Size { get; set; }
        public string? NewName { get; set; }
        public string? HashCode { get; set; }
    }
}
