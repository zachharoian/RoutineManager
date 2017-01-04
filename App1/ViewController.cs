using System;

using UIKit;

namespace App1
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            //  Test data
            EventData[] data = new EventData[4];
            data[0] = new EventData("Red","NewDefault1");
            data[1] = new EventData();
            data[2] = new EventData();
            data[3] = new EventData();
            data[1].Title = "Blue";
            data[1].Desc = "Default2";
            data[2].Title = "Green";
            data[2].Desc = "Default3";
            data[3].Title = "Yellow";
            data[3].Desc = "Default4";

            //  Create the table view.
            UITableView _table;

            //  Initalize the table view
            _table = new UITableView
            {
                //  0, 20 (For notification bar) -> Position in top left corner, and let it take the width and height-20 of screen.
                Frame = new CoreGraphics.CGRect(View.Frame.Left, View.Frame.Top+20, View.Bounds.Width, View.Bounds.Height-20),

                //  Insert data
                Source = new TableSource(data)
            };

            //  Display the table view on screen
            View.AddSubview(_table);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}