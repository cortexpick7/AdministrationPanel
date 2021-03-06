using AdministrationPanel.Forms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Delete window borders
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //variables
        private Button currentButton;
        private Form activeForm;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        //Section activation method which is changing button color and font size if its chosen
        private void ActivateButton(object btnSender) 
        {
            
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ColorTranslator.FromHtml("#255064");
                    currentButton.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    currentButton.Font = new System.Drawing.Font("Myriad Pro", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //Section deactivation method which is changing button color and font size of previous active button to normal
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = ColorTranslator.FromHtml("#E6FAFC");
                    previousBtn.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //Method that opens child form inside panel, to switch between them inside one window
        private void OpenChildButton(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoScroll = true;
            this.panelDesktop1.Controls.Add(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktop1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Navigation buttons actions
        private void shoppingButton_Click(object sender, EventArgs e)
        {
            sctnName.Text = "Cart";
            CartForm newForm = new CartForm();
            OpenChildButton(newForm, sender);
        }

        private void allProductsButton_Click(object sender, EventArgs e)
        {
            sctnName.Text = "All Products";
            AllItemsForm newForm = new AllItemsForm();
            OpenChildButton(newForm, sender);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            sctnName.Text = "Add New";
            AddForm newForm = new AddForm();
            OpenChildButton(newForm, sender);
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            sctnName.Text = "Statistics";
            StatisticsForm newForm = new StatisticsForm();
            OpenChildButton(newForm, sender);
        }


        
        //Make possible moving and resizing window without border
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
