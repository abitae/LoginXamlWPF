using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ClassLibrary.Models
{
    public class MenuModel : IEquatable<MenuModel>
    {
        public string NameMenu { get; set; }
        public string CategoryMenu { get; set; }
        public bool StateMenu { get; set; }

        public override string ToString()
        {
            return "NameMenu: " + NameMenu + "   CategoryMenu: " + CategoryMenu;
        }
        public bool Equals(MenuModel obj)
        {
            if (obj == null) return false;
            return (this.NameMenu.Equals(obj.NameMenu));
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            MenuModel objAsPart = obj as MenuModel;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
    }
}
