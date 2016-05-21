using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2007_S2016_Lesson1B
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = FirstNameTextbox.Text.ToString() + " " + LastNameTextBox.Text.ToString();    
        }
    }
}