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
            listView1.Location = new Point(24, 51);
            listView1.Margin = new Padding(7, 5, 7, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(416, 697);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 14);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 29);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // bianmasuduinput
            // 
            bianmasuduinput.Location = new Point(464, 87);
            bianmasuduinput.Margin = new Padding(7, 5, 7, 5);
            bianmasuduinput.Name = "bianmasuduinput";
            bianmasuduinput.Size = new Size(903, 39);
            bianmasuduinput.TabIndex = 2;
            // 
            // modechoose
            // 
            modechoose.FormattingEnabled = true;
            modechoose.Location = new Point(464, 710);
            modechoose.Margin = new Padding(7, 5, 7, 5);
            modechoose.Name = "modechoose";
            modechoose.Size = new Size(271, 37);
            modechoose.TabIndex = 3;
            // 
            // bianmasudu
            // 
            bianmasudu.AutoEllipsis = true;
            bianmasudu.AutoSize = true;
            bianmasudu.Location = new Point(464, 51);
            bianmasudu.Margin = new Padding(7, 0, 7, 0);
            bianmasudu.Name = "bianmasudu";
            bianmasudu.Size = new Size(109, 29);
            bianmasudu.TabIndex = 4;
            bianmasudu.Text = "编码速度";
            // 
            // crf
            // 
            crf.AutoSize = true;
            crf.Location = new Point(464, 145);
            crf.Margin = new Padding(7, 0, 7, 0);
            crf.Name = "crf";
            crf.Size = new Size(54, 29);
            crf.TabIndex = 5;
            crf.Text = "CRF";
            crf.Click += crf_Click;
            // 
            // crfinput
            // 
            crfinput.Location = new Point(464, 181);
            crfinput.Margin = new Padding(7, 5, 7, 5);
            crfinput.Name = "crfinput";
            crfinput.Size = new Size(903, 39);
            crfinput.TabIndex = 6;
            // 
            // savepath
            // 
            savepath.AutoSize = true;
            savepath.Location = new Point(464, 246);
            savepath.Margin = new Padding(7, 0, 7, 0);
            savepath.Name = "savepath";
            savepath.Size = new Size(109, 29);
            savepath.TabIndex = 7;
            savepath.Text = "保存路径";
            savepath.Click += label2_Click;
            // 
            // savepathinput
            // 
            savepathinput.Location = new Point(624, 239);
            savepathinput.Margin = new Padding(7, 5, 7, 5);
            savepathinput.Name = "savepathinput";
            savepathinput.Size = new Size(583, 39);
            savepathinput.TabIndex = 8;
            // 
            // choosesavepath
            // 
            choosesavepath.Location = new Point(1233, 239);
            choosesavepath.Margin = new Padding(7, 5, 7, 5);
            choosesavepath.Name = "choosesavepath";
            choosesavepath.Size = new Size(139, 36);
            choosesavepath.TabIndex = 9;
            choosesavepath.Text = "浏览";
            choosesavepath.UseVisualStyleBackColor = true;
            choosesavepath.Click += ChooseSavePath;
            // 
            // ffmpeg
            // 
            ffmpeg.AutoSize = true;
            ffmpeg.Location = new Point(464, 304);
            ffmpeg.Margin = new Padding(7, 0, 7, 0);
            ffmpeg.Name = "ffmpeg";
            ffmpeg.Size = new Size(139, 29);
            ffmpeg.TabIndex = 10;
            ffmpeg.Text = "ffmpeg路径";
            ffmpeg.Click += ffmpeg_Click;
            // 
            // ffmpeginput
            // 
            ffmpeginput.Location = new Point(624, 297);
            ffmpeginput.Margin = new Padding(7, 5, 7, 5);
            ffmpeginput.Name = "ffmpeginput";
            ffmpeginput.Size = new Size(583, 39);
            ffmpeginput.TabIndex = 11;
            // 
            // ffmpegchoose
            // 
            ffmpegchoose.Location = new Point(1233, 297);
            ffmpegchoose.Margin = new Padding(7, 5, 7, 5);
            ffmpegchoose.Name = "ffmpegchoose";
            ffmpegchoose.Size = new Size(139, 36);
            ffmpegchoose.TabIndex = 12;
            ffmpegchoose.Text = "浏览";
            ffmpegchoose.UseVisualStyleBackColor = true;
            ffmpegchoose.Click += ChooseFfmpegPath;
            // 
            // startbtn
            // 
            startbtn.Location = new Point(761, 710);
            startbtn.Margin = new Padding(7, 5, 7, 5);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(609, 36);
            startbtn.TabIndex = 13;
            startbtn.Text = "开始";
            startbtn.UseVisualStyleBackColor = true;
            startbtn.Click += Start;
            // 
            // resbox
            // 
            resbox.Location = new Point(464, 392);
            resbox.Margin = new Padding(7, 5, 7, 5);
            resbox.Multiline = true;
            resbox.Name = "resbox";
            resbox.ScrollBars = ScrollBars.Vertical;
            resbox.Size = new Size(903, 297);
            resbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 355);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 29);
            label2.TabIndex = 14;
            label2.Text = "运行结果";
            label2.Click += label2_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(576, 51);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(736, 29);
            label3.TabIndex = 15;
            label3.Text = "(极高压缩下支持数字0-13，其他模式0-8)，值越小速度越慢画质越高";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(520, 145);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(584, 29);
            label4.TabIndex = 16;
            label4.Text = "(数字0-63)，0为无损，1到63值越小文件越大画质越高";
            // 
            // Form1
            // 
            AcceptButton = startbtn;
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 769);
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
            Margin = new Padding(7, 5, 7, 5);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
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
