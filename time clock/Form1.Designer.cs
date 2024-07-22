namespace time_clock
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
            components = new System.ComponentModel.Container();
            clock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.Location = new Point(118, 75);
            clock.Name = "clock";
            clock.Size = new Size(50, 20);
            clock.TabIndex = 0;
            clock.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(118, 142);
            button1.Name = "button1";
            button1.Size = new Size(132, 58);
            button1.TabIndex = 1;
            button1.Text = "Click to mark";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(342, 54);
            listBox.Name = "listBox";
            listBox.Size = new Size(298, 184);
            listBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 301);
            Controls.Add(listBox);
            Controls.Add(button1);
            Controls.Add(clock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clock;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private ListBox listBox;
    }
}
