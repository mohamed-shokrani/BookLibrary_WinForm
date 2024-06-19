using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomForm : Form
{
    private bool mouseDown;
    private Point lastLocation;

    public CustomForm()
    {
        InitializeForm();
    }

    private void InitializeForm()
    {
        // Customize form properties
        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.BackColor = Color.White; // Example background color

        // Add custom close button
        Button closeButton = new Button();
        closeButton.Text = "X";
        closeButton.Size = new Size(30, 30);
        closeButton.Location = new Point(this.Width - 30, 0);
        closeButton.Click += (sender, e) => this.Close();
        this.Controls.Add(closeButton);

        // Add custom maximize button (optional)
        Button maximizeButton = new Button();
        maximizeButton.Text = "□";
        maximizeButton.Size = new Size(30, 30);
        maximizeButton.Location = new Point(this.Width - 60, 0);
        maximizeButton.Click += (sender, e) => this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        this.Controls.Add(maximizeButton);

        // Add custom minimize button (optional)
        Button minimizeButton = new Button();
        minimizeButton.Text = "-";
        minimizeButton.Size = new Size(30, 30);
        minimizeButton.Location = new Point(this.Width - 90, 0);
        minimizeButton.Click += (sender, e) => this.WindowState = FormWindowState.Minimized;
        this.Controls.Add(minimizeButton);

        // Allow form to be moved by clicking and dragging the title bar
        Panel titleBar = new Panel();
        titleBar.Size = new Size(this.Width, 30);
        titleBar.Location = new Point(0, 0);
        titleBar.MouseDown += (sender, e) =>
        {
            mouseDown = true;
            lastLocation = e.Location;
        };
        titleBar.MouseMove += (sender, e) =>
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        };
        titleBar.MouseUp += (sender, e) =>
        {
            mouseDown = false;
        };
        this.Controls.Add(titleBar);
    }
}
