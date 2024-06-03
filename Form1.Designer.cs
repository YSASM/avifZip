namespace avif_zip
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
            listView1 = new ListView();
            label1 = new Label();
            bianmasuduinput = new TextBox();
            modechoose = new ComboBox();
            bianmasudu = new Label();
            crf = new Label();
            crfinput = new TextBox();
            savepath = new Label();
            savepathinput = new TextBox();
            choosesavepath = new Button();
            ffmpeg = new Label();
            ffmpeginput = new TextBox();
            ffmpegchoose = new Button();
            startbtn = new Button();
            resbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.AllowDrop = true;
            listView1.Location = new Point(18, 44);
            listView1.Margin = new Padding(5);
            listView1.Name = "listView1";
            listView1.Size = new Size(321, 601);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // bianmasuduinput
            // 
            bianmasuduinput.Location = new Point(357, 75);
            bianmasuduinput.Margin = new Padding(5);
            bianmasuduinput.Name = "bianmasuduinput";
            bianmasuduinput.Size = new Size(696, 31);
            bianmasuduinput.TabIndex = 2;
            // 
            // modechoose
            // 
            modechoose.FormattingEnabled = true;
            modechoose.Location = new Point(357, 612);
            modechoose.Margin = new Padding(5);
            modechoose.Name = "modechoose";
            modechoose.Size = new Size(210, 33);
            modechoose.TabIndex = 3;
            // 
            // bianmasudu
            // 
            bianmasudu.AutoEllipsis = true;
            bianmasudu.AutoSize = true;
            bianmasudu.Location = new Point(357, 44);
            bianmasudu.Margin = new Padding(5, 0, 5, 0);
            bianmasudu.Name = "bianmasudu";
            bianmasudu.Size = new Size(84, 25);
            bianmasudu.TabIndex = 4;
            bianmasudu.Text = "编码速度";
            // 
            // crf
            // 
            crf.AutoSize = true;
            crf.Location = new Point(357, 125);
            crf.Margin = new Padding(5, 0, 5, 0);
            crf.Name = "crf";
            crf.Size = new Size(43, 25);
            crf.TabIndex = 5;
            crf.Text = "CRF";
            crf.Click += crf_Click;
            // 
            // crfinput
            // 
            crfinput.Location = new Point(357, 156);
            crfinput.Margin = new Padding(5);
            crfinput.Name = "crfinput";
            crfinput.Size = new Size(696, 31);
            crfinput.TabIndex = 6;
            // 
            // savepath
            // 
            savepath.AutoSize = true;
            savepath.Location = new Point(357, 212);
            savepath.Margin = new Padding(5, 0, 5, 0);
            savepath.Name = "savepath";
            savepath.Size = new Size(84, 25);
            savepath.TabIndex = 7;
            savepath.Text = "保存路径";
            savepath.Click += label2_Click;
            // 
            // savepathinput
            // 
            savepathinput.Location = new Point(480, 206);
            savepathinput.Margin = new Padding(5);
            savepathinput.Name = "savepathinput";
            savepathinput.Size = new Size(450, 31);
            savepathinput.TabIndex = 8;
            // 
            // choosesavepath
            // 
            choosesavepath.Location = new Point(948, 206);
            choosesavepath.Margin = new Padding(5);
            choosesavepath.Name = "choosesavepath";
            choosesavepath.Size = new Size(107, 31);
            choosesavepath.TabIndex = 9;
            choosesavepath.Text = "浏览";
            choosesavepath.UseVisualStyleBackColor = true;
            choosesavepath.Click += ChooseSavePath;
            // 
            // ffmpeg
            // 
            ffmpeg.AutoSize = true;
            ffmpeg.Location = new Point(357, 262);
            ffmpeg.Margin = new Padding(5, 0, 5, 0);
            ffmpeg.Name = "ffmpeg";
            ffmpeg.Size = new Size(107, 25);
            ffmpeg.TabIndex = 10;
            ffmpeg.Text = "ffmpeg路径";
            ffmpeg.Click += ffmpeg_Click;
            // 
            // ffmpeginput
            // 
            ffmpeginput.Location = new Point(480, 256);
            ffmpeginput.Margin = new Padding(5);
            ffmpeginput.Name = "ffmpeginput";
            ffmpeginput.Size = new Size(450, 31);
            ffmpeginput.TabIndex = 11;
            // 
            // ffmpegchoose
            // 
            ffmpegchoose.Location = new Point(948, 256);
            ffmpegchoose.Margin = new Padding(5);
            ffmpegchoose.Name = "ffmpegchoose";
            ffmpegchoose.Size = new Size(107, 31);
            ffmpegchoose.TabIndex = 12;
            ffmpegchoose.Text = "浏览";
            ffmpegchoose.UseVisualStyleBackColor = true;
            ffmpegchoose.Click += ChooseFfmpegPath;
            // 
            // startbtn
            // 
            startbtn.Location = new Point(585, 612);
            startbtn.Margin = new Padding(5);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(468, 31);
            startbtn.TabIndex = 13;
            startbtn.Text = "开始";
            startbtn.UseVisualStyleBackColor = true;
            startbtn.Click += Start;
            // 
            // resbox
            // 
            resbox.Location = new Point(357, 338);
            resbox.Margin = new Padding(5);
            resbox.Multiline = true;
            resbox.Name = "resbox";
            resbox.Size = new Size(696, 257);
            resbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 306);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 14;
            label2.Text = "运行结果";
            label2.Click += label2_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(443, 44);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(301, 25);
            label3.TabIndex = 15;
            label3.Text = "(数字0-8)，值越小速度越慢画质越高";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(400, 125);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(459, 25);
            label4.TabIndex = 16;
            label4.Text = "(数字0-63)，0为无损，1到63数字越小文件越大画质越高";
            // 
            // Form1
            // 
            AcceptButton = startbtn;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 663);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(resbox);
            Controls.Add(startbtn);
            Controls.Add(ffmpegchoose);
            Controls.Add(ffmpeginput);
            Controls.Add(ffmpeg);
            Controls.Add(choosesavepath);
            Controls.Add(savepathinput);
            Controls.Add(savepath);
            Controls.Add(crfinput);
            Controls.Add(crf);
            Controls.Add(bianmasudu);
            Controls.Add(modechoose);
            Controls.Add(bianmasuduinput);
            Controls.Add(label1);
            Controls.Add(listView1);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private TextBox bianmasuduinput;
        private ComboBox modechoose;
        private Label bianmasudu;
        private Label crf;
        private TextBox crfinput;
        private Label savepath;
        private TextBox savepathinput;
        private Button choosesavepath;
        private Label ffmpeg;
        private TextBox ffmpeginput;
        private Button ffmpegchoose;
        private Button startbtn;
        private TextBox resbox;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
