using System.Collections.Generic;

namespace FluentValication.WebApi.Models
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            IsValid = true;
            ValidationMessages = new List<string>();
        }
        public bool IsValid { get; set; }
        public List<string> ValidationMessages { get; set; }
    }
}
