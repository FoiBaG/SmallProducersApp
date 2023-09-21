using System;
using System.Windows.Forms;


namespace SmallProducersApp
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
            Screen primaryScreen = Screen.PrimaryScreen;


            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            //int screenWidth = primaryScreen.Bounds.Width;
            //int screenHeight = primaryScreen.Bounds.Height ;
            //StartPosition = FormStartPosition.Manual;
            ClientSize = new Size(400, 800);
            //Location = new Point(0, 0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }
        #endregion
    }
}