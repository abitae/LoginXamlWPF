using System.Collections.Generic;
using WPF.ClassLibrary.Models;

namespace WPF.ClassLibrary.ViewModels
{
    public class MenuView
    {
        List<MenuModel> list = new List<MenuModel>();

        public List<MenuModel> MenuAdd() {
            list.Add(new MenuModel() {
                NameMenu = "",
                CategoryMenu=""            
            });
            return list;
        }
        public List<MenuModel> MenuAdd(MenuModel menu)
        {
            list.Add(new MenuModel()
            {
                NameMenu = menu.NameMenu,
                CategoryMenu = menu.CategoryMenu
            });
            return list;
        }
        public bool MenuClear(List<MenuModel> menu)
        {
            menu.Clear();
            return true;
        }
    }
}
