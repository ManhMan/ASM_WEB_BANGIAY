using System;

namespace ASM_WEB_BANGIAY.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string Errorname { get; set; }
    }
}
