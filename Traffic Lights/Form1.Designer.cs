namespace Traffic_Lights
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlTrafficLight1 = new ctrlTrafficLight();
            ctrlTrafficLights2 = new ctrlTrafficLight();
            SuspendLayout();
            // 
            // ctrlTrafficLights1
            // 
            ctrlTrafficLight1.BackColor = Color.White;
            ctrlTrafficLight1.CurrentColor = ctrlTrafficLight.enTrafficColor.Red;
            ctrlTrafficLight1.GreenColorCount = 5;
            ctrlTrafficLight1.Location = new Point(261, 144);
            ctrlTrafficLight1.Name = "ctrlTrafficLights1";
            ctrlTrafficLight1.OrangeColorCount = 5;
            ctrlTrafficLight1.RedColorCount = 5;
            ctrlTrafficLight1.Size = new Size(100, 226);
            ctrlTrafficLight1.TabIndex = 0;
            ctrlTrafficLight1.OnColorChanged += ctrlTrafficLights1_OnColorChanged_1;
            // 
            // ctrlTrafficLights2
            // 
            ctrlTrafficLights2.BackColor = Color.White;
            ctrlTrafficLights2.CurrentColor = ctrlTrafficLight.enTrafficColor.Red;
            ctrlTrafficLights2.GreenColorCount = 5;
            ctrlTrafficLights2.Location = new Point(692, 144);
            ctrlTrafficLights2.Name = "ctrlTrafficLights2";
            ctrlTrafficLights2.OrangeColorCount = 5;
            ctrlTrafficLights2.RedColorCount = 5;
            ctrlTrafficLights2.Size = new Size(100, 226);
            ctrlTrafficLights2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 609);
            Controls.Add(ctrlTrafficLights2);
            Controls.Add(ctrlTrafficLight1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
        private ctrlTrafficLight ctrlTrafficLights2;
    }
}
