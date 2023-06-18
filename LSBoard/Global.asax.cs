using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace LSBoard
{
    public class Global : System.Web.HttpApplication
    {
        //어플리케이션 시작시 실행
        protected void Application_Start(object sender, EventArgs e)
        {            
            RegisterRoutes(RouteTable.Routes);          
        }

        private void RegisterRoutes(RouteCollection routes) // 라우터 테이블을 추가/관리하는 메서드
        {
            routes.MapPageRoute("", "", "~/Main.aspx");
            routes.MapPageRoute("LSBoard", "LSBoard", "~/Menu.aspx");
        }
    }
}