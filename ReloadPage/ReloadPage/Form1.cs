using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;
using QRCoder;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;


namespace ReloadPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RenderQrCode()
        {
         
            QRCodeGenerator.ECCLevel eccLevel = 0;
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBoxQRCode.Text, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {

                        var tmp = qrCode.GetGraphic(3, Color.Black, Color.White,
                            GetIconBitmap(), 0);
                        pictureBoxQRCode.BackgroundImage = tmp;

                        pictureBoxQRCode.ToString();

                        this.pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);

                        //Set the SizeMode to center the image.
                        this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;

                        pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                }
            }
        }

        private Bitmap GetIconBitmap()
        {
            Bitmap img = null;
            if (iconPath.Text.Length > 0)
            {
                try
                {
                    img = new Bitmap(iconPath.Text);
                }
                catch (Exception)
                {
                }
            }
            return img;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RenderQrCode();
        }

        private void button2_Click(object sender, EventArgs e)
        {
   
            var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 0f, 0f, 0f, 0f);
            

            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Tomek\Desktop\test.pdf", FileMode.Append));
            doc.Open();
            doc.SetMargins(0f, 0f, 0f, 0f);
 
            Bitmap qr_image = new Bitmap(pictureBoxQRCode.BackgroundImage);
            qr_image = addTextToImage(qr_image, textBoxQRCode.Text);


            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(qr_image, System.Drawing.Imaging.ImageFormat.Bmp);
       
            
            PdfPTable table = new PdfPTable(6);

            float tmp = 24.75F;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.WidthPercentage = 100;
            table.DefaultCell.FixedHeight = iTextSharp.text.Utilities.MillimetersToPoints(tmp);
            //table.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.DefaultCell.PaddingTop = 1;
            table.DefaultCell.PaddingBottom = 1;

            for (int i=0; i<72; i++)
            {
                pdfImage.ScaleAbsolute(30, 25);
                table.AddCell(pdfImage);
            }
            
            
            doc.Add(table);

            doc.Close();

            textBox1.Text = "chyba działa";
        }
        private Bitmap addTextToImage(Bitmap image, string text)
        {
            Bitmap tmp;
            using (Bitmap newbitmap = new Bitmap(image))
            {
                PointF firstLocation = new PointF(0, 0);
                using (Graphics graphics = Graphics.FromImage(newbitmap))
                {
                    using (System.Drawing.Font arialFont = new System.Drawing.Font("Arial", 8))
                    {
                        //graphics.DrawImage(newbitmap, 0, 0, iTextSharp.text.Utilities.MillimetersToPoints(80), iTextSharp.text.Utilities.MillimetersToPoints(50));
                        graphics.DrawString(text, arialFont, Brushes.Black, firstLocation);
                        
                        //graphics.DrawString(secondText, arialFont, Brushes.Red, secondLocation);
                    }
                }
                tmp = new Bitmap(newbitmap);
                tmp.SetResolution(300, 240);
            }
            return tmp;
        }

    }
}
