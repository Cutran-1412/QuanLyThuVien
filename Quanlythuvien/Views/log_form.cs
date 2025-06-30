using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Quanlythuvien
{
    public partial class log_form : Form
    {
        private Panel mainPanel;
        private Label titleLabel;
        private Panel userPanel;
        private PictureBox userIcon;
        private TextBox userTextBox;
        private Panel passwordPanel;
        private PictureBox passwordIcon;
        private TextBox passwordTextBox;
        private PictureBox togglePasswordIcon;
        private Button loginButton;
        private Button closeButton;
        private bool passwordVisible = false;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // API để bo tròn góc
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public log_form()
        {
            InitializeComponent();
            SetupCustomControls();
        }

        private void SetupCustomControls()
        {
            this.SuspendLayout();

            // Form settings
            this.Text = "";
            this.Size = new Size(450, 380);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(25, 25, 30);

            // Bo tròn góc form
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Thêm khả năng kéo thả form
            this.MouseDown += LogForm_MouseDown;
            this.MouseMove += LogForm_MouseMove;
            this.MouseUp += LogForm_MouseUp;

            // Main panel với gradient background
            mainPanel = new Panel();
            mainPanel.Size = new Size(380, 320);
            mainPanel.Location = new Point((this.Width - mainPanel.Width) / 2, (this.Height - mainPanel.Height) / 2);
            mainPanel.Paint += MainPanel_Paint;
            this.Controls.Add(mainPanel);

            // Close button
            closeButton = new Button();
            closeButton.Text = "✕";
            closeButton.Size = new Size(30, 30);
            closeButton.Location = new Point(this.Width - 35, 5);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            closeButton.Cursor = Cursors.Hand;
            closeButton.ForeColor = Color.FromArgb(200, 200, 200); // Màu chữ mặc định
            closeButton.Click += CloseButton_Click;
            this.Controls.Add(closeButton);

            // Title
            titleLabel = new Label();
            titleLabel.Text = "Quản lý thư viện";
            titleLabel.Font = new Font(FontFamily.GenericSansSerif, 24, FontStyle.Regular);
            titleLabel.ForeColor = Color.White;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Size = new Size(400, 55);
            titleLabel.Location = new Point(30, 10);
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            mainPanel.Controls.Add(titleLabel);

            // Subtitle
            Label subtitleLabel = new Label();
            subtitleLabel.Text = "Vui lòng đăng nhập !";
            subtitleLabel.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular);
            subtitleLabel.ForeColor = Color.FromArgb(160, 160, 160);
            subtitleLabel.BackColor = Color.Transparent;
            subtitleLabel.Size = new Size(300, 25);
            subtitleLabel.Location = new Point(40, 65);
            subtitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            mainPanel.Controls.Add(subtitleLabel);

            // User panel
            userPanel = new Panel();
            userPanel.Size = new Size(300, 50);
            userPanel.Location = new Point(40, 110);
            userPanel.Paint += InputPanel_Paint;
            mainPanel.Controls.Add(userPanel);

            // User icon
            userIcon = new PictureBox();
            userIcon.Size = new Size(20, 20);
            userIcon.Location = new Point(15, 13);
            userIcon.BackColor = Color.Transparent;
            userIcon.Paint += (s, e) => DrawUserIcon(e.Graphics, userIcon.ClientRectangle);
            userPanel.Controls.Add(userIcon);

            // User textbox
            userTextBox = new TextBox();
            userTextBox.Size = new Size(240, 24);
            userTextBox.Location = new Point(50, 13);
            userTextBox.BorderStyle = BorderStyle.None;
            userTextBox.Font = new Font(FontFamily.GenericSansSerif, 11);
            userTextBox.Text = "Username";
            userTextBox.ForeColor = Color.FromArgb(120, 120, 120);
            userTextBox.BackColor = Color.FromArgb(45, 45, 55);
            userTextBox.Enter += UserTextBox_Enter;
            userTextBox.Leave += UserTextBox_Leave;
            userPanel.Controls.Add(userTextBox);

            // Password panel
            passwordPanel = new Panel();
            passwordPanel.Size = new Size(300, 50);
            passwordPanel.Location = new Point(40, 180);
            passwordPanel.Paint += InputPanel_Paint;
            mainPanel.Controls.Add(passwordPanel);

            // Password icon
            passwordIcon = new PictureBox();
            passwordIcon.Size = new Size(24, 24);
            passwordIcon.Location = new Point(15, 13);
            passwordIcon.BackColor = Color.Transparent;
            passwordIcon.Paint += (s, e) => DrawLockIcon(e.Graphics, passwordIcon.ClientRectangle);
            passwordPanel.Controls.Add(passwordIcon);

            // Password textbox
            passwordTextBox = new TextBox();
            passwordTextBox.Size = new Size(200, 24);
            passwordTextBox.Location = new Point(50, 13);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font(FontFamily.GenericSansSerif, 11);
            passwordTextBox.Text = "Password";
            passwordTextBox.ForeColor = Color.FromArgb(120, 120, 120);
            passwordTextBox.BackColor = Color.FromArgb(45, 45, 55);
            passwordTextBox.UseSystemPasswordChar = false;
            passwordTextBox.Enter += PasswordTextBox_Enter;
            passwordTextBox.Leave += PasswordTextBox_Leave;
            passwordPanel.Controls.Add(passwordTextBox);

            // Toggle password visibility icon
            togglePasswordIcon = new PictureBox();
            togglePasswordIcon.Size = new Size(24, 24);
            togglePasswordIcon.Location = new Point(260, 13);
            togglePasswordIcon.BackColor = Color.Transparent;
            togglePasswordIcon.Cursor = Cursors.Hand;
            togglePasswordIcon.Paint += (s, e) => DrawEyeIcon(e.Graphics, togglePasswordIcon.ClientRectangle, passwordVisible);
            togglePasswordIcon.Click += TogglePasswordIcon_Click;
            passwordPanel.Controls.Add(togglePasswordIcon);

            // Login button
            loginButton = new Button();
            loginButton.Text = "ĐĂNG NHẬP";
            loginButton.Size = new Size(300, 45);
            loginButton.Location = new Point(40, 250);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            loginButton.Cursor = Cursors.Hand;
            loginButton.Click += LoginButton_Click;
            loginButton.Paint += LoginButton_Paint;
            loginButton.MouseEnter += LoginButton_MouseEnter;
            loginButton.MouseLeave += LoginButton_MouseLeave;
            mainPanel.Controls.Add(loginButt    on);

            this.ResumeLayout(false);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);

                // Gradient background
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel.ClientRectangle,
                    Color.FromArgb(40, 40, 50),
                    Color.FromArgb(30, 30, 40),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Subtle border
                using (Pen pen = new Pen(Color.FromArgb(60, 60, 70), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void InputPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 12;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(45, 45, 55)))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (Pen pen = new Pen(Color.FromArgb(65, 65, 75), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void LoginButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 12;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);

                // Gradient background
                Color startColor = btn.ClientRectangle.Contains(btn.PointToClient(MousePosition)) ?
                    Color.FromArgb(80, 150, 255) : Color.FromArgb(70, 130, 245);
                Color endColor = btn.ClientRectangle.Contains(btn.PointToClient(MousePosition)) ?
                    Color.FromArgb(50, 120, 225) : Color.FromArgb(40, 100, 215);

                using (LinearGradientBrush brush = new LinearGradientBrush(
                    btn.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Text
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(btn.Text, btn.Font, textBrush, btn.ClientRectangle, sf);
                }
            }
        }


        private void CloseButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            e.Graphics.Clear(Color.Transparent);

            // Chỉ vẽ text với màu cố định
            using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(200, 200, 200)))
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(btn.Text, btn.Font, textBrush, btn.ClientRectangle, sf);
            }
        }

        // Event handlers cho việc kéo thả form
        private void LogForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void LogForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void LogForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // Event handlers cho close button
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handlers cho login button
        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.Invalidate();
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.Invalidate();
        }

        private void UserTextBox_Enter(object sender, EventArgs e)
        {
            if (userTextBox.Text == "Username")
            {
                userTextBox.Text = "";
                userTextBox.ForeColor = Color.White;
            }
        }

        private void UserTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userTextBox.Text))
            {
                userTextBox.Text = "Username";
                userTextBox.ForeColor = Color.FromArgb(120, 120, 120);
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.White;
                if (!passwordVisible)
                    passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.FromArgb(120, 120, 120);
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void TogglePasswordIcon_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;

            if (passwordTextBox.Text != "Password")
            {
                passwordTextBox.UseSystemPasswordChar = !passwordVisible;
            }

            togglePasswordIcon.Invalidate();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = userTextBox.Text == "Username" ? "" : userTextBox.Text;
            string password = passwordTextBox.Text == "Password" ? "" : passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Đăng nhập với:\nUser: {user}\nPassword: {password}", "Thông tin đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DrawUserIcon(Graphics g, Rectangle rect)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.FromArgb(120, 120, 130), 2))
            {
                // Draw head
                g.DrawEllipse(pen, rect.X + 7, rect.Y + 3, 10, 10);
                // Draw body
                g.DrawArc(pen, rect.X + 2, rect.Y + 11, 20, 14, 0, 180);
            }
        }

        private void DrawLockIcon(Graphics g, Rectangle rect)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.FromArgb(120, 120, 130), 2))
            {
                // Draw lock body
                g.DrawRectangle(pen, rect.X + 6, rect.Y + 12, 12, 8);
                // Draw lock shackle
                g.DrawArc(pen, rect.X + 8, rect.Y + 5, 8, 10, 180, 180);
            }
        }

        private void DrawEyeIcon(Graphics g, Rectangle rect, bool visible)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.FromArgb(120, 120, 130), 1.5f))
            {
                if (visible)
                {
                    // Open eye
                    g.DrawEllipse(pen, rect.X + 4, rect.Y + 8, 16, 8);
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(120, 120, 130)))
                    {
                        g.FillEllipse(brush, rect.X + 10, rect.Y + 10, 4, 4);
                    }
                }
                else
                {
                    // Closed eye with line through it
                    g.DrawEllipse(pen, rect.X + 4, rect.Y + 8, 16, 8);
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(120, 120, 130)))
                    {
                        g.FillEllipse(brush, rect.X + 10, rect.Y + 10, 4, 4);
                    }
                    g.DrawLine(pen, rect.X + 4, rect.Y + 4, rect.X + 20, rect.Y + 20);
                }
            }
        }
    }
}