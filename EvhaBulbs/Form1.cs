using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvhaBulbs
{
    public partial class EvhaBulbs : Form
    {
        public EvhaBulbs()
        {
            InitializeComponent();
            lblHeader.Text = string.Format("port set to {0}", ConfigurationManager.AppSettings["portnumber"]);
            SetImageGreen(pbPrime);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageRelay.GetInstance().RelayIncoming += EvhaBulbs_RelayIncoming;
            lblHeader.Text = string.Format("listening on {0}", ConfigurationManager.AppSettings["portnumber"]);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MessageRelay.GetInstance().RelayIncoming -= EvhaBulbs_RelayIncoming;
            lblHeader.Text = string.Format("port set to {0}", ConfigurationManager.AppSettings["portnumber"]);

        }

        private void EvhaBulbs_RelayIncoming(MessageModel message)
        {
            AddTolistBox(message.ToString());
            HandlePrime(message.Id);

        }

        private void AddTolistBox(string message)
        {
            if (listBoxLog.InvokeRequired)
            {
                listBoxLog.Invoke(new Action<string>(AddTolistBox), message);
                return;
            }

            listBoxLog.Items.Insert(0, message);
        }

        private void SetPrimeDisplay(int nr)
        {
            if (lblPrimeDisplay.InvokeRequired)
            {
                lblPrimeDisplay.Invoke(new Action<int>(SetPrimeDisplay), nr);
                return;
            }

            lblPrimeDisplay.Text = nr.ToString();
        }

        private void HandlePrime(int number)
        {
            if (isPrime(number))
            {
                SetImageRed(pbPrime);
                SetPrimeDisplay(number);
            }
            else
            {
                SetImageGreen(pbPrime);
            }
        }

        private void SetImageRed(PictureBox pb)
        {
            pb.Image = Image.FromFile(@"images\red_light.png");
        }

        private void SetImageGreen(PictureBox pb)
        {
            pb.Image = Image.FromFile(@"images\green_light.png");
        }

        public static bool isPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

    }
}
