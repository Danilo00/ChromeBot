using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Timers;

namespace ChromeBot_by_DC
{
    public partial class Form1 : Form
    {
        string chromedriver_path = Environment.CurrentDirectory;
        //string chromedriver_path = @"C:\Users\danilo.cappabianca\source\repos\ChromeBot by DC";
        List<string> urlList = new List<string>();
        List<string> proxyList = new List<string>();
        int visit = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(File.Exists(chromedriver_path + "\\chromedriver.exe"))
            {
                if (urlList.Count > 0) //don't execute if UrlList is not loaded yet
                {
                    try
                    {
                        visit = 0;
                        ChromeOptions options = new ChromeOptions();
                        /*
                         * You can add every options argument you need. More info in Selenium documents.
                         * some examples here:
                        options.AddArgument("--proxy-server=" + string_proxy);
                        options.AddArgument("--silent");
                        options.AddArgument("--log-level=3");
                        options.AddArgument("--lang=en");
                        options.AddArgument("--disable-logging");
                        options.AddArgument("--no-sandbox");
                        options.AddArgument("--disable-infobars");
                        options.AddArgument("--ignore-certificate-errors");
                        options.AddArgument("--disable-dev-shm-usage");
                        options.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
                        */
                        for (int i = 0; i < nThreads.Value; i++)
                        {
                            //select a different random URL from List every thread (can be only one too)
                            Random random = new Random();
                            int r = random.Next(0, urlList.Count - 1);
                            string url = urlList[r];

                            //select a different random PROXY from List every thread (if exist)
                            string proxy = string.Empty;
                            if (proxyList.Count > 0)
                            {
                                r = random.Next(0, proxyList.Count - 1);
                                proxy = proxyList[r];
                            }

                            //Run each thread with different configuration                    
                            Thread thread = new Thread(() => OpenUrl(options, chromedriver_path, url, proxy))
                            {
                                IsBackground = true
                            };
                            thread.Start();
                            //System.Threading.Thread.Sleep(2 * 1000);               
                        }
                    }
                    catch (Exception ex){ File.AppendAllText("errorLog.txt",DateTime.Now + " | " + ex.Message); }
                }
                else MessageBox.Show("You need to upload at least one URL","URL List is missing!",MessageBoxButtons.OK,MessageBoxIcon.Warning);              
            }
            else MessageBox.Show("Chromedriver.exe is missing in the executable file same folder.\nMake sure you have installed latest version for your browser.\nIf you need you can download at: https://chromedriver.chromium.org/downloads","Chromedriver is missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Run Chrome Browser with declared options.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="chromedriver_path">Without this driver this software can't work. Make sure you have installed latest version for your browser.If you need you can download at: https://chromedriver.chromium.org/downloads</param>
        /// <param name="url">Link</param>
        /// <param name="proxy">IP</param>
        public void OpenUrl(ChromeOptions options, string chromedriver_path, string url, string proxy)
        {
            int nVisits = urlList.Count; //set default of visits equal as number of URLs (if user forgot to set)
            if (proxy != string.Empty) options.AddArgument("--proxy-server=" + proxy);
            try
            {
                if (nVisitsUrl.Text != string.Empty)
                {
                    if (nVisitsUrl.Text != string.Empty)
                        nVisits = int.Parse(nVisitsUrl.Text);                    
                    while (visit < nVisits) 
                    {
                        ++visit;
                        IWebDriver Driver = new ChromeDriver(chromedriver_path, options);
                        Driver.Navigate().GoToUrl(url);
                        Driver.Dispose();
                    }
                }
            }
            catch { }
        }

        private void btnUrlList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Txt Files (*.txt)|*.txt;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                urlList.AddRange(File.ReadAllLines(openFileDialog1.FileName));
            }
        }

        private void btnProxyList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Txt Files (*.txt)|*.txt;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                proxyList.AddRange(File.ReadAllLines(openFileDialog1.FileName));
            }
        }
    }
}
