using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public class MyContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        private Thread showerThread = null; 

        public MyContext()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Exit", Exit)
            }),
                Visible = true
            };
            StartProgram();
        }

        private void StartProgram()
        {
            IPictureShower shower = new PictureShowerScheduled();
            shower.Ended += Exit;
            showerThread = new Thread(()=> shower.run());
            showerThread.Start();
        }

        void Exit()
        {
            Exit(null, null);
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            showerThread.Abort();

            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
