using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace avif_zip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "avifZip";
            listView1.DragDrop += ListView1_DragDrop;
            listView1.DragEnter += ListView1_DragEnter;
            listView1.MouseUp += ListView1_MouseUp;
            label1.Text = "��ͼƬ�����ͼƬ���ļ�����ק���·��б��Ҽ���ɾ����";
            modechoose.Items.Add("��������");
            modechoose.Items.Add("����ѹ��");
            modechoose.SelectedIndex = 0;
            bianmasuduinput.Text = "0";
            crfinput.Text = "23";
            ffmpeginput.Text = System.Environment.CurrentDirectory + "\\ffmpeg.exe";
            savepathinput.Text = System.Environment.CurrentDirectory + "\\output";
        }

        private int taskCount = 0;

        private void ListView1_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
        }

        private void ListView1_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            //��Ҫ���룺�������������͵����ݣ������ļ�·��
            else
                e.Effect = DragDropEffects.None;
        }
        private string[] acceptType = ["png", "jpeg", "jpg", "tif", "tiff", "bmp", "heic", "heif", "avif", "webp", "jfif", "gif", "ico", "exr", "hdr"];

        private bool ExistImage(string path)
        {
            System.Collections.IList list = listView1.Items;
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = (ListViewItem)list[i];
                if ((string)item.Tag == path)
                {
                    return true;
                }
            }
            return false;
        }



        private void AddImage(string path)
        {
            var temp = path.Replace("\\", "/").Split("/");
            var fileName = temp[temp.Length - 1];
            temp = fileName.Split(".");
            var type = temp[temp.Length - 1];
            if (!acceptType.Contains(type))
            {
                return;
            }
            if (ExistImage(path))
            {
                return;
            }
            ListViewItem item = new ListViewItem(path);
            item.Tag = path;
            item.Text = fileName;
            listView1.Items.Add(item);
        }

        private void ListView1_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                string[] f = (string[])e.Data.GetData(DataFormats.FileDrop);
                for (int i = 0; i < f.Length; i++)
                {
                    if (File.Exists(f[i]))
                    {
                        AddImage(f[i]);
                    }
                    else if (Directory.Exists(f[i]))
                    {
                        try
                        {
                            string[] files = Directory.GetFiles(f[i], "*", SearchOption.AllDirectories);
                            foreach (string file in files)
                            {
                                AddImage(file);
                            }
                        }
                        catch { }
                    }
                    else
                    {
                        // ������

                    }
                }
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void crf_Click(object sender, EventArgs e)
        {

        }

        private void ChooseSavePath(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "��ѡ��һ���ļ��У�������ļ����ᱣ������ѡ����ļ�����";
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    savepathinput.Text = selectedFolderPath;
                }
            }
        }

        private void ChooseFfmpegPath(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "ѡ�� ffmpeg.exe �ļ�";
                openFileDialog.Filter = "�����ļ� (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // �û�ѡ�����ļ�
                    ffmpeginput.Text = openFileDialog.FileName;
                }
            }
        }

        private async void RunCMDCommand(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(ffmpeginput.Text)
            {
                Arguments = command,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            Process p = new Process()
            {
                StartInfo = startInfo,
            };
            p.ErrorDataReceived += new DataReceivedEventHandler(delegate (object sender, DataReceivedEventArgs e)
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // �����ﴦ��ʵʱ���յ������
                    // ���磬����UI�߳��е��ı�������ʾ���
                    this.Invoke(new Action(() =>
                    {
                        resbox.AppendText(e.Data + Environment.NewLine);
                    }));
                }
            });
            p.OutputDataReceived += new DataReceivedEventHandler(delegate (object sender, DataReceivedEventArgs e)
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // �����ﴦ��ʵʱ���յ������
                    // ���磬����UI�߳��е��ı�������ʾ���
                    this.Invoke(new Action(() =>
                    {
                        resbox.AppendText(e.Data + Environment.NewLine);
                    }));
                }
            });

            p.Start();
            p.BeginErrorReadLine();
            p.BeginOutputReadLine();
            //p.StandardInput.WriteLine(command);
            //p.StandardInput.WriteLine("echo Done");
            //p.StandardInput.WriteLine("exit");
            await p.WaitForExitAsync();
            taskCount--;
            startbtn.Text = "ʣ��������:" + taskCount as string;
            if (taskCount == 0) { 
                startbtn.Enabled = true;
                startbtn.Text = "��ʼ";
                resbox.AppendText("Done" + Environment.NewLine);
            }
        }

        private void Start(object sender, EventArgs e)
        {
            var mode = "";
            if (modechoose.SelectedIndex == 1)
            {
                mode = "-pix_fmt yuv444p";
            }
            if (ffmpeginput.Text == "")
            {
                MessageBox.Show("��û����д·��������д ffmpeg.exe �ļ����ڵ�·���������ļ�����", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (savepathinput.Text == "")
            {
                MessageBox.Show("��û����д·��������д����ļ��ı���·��", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bianmasuduinput.Text == "")
            {
                bianmasuduinput.Text = "0";
            }
            if (crfinput.Text == "")
            {
                crfinput.Text = "0";
            }
            var cmd = " -i \"{path}\" -c:v libaom-av1 " + mode + " -cpu-used " + bianmasuduinput.Text + " -crf " + crfinput.Text + " \"" + savepathinput.Text + "\\{filename}.avif\"";
            System.Collections.IList list = listView1.Items;
            if (listView1.Items.Count <= 0)
            {
                MessageBox.Show("�㻹û��ѡ���κ��ļ������ͼƬ�����ͼƬ���ļ�����ק���ļ��б�", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(savepathinput.Text))
            {
                Directory.CreateDirectory(savepathinput.Text);
            }
            startbtn.Enabled = false;
            resbox.Text = "";
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = (ListViewItem)list[i];
                var path = (string)item.Tag;
                var fileName = (string)item.Text.Split(".")[0];
                if (File.Exists(savepathinput.Text + "\\" + fileName + ".avif"))
                {
                    try
                    {
                        File.Delete(savepathinput.Text + "\\" + fileName + ".avif");
                    }
                    catch
                    {
                        continue;
                    }
                }
                var runCmd = cmd.Replace("{path}", path);
                runCmd = runCmd.Replace("{filename}", fileName);
                taskCount ++;
                startbtn.Text = "ʣ��������:" + taskCount as string;
                RunCMDCommand(runCmd);
            }
            listView1.Items.Clear();
            
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void ffmpeg_Click(object sender, EventArgs e)
        {

        }
    }
}
