using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSBoard
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //기본폴더 만들기
        }

        protected void link_intro_Click(object sender, EventArgs e)
        {
            GoToLink("MainUserControl/ProgrammIntro.ascx", this.main_content);            
        }

        protected void link_statistics_Click(object sender, EventArgs e)
        {
            if (GlobalCS.CheckUser())
            {
                GoToLink("MainUserControl/ProgrammStatistics.ascx", this.main_content);                
            }
            else
            {
                GoToLink("MainUserControl/FailPage.ascx", this.main_content);
            }
        }

        protected void link_bigdata_Click(object sender, EventArgs e)
        {
            GoToLink("MainUserControl/Bigdata.ascx", this.main_content);            
        }

        protected void link_home_Click(object sender, EventArgs e)
        {
            GoToLink("MainUserControl/Home.ascx", this.main_content);            
        }
        private void GoToLink(string path, Control ContentControl)
        {
            Control userControl = LoadControl(path);
            ContentControl.Controls.Clear();
            ContentControl.Controls.Add(userControl);
        }
    }
}