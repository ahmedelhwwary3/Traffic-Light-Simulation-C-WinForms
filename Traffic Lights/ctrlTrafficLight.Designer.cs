 
using Traffic_Lights.Properties;

namespace Traffic_Lights
{
    partial class ctrlTrafficLight
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbTrafficColor = new PictureBox();
            lblCounter = new Label();
            TrafficLightTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbTrafficColor).BeginInit();
            SuspendLayout();
            // 
            // pbTrafficColor
            // 
            pbTrafficColor.Image = Resources.Green;
            pbTrafficColor.Location = new Point(3, 3);
            pbTrafficColor.Name = "pbTrafficColor";
            pbTrafficColor.Size = new Size(92, 193);
            pbTrafficColor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTrafficColor.TabIndex = 0;
            pbTrafficColor.TabStop = false;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCounter.ForeColor = Color.Red;
            lblCounter.Location = new Point(34, 209);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(0, 25);
            lblCounter.TabIndex = 1;
            // 
            // TrafficLightTimer
            // 
            TrafficLightTimer.Interval = 1000;
            TrafficLightTimer.Tick += TrafficLightTimer_Tick;
            // 
            // ctrlTrafficLights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblCounter);
            Controls.Add(pbTrafficColor);
            Name = "ctrlTrafficLights";
            Size = new Size(99, 255);
            ((System.ComponentModel.ISupportInitialize)pbTrafficColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbTrafficColor;
        private Label lblCounter;
        private System.Windows.Forms.Timer TrafficLightTimer;
    }
}
