using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using TreeViewTutorial.ViewModels;
using TreeViewTutorial.Views;

namespace TreeViewTutorial
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        public override void OnFrameworkInitializationCompleted()
        {
            var window = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = window;
            }
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleView)
            {
                throw new NotSupportedException("Only desktop applications are supported");
            }
            
            base.OnFrameworkInitializationCompleted();
        }

   }
}