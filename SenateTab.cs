using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FISCA.Presentation;
using CefSharp.WinForms;
using CefSharp;

namespace AddSenateTab
{
    public partial class SenateTab : BlankPanel
    {
        public CefSharp.WinForms.ChromiumWebBrowser browser;

        public SenateTab()
        {
            InitializeComponent();

            Group = "說明手冊";

            //舊版本
            //helpContentPanel1.Naviate("http://sites.google.com/a/ischool.com.tw/emba_ntu");

            //新版本
            //helpContentPanel1.Naviate("https://sites.google.com/ischool.com.tw/emba/");

            //2017/10/26 - 鑲崁新的Browser
            //CefSharp.WinForms.ChromiumWebBrowser browser = new ChromiumWebBrowser("https://sites.google.com/ischool.com.tw/test-instruction/");


            browser = new ChromiumWebBrowser("https://sites.google.com/ischool.com.tw/test-instruction/");
            browser.Dock = DockStyle.Fill;
            ContentPanePanel.Controls.Add(browser);

            //改寫
            browser.RequestHandler = new HandlerNe(); //Parse URL
            browser.LifeSpanHandler = new HandlerLife(); //關閉 OnBeforePopup

            this.Load += new System.EventHandler(this.Form_Load);
        }


        private static SenateTab _DFM_admin;

        private void Form_Load(object sender, EventArgs e)
        {
        }
        public static SenateTab Instance
        {
            get { if (_DFM_admin == null) _DFM_admin = new SenateTab(); return _DFM_admin; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ContentPanePanel
            // 
            this.ContentPanePanel.Dock = System.Windows.Forms.DockStyle.None;
            this.ContentPanePanel.Location = new System.Drawing.Point(0, 163);
            this.ContentPanePanel.Size = new System.Drawing.Size(870, 421);
            // 
            // SenateTab
            // 
            this.Name = "SenateTab";
            this.ResumeLayout(false);

        }

        //public void ReSet(string url)
        //{
        //    helpContentPanel1.Naviate(url);
        //}

        //public void GoBack()
        //{
        //    helpContentPanel1.GoBack();
        //}

        //public void GoForward()
        //{
        //    helpContentPanel1.GoForward();
        //}
        //public void URLRefresh()
        //{
        //    helpContentPanel1.URLRefresh();
        //}
        //public void URLStop()
        //{
        //    helpContentPanel1.URLStop();
        //}
    }
}
