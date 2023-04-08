using CefSharp;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
namespace wfCarsSiteListen
{    
    public partial class FrmWebSiteListener : Form
    {
        public WebListener webListener = null;
        public FrmWebSiteListener()
        {
            InitializeComponent();
            webListener = new WebListener();
        }      

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                txtContent.Clear();
                string webUrl = txtWebUrl.Text;
                if(string.IsNullOrEmpty(webUrl))
                {
                    throw (new Exception("Site to be listen is empty, please insert a valid url address..."));
                }
                webListener.OpenUrl(webUrl);
                string source = webListener.Page.GetSourceAsync().GetAwaiter().GetResult();
                string txt = webListener.Page.GetTextAsync().GetAwaiter().GetResult();
                File.WriteAllText("d:/testedus.json", source);
                File.WriteAllText("d:/testedustext.json", txt);
                txtContent.Text += source;
            }
            catch (Exception err)
            {
                txtContent.Text = $"An error happened: {err.Message}";
            }
        }

        private void btnToJson_Click(object sender, EventArgs e)
        {
            string content = txtContent.Text;

            string result = JSonParser.ParseToJSon(content);

           //string htmlContent= HttpUtility.HtmlDecode(content);            
           // JObject jsonContent2 = JObject.Parse(htmlContent);


           // JObject jsonContent= JObject.Parse(content);
           // txtContent.Text = jsonContent.ToString();            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
        }
    }
}
