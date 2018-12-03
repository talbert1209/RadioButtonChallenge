using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okayButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "You selected the pencil option.";
                Image.ImageUrl = "~/Images/pencil.png";
            }

            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "You selected the pen option.";
                Image.ImageUrl = "~/Images/pen.png";
            }

            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "You selected the phone option,";
                Image.ImageUrl = "~/Images/phone.png";
            }

            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "You selected the tablet option.";
                Image.ImageUrl = "~/Images/tablet.png";
            }
            else
            {
                resultLabel.Text = "Please select an option.";
            }
        }
    }
}