using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGK.Models
{
    public class vtd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string surname { get; set; }
        public string TC { get; set; }
        public string  phone{ get; set; }

        internal static Task<string> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
