namespace _20150_03_04_Wetter
{
    partial class frmTemperatur
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zgTemperatur = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zgTemperatur
            // 
            this.zgTemperatur.IsShowPointValues = false;
            this.zgTemperatur.Location = new System.Drawing.Point(12, 12);
            this.zgTemperatur.Name = "zgTemperatur";
            this.zgTemperatur.PointValueFormat = "G";
            this.zgTemperatur.Size = new System.Drawing.Size(1059, 482);
            this.zgTemperatur.TabIndex = 0;
            // 
            // frmTemperatur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 506);
            this.Controls.Add(this.zgTemperatur);
            this.Name = "frmTemperatur";
            this.Text = "Temperatur";
            this.ResumeLayout(false);

        }

        #endregion

        public ZedGraph.ZedGraphControl zgTemperatur;
    }
}