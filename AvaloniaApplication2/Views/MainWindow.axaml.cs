using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;

namespace AvaloniaApplication2.Views;

public partial class MainWindow : Window
{
    private List<Image> _images = new List<Image>();
    public MainWindow()
    {
        InitializeComponent();
        InitializeImages();
    }
    
    private void InitializeImages()
    {
        _images.Add(this.FindControl<Image>("Button1Image"));
        _images.Add(this.FindControl<Image>("Button2Image"));
        _images.Add(this.FindControl<Image>("Button3Image"));
        _images.Add(this.FindControl<Image>("Button4Image"));
        _images.Add(this.FindControl<Image>("Button5Image"));
        _images.Add(this.FindControl<Image>("Button6Image"));
        _images.Add(this.FindControl<Image>("Button7Image"));
        _images.Add(this.FindControl<Image>("Button8Image"));
        _images.Add(this.FindControl<Image>("Button9Image"));
        _images.Add(this.FindControl<Image>("Button10Image"));
        _images.Add(this.FindControl<Image>("Button11Image"));
        _images.Add(this.FindControl<Image>("Button12Image"));
        _images.Add(this.FindControl<Image>("Button13Image"));
        _images.Add(this.FindControl<Image>("Button14Image"));
        _images.Add(this.FindControl<Image>("Button15Image"));
        _images.Add(this.FindControl<Image>("Button16Image"));
        _images.Add(this.FindControl<Image>("Button17Image"));
        _images.Add(this.FindControl<Image>("Button18Image"));
        _images.Add(this.FindControl<Image>("Button19Image"));
        _images.Add(this.FindControl<Image>("Button20Image"));
        _images.Add(this.FindControl<Image>("Button21Image"));
        _images.Add(this.FindControl<Image>("Button22Image"));
        _images.Add(this.FindControl<Image>("Button23Image"));
        _images.Add(this.FindControl<Image>("Button24Image"));
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        // _button1Image = this.FindControl<Image>("Button1Image");
        // _button2Image = this.FindControl<Image>("Button2Image");

    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button && int.TryParse(button.Tag?.ToString(), out int index))
        {
            if (index >= 0 && index < _images.Count)
            {
                SetImageSource(_images[index], "/Users/PC10/RiderProjects/AvaloniaApplication2/AvaloniaApplication2/Assets/Images/cross.png");
            }
        }
    }
    
    private void SetImageSource(Image image, string imagePath)
    {
        if (image != null)
        {
            image.Source = new Bitmap(imagePath);
        }
    }

    
    
}