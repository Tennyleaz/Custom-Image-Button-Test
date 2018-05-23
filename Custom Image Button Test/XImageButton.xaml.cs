using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Custom_Image_Button_Test
{
    /// <summary>
    /// XImageButton.xaml 的互動邏輯
    /// </summary>
    public partial class XImageButton : UserControl
    {
        public XImageButton()
        {
            InitializeComponent();
        }

        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }
        public double ImageWidth
        {
            get { return (double)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(double), typeof(XImageButton),
            new FrameworkPropertyMetadata(30.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(double), typeof(XImageButton),
            new FrameworkPropertyMetadata(30.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public ImageSource DisabledImage
        {
            get { return (ImageSource)GetValue(DisabledImageProperty); }
            set { SetValue(DisabledImageProperty, value); }
        }
        public static readonly DependencyProperty DisabledImageProperty =
            DependencyProperty.Register("DisabledImage", typeof(ImageSource), typeof(XImageButton), new UIPropertyMetadata(null));

        public ImageSource NormalImage
        {
            get { return (ImageSource)GetValue(NormalImageProperty); }
            set { SetValue(NormalImageProperty, value); }
        }
        public static readonly DependencyProperty NormalImageProperty =
            DependencyProperty.Register("NormalImage", typeof(ImageSource), typeof(XImageButton), new UIPropertyMetadata(null));

        public ImageSource HoverImage
        {
            get { return (ImageSource)GetValue(HoverImageProperty); }
            set { SetValue(HoverImageProperty, value); }
        }
        public static readonly DependencyProperty HoverImageProperty =
            DependencyProperty.Register("HoverImage", typeof(ImageSource), typeof(XImageButton), new UIPropertyMetadata(null));

        public ImageSource PressedImage
        {
            get { return (ImageSource)GetValue(PressedImageProperty); }
            set { SetValue(PressedImageProperty, value); }
        }
        public static readonly DependencyProperty PressedImageProperty =
            DependencyProperty.Register("PressedImage", typeof(ImageSource), typeof(XImageButton), new UIPropertyMetadata(null));

        public ImageSource ForeImages
        {
            get { return (ImageSource)GetValue(ForeImageProperty); }
            set { SetValue(ForeImageProperty, value); }
        }
        public static readonly DependencyProperty ForeImageProperty =
            DependencyProperty.Register("ForeImages", typeof(ImageSource), typeof(XImageButton), new UIPropertyMetadata(null));

        public Visibility BorderVisibility
        {
            get { return (Visibility)GetValue(BorderVisibilityProperty); }
            set { SetValue(BorderVisibilityProperty, value); }
        }
        public static readonly DependencyProperty BorderVisibilityProperty =
            DependencyProperty.Register("BorderVisibility", typeof(Visibility), typeof(XImageButton),
            new FrameworkPropertyMetadata(Visibility.Hidden, FrameworkPropertyMetadataOptions.AffectsRender));

        public string TextContent
        {
            get { return (string)GetValue(TextContentProperty); }
            set { SetValue(TextContentProperty, value); }
        }
        public static readonly DependencyProperty TextContentProperty =
            DependencyProperty.Register("TextContent", typeof(string), typeof(XImageButton), new UIPropertyMetadata(null));

        public SolidColorBrush HoverBrush
        {
            get { return (SolidColorBrush)GetValue(HoverBrushProperty); }
            set { SetValue(HoverBrushProperty, value); }
        }
        public static readonly DependencyProperty HoverBrushProperty =
            DependencyProperty.Register("HoverBrush", typeof(SolidColorBrush), typeof(XImageButton), new UIPropertyMetadata(Brushes.Transparent));

        public event RoutedEventHandler Click;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }
}
