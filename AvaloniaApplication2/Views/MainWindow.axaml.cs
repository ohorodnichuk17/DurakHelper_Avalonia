using System;
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
    private readonly List<string> _initialImagePaths = new List<string> 
    {
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/c9.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/крести_10.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/крести_j.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/крести_q.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/крести_k.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/крести_а.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/буби_9.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/буби_10.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/буби_j.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/буби_q.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/буби_k.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/буби_а.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/пики_9.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/пики_10.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/пики_j.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/пики_q.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/пики_k.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/пики_а.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/чирви_9.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/чирви_10.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/чирви_j.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/чирви_q.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/чирви_k.png",
        "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/черви_а.png"
    };

    public MainWindow()
    {
        InitializeComponent();
        InitializeImages();
        
        var reloadButton = this.FindControl<Button>("ReloadButton");
        if (reloadButton != null) reloadButton.Click += ReloadButton_Click;
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
        
        for (int i = 0; i < _images.Count; i++)
        {
            _initialImagePaths.Add(_images[i].Source.ToString());
        }
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button && int.TryParse(button.Tag?.ToString(), out int index))
        {
            if (index >= 0 && index < _images.Count)
            {
                SetImageSource(_images[index], "/Users/PC10/RiderProjects/Durak Helper/AvaloniaApplication2/Assets/Images/cross.png");
            }
        }
    }  
    
    private void ReloadButton_Click(object sender, RoutedEventArgs e)
    {
        for (int i = 0; i < _images.Count; i++)
        {
            SetImageSource(_images[i], _initialImagePaths[i]);
        }
    }
    
    private void SetImageSource(Image image, string imagePath)
    {
        if (image != null)
        {
            try
            {
                Console.WriteLine($"Loading image: {imagePath}");
                image.Source = new Bitmap(imagePath);
                Console.WriteLine($"Image loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
        }
    }
}