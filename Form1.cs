using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Properties;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        Machine machine = new Machine();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        { 
        }

        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            // Create image.
            Image imageFile = Image.FromFile("android.png");


            // Draw image to screen.
            e.Graphics.DrawImage(imageFile, new PointF(120.0F, 120.0F));
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
         }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Color ActiveColor = Color.SpringGreen;
            clearLableBoxes();
             foreach (var item in machine.Apples)
            {
                switch (item.location)
                {
                    case MachineParts.FirstTrackStart:
                        labelFirstTrackStart.BackColor = ActiveColor;
                        break;
                    case MachineParts.CorruptionCheck:
                        labelCorruptionCheck.BackColor = ActiveColor;
                        break;
                    case MachineParts.CorruptedBasket:
                        labelCorruptionBasket.BackColor = ActiveColor;
                        break;
                    case MachineParts.FirstTrackEnd:
                        labelFirstTrackEnd.BackColor = ActiveColor;
                        break;
                    case MachineParts.SizeCheck:
                        labelSizeCheck.BackColor = ActiveColor;
                        break;
                    case MachineParts.BigSizeTrack:
                        labelBigSizeTrack.BackColor = ActiveColor;
                        break;
                    case MachineParts.SmallSizeTrack:
                        labelSmallSizeTrack.BackColor = ActiveColor;
                        break;
                    case MachineParts.BigBasket:
                        labelBigSizeBasket.BackColor = ActiveColor;
                        break;
                    case MachineParts.SmallBasket:
                        labelSmallSizeBasket.BackColor = ActiveColor;
                        break;
                    default:
                        break;
                }
            }
            machine.run();
        }

        private void clearLableBoxes()
        {
            labelFirstTrackStart.BackColor = Color.Silver;
            labelCorruptionCheck.BackColor = Color.Silver;
            labelCorruptionBasket.BackColor = Color.Silver;
            labelFirstTrackEnd.BackColor = Color.Silver;
            labelSizeCheck.BackColor = Color.Silver;
            labelBigSizeTrack.BackColor = Color.Silver;
            labelBigSizeBasket.BackColor = Color.Silver;
            labelSmallSizeTrack.BackColor = Color.Silver;
            labelSmallSizeBasket.BackColor = Color.Silver;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            machine.addApple(AppleSize.Big, false);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            machine.addApple(radioSizeBig.Checked ? AppleSize.Big : AppleSize.Small, checkBoxIsCorrupted.Checked);
        }
    }
}
