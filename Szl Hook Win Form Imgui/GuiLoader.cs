using Gui;

namespace Szl_Hook_Win_Form_Imgui
{
    public partial class GuiLoader : Form
    {
        public GuiLoader()
        {
            InitializeComponent();
        }

        private void GuiLoader_Load(object sender, EventArgs e)
        {
            Renderer renderer = new Renderer();
            renderer.Start();
            this.Close();
        }
    }
}
