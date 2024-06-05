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
            listView1.Location = new Point(13, 30);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(226, 410);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // bianmasuduinput
            // 
            bianmasuduinput.Location = new Point(250, 51);
            bianmasuduinput.Margin = new Padding(4, 3, 4, 3);
            bianmasuduinput.Name = "bianmasuduinput";
            bianmasuduinput.Size = new Size(488, 23);
            bianmasuduinput.TabIndex = 2;
            // 
            // modechoose
            // 
            modechoose.FormattingEnabled = true;
            modechoose.Location = new Point(250, 416);
            modechoose.Margin = new Padding(4, 3, 4, 3);
            modechoose.Name = "modechoose";
            modechoose.Size = new Size(148, 25);
            modechoose.TabIndex = 3;
            // 
            // bianmasudu
            // 
            bianmasudu.AutoEllipsis = true;
            bianmasudu.AutoSize = true;
            bianmasudu.Location = new Point(250, 30);
            bianmasudu.Margin = new Padding(4, 0, 4, 0);
            bianmasudu.Name = "bianmasudu";
            bianmasudu.Size = new Size(56, 17);
            bianmasudu.TabIndex = 4;
            bianmasudu.Text = "编码速度";
            // 
            // crf
            // 
            crf.AutoSize = true;
            crf.Location = new Point(250, 85);
            crf.Margin = new Padding(4, 0, 4, 0);
            crf.Name = "crf";
            crf.Size = new Size(30, 17);
            crf.TabIndex = 5;
            crf.Text = "CRF";
            crf.Click += crf_Click;
            // 
            // crfinput
            // 
            crfinput.Location = new Point(250, 106);
            crfinput.Margin = new Padding(4, 3, 4, 3);
            crfinput.Name = "crfinput";
            crfinput.Size = new Size(488, 23);
            crfinput.TabIndex = 6;
            // 
            // savepath
            // 
            savepath.AutoSize = true;
            savepath.Location = new Point(250, 144);
            savepath.Margin = new Padding(4, 0, 4, 0);
            savepath.Name = "savepath";
            savepath.Size = new Size(56, 17);
            savepath.TabIndex = 7;
            savepath.Text = "保存路径";
            savepath.Click += label2_Click;
            // 
            // savepathinput
            // 
            savepathinput.Location = new Point(336, 140);
            savepathinput.Margin = new Padding(4, 3, 4, 3);
            savepathinput.Name = "savepathinput";
            savepathinput.Size = new Size(316, 23);
            savepathinput.TabIndex = 8;
            // 
            // choosesavepath
            // 
            choosesavepath.Location = new Point(664, 140);
            choosesavepath.Margin = new Padding(4, 3, 4, 3);
            choosesavepath.Name = "choosesavepath";
            choosesavepath.Size = new Size(75, 21);
            choosesavepath.TabIndex = 9;
            choosesavepath.Text = "浏览";
            choosesavepath.UseVisualStyleBackColor = true;
            choosesavepath.Click += ChooseSavePath;
            // 
            // ffmpeg
            // 
            ffmpeg.AutoSize = true;
            ffmpeg.Location = new Point(250, 178);
            ffmpeg.Margin = new Padding(4, 0, 4, 0);
            ffmpeg.Name = "ffmpeg";
            ffmpeg.Size = new Size(74, 17);
            ffmpeg.TabIndex = 10;
            ffmpeg.Text = "ffmpeg路径";
            ffmpeg.Click += ffmpeg_Click;
            // 
            // ffmpeginput
            // 
            ffmpeginput.Location = new Point(336, 174);
            ffmpeginput.Margin = new Padding(4, 3, 4, 3);
            ffmpeginput.Name = "ffmpeginput";
            ffmpeginput.Size = new Size(316, 23);
            ffmpeginput.TabIndex = 11;
            // 
            // ffmpegchoose
            // 
            ffmpegchoose.Location = new Point(664, 174);
            ffmpegchoose.Margin = new Padding(4, 3, 4, 3);
            ffmpegchoose.Name = "ffmpegchoose";
            ffmpegchoose.Size = new Size(75, 21);
            ffmpegchoose.TabIndex = 12;
            ffmpegchoose.Text = "浏览";
            ffmpegchoose.UseVisualStyleBackColor = true;
            ffmpegchoose.Click += ChooseFfmpegPath;
            // 
            // startbtn
            // 
            startbtn.Location = new Point(410, 416);
            startbtn.Margin = new Padding(4, 3, 4, 3);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(328, 21);
            startbtn.TabIndex = 13;
            startbtn.Text = "开始";
            startbtn.UseVisualStyleBackColor = true;
            startbtn.Click += Start;
            // 
            // resbox
            // 
            resbox.Location = new Point(250, 230);
            resbox.Margin = new Padding(4, 3, 4, 3);
            resbox.Multiline = true;
            resbox.Name = "resbox";
            resbox.ScrollBars = ScrollBars.Vertical;
            resbox.Size = new Size(488, 176);
            resbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 14;
            label2.Text = "运行结果";
            label2.Click += label2_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(310, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 17);
            label3.TabIndex = 15;
            label3.Text = "(数字0-8)，值越小速度越慢画质越高";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(280, 85);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(310, 17);
            label4.TabIndex = 16;
            label4.Text = "(数字0-63)，0为无损，1到63数字越小文件越大画质越高";
            // 
            // Form1
            // 
            AcceptButton = startbtn;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 451);
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
            Margin = new Padding(4, 3, 4, 3);
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
