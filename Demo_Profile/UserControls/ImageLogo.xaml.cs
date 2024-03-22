using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Demo_Profile.UserControls
{
    public partial class ImageLogo : UserControl
    {
        public ImageLogo()
        {
            InitializeComponent();
        }

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(ImageSource), typeof(ImageLogo));

    }
}