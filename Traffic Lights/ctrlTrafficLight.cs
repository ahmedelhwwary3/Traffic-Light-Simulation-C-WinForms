 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Lights.Properties;



namespace Traffic_Lights
{

    public partial class ctrlTrafficLight : UserControl
    {
        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        public class TrafficLightEventArgs : EventArgs
        {
            public enTrafficColor enPrevColor { get; set; }
            public enTrafficColor enCurrentColor { get; set; }
            public enTrafficColor enNextColor { get; set; }
            public int ColorCount {  get; set; }
            string GetTrafficColorName(enTrafficColor color)
            => Enum.GetName(color)??"N/A";
            public string PrevColor => GetTrafficColorName(enPrevColor);
            public string CurrentColor => GetTrafficColorName(enCurrentColor);
            public string NextColor => GetTrafficColorName(enNextColor);
            public TrafficLightEventArgs(enTrafficColor prevColor, enTrafficColor currentColor, enTrafficColor nextColor,int colorCount)
            {
                enCurrentColor = currentColor;
                enNextColor = nextColor;
                ColorCount = colorCount;
                enPrevColor = prevColor;
            }
        }
 
        public enum enTrafficColor
        {
            Red, Orange, Green
        }
        private enTrafficColor _CurrentColor = enTrafficColor.Red;
        private enTrafficColor _NextColor = enTrafficColor.Green;
        private enTrafficColor _PrevColor = enTrafficColor.Orange;
        public enTrafficColor CurrentColor
        {
            get => _CurrentColor;
            set
            {
                _CurrentColor = value;
                switch (_CurrentColor)
                {
                    case enTrafficColor.Red:
                        {
                            pbTrafficColor.Image = Resources.Red;
                            _NextColor = enTrafficColor.Orange;
                            _CurrentColorCount = RedColorCount;
                            _PrevColor = enTrafficColor.Green;
                            lblCounter.ForeColor = Color.Red;
                            break;
                        }
                    case enTrafficColor.Orange:
                        {
                            pbTrafficColor.Image = Resources.Orange;
                            _NextColor = enTrafficColor.Green;
                            _CurrentColorCount = OrangeColorCount;
                            _PrevColor = enTrafficColor.Red;
                            lblCounter.ForeColor = Color.Orange;
                            break;
                        }
                    case enTrafficColor.Green:
                        {
                            pbTrafficColor.Image = Resources.Green;
                            _NextColor = enTrafficColor.Red;
                            _CurrentColorCount = GreenColorCount;
                            _PrevColor = enTrafficColor.Orange;
                            lblCounter.ForeColor = Color.Green;
                            break;
                        }
                    default:
                        pbTrafficColor.Image = Resources.Red;
                        return;
                }
            }

        }
        private int _RedColorCount = 5;
        private int _OrangeColorCount = 5;
        private int _GreenColorCount = 5;
        public int RedColorCount
        {
            get => _RedColorCount;
            set
            {
                if (value <= 0)
                    return;
                _RedColorCount = value;
            }
        }
        public int OrangeColorCount
        {
            get => _OrangeColorCount;
            set
            {
                if (value <= 0)
                    return;
                _OrangeColorCount = value;
            }
        }
        public int GreenColorCount
        {
            get => _GreenColorCount;
            set
            {
                if (value <= 0)
                    return;
                _GreenColorCount = value;
            }
        }
        private int _CurrentColorCount=5;
        public event EventHandler<TrafficLightEventArgs> OnColorChanged;
        protected virtual void RaiseOnColorChangedEvent(enTrafficColor PrevColor,enTrafficColor Current, enTrafficColor Next,int CurrentColorCount)
            => OnColorChanged?.Invoke(this, new TrafficLightEventArgs(PrevColor,Current, Next, CurrentColorCount));
        public void TimerStart()
        {
            TrafficLightTimer.Start();
            lblCounter.Text =_CurrentColorCount.ToString();
        }
        public void TimerStop()
        {
            TrafficLightTimer.Stop();
            lblCounter.Text = string.Empty;
        }

        private void TrafficLightTimer_Tick(object sender, EventArgs e)
        {
            if(_CurrentColorCount==0)
                ChangeColor();
            else
                _CurrentColorCount--;
            lblCounter.Text = _CurrentColorCount.ToString();
        }
        private void ChangeColor()
        {
            CurrentColor = _NextColor;
            RaiseOnColorChangedEvent(_PrevColor,_CurrentColor,_NextColor,_CurrentColorCount);
        }
    }
}
