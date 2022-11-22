using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface INSXRepo
    {
        IEnumerable<NSX> GetAllNSX();
        NSX GetByIdNSX(int ma);
        bool AddNSX(NSX nsx);
        bool UpdateNSX(NSX nsx);
        bool DeleteNSX(NSX nsx);
    }
}
