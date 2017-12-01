namespace WPF.ClassLibrary.ViewModels
{
    using System.Collections.Generic;
    using WPF.ClassLibrary.Models;
    public class MenuView
    {
        List<MenuModel> list = new List<MenuModel>();

        public List<MenuModel> MenuAdd(MenuModel ItemMenu)
        {
            list.Add(new MenuModel()
            {
                NameMenu = ItemMenu.NameMenu,
                CategoryMenu = ItemMenu.CategoryMenu
            });
            return list;
        }
        public List<MenuModel> MenuClear(List<MenuModel> ListMenu)
        {
            ListMenu.Clear();
            return ListMenu;
        }
    }
}
