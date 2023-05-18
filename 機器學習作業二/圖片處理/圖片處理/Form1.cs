using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 圖片處理
{
    public partial class Form1 : Form
    {
        Ini ini;
        public Form1()
        {
            InitializeComponent();
        }

        private void ResizeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckMemoryFile();
            label7.Text = "";
            label8.Text = "";
            orgXRay.Text = ini.ReadIniFile("Resize", "Org","");
            newXRay.Text = ini.ReadIniFile("Resize", "NewOrg", "");
            orgMask.Text = ini.ReadIniFile("Resize", "Mask", "");
            newMask.Text = ini.ReadIniFile("Resize", "NewMask", "");
            resizeNumber.Text = ini.ReadIniFile("Resize", "Size", "");
            newName.Text = ini.ReadIniFile("Resize", "NewName", "");
            orgCOXRay.Text = ini.ReadIniFile("Cutout", "Org", "");
            newCOXRay.Text = ini.ReadIniFile("Cutout", "NewOrg", "");
            orgCOMask.Text = ini.ReadIniFile("Cutout", "Mask", "");
            newCOMask.Text = ini.ReadIniFile("Cutout", "NewMask", "");
            cutoutWidth.Text = ini.ReadIniFile("Cutout", "Width", "");
            cutoutHeight.Text = ini.ReadIniFile("Cutout", "Height", "");
            cutoutNewName.Text = ini.ReadIniFile("Cutout", "NewName", "");

            orgSpinXRay.Text = ini.ReadIniFile("Spin", "Org", "");
            newSpinXRay.Text = ini.ReadIniFile("Spin", "NewOrg", "");
            orgSpinMask.Text = ini.ReadIniFile("Spin", "Mask", "");
            newSpinMask.Text = ini.ReadIniFile("Spin", "NewMask", "");
           spinNewName.Text = ini.ReadIniFile("Spin", "NewName", "");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SetFolder(orgXRay, "請選擇X-Ray原資料夾");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SetFolder(newXRay, "請選擇X-Ray新資料夾");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SetFolder(orgMask, "請選擇Mask原資料夾");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SetFolder(newMask, "請選擇Mask新資料夾");
        }

        private void SetFolder(TextBox tb, string msg)
        {
            FolderBrowserDialog path = new FolderBrowserDialog
            {
                Description = msg
            };
            if (!tb.Text.Equals(""))
                path.SelectedPath = tb.Text;
            path.ShowDialog();
            if (!path.SelectedPath.Equals(""))
            {
                tb.Text = path.SelectedPath;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SetMemory("Resize","Org", orgXRay.Text);
            SetMemory("Resize", "NewOrg", newXRay.Text);
            SetMemory("Resize", "Mask", orgMask.Text);
            SetMemory("Resize", "NewMask", newMask.Text);
            SetMemory("Resize", "Size", resizeNumber.Text);
            SetMemory("Resize", "NewName", newName.Text);
            bwResize.RunWorkerAsync();
        }

        private void SetMemory(string section, string key, string val)
        {
            ini.WriteIniFile(section, key, val);
        }

        private void CheckMemoryFile()
        {
            if (!File.Exists(string.Format("{0}\\memory.ini", Application.StartupPath)))
                File.Create(string.Format("{0}\\memory.ini", Application.StartupPath));
             ini = new Ini(string.Format("{0}\\memory.ini", Application.StartupPath));
        }

        private void BwResize_DoWork(object sender, DoWorkEventArgs e)
        {
            SetGroupEnable(false);
            label7.Text = "";
            label8.Text = "";
            tbMsg.Text = "";
            SetProcessMsg(string.Format("<{0}> 執行<圖片原比例尺寸修改>",DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")));
            ImageProcess(orgXRay.Text, orgMask.Text,1);
            SetGroupEnable(true);
        }

        private void SetProcessMsg(string msg)
        {
            tbMsg.AppendText(string.Format("{0}{1}", msg, Environment.NewLine));
        }

        private void ImageProcess(string xray, string mask, int type)
        {
            string[] xrayFiles = Directory.GetFiles(xray);
            string[] maskFiles = Directory.GetFiles(mask);
            label8.Text = xrayFiles.Length.ToString();
            nowProcess.Maximum = xrayFiles.Length;
            for (int x = 0; x < xrayFiles.Length; x++)
            {
                string xFile = Path.GetFileNameWithoutExtension(xrayFiles[x]).Replace("img_","");
                for (int m = 0; m< maskFiles.Length; m++)
                {
                    string mFile= Path.GetFileNameWithoutExtension(maskFiles[m]).Replace("mask_", "");
                    if (xFile.Equals(mFile))
                    {
                        string newFileName = "";
                        switch (type)
                        {
                            case 1:
                                newFileName = string.Format("{0}_{1}_{2}", newName.Text, x, m);
                                ResizeImage(xrayFiles[x], string.Format("{0}\\{1}{2}", newXRay.Text, newFileName, Path.GetExtension(xrayFiles[x]).ToLower()));
                                ResizeImage(maskFiles[x], string.Format("{0}\\{1}{2}", newMask.Text, newFileName, Path.GetExtension(maskFiles[x]).ToLower()));
                                break;
                            case 2:
                                newFileName = string.Format("{0}_{1}_{2}", cutoutNewName.Text, x, m);
                                CutoutImage(xrayFiles[x], string.Format("{0}\\{1}{2}", newCOXRay.Text, newFileName, Path.GetExtension(xrayFiles[x]).ToLower()));
                                CutoutImage(maskFiles[x], string.Format("{0}\\{1}{2}", newCOMask.Text, newFileName, Path.GetExtension(maskFiles[x]).ToLower()));
                                break;
                            case 3:
                                newFileName = string.Format("{0}_{1}_{2}", spinNewName.Text, x, m);
                                SpinImage(xrayFiles[x], string.Format("{0}\\{1}", newSpinXRay.Text, newFileName), Path.GetExtension(xrayFiles[x]).ToLower());
                                SpinImage(maskFiles[x], string.Format("{0}\\{1}", newSpinMask.Text, newFileName), Path.GetExtension(maskFiles[x]).ToLower());
                                break;
                        }
                        SetProcessMsg(string.Format( "X-Ray 路徑:{0}{1}Mask 路徑:{2}{1}新檔名:{3}{1}", xrayFiles[x],Environment.NewLine, maskFiles[m], newFileName));
                        break;
                    }
                    nowProcess.Value = (x + 1);
                    label7.Text = (x + 1).ToString();
                }
            }
        }

        private void SpinImage(string oldPath, string newPath, string fe)
        {
            RotateFlipType[] pft = { RotateFlipType.Rotate180FlipNone, RotateFlipType.Rotate270FlipNone, RotateFlipType.Rotate90FlipNone, RotateFlipType.Rotate180FlipX, RotateFlipType.Rotate180FlipXY, RotateFlipType.Rotate180FlipY, RotateFlipType.Rotate270FlipX, RotateFlipType.Rotate270FlipXY, RotateFlipType.Rotate270FlipY, RotateFlipType.Rotate90FlipX, RotateFlipType.Rotate90FlipXY, RotateFlipType.Rotate90FlipY };
            for (int p = 0; p < pft.Length; p++)
            {
                try
                {
                    FileStream fs = File.OpenRead(oldPath);
                    Image old = Image.FromStream(fs);
                    old.RotateFlip(pft[p]);
                    old.Save(string.Format("{0}_{1}{2}", newPath, p, fe));
                    fs.Close();
                    old.Dispose();
                    fs.Dispose();
                }
                catch (Exception exp)
                {
                    SetProcessMsg(string.Format("發生錯誤:{0}{1}", Environment.NewLine, exp.Message));
                }
            }
        }

        private void CutoutImage(string oldPath, string newPath)
        {
            try
            {
                FileStream fs = File.OpenRead(oldPath);
                Image old = Image.FromStream(fs);
                Rectangle cropArea = new Rectangle((old.Width / 2 - int.Parse(cutoutWidth.Text) / 2), 0, int.Parse(cutoutWidth.Text), int.Parse(cutoutHeight.Text));
                Bitmap bmpImage = new Bitmap(old);
                Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
                bmpCrop.Save(newPath);
                fs.Close();
                old.Dispose();
                bmpImage.Dispose();
                bmpCrop.Dispose();
                fs.Dispose();
            }catch (Exception exp)
            {
                SetProcessMsg(string.Format("發生錯誤:{0}{1}", Environment.NewLine, exp.Message));
            }
}

        private void ResizeImage(string oldPath, string newPath)
        {
            try
            {
                FileStream fs = File.OpenRead(oldPath);
                Image old = Image.FromStream(fs);
                double resize = double.Parse(resizeNumber.Text) / (double)old.Width;
                if (old.Width > old.Height)
                    resize = double.Parse(resizeNumber.Text) / (double)old.Height;
                Bitmap imgoutput = new Bitmap(old, (int)(old.Width * resize), (int)(old.Height * resize));
                imgoutput.Save(newPath);
                fs.Close();
                old.Dispose();
                imgoutput.Dispose();
                fs.Dispose();
            }catch (Exception exp)
            {
                SetProcessMsg(string.Format("發生錯誤:{0}{1}",Environment.NewLine, exp.Message));
            }
        }

        private void SetGroupEnable(bool isEnable)
        {
            ResizeG.Enabled = isEnable;
            CutOut.Enabled = isEnable;
            Spin.Enabled = isEnable;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            SetFolder(orgCOXRay, "請選擇X-Ray原資料夾");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SetFolder(newCOXRay, "請選擇X-Ray新資料夾");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SetFolder(orgCOMask, "請選擇Mask原資料夾");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SetFolder(newCOMask, "請選擇Mask新資料夾");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SetMemory("Cutout", "Org", orgCOXRay.Text);
            SetMemory("Cutout", "NewOrg", newCOXRay.Text);
            SetMemory("Cutout", "Mask", orgCOMask.Text);
            SetMemory("Cutout", "NewMask", newCOMask.Text);
            SetMemory("Cutout", "Width", cutoutWidth.Text);
            SetMemory("Cutout", "Height", cutoutHeight.Text);
            SetMemory("Cutout", "NewName", cutoutNewName.Text);
            bwCutout.RunWorkerAsync();
        }

        private void BwCutout_DoWork(object sender, DoWorkEventArgs e)
        {
            SetGroupEnable(false);
            label7.Text = "";
            label8.Text = "";
            tbMsg.Text = "";
            SetProcessMsg(string.Format("<{0}> 執行<圖片裁剪>", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")));
            ImageProcess(orgCOXRay.Text, orgCOMask.Text, 2);
            SetGroupEnable(true);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            SetFolder(orgSpinXRay, "請選擇X-Ray原資料夾");
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            SetFolder(newSpinXRay, "請選擇X-Ray新資料夾");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            SetFolder(orgSpinMask, "請選擇Mask原資料夾");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            SetFolder(newSpinMask, "請選擇Mask新資料夾");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            SetMemory("Spin", "Org", orgSpinXRay.Text);
            SetMemory("Spin", "NewOrg", newSpinXRay.Text);
            SetMemory("Spin", "Mask", orgSpinMask.Text);
            SetMemory("Spin", "NewMask", newSpinMask.Text);
            SetMemory("Spin", "NewName", spinNewName.Text);
            bwSpin.RunWorkerAsync();
        }

        private void BwSpin_DoWork(object sender, DoWorkEventArgs e)
        {
            SetGroupEnable(false);
            label7.Text = "";
            label8.Text = "";
            tbMsg.Text = "";
            SetProcessMsg(string.Format("<{0}> 執行<圖片旋轉>", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")));
            ImageProcess(orgSpinXRay.Text, orgSpinMask.Text, 3);
            SetGroupEnable(true);
        }
    }
}
