using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EmpRepo emp = new EmpRepo();
                // Call the GetEmployees method to retrieve the list of employees
                List<EmployeeModel> employees = emp.GetEmployees();

                // Bind the list of employees to the GridView
                gridView1.DataSource = employees;
                gridView1.DataBind();
            }

        }
       
    }
}