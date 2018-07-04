using CefSharp;
using FISCA;
using FISCA.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSenateTab
{
    public class Program
    {
        [MainMethod()]
        public static void Main()
        {
            SenateTab st = new SenateTab();
            MotherForm.AddPanel(st);

            RibbonBarItem StuItem4 = FISCA.Presentation.MotherForm.RibbonBarItems["說明手冊", "網頁功能"];
            //StuItem4["上一頁"].Size = RibbonBarButton.MenuButtonSize.Large;
            //StuItem4["上一頁"].Click += delegate
            //{
            //    st.browser.Back();
            //};
            //StuItem4["下一頁"].Size = RibbonBarButton.MenuButtonSize.Large;
            //StuItem4["下一頁"].Click += delegate
            //{
            //    st.browser.Forward();
            //};

            StuItem4["重新整理"].Image = Properties.Resources.reload_64_2;
            StuItem4["重新整理"].Size = RibbonBarButton.MenuButtonSize.Large;
            StuItem4["重新整理"].Click += delegate
            {
                st.browser.Reload();
            };




            IList<IFeature> list = Features.EnumerateFeatures();
            foreach (IFeature each in list)
            {
                Console.WriteLine(each.Code);
            }
        }
    }
}