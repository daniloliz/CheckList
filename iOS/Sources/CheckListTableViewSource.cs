using System;
using System.Collections.Generic;
using CheckList;
using Foundation;
using UIKit;

namespace CheckList.iOS.Sources
{
    public class CheckListTableViewSource : UITableViewSource
    {
        readonly IList<CarteiraVacinacao> Carts;
        readonly UIViewController Controller;

        public CheckListTableViewSource(IList<CarteiraVacinacao> carts, UIViewController controller)
        {
            Carts = carts;
            Controller = controller;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("CheckListTableViewCell", indexPath) as CheckListTableViewCell;
            if (cell == null)
            {
                cell = new CheckListTableViewCell(new NSString("CheckListTableViewCell"),
                                                  Carts[indexPath.Row], Controller);
            }

            cell.UpdateCell(Carts[indexPath.Row], Controller);

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Carts.Count;
        }
    }
}
