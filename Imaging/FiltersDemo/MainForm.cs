// Image Processing filters demo
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright ?AForge.NET, 2006-2011
// contacts@aforgenet.com
//

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;

namespace FiltersDemo
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MenuItem fileItem;
        private System.Windows.Forms.MenuItem openFileItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem exitFilrItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem sizeItem;
        private System.Windows.Forms.MenuItem normalSizeItem;
        private System.Windows.Forms.MenuItem stretchedSizeItem;
        private System.Windows.Forms.MenuItem centeredSizeItem;
        private System.Windows.Forms.MenuItem filtersItem;
        private System.Windows.Forms.MenuItem noneFiltersItem;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem sepiaFiltersItem;
        private System.Windows.Forms.MenuItem invertFiltersItem;
        private System.Windows.Forms.MenuItem rotateChannelFiltersItem;
        private System.Windows.Forms.MenuItem grayscaleFiltersItem;
        private System.Windows.Forms.MenuItem colorFiltersItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem hueModifierFiltersItem;
        private System.Windows.Forms.MenuItem saturationAdjustingFiltersItem;
        private System.Windows.Forms.MenuItem brightnessAdjustingFiltersItem;
        private System.Windows.Forms.MenuItem contrastAdjustingFiltersItem;
        private System.Windows.Forms.MenuItem hslFiltersItem;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem yCbCrLinearFiltersItem;
        private System.Windows.Forms.MenuItem yCbCrFiltersItem;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem thresholdFiltersItem;
        private System.Windows.Forms.MenuItem floydFiltersItem;
        private System.Windows.Forms.MenuItem orderedDitheringFiltersItem;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem convolutionFiltersItem;
        private System.Windows.Forms.MenuItem sharpenFiltersItem;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem differenceEdgesFiltersItem;
        private System.Windows.Forms.MenuItem homogenityEdgesFiltersItem;
        private System.Windows.Forms.MenuItem sobelEdgesFiltersItem;
        private System.Windows.Forms.MenuItem rgbLinearFiltersItem;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem jitterFiltersItem;
        private System.Windows.Forms.MenuItem oilFiltersItem;
        private MenuItem gaussianFiltersItem;
        private MenuItem textureFiltersItem;
        private IContainer components;

        private System.Drawing.Bitmap sourceImage;
        private MenuItem menuItem9;
        private MenuItem BT709Item;
        private MenuItem RYItem;
        private MenuItem YItem;
        private System.Drawing.Bitmap filteredImage;

        // Constructor
        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // set default size mode of picture box
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileItem = new System.Windows.Forms.MenuItem();
            this.openFileItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.exitFilrItem = new System.Windows.Forms.MenuItem();
            this.filtersItem = new System.Windows.Forms.MenuItem();
            this.noneFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.grayscaleFiltersItem = new System.Windows.Forms.MenuItem();
            this.sepiaFiltersItem = new System.Windows.Forms.MenuItem();
            this.invertFiltersItem = new System.Windows.Forms.MenuItem();
            this.rotateChannelFiltersItem = new System.Windows.Forms.MenuItem();
            this.colorFiltersItem = new System.Windows.Forms.MenuItem();
            this.rgbLinearFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.hueModifierFiltersItem = new System.Windows.Forms.MenuItem();
            this.saturationAdjustingFiltersItem = new System.Windows.Forms.MenuItem();
            this.brightnessAdjustingFiltersItem = new System.Windows.Forms.MenuItem();
            this.contrastAdjustingFiltersItem = new System.Windows.Forms.MenuItem();
            this.hslFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.yCbCrLinearFiltersItem = new System.Windows.Forms.MenuItem();
            this.yCbCrFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.thresholdFiltersItem = new System.Windows.Forms.MenuItem();
            this.floydFiltersItem = new System.Windows.Forms.MenuItem();
            this.orderedDitheringFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.convolutionFiltersItem = new System.Windows.Forms.MenuItem();
            this.sharpenFiltersItem = new System.Windows.Forms.MenuItem();
            this.gaussianFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.differenceEdgesFiltersItem = new System.Windows.Forms.MenuItem();
            this.homogenityEdgesFiltersItem = new System.Windows.Forms.MenuItem();
            this.sobelEdgesFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.jitterFiltersItem = new System.Windows.Forms.MenuItem();
            this.oilFiltersItem = new System.Windows.Forms.MenuItem();
            this.textureFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.sizeItem = new System.Windows.Forms.MenuItem();
            this.normalSizeItem = new System.Windows.Forms.MenuItem();
            this.stretchedSizeItem = new System.Windows.Forms.MenuItem();
            this.centeredSizeItem = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.BT709Item = new System.Windows.Forms.MenuItem();
            this.RYItem = new System.Windows.Forms.MenuItem();
            this.YItem = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileItem,
            this.filtersItem,
            this.sizeItem});
            // 
            // fileItem
            // 
            this.fileItem.Index = 0;
            this.fileItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.openFileItem,
            this.menuItem3,
            this.exitFilrItem});
            this.fileItem.Text = "&File";
            // 
            // openFileItem
            // 
            this.openFileItem.Index = 0;
            this.openFileItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.openFileItem.Text = "&Open";
            this.openFileItem.Click += new System.EventHandler(this.openFileItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // exitFilrItem
            // 
            this.exitFilrItem.Index = 2;
            this.exitFilrItem.Text = "E&xit";
            this.exitFilrItem.Click += new System.EventHandler(this.exitFilrItem_Click);
            // 
            // filtersItem
            // 
            this.filtersItem.Enabled = false;
            this.filtersItem.Index = 1;
            this.filtersItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.noneFiltersItem,
            this.menuItem1,
            this.grayscaleFiltersItem,
            this.sepiaFiltersItem,
            this.invertFiltersItem,
            this.rotateChannelFiltersItem,
            this.colorFiltersItem,
            this.rgbLinearFiltersItem,
            this.menuItem2,
            this.hueModifierFiltersItem,
            this.saturationAdjustingFiltersItem,
            this.brightnessAdjustingFiltersItem,
            this.contrastAdjustingFiltersItem,
            this.hslFiltersItem,
            this.menuItem4,
            this.yCbCrLinearFiltersItem,
            this.yCbCrFiltersItem,
            this.menuItem5,
            this.thresholdFiltersItem,
            this.floydFiltersItem,
            this.orderedDitheringFiltersItem,
            this.menuItem6,
            this.convolutionFiltersItem,
            this.sharpenFiltersItem,
            this.gaussianFiltersItem,
            this.menuItem7,
            this.differenceEdgesFiltersItem,
            this.homogenityEdgesFiltersItem,
            this.sobelEdgesFiltersItem,
            this.menuItem8,
            this.jitterFiltersItem,
            this.oilFiltersItem,
            this.textureFiltersItem,
            this.menuItem9,
            this.BT709Item,
            this.RYItem,
            this.YItem});
            this.filtersItem.Text = "Fi&lters";
            // 
            // noneFiltersItem
            // 
            this.noneFiltersItem.Index = 0;
            this.noneFiltersItem.Text = "&None";
            this.noneFiltersItem.Click += new System.EventHandler(this.noneFiltersItem_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "-";
            // 
            // grayscaleFiltersItem
            // 
            this.grayscaleFiltersItem.Index = 2;
            this.grayscaleFiltersItem.Text = "&Grayscale（灰度）";
            this.grayscaleFiltersItem.Click += new System.EventHandler(this.grayscaleFiltersItem_Click);
            // 
            // sepiaFiltersItem
            // 
            this.sepiaFiltersItem.Index = 3;
            this.sepiaFiltersItem.Text = "&Sepia（深棕色）";
            this.sepiaFiltersItem.Click += new System.EventHandler(this.sepiaFiltersItem_Click);
            // 
            // invertFiltersItem
            // 
            this.invertFiltersItem.Index = 4;
            this.invertFiltersItem.Text = "&Invert（反相）";
            this.invertFiltersItem.Click += new System.EventHandler(this.invertFiltersItem_Click);
            // 
            // rotateChannelFiltersItem
            // 
            this.rotateChannelFiltersItem.Index = 5;
            this.rotateChannelFiltersItem.Text = "RotateChannelsl（旋转通道）";
            this.rotateChannelFiltersItem.Click += new System.EventHandler(this.rotateChannelFiltersItem_Click);
            // 
            // colorFiltersItem
            // 
            this.colorFiltersItem.Index = 6;
            this.colorFiltersItem.Text = "ColorFiltering（颜色过滤）";
            this.colorFiltersItem.Click += new System.EventHandler(this.colorFiltersItem_Click);
            // 
            // rgbLinearFiltersItem
            // 
            this.rgbLinearFiltersItem.Index = 7;
            this.rgbLinearFiltersItem.Text = "LevelsLinear（水平线性校正）";
            this.rgbLinearFiltersItem.Click += new System.EventHandler(this.rgbLinearFiltersItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 8;
            this.menuItem2.Text = "-";
            // 
            // hueModifierFiltersItem
            // 
            this.hueModifierFiltersItem.Index = 9;
            this.hueModifierFiltersItem.Text = "HueModifier(色调)";
            this.hueModifierFiltersItem.Click += new System.EventHandler(this.hueModifierFiltersItem_Click);
            // 
            // saturationAdjustingFiltersItem
            // 
            this.saturationAdjustingFiltersItem.Index = 10;
            this.saturationAdjustingFiltersItem.Text = "SaturationCorrection（饱和度）";
            this.saturationAdjustingFiltersItem.Click += new System.EventHandler(this.saturationAdjustingFiltersItem_Click);
            // 
            // brightnessAdjustingFiltersItem
            // 
            this.brightnessAdjustingFiltersItem.Index = 11;
            this.brightnessAdjustingFiltersItem.Text = "BrightnessCorrection（亮度）";
            this.brightnessAdjustingFiltersItem.Click += new System.EventHandler(this.brightnessAdjustingFiltersItem_Click);
            // 
            // contrastAdjustingFiltersItem
            // 
            this.contrastAdjustingFiltersItem.Index = 12;
            this.contrastAdjustingFiltersItem.Text = "ContrastCorrection（对比度）";
            this.contrastAdjustingFiltersItem.Click += new System.EventHandler(this.contrastAdjustingFiltersItem_Click);
            // 
            // hslFiltersItem
            // 
            this.hslFiltersItem.Index = 13;
            this.hslFiltersItem.Text = "HSLFiltering（HSL通道过滤器）";
            this.hslFiltersItem.Click += new System.EventHandler(this.hslFiltersItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 14;
            this.menuItem4.Text = "-";
            // 
            // yCbCrLinearFiltersItem
            // 
            this.yCbCrLinearFiltersItem.Index = 15;
            this.yCbCrLinearFiltersItem.Text = "YCbCrLinear(YCbCr通道的线性校正)";
            this.yCbCrLinearFiltersItem.Click += new System.EventHandler(this.yCbCrLinearFiltersItem_Click);
            // 
            // yCbCrFiltersItem
            // 
            this.yCbCrFiltersItem.Index = 16;
            this.yCbCrFiltersItem.Text = "YCbCrFiltering（YCbCr通道过滤器）";
            this.yCbCrFiltersItem.Click += new System.EventHandler(this.yCbCrFiltersItem_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 17;
            this.menuItem5.Text = "-";
            // 
            // thresholdFiltersItem
            // 
            this.thresholdFiltersItem.Index = 18;
            this.thresholdFiltersItem.Text = "Threshold(阈值二值化)";
            this.thresholdFiltersItem.Click += new System.EventHandler(this.thresholdFiltersItem_Click);
            // 
            // floydFiltersItem
            // 
            this.floydFiltersItem.Index = 19;
            this.floydFiltersItem.Text = "FloydSteinbergDithering(Floyd Steinberg误差扩散抖动)";
            this.floydFiltersItem.Click += new System.EventHandler(this.floydFiltersItem_Click);
            // 
            // orderedDitheringFiltersItem
            // 
            this.orderedDitheringFiltersItem.Index = 20;
            this.orderedDitheringFiltersItem.Text = "OrderedDithering(阈值矩阵二值化)";
            this.orderedDitheringFiltersItem.Click += new System.EventHandler(this.orderedDitheringFiltersItem_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 21;
            this.menuItem6.Text = "-";
            // 
            // convolutionFiltersItem
            // 
            this.convolutionFiltersItem.Index = 22;
            this.convolutionFiltersItem.Text = "Convolution(卷积)";
            this.convolutionFiltersItem.Click += new System.EventHandler(this.convolutionFiltersItem_Click);
            // 
            // sharpenFiltersItem
            // 
            this.sharpenFiltersItem.Index = 23;
            this.sharpenFiltersItem.Text = "Sharpen(尖锐化)";
            this.sharpenFiltersItem.Click += new System.EventHandler(this.sharpenFiltersItem_Click);
            // 
            // gaussianFiltersItem
            // 
            this.gaussianFiltersItem.Index = 24;
            this.gaussianFiltersItem.Text = "GaussianBlur（高斯模糊）";
            this.gaussianFiltersItem.Click += new System.EventHandler(this.gaussianFiltersItem_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 25;
            this.menuItem7.Text = "-";
            // 
            // differenceEdgesFiltersItem
            // 
            this.differenceEdgesFiltersItem.Index = 26;
            this.differenceEdgesFiltersItem.Text = "DifferenceEdgeDetector（边缘检测）";
            this.differenceEdgesFiltersItem.Click += new System.EventHandler(this.differenceEdgesFiltersItem_Click);
            // 
            // homogenityEdgesFiltersItem
            // 
            this.homogenityEdgesFiltersItem.Index = 27;
            this.homogenityEdgesFiltersItem.Text = "HomogenityEdgeDetector(均匀性边缘检测器)";
            this.homogenityEdgesFiltersItem.Click += new System.EventHandler(this.homogenityEdgesFiltersItem_Click);
            // 
            // sobelEdgesFiltersItem
            // 
            this.sobelEdgesFiltersItem.Index = 28;
            this.sobelEdgesFiltersItem.Text = "SobelEdgeDetector(索贝尔边缘检测器)";
            this.sobelEdgesFiltersItem.Click += new System.EventHandler(this.sobelEdgesFiltersItem_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 29;
            this.menuItem8.Text = "-";
            // 
            // jitterFiltersItem
            // 
            this.jitterFiltersItem.Index = 30;
            this.jitterFiltersItem.Text = "Jitter(抖动滤波器)";
            this.jitterFiltersItem.Click += new System.EventHandler(this.jitterFiltersItem_Click);
            // 
            // oilFiltersItem
            // 
            this.oilFiltersItem.Index = 31;
            this.oilFiltersItem.Text = "OilPainting(油画)";
            this.oilFiltersItem.Click += new System.EventHandler(this.oilFiltersItem_Click);
            // 
            // textureFiltersItem
            // 
            this.textureFiltersItem.Index = 32;
            this.textureFiltersItem.Text = "Texture（纹理）";
            this.textureFiltersItem.Click += new System.EventHandler(this.textureFiltersItem_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 33;
            this.menuItem9.Text = "-";
            // 
            // sizeItem
            // 
            this.sizeItem.Index = 2;
            this.sizeItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.normalSizeItem,
            this.stretchedSizeItem,
            this.centeredSizeItem});
            this.sizeItem.Text = "&Size mode";
            this.sizeItem.Popup += new System.EventHandler(this.sizeItem_Popup);
            // 
            // normalSizeItem
            // 
            this.normalSizeItem.Index = 0;
            this.normalSizeItem.Text = "&Normal";
            this.normalSizeItem.Click += new System.EventHandler(this.normalSizeItem_Click);
            // 
            // stretchedSizeItem
            // 
            this.stretchedSizeItem.Index = 1;
            this.stretchedSizeItem.Text = "&Stretched";
            this.stretchedSizeItem.Click += new System.EventHandler(this.stretchedSizeItem_Click);
            // 
            // centeredSizeItem
            // 
            this.centeredSizeItem.Index = 2;
            this.centeredSizeItem.Text = "&Centered";
            this.centeredSizeItem.Click += new System.EventHandler(this.centeredSizeItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files (*.jpg,*.png,*.tif,*.bmp,*.gif)|*.jpg;*.png;*.tif;*.bmp;*.gif|JPG fil" +
    "es (*.jpg)|*.jpg|PNG files (*.png)|*.png|TIF files (*.tif)|*.tif|BMP files (*.bm" +
    "p)|*.bmp|GIF files (*.gif)|*.gif";
            this.openFileDialog.Title = "Open image";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(7, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(528, 315);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // BT709Item
            // 
            this.BT709Item.Index = 34;
            this.BT709Item.Text = "BT709";
            this.BT709Item.Click += new System.EventHandler(this.BT709Item_Click);
            // 
            // RYItem
            // 
            this.RYItem.Index = 35;
            this.RYItem.Text = "R-Y";
            this.RYItem.Click += new System.EventHandler(this.RYItem_Click);
            // 
            // YItem
            // 
            this.YItem.Index = 36;
            this.YItem.Text = "Y";
            this.YItem.Click += new System.EventHandler(this.YItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(542, 325);
            this.Controls.Add(this.pictureBox);
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(384, 258);
            this.Name = "MainForm";
            this.Text = "Image Processing filters demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }

        // On File->Exit menu item
        private void exitFilrItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        // On File->Open menu item
        private void openFileItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                // show file open dialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // load image
                    sourceImage = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                    //Console.WriteLine(openFileDialog.FileName);
                    // check pixel format
                    if ((sourceImage.PixelFormat == PixelFormat.Format16bppGrayScale) ||
                         (Bitmap.GetPixelFormatSize(sourceImage.PixelFormat) > 32))
                    {
                        MessageBox.Show("The demo application supports only color images.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // free image
                        sourceImage.Dispose();
                        sourceImage = null;
                    }
                    else
                    {
                        // make sure the image has 24 bpp format
                        if (sourceImage.PixelFormat != PixelFormat.Format24bppRgb)
                        {
                            Bitmap temp = AForge.Imaging.Image.Clone(sourceImage, PixelFormat.Format24bppRgb);
                            sourceImage.Dispose();
                            sourceImage = temp;
                        }
                    }

                    ClearCurrentImage();

                    // display image
                    pictureBox.Image = sourceImage;
                    noneFiltersItem.Checked = true;

                    // enable filters menu
                    filtersItem.Enabled = (sourceImage != null);
                }
            }
            catch
            {
                MessageBox.Show("Failed loading the image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // On Size mode->Normal menu item
        private void normalSizeItem_Click(object sender, System.EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        // On Size mode->Stretched menu item
        private void stretchedSizeItem_Click(object sender, System.EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // On Size mode->Centered size menu item
        private void centeredSizeItem_Click(object sender, System.EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        // On Size menu item popup
        private void sizeItem_Popup(object sender, System.EventArgs e)
        {
            normalSizeItem.Checked = (pictureBox.SizeMode == PictureBoxSizeMode.Normal);
            stretchedSizeItem.Checked = (pictureBox.SizeMode == PictureBoxSizeMode.StretchImage);
            centeredSizeItem.Checked = (pictureBox.SizeMode == PictureBoxSizeMode.CenterImage);
        }

        // Clear current image in picture box
        private void ClearCurrentImage()
        {
            // clear current image from picture box
            pictureBox.Image = null;
            // free current image
            if ((noneFiltersItem.Checked == false) && (filteredImage != null))
            {
                filteredImage.Dispose();
                filteredImage = null;
            }
            // uncheck all menu items
            foreach (MenuItem item in filtersItem.MenuItems)
                item.Checked = false;
        }

        // Apply filter to the source image and show the filtered image
        private void ApplyFilter(IFilter filter)
        {
            ClearCurrentImage();
            // apply filter
            filteredImage = filter.Apply(sourceImage);
            // display filtered image
            pictureBox.Image = filteredImage;
        }

        // On Filters->None item
        private void noneFiltersItem_Click(object sender, System.EventArgs e)
        {
            ClearCurrentImage();
            // display source image
            pictureBox.Image = sourceImage;
            noneFiltersItem.Checked = true;
        }

        // On Filters->Grayscale item
        private void grayscaleFiltersItem_Click(object sender, System.EventArgs e)
        {
            ApplyFilter(Grayscale.CommonAlgorithms.BT709);
            grayscaleFiltersItem.Checked = true;
        }

        // On Filters->Sepia item
        private void sepiaFiltersItem_Click(object sender, System.EventArgs e)
        {
            ApplyFilter(new Sepia());
            sepiaFiltersItem.Checked = true;
        }

        // On Filters->Invert item
        private void invertFiltersItem_Click(object sender, System.EventArgs e)
        {
            ApplyFilter(new Invert());
            invertFiltersItem.Checked = true;
        }

        // On Filters->Rotate Channels item
        private void rotateChannelFiltersItem_Click(object sender, System.EventArgs e)
        {
            ApplyFilter(new RotateChannels());
            rotateChannelFiltersItem.Checked = true;
        }

        // On Filters->Color filtering
        //颜色校正
        private void colorFiltersItem_Click(object sender, System.EventArgs e)
        {
            //将指定颜色区间用指定的颜色填充（默认为黑色，可以指定fileColor属性）
            ApplyFilter(new ColorFiltering(new IntRange(25, 230), new IntRange(25, 230), new IntRange(25, 230)));
            colorFiltersItem.Checked = true;
        }

        // On Filters->Hue modifier
        //色调定义（改变色调）
        private void hueModifierFiltersItem_Click(object sender, System.EventArgs e)
        {
            /*
            滤波器在HSL颜色空间中操作，并更新像素的色调值，
            将其设置为指定值（亮度和饱和度保持不变）。
            滤波器的结果看起来像通过给定颜色的玻璃观察到图像。
            范围：-180，50，300都可以，具体是多少未验证
            */
            ApplyFilter(new HueModifier(50));
            hueModifierFiltersItem.Checked = true;
        }

        // On Filters->Saturation adjusting
        //饱和度调节
        private void saturationAdjustingFiltersItem_Click(object sender, System.EventArgs e)
        {
            /*
            增加或减少指定百分比，-减少，+增加
            */
            ApplyFilter(new SaturationCorrection(0.15f));
            saturationAdjustingFiltersItem.Checked = true;
        }

        // On Filters->Brightness adjusting
        //亮度
        private void brightnessAdjustingFiltersItem_Click(object sender, System.EventArgs e)
        {
            //设置范围： [-255, 255]
            //默认为10，可以通过构造函数设置，比如：new BrightnessCorrection(-50)
            ApplyFilter(new BrightnessCorrection());
            brightnessAdjustingFiltersItem.Checked = true;
        }

        // On Filters->Contrast adjusting
        //对比度
        private void contrastAdjustingFiltersItem_Click(object sender, System.EventArgs e)
        {
            /*
            该滤波器基于LevelsLinear滤波器，在因子值为正的情况下，
            简单地将所有输入范围设置为(Factor，255-Factor)，
            将所有输出范围设置为(0，255)。
            如果因子值为负，则所有输入范围都设置为(0，255)，
            所有输出范围都设置为(-Factor，255_Factor)。
            */
            /*
            范围：[-127, 127]. 
            默认为10，可以通过构造函数设置，比如：new ContrastCorrection(-50)
            */
            ApplyFilter(new ContrastCorrection());
            contrastAdjustingFiltersItem.Checked = true;
        }

        // On Filters->HSL filtering
        /// <summary>
        /// HSL颜色空间中颜色过滤
        /// Hue :色调
        /// Saturation ：对比度
        ///Luminance :亮度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hslFiltersItem_Click(object sender, System.EventArgs e)
        {
            HSLFiltering ff = new HSLFiltering(new IntRange(330, 30), new Range(0, 1), new Range(0, 1));
            //如果为false,则用指定的颜色填充区间内的像素，如果为true，则用指定的颜色填充区间外的像素（默认为true）
            ff.FillOutsideRange = false;
            ff.FillColor = new HSL(330, 0.5f, 0.5f);
            ApplyFilter(ff);
            hslFiltersItem.Checked = true;
        }

        // On Filters->YCbCr filtering
        /// <summary>
        /// 该滤波器工作在YCbCr颜色空间中，
        /// 并且提供对其通道的线性校正设施——将指定通道的输入范围映射到指定输出范围。
        /// 能够改变图像的色彩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yCbCrLinearFiltersItem_Click(object sender, System.EventArgs e)
        {
            YCbCrLinear filter = new YCbCrLinear();

            //InCb:[-0.5~0.5]
            //InCr:[-0.5~0.5]
            //InY:[0~1]
            filter.InCb = new Range(-0.276f, 0.163f);
            filter.InCr = new Range(-0.202f, 0.500f);
            ApplyFilter(filter);
            yCbCrLinearFiltersItem.Checked = true;
        }

        // On Filters->YCbCr filtering
        /// <summary>
        /// YCbCr颜色空间中颜色过滤器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yCbCrFiltersItem_Click(object sender, System.EventArgs e)
        {
            YCbCrFiltering ff = new YCbCrFiltering(new Range(0.2f, 0.9f), new Range(-0.3f, 0.3f), new Range(-0.3f, 0.3f));
            ff.FillColor = new YCbCr(0.2f, 0.3f, 0.3f);
            ff.FillOutsideRange = false;//false:用指定颜色填充区间外的像素，true：填充区间内的像素（默认为true）
            ApplyFilter(ff);
            yCbCrFiltersItem.Checked = true;
        }

        // On Filters->Threshold binarization
        /// <summary>
        /// 使用指定的阈值进行二值化，源图像必须是一个8bpp/16bpp的灰度图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thresholdFiltersItem_Click(object sender, System.EventArgs e)
        {
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply threshold filter
            ApplyFilter(new Threshold());//可以指定阈值new Threshold(128)，默认128
            /*
            在8bpp图像的情况下，阈值在[0,255]范围内，
            在16bpp图像的情况下，阈值在[0,65535]范围内。
            */
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            thresholdFiltersItem.Checked = true;
        }

        // On Filters->Floyd-Steinberg dithering
        /// <summary>
        /// Floyd Steinberg误差扩散抖动
        /// 该滤波器表示基于Floyd Steinberg系数的误差扩散抖动的二值化滤波器。误差扩散到4个相邻像素的下一个系数：
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void floydFiltersItem_Click(object sender, System.EventArgs e)
        {
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply threshold filter
            ApplyFilter(new FloydSteinbergDithering());//可以通过属性设置阈值，默认为128
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            floydFiltersItem.Checked = true;
        }

        // On Filters->Ordered dithering
        /// <summary>
        /// 滤波器的概念与阈值滤波器的概念相同——如果像素的强度等于或高于阈值，则将像素值更改为白色，否则将更改为黑色。
        /// 不同的是滤波器使用阈值矩阵。处理图像被划分为每个矩阵大小的相邻窗口。
        /// 对于每个窗口内的像素二值化，从指定的阈值矩阵使用相应的阈值。
        /// 矩阵可以是以下这样
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //    byte[,] matrix = new byte[4, 4]
        // {
        //{  95, 233, 127, 255 },
        //{ 159,  31, 191,  63 },
        //{ 111, 239,  79, 207 },
        //{ 175,  47, 143,  15 }
        // };

        private void orderedDitheringFiltersItem_Click(object sender, System.EventArgs e)
        {


            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply threshold filter
            ApplyFilter(new OrderedDithering());//可以通过构造函数传递一个矩阵，new OrderedDithering(matrix)
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            orderedDitheringFiltersItem.Checked = true;
        }

        // On Filters->Correlation
        /// <summary>
        /// 卷积，不同的卷积内核会出现截然不同的效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convolutionFiltersItem_Click(object sender, System.EventArgs e)
        {
            // define emboss kernel
            int[,] kernel1 = {
            { -2, -1,  0 },
            { -1,  1,  1 },
            {  0,  1,  2 } };

            // define emboss kernel
            int[,] kernel2 = {
            { 1, 2, 3, 2, 1 },
            { 2, 4, 5, 4, 2 },
            { 3, 5, 6, 5, 3 },
            { 2, 4, 5, 4, 2 },
            { 1, 2, 3, 2, 1 }  };

            int[,] kernel3 = {
            { 0, -1, 0 },
            { 0, -1, 0 },
            { 0, -1, 0 }, };

            ApplyFilter(new Convolution(kernel1));
            convolutionFiltersItem.Checked = true;
        }

        // On Filters->Sharpen
        /// <summary>
        /// 尖锐化，内部使用默认的内核进行卷积,效果不同于直接进行卷积操作（不清楚为什么）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sharpenFiltersItem_Click(object sender, System.EventArgs e)
        {
            /*
             0  -1   0
            -1   5  -1
             0  -1   0
            */
            //卷积核必须是正方形，其宽度/高度应该是奇数，并且应该在[3, 99 ]范围内
            ApplyFilter(new Sharpen());
            sharpenFiltersItem.Checked = true;
        }

        // On Filters->Difference edge detector
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void differenceEdgesFiltersItem_Click(object sender, System.EventArgs e)
        {
            /*
            滤波器通过计算围绕处理像素的4个方向上的像素之间的最大差异来找到对象的边缘。
            假设源图像的3x3平方元素（x-是当前处理的像素）：
            P1 P2 P3
            P8 X  P4
            P7 P6 P5
            结果图像的对应像素等于：
            最大值（|p1-p5|，|p2-p6|，|p3-p7|，|p4-p8|）
            */
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply edge filter
            ApplyFilter(new DifferenceEdgeDetector());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            differenceEdgesFiltersItem.Checked = true;
        }

        // On Filters->Homogenity edge detector
        private void homogenityEdgesFiltersItem_Click(object sender, System.EventArgs e)
        {
            /*
            该滤波器通过计算处理像素与相邻像素在8方向上的最大差异来找到对象的边缘。
            假设源图像的3x3平方元素（x-是当前处理的像素）：
            P1 P2 P3
            P8 X  P4
            P7 P6 P5
            结果图像的对应像素等于：
            极大值(  |X-P1|，|X-P2|，|X-P3|，|X-P4|，
                     |X-P5|，|X-P6|，|X-P7|，|X-P8|）
            */
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply edge filter
            ApplyFilter(new HomogenityEdgeDetector());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            homogenityEdgesFiltersItem.Checked = true;
        }

        // On Filters->Sobel edge detector
        /// <summary>
        /// 索贝尔边缘检测器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sobelEdgesFiltersItem_Click(object sender, System.EventArgs e)
        {
            /*
            结果图像的每个像素被计算为源图像的相应像素的近似绝对梯度大小：
            | G | = | GX | + | Gy ]，
            利用Sobel卷积核计算Gx和Gy：
            GX          GY
            -1 0 ＋1     ＋1 ＋2 +1
            -2 0 +2      0  0   0
            -1 0 +1     -1 -2   -1
            使用上述内核，使用下一个方程计算像素X的近似大小：
            P1 P2 P3
            P8 X  P4
            P7 P6 P5
            |G| = |P1 + 2P2 + P3 - P7 - 2P6 - P5| +
                  |P3 + 2P4 + P5 - P1 - 2P8 - P7|
            */
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply edge filter
            ApplyFilter(new SobelEdgeDetector());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

            sobelEdgesFiltersItem.Checked = true;
        }

        // On Filters->Levels Linear Correction
        //水平线性矫正
        private void rgbLinearFiltersItem_Click(object sender, System.EventArgs e)
        {
            LevelsLinear filter = new LevelsLinear();

            /*
            该滤波器通过将指定信道的输入范围映射到输出范围来执行对RGB信道的线性校正。
            它类似于颜色映射，但是重新映射是线性的。
            */
            filter.InRed = new IntRange(30, 230);
            filter.InGreen = new IntRange(50, 240);
            filter.InBlue = new IntRange(10, 210);

            ApplyFilter(filter);
            rgbLinearFiltersItem.Checked = true;
        }

        // On Filters->Jitter
        /// <summary>
        /// 抖动滤波器
        /// 滤波器在指定半径的窗口内以随机方向移动源图像的每个像素。
        ///该滤波器接受8个BPP灰度图像和24/32个彩色图像进行处理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jitterFiltersItem_Click(object sender, System.EventArgs e)
        {
            ApplyFilter(new Jitter());//可以通过构造函数传入抖动半径Radius[1~10];
            jitterFiltersItem.Checked = true;
        }

        // On Filters->Oil Painting
        //油画效果
        //用一个窗口内最频繁的像素代替周围像素
        private void oilFiltersItem_Click(object sender, System.EventArgs e)
        {
            //brushSize：搜寻的窗口大小
            ApplyFilter(new OilPainting());//可以通过构造函数传递brushSize[3~21]，默认为5
            oilFiltersItem.Checked = true;
        }

        // On Filters->Gaussin blur
        //高斯模糊，内部也是卷积操作，
        private void gaussianFiltersItem_Click(object sender, EventArgs e)
        {

            //sigma(double)：[0.5~5.0],默认为1.4
            //size(int32)：  [3~21]默认为5
            ApplyFilter(new GaussianBlur(2.0, 7));//sigma(double)，size(int32)
            gaussianFiltersItem.Checked = true;
        }

        // On Filters->Texture
        /// <summary>
        /// 纹理滤波器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textureFiltersItem_Click(object sender, EventArgs e)
        {
            /*Texturer说明
            使用给定纹理的因素调整像素的颜色值。结合不同类型的纹理生成器，过滤器可以产生不同类型的有趣效果。
            筛选器使用指定的纹理来使用下一个公式调整值：
            dst = src * PreserveLevel + src * FilterLevel * textureValue,
            其中，src是源图像中的像素值，dst是目的地图像中的像素值，并且textureValue是来自所提供的纹理的对应值。
            使用RealVeleVE和FilterLevel ，可以控制由纹理影响的源数据的部分。
            在大多数情况下， PreserveLevel和FilterLevel 属性以这样的方式设置，即FieleVele+FieldLe＝1。
            但是这些值实际上没有限制，因此它们的总和可以大于1，从而创建不同类型的效果。
            */
            //纹理的产生
            /*
            new Texturer(ITextureGenerator generator, Double filterLevel, Double preserveLevel)
            filterLevel:过滤因子决定图像分数以过滤-由所提供的纹理的值乘以。默认值设置为0.5。
            preserveLevel:保留因子决定图像分数以避免过滤。默认值设置为0.5。
            */
            ApplyFilter(new Texturer(new TextileTexture(), 1.0, 0.8));
            textureFiltersItem.Checked = true;

            //TextileTexture说明
            /*
            纹理生成器创建纹理与纺织品的效果。发生器是基于PrLin噪声函数的。

            */
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sourceImage = (Bitmap)Bitmap.FromFile(@"C:\Users\Administrator\Desktop\test\html\img\imaging\adaptive_smooth.png");
            ClearCurrentImage();

            // display image
            pictureBox.Image = sourceImage;
            noneFiltersItem.Checked = true;

            // enable filters menu
            filtersItem.Enabled = (sourceImage != null);
        }

        // On Filters->BT709
        private void BT709Item_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            ApplyFilter(Grayscale.CommonAlgorithms.BT709);
            sourceImage.Dispose();
            sourceImage = originalImage;
            BT709Item.Checked = true;
        }
        // On Filters->R-Y
        private void RYItem_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            ApplyFilter(Grayscale.CommonAlgorithms.RMY);
            sourceImage.Dispose();
            sourceImage = originalImage;
            BT709Item.Checked = true;
        }
        // On Filters->Y
        private void YItem_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            ApplyFilter(Grayscale.CommonAlgorithms.Y);
            sourceImage.Dispose();
            sourceImage = originalImage;
            BT709Item.Checked = true;
        }
    }
}
