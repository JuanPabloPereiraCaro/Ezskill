using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using InputManager;

namespace InputManager_Library_Example2
{
    public partial class MainDisplay : Form
    {
        public MainDisplay()
        {
            InitializeComponent();
        }

        private void WriteExampleText_Click(object sender, EventArgs e)
        {
            ExampleText.Focus(); //Sets focus on the example text

            //Writing Hello with keys sending
            Keyboard.KeyDown(Keys.H);
            Keyboard.KeyUp(Keys.H);

            Keyboard.KeyDown(Keys.E);
            Keyboard.KeyUp(Keys.E);

            Keyboard.KeyDown(Keys.L);
            Keyboard.KeyUp(Keys.L);

            Keyboard.KeyDown(Keys.L);
            Keyboard.KeyUp(Keys.L);

            Keyboard.KeyDown(Keys.O);
            Keyboard.KeyUp(Keys.O);

        }

        private void SelectText_Click(object sender, EventArgs e)
        {
            //Moves the mouse to the example textbox
            Mouse.Move(ExampleTextArea().X, ExampleTextArea().Y);
            //Clicks on the left mouse button twice to select all text
            Mouse.PressButton(Mouse.MouseKeys.Left);
            Mouse.PressButton(Mouse.MouseKeys.Left);
        }

        private void RightClickText_Click(object sender, EventArgs e)
        {
            //Moves the mouse to the example textbox
            Mouse.Move(ExampleTextArea().X, ExampleTextArea().Y);

            Mouse.PressButton(Mouse.MouseKeys.Right);
        }

        private Point ExampleTextArea()
        {
            //Gets an empty area of the textbox
            return new Point(this.Location.X + ExampleText.Location.X + 25, this.Location.Y + ExampleText.Location.Y + 50);
        }

        private void SelectAllKeyboard_Click(object sender, EventArgs e)
        {
            ExampleText.Focus(); //Sets focus on the example textbox

            //Sends Shift + Control + Left to select a word
            Keys[] keys = new Keys[] { Keys.RShiftKey, Keys.RControlKey, Keys.Left };
            Keyboard.ShortcutKeys(keys);
        }
    }
}
