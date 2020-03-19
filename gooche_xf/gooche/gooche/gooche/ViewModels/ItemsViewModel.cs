using gooche.Classes;
using gooche.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace gooche.ViewModels
{
    public class ItemsViewModel : ViewModelBase
    {
        private IItemsModel itemsModel { get; }


        private List<Menu> menuList;

        public List<Menu> MenuList
        {
            get => menuList;
            set => SetProperty(ref menuList, value);
        }

        public ItemsViewModel(INavigationService navigationService, IItemsModel itemsMdl)
            : base(navigationService)
        {
            Title = "Items";
            itemsModel = itemsMdl;
            Task.Run(async () =>
            {
                await InitItems();
            });
        }

        private async Task InitItems()
        {
            MenuList = await itemsModel.GetMenus();
        }
    }
}
