using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharpZavertailo2.Views;

namespace CharpZavertailo2.Tools.Navigation
{
    internal class InitializationNavigationModel : BaseNavigationModel
    {
        public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {

        }

        protected override void InitializeView(ViewType viewType)
        {
            if (!ViewsDictionary.ContainsKey(viewType))
            {
                switch (viewType)
                {
                    case ViewType.PersonFillInfo:
                        ViewsDictionary.Add(viewType, new PersonFillInfoView());
                        break;
                    case ViewType.Main:
                        ViewsDictionary.Add(viewType, new MainView());
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
                }
            }
            else
            {
                switch (viewType)
                {
                    case ViewType.PersonFillInfo:
                        break;
                    case ViewType.Main:
                        ViewsDictionary[viewType] = new MainView();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
                }
            }
        }
    }
}
