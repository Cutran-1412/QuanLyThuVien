using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Quanlythuvien
{
    public partial class MainHub : Form
    {
        // Import DLL cho hiệu ứng shadow và bo góc
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private Panel sidePanel;
        private Panel mainPanel;
        private Panel topPanel;
        private Label timeLabel;
        private Label dateLabel;
        private System.Windows.Forms.Timer clockTimer;
        private Button maximizeButton;
        private Size normalSize;
        private Point normalLocation;

        public MainHub()
        {
            InitializeComponent();
            InitializeModernUI();
            SetupTimer();
        }

        private void InitializeModernUI()
        {
            // Cấu hình form cơ bản
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White; // Nền chính màu trắng
            this.DoubleBuffered = true;

            // Lưu kích thước và vị trí ban đầu
            normalSize = this.Size;
            normalLocation = this.Location;

            // Tạo shadow effect
            CreateShadowEffect();

            // Tạo layout chính
            CreateLayout();

            // Tạo sidebar
            CreateSidebar();

            // Tạo main content
            CreateMainContent();

            // Tạo top bar
            CreateTopBar();
        }

        private void CreateShadowEffect()
        {
            // Tạo hiệu ứng shadow cho form
            var margins = new MARGINS()
            {
                bottomHeight = 1,
                leftWidth = 1,
                rightWidth = 1,
                topHeight = 1
            };

            DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        }

        private void CreateLayout()
        {
            // Side Panel (Menu bên trái) - màu xanh nước biển
            sidePanel = new Panel()
            {
                Dock = DockStyle.Left,
                Width = 250,
                BackColor = Color.FromArgb(0, 128, 128), // Teal/xanh nước biển
                Padding = new Padding(0, 60, 0, 0) // Để chỗ cho top bar
            };

            // Main Panel (Nội dung chính) - màu trắng
            mainPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(0, 60, 0, 0) // Để chỗ cho top bar
            };

            // Top Panel (Thanh trên cùng) - màu xanh nước biển nhạt hơn
            topPanel = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(240, 248, 248) // Trắng với chút xanh
            };

            this.Controls.Add(mainPanel);
            this.Controls.Add(sidePanel);
            this.Controls.Add(topPanel);
        }

        private void CreateTopBar()
        {
            var groupLabel = new Label()
            {
                Text = "Nhóm 2 - Đồ án 1",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 128, 128), // Màu xanh nước biển giống title
                AutoSize = true,
                Location = new Point(20, 15), // Cách lề trái 20px, căn giữa theo chiều cao
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            // Nút close, minimize, maximize
            var closeButton = CreateTopButton("✕", Color.FromArgb(220, 53, 69)); // Đỏ nhạt
            closeButton.Location = new Point(this.Width - 50, 15);
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.Click += (s, e) => this.Close();

            var maximizeButton = CreateTopButton("□", Color.FromArgb(40, 167, 69)); // Xanh lá nhạt
            maximizeButton.Location = new Point(this.Width - 100, 15);
            maximizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximizeButton.Click += (s, e) => ToggleMaximize();
            this.maximizeButton = maximizeButton; // Lưu reference để thay đổi icon

            var minimizeButton = CreateTopButton("−", Color.FromArgb(23, 162, 184)); // Xanh dương nhạt
            minimizeButton.Location = new Point(this.Width - 150, 15);
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeButton.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            topPanel.Controls.AddRange(new Control[] { groupLabel, closeButton, maximizeButton, minimizeButton });
        }

        private Button CreateTopButton(string text, Color backColor)
        {
            var button = new Button()
            {
                Text = text,
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = backColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(backColor.A,
                Math.Min(255, backColor.R + 30),
                Math.Min(255, backColor.G + 30),
                Math.Min(255, backColor.B + 30));

            return button;
        }

        private void CreateSidebar()
        {
            var menuItems = new[]
            {
            new { Icon = "🏠", Text = "Home", IsActive = true },
            new { Icon = "📊", Text = "Quản lý sách", IsActive = false },
            new { Icon = "📋", Text = "Quản lý mượn - trả", IsActive = false },
            new { Icon = "📦", Text = "Quản lý độc giả", IsActive = false },
            new { Icon = "👥", Text = "Báo cáo thống kê", IsActive = false }
        };

            int yPosition = 20;

            foreach (var item in menuItems)
            {
                var menuButton = CreateMenuButton(item.Icon, item.Text, item.IsActive);
                menuButton.Location = new Point(0, yPosition);

                // Thêm event click cho từng menu item
                menuButton.Click += (sender, e) => OnMenuItemClick(item.Text);

                sidePanel.Controls.Add(menuButton);
                yPosition += 50;
            }
        }

        private Button CreateMenuButton(string icon, string text, bool isActive)
        {
            var button = new Button()
            {
                Size = new Size(250, 45),
                FlatStyle = FlatStyle.Flat,
                BackColor = isActive ? Color.FromArgb(0, 100, 100) : Color.Transparent, // Xanh đậm hơn cho active
                ForeColor = Color.White, // Chữ trắng cho sidebar
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0),
                Text = $"{icon}  {text}",
                Cursor = Cursors.Hand
            };

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 100); // Hover màu xanh đậm

            // Thêm border trái cho item active
            if (isActive)
            {
                button.Paint += (s, e) =>
                {
                    using (var brush = new SolidBrush(Color.White)) // Border trắng
                    {
                        e.Graphics.FillRectangle(brush, 0, 0, 4, button.Height);
                    }
                };
            }

            return button;
        }

        private void CreateMainContent()
        {
            // Panel chứa tiêu đề và đồng hồ ở giữa
            var centerPanel = new Panel()
            {
                Size = new Size(500, 280),
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.None
            };

            // Tính toán vị trí center
            centerPanel.Location = new Point(
                (mainPanel.Width - centerPanel.Width) / 2,
                (mainPanel.Height - centerPanel.Height) / 2);

            // Tiêu đề QUẢN LÝ THƯ VIỆN
            var titleLabel = new Label()
            {
                Text = "QUẢN LÝ THƯ VIỆN",
                Font = new Font("Segoe UI", 27, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 128, 128), // Màu xanh nước biển
                AutoSize = true,
                Location = new Point(5, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Đồng hồ - chữ màu xám
            timeLabel = new Label()
            {
                Font = new Font("Segoe UI", 48, FontStyle.Bold),
                ForeColor = Color.FromArgb(108, 117, 125), // Màu xám
                AutoSize = true,
                Location = new Point(50, 100),
                TextAlign = ContentAlignment.MiddleCenter
            };

            dateLabel = new Label()
            {
                Font = new Font("Segoe UI", 16),
                ForeColor = Color.FromArgb(134, 142, 150), // Màu xám nhạt hơn
                AutoSize = true,
                Location = new Point(80, 200),
                TextAlign = ContentAlignment.MiddleCenter
            };

            centerPanel.Controls.AddRange(new Control[] { titleLabel, timeLabel, dateLabel });

            mainPanel.Controls.Add(centerPanel);
        }

        private void SetupTimer()
        {
            clockTimer = new System.Windows.Forms.Timer()
            {
                Interval = 1000,
                Enabled = true
            };

            clockTimer.Tick += (s, e) => UpdateTime();
            UpdateTime(); // Cập nhật ngay lập tức
        }

        private void UpdateTime()
        {
            var now = DateTime.Now;
            timeLabel.Text = now.ToString("HH:mm:ss");
            dateLabel.Text = now.ToString("dddd, MMMM dd, yyyy");

            // Đảm bảo dateLabel luôn hiển thị và căn giữa
            dateLabel.Left = timeLabel.Left + (timeLabel.Width - dateLabel.Width) / 2;
        }

        private void ToggleMaximize()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Restore to normal size
                this.WindowState = FormWindowState.Normal;
                this.Size = normalSize;
                this.Location = normalLocation;
                maximizeButton.Text = "□";

                // Thêm lại bo góc
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
            else
            {
                // Lưu vị trí và kích thước hiện tại trước khi maximize
                if (this.WindowState == FormWindowState.Normal)
                {
                    normalSize = this.Size;
                    normalLocation = this.Location;
                }

                // Maximize
                this.Region = null; // Xóa bo góc khi full screen
                this.WindowState = FormWindowState.Maximized;
                maximizeButton.Text = "❐";
            }
        }

        // Cho phép di chuyển form bằng cách kéo
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTCAPTION = 2;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if ((int)m.Result == HTCLIENT)
                    m.Result = (IntPtr)HTCAPTION;
                return;
            }
            base.WndProc(ref m);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Không set WindowState.Maximized nữa

            // Thêm bo góc cho form
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        // Event handler cho các menu item
        private void OnMenuItemClick(string menuName)
        {
            switch (menuName)
            {
                case "Home":
                    ShowHomePage();
                    break;
                case "Quản lý sách":
                    ShowBookMag();
                    break;
                case "Quản lý mượn - trả":
                    ShowBorrowMag();
                    break;
                case "Quản lý độc giả":
                    ShowAuthorMag();
                    break;
                case "Báo cáo thống kê":
                    ShowStatistical();
                    break;
            }
        }

        // Các function xử lý cho từng menu
        private void ShowHomePage()
        {
            MessageBox.Show("Đang hiển thị trang Home", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Code xử lý hiển thị trang Home
        }
        private void ShowBookMag()
        {
            MessageBox.Show("Đang hiển thị trang quản lý sách", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Code xử lý hiển thị trang Home
        }
        private void ShowBorrowMag()
        {
            MessageBox.Show("Đang hiển thị trang quản lý mượn - trả", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Code xử lý hiển thị trang Home
        }
        private void ShowAuthorMag()
        {
            MessageBox.Show("Đang hiển thị trang quản lý độc giả", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Code xử lý hiển thị trang Home
        }
        private void ShowStatistical()
        {
            MessageBox.Show("Đang hiển thị trang báo cáo thống kê", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Code xử lý hiển thị trang Home
        }
    }
}