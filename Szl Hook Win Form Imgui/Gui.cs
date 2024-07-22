using GuiStyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using ClickableTransparentOverlay;
using WindowsInput;
using WindowsInput.Native;

namespace Gui
{
    public class Renderer : Overlay
    {
        

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vkey);


        InputSimulator inputSimulator = new InputSimulator();



        protected override void Render()
        {
            StyleGui styleGui = new StyleGui();
            styleGui.styleGui();
            ImGui.Begin("Window");





            ImGui.End();
            FunctionLoop();
        }



        void FunctionLoop()
        {
            
            


        }
    }
}
