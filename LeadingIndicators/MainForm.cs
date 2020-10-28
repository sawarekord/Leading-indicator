using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeadingIndicators
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];

            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
