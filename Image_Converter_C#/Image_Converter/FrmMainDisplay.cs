using System;
using System.Drawing;
using System.Windows.Forms;

namespace Image_Converter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmMainDisplay : Form
    {
        bool loadButtonFlg, writeButtonFlg, extensionFlg;
        bool sleepFlg;
        int timerCounter = 0;

        // ナビのアニメーション用構造体
        struct NaviFactor
        {
            public int id;
            public Image image;
            public string message;
        }

        private static readonly NaviFactor[] naviFactor = new NaviFactor[4]{
            new NaviFactor(){ id = 12 , image =Properties.Resources.sleep1 , message = "・・・" },
            new NaviFactor(){ id = 16 , image =Properties.Resources.sleep2 , message = "Z・・・" },
            new NaviFactor(){ id = 20 , image =Properties.Resources.sleep3 , message = "ZZ・・・" },
            new NaviFactor(){ id = 24 , image =Properties.Resources.sleep4 , message = "ZZZ・・・" },
        };

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmMainDisplay()
        {
            // 初期化処理
            InitializeComponent();
        }

        /// <summary>
        /// 画像描画処理
        /// </summary>
        /// <param name="image_pos"></param>
        /// <param name="import_file_name"></param>
        private void drawImage(PictureBox imagePos , Image loadFileName)
        {
            imagePos.Image = loadFileName;   // 指定した場所に画像描画        
        }
        
        /// <summary>
        /// ドラッグ可能エリアに入った時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxImagePreviewDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)){ e.Effect = DragDropEffects.Copy; }
        }

        /// <summary>
        /// ドラッグアンドドロップした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxImagePreviewDragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) { return; }

            // ドラッグアンドロップされたファイル名を代入する
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);

            // ファイルの拡張子が画像データの物ならテキストボックスに表示する
            bool fileExtensionCheck = false;
            foreach (string fName in fileName) { fileExtensionCheck = fileTypeCheck(fName); }
            if (fileExtensionCheck)
            {
                try
                {
                    drawImage(pbxImagePreview, Image.FromFile(fileName[0]));
                    txtReadFileDirectory.Text = fileName[0];
                }
                catch (Exception)
                {
                    MessageBox.Show("ファイルのデータが壊れています",
                    "ふぁっきゅー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
            }
        }

        /// <summary>
        /// ドラッグアンドドロップされたファイルが画像ファイルか確認する処理
        /// </summary>
        /// <param name="file_name"></param>
        /// <returns></returns>
        private bool fileTypeCheck( string fileName )
        {
            string[] extensionArray = { "bmp" , "png" , "jpeg" , "tiff" , "gif" };
            foreach (string extension in extensionArray)
            {
                if (extension == fileName.Substring(fileName.Length - extension.Length, extension.Length))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// コンボボックスを操作する時の関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectFileExtensionTextChanged(object sender, EventArgs e)
        {
            extensionFlg = true;  // 変換ボタン用フラグをtrueにする

            // 書き込み先を選択したあとにコンボボックスを再選択したときの処理
            if (writeButtonFlg)
            {
                string fileDirectory = System.IO.Path.GetDirectoryName(txtWriteFileDirectory.Text);
                string fileName = System.IO.Path.GetFileNameWithoutExtension(txtWriteFileDirectory.Text); // 拡張子を除いたファイル名を取得
                txtWriteFileDirectory.Text = fileDirectory + "\\" + fileName + "." + this.cmbbxSelectFileExtension.SelectedItem.ToString();     // ファイル名 + 拡張子を代入
                txtWriteFileDirectory.Text = txtWriteFileDirectory.Text;                                   // 書き込み用のテキストボックスを更新
            }
        }

        /// <summary>
        /// 読み込み先ボタン押下時処理関数 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadClick(object sender, EventArgs e)
        {
            // ファイルダイアログを表示
            if (openFileDialog1.ShowDialog() != DialogResult.OK) { return; }

            // デフォルトネームでなければ描画
            if (openFileDialog1.FileName == "default.bmp") { return; }

            try
            {
                // 画像描画処理
                drawImage(pbxImagePreview, Image.FromFile(openFileDialog1.FileName));
            }
            catch(Exception){
                MessageBox.Show("ファイルのデータが壊れています",
                "ふぁっきゅー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            // テキストボックス内にファイルパスを表示する
            txtReadFileDirectory.Text = openFileDialog1.FileName;
            loadButtonFlg = true; // 変換ボタン用フラグをtrueにする
        }

        /// <summary>
        /// 書き込み先ボタン押下時処理関数 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteClick(object sender, EventArgs e)
        {
            // ファイルダイアログを表示
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) { return; }
            
            if (extensionFlg)
            {
                string fileDirectory = System.IO.Path.GetDirectoryName(this.saveFileDialog1.FileName);
                string fileName = System.IO.Path.GetFileNameWithoutExtension(this.saveFileDialog1.FileName); // 拡張子を除いたファイル名を取得
                this.saveFileDialog1.FileName = fileDirectory + "\\" + fileName + "." + this.cmbbxSelectFileExtension.SelectedItem.ToString();     // ファイル名 + 拡張子を代入
            }
            txtWriteFileDirectory.Text = this.saveFileDialog1.FileName;
            writeButtonFlg = true; // 変換ボタン用フラグをtrueにする
        }

        /// <summary>
        /// 変換ボタン押下時処理関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransferClick(object sender, EventArgs e)
        {
            // 変換開始判定 3箇所選択していれば変換開始
            if (loadButtonFlg && writeButtonFlg && extensionFlg)
            {

                // インポートファイルのデータを読み込む
                using (Image transferImage = Image.FromFile(txtReadFileDirectory.Text))
                {
                    // コンボボックスで選択した拡張子に変換
                    if (this.cmbbxSelectFileExtension.SelectedItem.ToString() == "png") { transferImage.Save(txtWriteFileDirectory.Text, System.Drawing.Imaging.ImageFormat.Png); }
                    else if (this.cmbbxSelectFileExtension.SelectedItem.ToString() == "bmp") { transferImage.Save(txtWriteFileDirectory.Text, System.Drawing.Imaging.ImageFormat.Bmp); }
                    else if (this.cmbbxSelectFileExtension.SelectedItem.ToString() == "jpeg") { transferImage.Save(txtWriteFileDirectory.Text, System.Drawing.Imaging.ImageFormat.Jpeg); }
                    else if (this.cmbbxSelectFileExtension.SelectedItem.ToString() == "gif") { transferImage.Save(txtWriteFileDirectory.Text, System.Drawing.Imaging.ImageFormat.Gif); }
                    else { transferImage.Save(txtWriteFileDirectory.Text, System.Drawing.Imaging.ImageFormat.Tiff); }
                }
                this.txtNaviMessage.Text = "変換完了だよ";
                drawImage(pbxNavi, Properties.Resources.glad);
            }
            else
            {
                this.txtNaviMessage.Text = "3つの項目が選択されていないから変換できないよ";
                drawImage(pbxNavi, Properties.Resources.fail);
                return;
            }
        }

        /// <summary>
        /// 連装砲ちゃんをクリックした際の画像変更関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void naviClick(object sender, EventArgs e) { drawImage(pbxNavi, Properties.Resources.click); }

        /// <summary>
        /// 画面上で動作があれば連装砲ちゃんを変化させる関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainDisplayMouseMove(object sender, MouseEventArgs e)
        {
            if (sleepFlg && timerCounter == 0)
            {
                drawImage(pbxNavi, Properties.Resources.getup);
                txtNaviMessage.Text = "!?";
                animationTimer.Start();
            }
            else if (!sleepFlg)
            {
                timerCounter = 0; // タイマーカウンタ初期化
                drawImage(pbxNavi, Properties.Resources.normal);
                txtNaviMessage.Text = "3つの項目を選択していってね\r\n\r\n画像はドラッグアンドドロップでもできるよ";
            }
        }

        /// <summary>
        /// タイマーイベント関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animationTimerTick(object sender, EventArgs e)
        {
            const int oneTimeTick = 4;

            timerCounter++; // タイマーカウンター
            if (sleepFlg == false)
            {
                const int sleepAssort   = 4; // アニメーションの種類数
                const int sleepMaxFrame = 6; // 待機時のアニメーションカウンタ最大値

                // タイマーカウンターとidが同じものがあれば中身を表示する処理
                for (int i = 0; i < sleepAssort; i++)
                {
                    if (timerCounter != naviFactor[i].id) { continue; }

                    drawImage(pbxNavi, naviFactor[i].image);
                    txtNaviMessage.Text = naviFactor[i].message;
                    if (timerCounter >= oneTimeTick * sleepMaxFrame)
                    {
                        sleepFlg = true;
                        timerCounter = 0; // タイマーカウンタ初期化
                        animationTimer.Stop();
                    }
                }
            }
            else
            {
                if (timerCounter == oneTimeTick)
                {
                    Image shyFace = Properties.Resources.shy;
                    drawImage(pbxNavi, shyFace);
                    txtNaviMessage.Text = "///";
                }
                else if (timerCounter == oneTimeTick * 2)
                {
                    timerCounter = 0;
                    sleepFlg = false; // スリープフラグ解除
                }
            }
        }
    }
}
