namespace Weather
{
    partial class GraphicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicForm));
            this.zgTemperatur = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zgTemperatur
            // 
            this.zgTemperatur.IsShowPointValues = false;
            this.zgTemperatur.Location = new System.Drawing.Point(9, 10);
            this.zgTemperatur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zgTemperatur.Name = "zgTemperatur";
            this.zgTemperatur.PointValueFormat = "G";
            this.zgTemperatur.Size = new System.Drawing.Size(794, 392);
            this.zgTemperatur.TabIndex = 0;
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 411);
            this.Controls.Add(this.zgTemperatur);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "GraphicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.ResumeLayout(false);

        }

        #endregion

        public ZedGraph.ZedGraphControl zgTemperatur;
    }
}