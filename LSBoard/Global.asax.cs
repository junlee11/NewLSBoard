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
            //로그인 페이지
            routes.MapPageRoute("", "", "~/Main.aspx");

            //첫 페이지
            routes.MapPageRoute("LSBoard", "LSBoard", "~/MenuPage/Home.aspx");

            //소개 페이지
            routes.MapPageRoute("LSBoard/Intro", "LSBoard/Intro", "~/MenuPage/Intro.aspx");

            //통계 페이지
            routes.MapPageRoute("LSBoard/Statistics", "LSBoard/Statistics", "~/MenuPage/Statistics.aspx");
        }
    }
}