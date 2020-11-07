using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SpecialErrorHandling
{
    public class RecordNotFoundException:Exception
    {
        public override string Message { get; } = "Benim hata sınıfım";
    }
}
