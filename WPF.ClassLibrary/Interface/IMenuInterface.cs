

namespace WPF.ClassLibrary.Interface
{
    using System.Collections.Generic;
    using WPF.ClassLibrary.Models;
    public interface IMenuInterface
    {
        List<MenuModel> MenuAdd(MenuModel ItemMenu);
        List<MenuModel> MenuClear(List<MenuModel> ListMenu);
    }
}
