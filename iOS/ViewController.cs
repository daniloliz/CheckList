using System;
using System.Collections.Generic;
using CheckList.iOS.Sources;
using CheckList;
using CheckList.Enum;
using UIKit;

namespace CheckList.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
#endif
            //CheckListTableView

            var api = new PeticaoAPI();
            var carts = await api.GetCarts();

            var source = new CheckListTableViewSource(carts, this);
            CheckListTableView.Source = source;
            CheckListTableView.RowHeight = UITableView.AutomaticDimension;
            CheckListTableView.EstimatedRowHeight = 40f;
            CheckListTableView.ReloadData();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
