namespace 좀비고_보안_우회
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBypassOn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo pri = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process pro = new System.Diagnostics.Process();

            //실행할 파일 명 입력하기
            pri.FileName = "cmd.exe";

            //cmd 창 띄우기
            pri.CreateNoWindow = false;

            //flase가 띄우기, true가 안 띄우기
            pri.UseShellExecute = false;
            pri.RedirectStandardInput = true;
            pri.RedirectStandardOutput = true;
            pri.RedirectStandardError = true;
            pro.StartInfo = pri;
            pro.Start();

            pro.StandardInput.Write(@"adb devices" + Environment.NewLine);
            pro.StandardInput.Write(@"adb shell" + Environment.NewLine);
            pro.StandardInput.Write(@"mount -o remount r,w /system" + Environment.NewLine);
            pro.StandardInput.Write(@"mount -o remount r,w /data" + Environment.NewLine);
            pro.StandardInput.Write(@"cd system/xbin" + Environment.NewLine);
            pro.StandardInput.Write(@"mv su su2" + Environment.NewLine);
            pro.StandardInput.Write(@"cd system/bin" + Environment.NewLine);
            pro.StandardInput.Write(@"mv su su2" + Environment.NewLine);
            pro.StandardInput.Write(@"cd /data/app" + Environment.NewLine);
            pro.StandardInput.Write(@"mv catch_.me_.if_.you_.can_-1 acatch_.me_.if_.you_.can_-1" + Environment.NewLine);

            pro.StandardInput.Close();
            pro.WaitForExit();
            pro.Close();
        }

        private void btnBypassOff_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo pri = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process pro = new System.Diagnostics.Process();

            //실행할 파일 명 입력하기
            pri.FileName = "cmd.exe";

            //cmd 창 띄우기
            pri.CreateNoWindow = false;

            //flase가 띄우기, true가 안 띄우기
            pri.UseShellExecute = false;
            pri.RedirectStandardInput = true;
            pri.RedirectStandardOutput = true;
            pri.RedirectStandardError = true;
            pro.StartInfo = pri;
            pro.Start();

            pro.StandardInput.Write(@"adb devices" + Environment.NewLine);
            pro.StandardInput.Write(@"adb shell" + Environment.NewLine);
            pro.StandardInput.Write(@"mount -o remount r,w /system" + Environment.NewLine);
            pro.StandardInput.Write(@"mount -o remount r,w /data" + Environment.NewLine);
            pro.StandardInput.Write(@"cd system/xbin" + Environment.NewLine);
            pro.StandardInput.Write(@"mv su2 su" + Environment.NewLine);
            pro.StandardInput.Write(@"cd system/bin" + Environment.NewLine);
            pro.StandardInput.Write(@"mv su2 su" + Environment.NewLine);
            pro.StandardInput.Write(@"cd /data/app" + Environment.NewLine);
            pro.StandardInput.Write(@"mv acatch_.me_.if_.you_.can_-1 catch_.me_.if_.you_.can_-1" + Environment.NewLine);

            pro.StandardInput.Close();
            pro.WaitForExit();
            pro.Close();
        }
    }
}
