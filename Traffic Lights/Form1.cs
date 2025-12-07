using static Traffic_Lights.ctrlTrafficLight;
namespace Traffic_Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        void ShowColorMBox(string PrevColor, string NextColor, string CurrentColor, int CurrentColorCount)
        {
            MessageBox.Show(
                $"PrevColor:{PrevColor}\n" +
                $"NextColor:{NextColor}\n" +
                $"CurrentColor:{CurrentColor}\n" +
                $"CurrentColorCount:{CurrentColorCount}",
                "Color Details", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTrafficLight1.TimerStart();

        }

        private void ctrlTrafficLights1_OnColorChanged_1(object sender, TrafficLightEventArgs e)
        {
            ShowColorMBox(e.PrevColor, e.NextColor, e.CurrentColor, e.ColorCount);
            switch (e.enCurrentColor)
            {
                case enTrafficColor.Green:
                    {
                        ctrlTrafficLights2.CurrentColor = enTrafficColor.Red;
                        break;
                    }
                case enTrafficColor.Red:
                    {
                        ctrlTrafficLights2.CurrentColor = enTrafficColor.Green;
                        break;
                    }
                case enTrafficColor.Orange:
                    {
                        ctrlTrafficLights2.CurrentColor = enTrafficColor.Orange;
                        break;
                    }
                default:
                    {
                        ctrlTrafficLights2.CurrentColor = enTrafficColor.Orange;
                        return;
                    }

            }
        }
    }
}
