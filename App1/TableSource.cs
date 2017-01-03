using System;
using System.Collections.Generic;
using System.Text;
using Foundation;

//  Include UIKit, the visual elements of the app.
using UIKit;

namespace App1
{
    //  Inherets from UITableViewSource
    public class TableSource : UITableViewSource
    {
        //  Array for data to be stored
        string[] tableItems;
        //  Cell ID
        string cellIdentifier = "TableCell";



        //  Constructor
        public TableSource (string[] items) 
        {
            //  Fill object array with array input in constructor
            tableItems = items;
        }

        //  Custom method for retrieving amount of items in array
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            //  Returns how many items are in the array.
            return tableItems.Length;
        }

        //  When the row is touched
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //  Displays alert when touched
            new UIAlertView("Alert", "You touched: " + tableItems[indexPath.Row], null, "OK", null).Show ();

        }

        //  Custom method for cell retreival
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //  Creates a table cell called 'cell' and allows it to be recycled
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

            //  Checks if a cell needs to be created, and allows the cell to be recycled
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

            //  Change the text of the cell
            cell.TextLabel.Text = tableItems[indexPath.Row];
            return cell;

        }
    }
}
