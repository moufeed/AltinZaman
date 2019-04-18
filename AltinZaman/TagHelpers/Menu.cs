using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamTechSDK.Common.Services.ContentService.Menus;
using TamTechSDK.Common.Services.ContentService.Menus.Enums;
using TamTechSDK.Common.Services.ContentService.Menus.Models;

namespace AltinZaman.TagHelpers
{
    public class Menu : TagHelper
    {

        private readonly IPublicMenusService _publicMenusService;

        private Dictionary<string, string> paths;
        public Menu(IPublicMenusService publicMenusService)
        {
            _publicMenusService = publicMenusService;

            var culture = CultureInfo.CurrentCulture.Name;
            paths = new Dictionary<string, string>
                   {
                      { MenuItemTypeEnum.product.ToString()  , $"/{culture}/portal/products/Details" },
                      { MenuItemTypeEnum.page.ToString()  , $"/{culture}/portal/pages/v" },
                      { MenuItemTypeEnum.staticpage.ToString()  , $"/{culture}/portal" },
                      { MenuItemTypeEnum.service.ToString()  , $"/{culture}/portal/services/v" },

                   };
        }



        private void GenerateLiItem(MenuItemDto Menu, StringBuilder stringBuilder, bool subItem = false, string path = "")
        {
            stringBuilder.Append($"<li class=\"{((subItem) ? "" : "nav-item")}\">");
            if (Menu.Url.Equals("/"))
            {
                stringBuilder.Append($"<a class=\"{((subItem) ? "dropdown-item" : "nav-link")}\" href=\"{ path }\" >");
            }
            else
            {
                stringBuilder.Append($"<a class=\"{((subItem) ? "dropdown-item" : "nav-link")}\" href=\"{ path }/{ Menu.Url }\" >");
            }
            stringBuilder.Append($"{Menu.Title}");
            stringBuilder.Append("</a>");
            stringBuilder.Append("</li>");
        }


        private string Print_UL(List<MenuItemDto> MenuItems, bool submenu = false, bool rootLevel = false)
        {
            StringBuilder stringBuilder = new StringBuilder($"<ul class=\" {((rootLevel) ? "navigation clearfix" : "")} \">");

            if (MenuItems?.Count > 0)
            {
                foreach (MenuItemDto Menu in MenuItems)
                {
                    if (Menu.ItemType == MenuItemTypeEnum.dropdown.ToString())
                    {
                        Print_Li_Dropdown(Menu, stringBuilder, rootLevel);
                    }
                    else
                    {
                        Print_Li(Menu, stringBuilder, submenu);
                    }
                }
            }

            stringBuilder.Append("</ul>");
            return stringBuilder.ToString();
        }


        private void Print_Li_Dropdown(MenuItemDto Menu, StringBuilder stringBuilder, bool rootLevel = false)
        {
            stringBuilder.Append("<li class=\"dropdown\">");

            stringBuilder.Append($"<a href=\"#\">");
            stringBuilder.Append($"{Menu.Title}");
            stringBuilder.Append("</a>");

            var sublavel = Print_UL(Menu.MenuItems, true, false);
            stringBuilder.Append(sublavel);

            stringBuilder.Append("</li>");

        }

        private void Print_Li(MenuItemDto Menu, StringBuilder stringBuilder, bool subItem = false)
        {

            /*
              stringBuilder.Append($"<li class=\"{((subItem) ? "" : "nav-item")}\">");
                 stringBuilder.Append($"<a class=\"{((subItem) ? "dropdown-item" : "nav-link")}\" href=\"#\">");
                 stringBuilder.Append($"{Menu.Title}");
                 stringBuilder.Append("</a>");
             stringBuilder.Append("</li>"); */

            #region service
            if (Menu.ItemType.Equals(MenuItemTypeEnum.service.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                GenerateLiItem(Menu, stringBuilder, subItem, (string)paths[MenuItemTypeEnum.service.ToString()]);
            }
            #endregion

            #region static page
            if (Menu.ItemType.Equals(MenuItemTypeEnum.staticpage.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                GenerateLiItem(Menu, stringBuilder, subItem, (string)paths[MenuItemTypeEnum.staticpage.ToString()]);
            }
            #endregion

            #region Url
            if (Menu.ItemType.Equals(MenuItemTypeEnum.url.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                var target = (Menu.UrlTarget?.Length > 0) ? Menu.UrlTarget : "_blank";
                stringBuilder.Append($"<li class=\"{((subItem) ? "" : "nav-item")}\">");
                stringBuilder.Append($"<a class=\"{((subItem) ? "dropdown-item" : "nav-link")}\" href=\"{Menu.Url}\" target=\"{target}\">");
                stringBuilder.Append($"{Menu.Title}");
                stringBuilder.Append("</a>");
                stringBuilder.Append("</li>");
            }
            #endregion

            #region page
            if (Menu.ItemType.Equals(MenuItemTypeEnum.page.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                GenerateLiItem(Menu, stringBuilder, subItem, (string)paths[MenuItemTypeEnum.page.ToString()]);
            }
            #endregion

            #region product
            if (Menu.ItemType.Equals(MenuItemTypeEnum.product.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                GenerateLiItem(Menu, stringBuilder, subItem, (string)paths[MenuItemTypeEnum.product.ToString()]);
            }
            #endregion
        }


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;
             

            var menu = await _publicMenusService.GetNavbarMenuAsync();

            output.Content.SetHtmlContent(Print_UL(menu.MenuItems, false, true));
        }
    }
}
