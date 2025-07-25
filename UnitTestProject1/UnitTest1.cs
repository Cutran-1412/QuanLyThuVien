using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private static WindowsDriver<WindowsElement> mainSession;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            var sesison = GetSession();
            Login(sesison);
            mainSession = GetMainFormSession();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            mainSession?.Quit();
        }
        [TestMethod]
        public void TestBorrow1()
        {

            var btnMuontra = mainSession.FindElementByAccessibilityId("ibtnmuontra");
            btnMuontra.Click();
            Thread.Sleep(1000);
            var btnBorrow = mainSession.FindElementByAccessibilityId("ibtnmuon");
            btnBorrow.Click(); Thread.Sleep(1000);
            var btnTao = mainSession.FindElementByAccessibilityId("gbtnTaoPhieuMuon");
            btnTao.Click(); Thread.Sleep(1000);
            // dociga
            var gcboMaDG = mainSession.FindElementByAccessibilityId("gcboMaDG");
            gcboMaDG.Click(); Thread.Sleep(1000);
            var dg01 = mainSession.FindElementByName("DG003");
            dg01.Click();
            Thread.Sleep(1000);
            //sach
            var gcboMaSach = mainSession.FindElementByAccessibilityId("gcboMaSach");
            gcboMaSach.Click();
            var S001 = mainSession.FindElementByName("S001");
            S001.Click();
            Thread.Sleep(1000);
            //soluong
            var txtSL = mainSession.FindElementByAccessibilityId("gtxtSoLuongMuon");
            txtSL.Click();
            txtSL.SendKeys("1");
            Thread.Sleep(1000);
            //them
            var btnThemSach = mainSession.FindElementByAccessibilityId("gbtnThemSach");
            btnThemSach.Click();
            Thread.Sleep(3000);
            //luu 
            var btnLuu = mainSession.FindElementByAccessibilityId("gbtnLuu");
            btnLuu.Click();

            IsBorrow1Pass();
        }
        [TestMethod]
        public void TestBorrow2()
        {
            Thread.Sleep(3000);
            var btnTao = mainSession.FindElementByAccessibilityId("gbtnTaoPhieuMuon");
            btnTao.Click(); Thread.Sleep(1000);
         
            //sach
            var gcboMaSach = mainSession.FindElementByAccessibilityId("gcboMaSach");
            gcboMaSach.Click();
            var S001 = mainSession.FindElementByName("S001");
            S001.Click();
            Thread.Sleep(1000);
            //soluong
            var txtSL = mainSession.FindElementByAccessibilityId("gtxtSoLuongMuon");
            txtSL.Click();
            txtSL.SendKeys("1");
            Thread.Sleep(2000);
            //them
            var btnThemSach = mainSession.FindElementByAccessibilityId("gbtnThemSach");
            btnThemSach.Click();
            Thread.Sleep(1000);
            //luu 
            var btnLuu = mainSession.FindElementByAccessibilityId("gbtnLuu");
            btnLuu.Click();

            IsBorrow2Pass();
        }
        [TestMethod]
        public void TestBorrow3()
        {
            Thread.Sleep(3000);
            var btnBorrow = mainSession.FindElementByAccessibilityId("ibtnmuon");
            btnBorrow.Click(); Thread.Sleep(1000);
            var btnTao = mainSession.FindElementByAccessibilityId("gbtnTaoPhieuMuon");
            btnTao.Click(); Thread.Sleep(1000);
            // dociga
            var gcboMaDG = mainSession.FindElementByAccessibilityId("gcboMaDG");
            gcboMaDG.Click(); Thread.Sleep(1000);
            var dg01 = mainSession.FindElementByName("DG003");
            dg01.Click();
            Thread.Sleep(1000);
            //sach
            var gcboMaSach = mainSession.FindElementByAccessibilityId("gcboMaSach");
            gcboMaSach.Click();
            var S001 = mainSession.FindElementByName("S001");
            S001.Click();
            Thread.Sleep(1000);
            //soluong
            var txtSL = mainSession.FindElementByAccessibilityId("gtxtSoLuongMuon");
            txtSL.Click();
            txtSL.SendKeys("1");
            Thread.Sleep(2000);
   
            //luu 
            var btnLuu = mainSession.FindElementByAccessibilityId("gbtnLuu");
            btnLuu.Click();

            IsBorrow3Pass();
        }
        public void IsBorrow1Pass()
        {
            // 1. Tạo session desktop
            var desktopOpts = new DesiredCapabilities();
            desktopOpts.SetCapability("app", "Root");
            var desktopSession = new WindowsDriver<WindowsElement>(
                new Uri("http://127.0.0.1:4723"), desktopOpts);

            // 2. Tìm cửa sổ chính theo tên
            var mainWindow = desktopSession.FindElementByName("Đã thêm phiếu mượn thành công");
          
            Assert.IsNotNull(mainWindow);
            Thread.Sleep(2000);
            var okbtn = desktopSession.FindElementByName("OK");
            okbtn.Click();
        }
        public void IsBorrow2Pass()
        {
            // 1. Tạo session desktop
            var desktopOpts = new DesiredCapabilities();
            desktopOpts.SetCapability("app", "Root");
            var desktopSession = new WindowsDriver<WindowsElement>(
                new Uri("http://127.0.0.1:4723"), desktopOpts);

            // 2. Tìm cửa sổ chính theo tên (dùng Inspect.exe để lấy tên form chính)
            var mainWindow = desktopSession.FindElementByName("Vui lòng chọn mã độc giả");
            Thread.Sleep(2000);
            var okbtn = desktopSession.FindElementByName("OK");
            okbtn.Click();
            Assert.IsNotNull(mainWindow);
        }
        public void IsBorrow3Pass()
        {
            // 1. Tạo session desktop
            var desktopOpts = new DesiredCapabilities();
            desktopOpts.SetCapability("app", "Root");
            var desktopSession = new WindowsDriver<WindowsElement>(
                new Uri("http://127.0.0.1:4723"), desktopOpts);

            // 2. Tìm cửa sổ chính theo tên (dùng Inspect.exe để lấy tên form chính)
            var mainWindow = desktopSession.FindElementByName("Chưa có sách nào được chọn");
            Thread.Sleep(2000);
            var okbtn = desktopSession.FindElementByName("OK");
            okbtn.Click();
            Assert.IsNotNull(mainWindow);
        }
        public static void Login(WindowsDriver<WindowsElement> session)
        {

            var user = session.FindElementByAccessibilityId("gtxtUsername");
            var pass = session.FindElementByAccessibilityId("gtxtPassword");
            var btnLog = session.FindElementByAccessibilityId("gbtndangnhap");
            user.Click();
            Thread.Sleep(100);
            user.SendKeys("Admin1");
            Thread.Sleep(100);
            pass.Click();

            pass.SendKeys("2004");
            Thread.Sleep(100);
            btnLog.Click();
            Thread.Sleep(1000);
            var okbtn = session.FindElementByName("OK");
            okbtn.Click();
        }
        public static  WindowsDriver<WindowsElement> GetSession()
        {
            try
            {
                DesiredCapabilities cap = new DesiredCapabilities();
                cap.SetCapability("app", @"D:\University\hoc ki phu\do an 1\QuanLyThuVien\Quanlythuvien\bin\Debug\net6.0-windows\Quanlythuvien.exe");
                WindowsDriver<WindowsElement> session =
                    new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), cap);

                Console.WriteLine("Kết nối thành công đến WinAppDriver!");

                return session;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            return null;
        }
        static WindowsDriver<WindowsElement> GetMainFormSession()
        {
            try
            {
                // 1. Tạo session desktop
                var desktopOpts = new DesiredCapabilities();
                desktopOpts.SetCapability("app", "Root");
                var desktopSession = new WindowsDriver<WindowsElement>(
                    new Uri("http://127.0.0.1:4723"), desktopOpts);

                // 2. Tìm cửa sổ chính theo tên (dùng Inspect.exe để lấy tên form chính)
                var mainWindow = desktopSession.FindElementByName("frmMain");

                // 3. Lấy handle và convert sang hex
                string mainHandle = int.Parse(mainWindow.GetAttribute("NativeWindowHandle")).ToString("x");

                // 4. Attach session mới vào cửa sổ chính
                var mainOpts = new DesiredCapabilities();
                mainOpts.SetCapability("appTopLevelWindow", mainHandle);
                var mainSession = new WindowsDriver<WindowsElement>(
                    new Uri("http://127.0.0.1:4723"), mainOpts);

                Console.WriteLine("Đã attach vào form chính!");
                return mainSession;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi attach main form: {ex.Message}");
                return null;
            }
        }
    }
}
