using System;

using Sturla.io.DesignTimeModelBindingXF.Models;

namespace Sturla.io.DesignTimeModelBindingXF.ViewModels
{
	public class ItemDetailViewModel : BaseViewModel
	{
		public Item Item { get; set; }
		public ItemDetailViewModel(Item item = null)
		{
			Title = item?.Text;
			Item = item;
		}
	}
}
