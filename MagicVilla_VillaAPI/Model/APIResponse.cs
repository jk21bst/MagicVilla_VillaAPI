using System.Net;
using System.Runtime.InteropServices.ObjectiveC;

namespace MagicVilla_VillaAPI.Model
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }  
    }
}
