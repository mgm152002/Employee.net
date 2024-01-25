using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve values from TextBox controls
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            EmployeeModel e1 = new EmployeeModel
            {
                first_name = firstName,
                last_name = lastName,
                email = email
            };
            EmpRepo e2 = new EmpRepo();
            e2.AddEmp(e1);

        }
    }
}