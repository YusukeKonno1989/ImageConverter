namespace Image_Converter
{
    partial class FrmMainDisplay
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainDisplay));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.cmbbxSelectFileExtension = new System.Windows.Forms.ComboBox();
            this.pbxImagePreview = new System.Windows.Forms.PictureBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.txtReadFileDirectory = new System.Windows.Forms.TextBox();
            this.txtWriteFileDirectory = new System.Windows.Forms.TextBox();
            this.pbxNavi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaviMessage = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelProduce = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNavi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(535, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 50);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "読み込み   ファイル";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoadClick);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(535, 284);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 50);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "書き込み先";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWriteClick);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTransfer.Location = new System.Drawing.Point(31, 340);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(483, 50);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "変換開始";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransferClick);
            // 
            // cmbbxSelectFileExtension
            // 
            this.cmbbxSelectFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxSelectFileExtension.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbbxSelectFileExtension.FormattingEnabled = true;
            this.cmbbxSelectFileExtension.Items.AddRange(new object[] {
            "bmp",
            "png",
            "jpeg",
            "tiff",
            "gif"});
            this.cmbbxSelectFileExtension.Location = new System.Drawing.Point(389, 103);
            this.cmbbxSelectFileExtension.Name = "cmbbxSelectFileExtension";
            this.cmbbxSelectFileExtension.Size = new System.Drawing.Size(197, 24);
            this.cmbbxSelectFileExtension.TabIndex = 3;
            this.cmbbxSelectFileExtension.TextChanged += new System.EventHandler(this.selectFileExtensionTextChanged);
            // 
            // pbxImagePreview
            // 
            this.pbxImagePreview.AllowDrop = true;
            this.pbxImagePreview.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbxImagePreview.BackgroundImage = global::Image_Converter.Properties.Resources.image_background;
            this.pbxImagePreview.Location = new System.Drawing.Point(31, 76);
            this.pbxImagePreview.Name = "pbxImagePreview";
            this.pbxImagePreview.Size = new System.Drawing.Size(347, 195);
            this.pbxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagePreview.TabIndex = 4;
            this.pbxImagePreview.TabStop = false;
            this.pbxImagePreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxImagePreviewDragDrop);
            this.pbxImagePreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxImagePreviewDragEnter);
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelExtension.Location = new System.Drawing.Point(387, 76);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(202, 24);
            this.labelExtension.TabIndex = 6;
            this.labelExtension.Text = "変換先拡張子選択";
            // 
            // txtReadFileDirectory
            // 
            this.txtReadFileDirectory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReadFileDirectory.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtReadFileDirectory.Location = new System.Drawing.Point(31, 24);
            this.txtReadFileDirectory.Name = "txtReadFileDirectory";
            this.txtReadFileDirectory.ReadOnly = true;
            this.txtReadFileDirectory.Size = new System.Drawing.Size(483, 27);
            this.txtReadFileDirectory.TabIndex = 7;
            // 
            // txtWriteFileDirectory
            // 
            this.txtWriteFileDirectory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtWriteFileDirectory.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtWriteFileDirectory.Location = new System.Drawing.Point(31, 296);
            this.txtWriteFileDirectory.Name = "txtWriteFileDirectory";
            this.txtWriteFileDirectory.ReadOnly = true;
            this.txtWriteFileDirectory.Size = new System.Drawing.Size(483, 27);
            this.txtWriteFileDirectory.TabIndex = 8;
            // 
            // pbxNavi
            // 
            this.pbxNavi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxNavi.Image = ((System.Drawing.Image)(resources.GetObject("pbxNavi.Image")));
            this.pbxNavi.Location = new System.Drawing.Point(510, 178);
            this.pbxNavi.Name = "pbxNavi";
            this.pbxNavi.Size = new System.Drawing.Size(100, 93);
            this.pbxNavi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNavi.TabIndex = 9;
            this.pbxNavi.TabStop = false;
            this.pbxNavi.Click += new System.EventHandler(this.naviClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(495, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "＞";
            // 
            // txtNaviMessage
            // 
            this.txtNaviMessage.BackColor = System.Drawing.Color.FloralWhite;
            this.txtNaviMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNaviMessage.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNaviMessage.Location = new System.Drawing.Point(389, 161);
            this.txtNaviMessage.Name = "txtNaviMessage";
            this.txtNaviMessage.Size = new System.Drawing.Size(106, 109);
            this.txtNaviMessage.TabIndex = 11;
            this.txtNaviMessage.Text = "3つの項目を選択していってね\r\n\r\n画像はドラッグアンドドロップでもできるよ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "default.bmp";
            this.openFileDialog1.Filter = "bmpファイル(*.bmp;)|*.bmp;|pngファイル(*.png;)|*.png;|jpegファイル(*.jpeg;)|*.jpeg;|tiffファイル(" +
    "*.tiff;)|*.tiff;|gifファイル(*.gif;)|*.gif;|すべてのファイル(*.*)|*.*";
            this.openFileDialog1.FilterIndex = 7;
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "開くファイルを選択してください";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "default.";
            this.saveFileDialog1.Filter = "すべてのファイル(*.*)|*.*";
            this.saveFileDialog1.FilterIndex = 0;
            this.saveFileDialog1.InitialDirectory = "C:\\Users\\konno_y\\Desktop";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "保存先選択とファイル名を入力してください";
            // 
            // labelProduce
            // 
            this.labelProduce.AutoSize = true;
            this.labelProduce.Location = new System.Drawing.Point(539, 349);
            this.labelProduce.Name = "labelProduce";
            this.labelProduce.Size = new System.Drawing.Size(68, 12);
            this.labelProduce.TabIndex = 12;
            this.labelProduce.Text = "Produced by";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(520, 367);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(107, 35);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "紺野提督";
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 1100;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimerTick);
            // 
            // FrmMainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelProduce);
            this.Controls.Add(this.txtNaviMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxNavi);
            this.Controls.Add(this.txtWriteFileDirectory);
            this.Controls.Add(this.txtReadFileDirectory);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.pbxImagePreview);
            this.Controls.Add(this.cmbbxSelectFileExtension);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMainDisplay";
            this.Text = "Image_Converter";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainDisplayMouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNavi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ComboBox cmbbxSelectFileExtension;
        private System.Windows.Forms.PictureBox pbxImagePreview;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.TextBox txtReadFileDirectory;
        private System.Windows.Forms.TextBox txtWriteFileDirectory;
        private System.Windows.Forms.PictureBox pbxNavi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNaviMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelProduce;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Timer animationTimer;
    }
}

