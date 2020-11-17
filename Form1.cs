using Guna.UI2.WinForms;
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

        VirtualMachine machine = new VirtualMachine();

        Dictionary<MachineParts, Guna2Chip> partToLabel;
        Color ActiveBackgroundColor = Color.LimeGreen, ActiveFontColor = Color.White, DisabledBackgroundColor = Color.Silver, DisabledFontColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }
 



        private void Timer1_Tick(object sender, EventArgs e)
        {
            clearLableBoxes();
            foreach (var item in partToLabel)
            {
                item.Value.FillColor = machine.Parts[item.Key].apple != null ? ActiveBackgroundColor : DisabledBackgroundColor;
                item.Value.ForeColor = machine.Parts[item.Key].apple != null ? ActiveFontColor : DisabledFontColor;
            }
            machine.run();
        }

        private void clearLableBoxes()
        {
            foreach (var item in partToLabel)
            {
                item.Value.FillColor = DisabledFontColor;
                item.Value.ForeColor = DisabledFontColor;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            machine.addApple(new Apple(AppleSize.Small, false));
            partToLabel = new Dictionary<MachineParts, Guna2Chip>
                            {
                                {MachineParts.FirstTrackStart , labelFirstTrackStart},
                                {MachineParts.CorruptionCheck , labelCorruptionCheck},
                                {MachineParts.CorruptedBasket , labelCorruptionBasket},
                                {MachineParts.FirstTrackEnd , labelFirstTrackEnd},
                                {MachineParts.SizeCheck , labelSizeCheck},
                                {MachineParts.BigSizeTrack,labelBigSizeTrack},
                                {MachineParts.SmallSizeTrack,labelSmallSizeTrack },
                                {MachineParts.BigBasket,labelBigSizeBasket },
                                {MachineParts.SmallBasket,labelSmallSizeBasket }
                            };
        }



        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            machine.addApple(new Apple(radioSizeBig.Checked ? AppleSize.Big : AppleSize.Small, checkBoxIsCorrupted.Checked));
        }

        private void Guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
