namespace InputManager_Library_Example2
{
    partial class MainDisplay
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
            this.ExampleText = new System.Windows.Forms.TextBox();
            this.WriteExampleText = new System.Windows.Forms.Button();
            this.SelectText = new System.Windows.Forms.Button();
            this.RightClickText = new System.Windows.Forms.Button();
            this.SelectAllKeyboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExampleText
            // 
            this.ExampleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExampleText.Location = new System.Drawing.Point(0, 0);
            this.ExampleText.Multiline = true;
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(319, 288);
            this.ExampleText.TabIndex = 0;
            // 
            // WriteExampleText
            // 
            this.WriteExampleText.Location = new System.Drawing.Point(8, 311);
            this.WriteExampleText.Name = "WriteExampleText";
            this.WriteExampleText.Size = new System.Drawing.Size(122, 23);
            this.WriteExampleText.TabIndex = 1;
            this.WriteExampleText.Text = "Write example text";
            this.WriteExampleText.UseVisualStyleBackColor = true;
            this.WriteExampleText.Click += new System.EventHandler(this.WriteExampleText_Click);
            // 
            // SelectText
            // 
            this.SelectText.Location = new System.Drawing.Point(136, 363);
            this.SelectText.Name = "SelectText";
            this.SelectText.Size = new System.Drawing.Size(174, 23);
            this.SelectText.TabIndex = 2;
            this.SelectText.Text = "Select all text with the mouse";
            this.SelectText.UseVisualStyleBackColor = true;
            this.SelectText.Click += new System.EventHandler(this.SelectText_Click);
            // 
            // RightClickText
            // 
            this.RightClickText.Location = new System.Drawing.Point(8, 363);
            this.RightClickText.Name = "RightClickText";
            this.RightClickText.Size = new System.Drawing.Size(122, 23);
            this.RightClickText.TabIndex = 3;
            this.RightClickText.Text = "Right click on textbox";
            this.RightClickText.UseVisualStyleBackColor = true;
            this.RightClickText.Click += new System.EventHandler(this.RightClickText_Click);
            // 
            // SelectAllKeyboard
            // 
            this.SelectAllKeyboard.Location = new System.Drawing.Point(136, 311);
            this.SelectAllKeyboard.Name = "SelectAllKeyboard";
            this.SelectAllKeyboard.Size = new System.Drawing.Size(174, 23);
            this.SelectAllKeyboard.TabIndex = 4;
            this.SelectAllKeyboard.Text = "Select a word with the keyboard";
            this.SelectAllKeyboard.UseVisualStyleBackColor = true;
            this.SelectAllKeyboard.Click += new System.EventHandler(this.SelectAllKeyboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Keyboard:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mouse:";
            // 
            // MainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectAllKeyboard);
            this.Controls.Add(this.RightClickText);
            this.Controls.Add(this.SelectText);
            this.Controls.Add(this.WriteExampleText);
            this.Controls.Add(this.ExampleText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputManager Library - Sending messages example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExampleText;
        private System.Windows.Forms.Button WriteExampleText;
        private System.Windows.Forms.Button SelectText;
        private System.Windows.Forms.Button RightClickText;
        private System.Windows.Forms.Button SelectAllKeyboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

