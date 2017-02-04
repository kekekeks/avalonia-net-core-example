using System.IO;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace ControlCatalog.Pages
{
    public class ImagePage : UserControl
    {
        private Image iconImage;
        public ImagePage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            iconImage = this.Get<Image>("Icon");
        }

        protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnAttachedToVisualTree(e);
            if (iconImage.Source == null)
            {
                if (AvaloniaLocator.Current.GetService<IRuntimePlatform>().GetRuntimeInfo().OperatingSystem
                        == OperatingSystemType.WinNT)
                    //Not implemented yet
                    return;
                var windowRoot = e.Root as Window;
                if (windowRoot != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        windowRoot.Icon.Save(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        iconImage.Source = new Bitmap(stream);
                    }
                }
            }
        }
    }
}
