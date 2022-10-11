namespace Trucos_MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        // Indicar el tamaño para la app de Windows.
        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
#if WINDOWS

                        // Asignar manualmente el tamaño. 
                        int winWidth = 1200;
                        int winHeight = 940;

                        var mauiWindow = handler.VirtualView;
                        var nativeWindow = handler.PlatformView;
                        nativeWindow.Activate();
                        IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
                        var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
                        var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
                        appWindow.Resize(new Windows.Graphics.SizeInt32(winWidth, winHeight));

                        // get screen size
                        DisplayInfo disp = DeviceDisplay.Current.MainDisplayInfo;
                        double x, y;

                        // dispatcher is used to give the window time to actually resize
                        Dispatcher.Dispatch(() =>
                        {
                            disp = DeviceDisplay.Current.MainDisplayInfo;
                            x = (disp.Width / disp.Density - winWidth) / 2;
                            if (x < 0) 
                            {
                                x = 0;
                            }
                            y = (disp.Height / disp.Density - winHeight) / 2;
                            if (y < 0)
                            {
                                y = 0;
                            }
                            appWindow.Move(new Windows.Graphics.PointInt32((int)x, (int)y));

                            // Si cambiamos la posición, esto hay que hacerlo en el Dispatcher.Dispatch
                            // El título hay que asignarlo antes de asignar los colores.
                            appWindow.Title = "Trucos MAUI by elGuille";
                            // Este es el color que tiene en mi equipo la barra de título.
                            appWindow.TitleBar.BackgroundColor = Microsoft.UI.ColorHelper.FromArgb(255, 0, 120, 212);
                            appWindow.TitleBar.ForegroundColor = Microsoft.UI.Colors.White;
                        });

#endif
        });


        MainPage = new AppShell();
	}

    // Truco 5
    //        // Indicar el tamaño para la app de Windows.
    //        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
    //        {
    //#if WINDOWS

    //                // Asignar manualmente el tamaño. 
    //                int winWidth = 1000;
    //                int winHeight = 900;

    //                var mauiWindow = handler.VirtualView;
    //                var nativeWindow = handler.PlatformView;
    //                nativeWindow.Activate();
    //                IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
    //                var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
    //                var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
    //                appWindow.Resize(new Windows.Graphics.SizeInt32(winWidth, winHeight));

    //#endif
    //        });

    // Truco 6
    //        // Indicar el tamaño para la app de Windows.
    //        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
    //        {
    //#if WINDOWS

    //                        // Asignar manualmente el tamaño. 
    //                        int winWidth = 1200;
    //                        int winHeight = 940;

    //                        var mauiWindow = handler.VirtualView;
    //                        var nativeWindow = handler.PlatformView;
    //                        nativeWindow.Activate();
    //                        IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
    //                        var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
    //                        var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
    //                        appWindow.Resize(new Windows.Graphics.SizeInt32(winWidth, winHeight));

    //                        // El título hay que asignarlo antes de asignar los colores.
    //                        appWindow.Title = "Trucos MAUI by elGuille";
    //                        // Este es el color que tiene en mi equipo la barra de título.
    //                        appWindow.TitleBar.BackgroundColor = Microsoft.UI.ColorHelper.FromArgb(255, 0, 120, 212);
    //                        appWindow.TitleBar.ForegroundColor = Microsoft.UI.Colors.White;

    //#endif
    //        });

    // Truco 7
    //        // Indicar el tamaño para la app de Windows.
    //        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
    //        {
    //#if WINDOWS

    //                // Asignar manualmente el tamaño. 
    //                int winWidth = 1200;
    //                int winHeight = 940;

    //                var mauiWindow = handler.VirtualView;
    //                var nativeWindow = handler.PlatformView;
    //                nativeWindow.Activate();
    //                IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
    //                var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
    //                var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
    //                appWindow.Resize(new Windows.Graphics.SizeInt32(winWidth, winHeight));
    //                // Posicionarlo manualmente. (11/oct/22 11.35)
    //                //appWindow.Move(new Windows.Graphics.PointInt32(1200 - winWidth / 2, 100));
    //                //appWindow.Move(new Windows.Graphics.PointInt32(0, 0));
    //                //appWindow.Title = "Crear Clases Tablas (MAUI)";

    //                // get screen size
    //                DisplayInfo disp = DeviceDisplay.Current.MainDisplayInfo;
    //                double x, y;

    //                // dispatcher is used to give the window time to actually resize
    //                Dispatcher.Dispatch(() =>
    //                {
    //                    disp = DeviceDisplay.Current.MainDisplayInfo;
    //                    x = (disp.Width / disp.Density - winWidth) / 2;
    //                    if (x < 0) 
    //                    {
    //                        x = 0;
    //                    }
    //                    y = (disp.Height / disp.Density - winHeight) / 2;
    //                    if (y < 0)
    //                    {
    //                        y = 0;
    //                    }
    //                    appWindow.Move(new Windows.Graphics.PointInt32((int)x, (int)y));
    //                    // El título hay que asignarlo antes de asignar los colores.
    //                    appWindow.Title = "Trucos MAUI";
    //                    // Este es el color que tiene en mi equipo la barra de título.
    //                    appWindow.TitleBar.BackgroundColor = Microsoft.UI.ColorHelper.FromArgb(255, 0, 120, 212);
    //                    appWindow.TitleBar.ForegroundColor = Microsoft.UI.Colors.White;
    //                });

    //#endif
    //        });

}
