namespace WPF.ClassLibrary.ViewModels
{
    using System.Collections.Generic;
    using WPF.ClassLibrary.Interface;
    using WPF.ClassLibrary.Models;
    public class MenuView : IMenuInterface
    {
        List<MenuModel> ListMenu = new List<MenuModel>();

        public List<MenuModel> MenuAdd(MenuModel ItemMenu)
        {
            ListMenu.Add(new MenuModel()
            {
                IdMenu = ItemMenu.IdMenu,
                NameMenu = ItemMenu.NameMenu,
                CategoryMenu = ItemMenu.CategoryMenu
            });
            return ListMenu;
        }
        public List<MenuModel> MenuClear(List<MenuModel> ListMenu)
        {
            ListMenu.Clear();
            return ListMenu;
        }
    }
}
