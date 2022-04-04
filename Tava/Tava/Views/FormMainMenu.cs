using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tava.Views
{
    public partial class FormMainMenu : Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;


        // Contructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
        }

        // Methods
        private Color SelectThemeColor()
        // We select  random color from the list of color for the theme (Optinal, you can use only one color
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)                                  // If the color has already been selected, we select
            {                                                           // again to choose a different one
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        // We highlight the button that has been clicked (Active form):
        // 1) We select a random for the theme (optional, you can use a single color to highlight the button)
        // 2) We change the background color of the button
        // 3) We change the font color of the button
        // 4) We change the font size of the button

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
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    // 12.5F: By activiting / highlighting a button, we increase the size of the Font-zoom effect (in my case at 12.5)
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,
                                                                           -0.3);
                    // We save the current theme color
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        // We desactivate the highlighting of the button - Default values
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        // We create a method to open the forms in the container panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            // We highlight the button (Activate)
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            // We show the title (Text) of the child form in the title bar (lblTitle)
            //lblTitle.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnProductsRegistration_Click(object sender, EventArgs e)
        {
            // We replace the open form method
            OpenChildForm(new Forms.FormProductsRegistration(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // We replace the open form method
           OpenChildForm(new Forms.FormSalesRegistration(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // We replace the open form method
            OpenChildForm(new Forms.FormInventories(), sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            // We replace the open form method
            OpenChildForm(new Forms.FormProducts(), sender);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
           // We replace the open form method
            OpenChildForm(new Forms.FormSales(), sender);
        }

        private void btnAddresses_Click(object sender, EventArgs e)
        {
            // We replace the open form method
            OpenChildForm(new Forms.FormAddresses(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            // We replace the open form method
            OpenChildForm(new Forms.FormCustomers(), sender);
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activateForm != null)
                activateForm.Close();
            Reset();
        }
    }
}
