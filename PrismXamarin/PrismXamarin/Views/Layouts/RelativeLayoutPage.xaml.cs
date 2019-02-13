using Xamarin.Forms;

namespace PrismXamarin.Views.Layouts
{
    public partial class RelativeLayoutPage
    {
        public RelativeLayoutPage()
        {
            InitializeComponent();

            //var layout = new RelativeLayout();
            //var redBox = new BoxView { Color = Color.Red };
            //var blueBox = new BoxView { Color = Color.Blue };

            //layout.Children.Add(redBox,
            //    Constraint.RelativeToParent((parent) => { return parent.X; }),
            //    Constraint.RelativeToParent((parent) => { return parent.Height * .15; }),
            //    Constraint.RelativeToParent((parent) => { return parent.Width; }),
            //    Constraint.RelativeToParent((parent) => { return parent.Height * .8; }));

            //layout.Children.Add(blueBox,
            //    Constraint.RelativeToView(redBox, (parent, sibling) => { return sibling.X + 20; }),
            //    Constraint.RelativeToView(redBox, (parent, sibling) => { return sibling.Y + 20; }),
            //    Constraint.RelativeToParent((parent) => { return parent.Width * .5; }),
            //    Constraint.RelativeToParent((parent) => { return parent.Height * .5; }));

            //Content = layout;
        }
    }
}
