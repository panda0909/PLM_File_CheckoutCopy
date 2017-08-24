using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aras.IOM;
using System.Xml;
using System.IO;
using System.Security.Principal;
using System.Runtime.InteropServices;

namespace TLTC_MES_Test
{
   
    public partial class FileCopy : Form
    {
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);
        Innovator inn;
        string file_fullname = "";
        public FileCopy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            //GSEOFunction.GSEOFunctionFactory gseo = new GSEOFunction.GSEOFunctionFactory(inn);
            /*
            string strTaskId = textBox1.Text;

            GSEOFunction.GSEOFunctionFactory gseo = new GSEOFunction.GSEOFunctionFactory(inn);
            
            if (gseo.CheckIsNotExeIntegration(strTaskId))
            {
                MessageBox.Show("error1");
                return;
            }
            */
            //Item r_Form;
            
            
            //r_Form = gseo.GetWorkflowFormByActivityId(strTaskId);
           
            /*
            //string thisType = gseo.GetSourceTypeByActivityId(strTaskId);
            Item r_Form = inn.getItemById("work order", textBox1.Text);
            string thisType = "work order";

            string strIntName = "PLM2MES_Nanya";

            string strIntContID = gseo.GetIntegrationContentID(strIntName, thisType);

            string strResult = gseo.CreateTransformationInfo_NanyaMES_WO(strIntContID, r_Form.getID());
            
            XmlDocument plmXDoc = new XmlDocument();
            plmXDoc.LoadXml(strResult);

            ERPXmlToMES aaa = new ERPXmlToMES();
            string applyReesult=aaa.Apply(plmXDoc);
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Item fileItm = inn.newItem("File","get");
            fileItm.setProperty("id", txtFileID.Text);
            fileItm = fileItm.apply();
            if (fileItm.isError())
            {
                MessageBox.Show(fileItm.getErrorString());
                return;
            }
            else
            {
                fileItm = fileItm.checkout(txtCheckoutPath.Text);
                file_fullname = fileItm.getProperty("checkedout_path");
                txtCheckoutPathAfter.Text = file_fullname;
            }
        }

        private void btnCopyTo_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(txtCheckoutPathAfter.Text, txtLocalPath.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnCopyNet_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(txtCheckoutPathAfter.Text, txtNetPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnCopyNetAD_Click(object sender, EventArgs e)
        {
            try
            {
                AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                IntPtr _TokenHandle = IntPtr.Zero;
                // logon types
                const int LOGON32_LOGON_INTERACTIVE = 2;
                const int LOGON32_LOGON_NETWORK = 3;
                const int LOGON32_LOGON_NEW_CREDENTIALS = 9;

                // logon providers
                const int LOGON32_PROVIDER_DEFAULT = 0;
                const int LOGON32_PROVIDER_WINNT50 = 3;
                const int LOGON32_PROVIDER_WINNT40 = 2;
                const int LOGON32_PROVIDER_WINNT35 = 1;
                //Call LogonUser to obtain a handle to an access token.
                // int returnValue = LogonUser("administrator", "192.168.0.200", "1Qaz2Wsx", LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, ref _TokenHandle);
                bool returnValue = LogonUser(txtAD.Text,txtDomain.Text, txtPWD.Text, LOGON32_LOGON_NEW_CREDENTIALS, LOGON32_PROVIDER_DEFAULT, ref _TokenHandle);
                WindowsImpersonationContext _WindowsImpersonationContext;
                // return "拿到token"+returnValue.ToString();
                if (returnValue)
                {
                    WindowsIdentity newId = new WindowsIdentity(_TokenHandle);
                    _WindowsImpersonationContext = newId.Impersonate();
                    File.Copy(txtCheckoutPathAfter.Text, txtNetPath.Text, true);
                    

                    _WindowsImpersonationContext.Undo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string url = txtPLMIP.Text;
            string db = txtPLMDB.Text;
            string user = txtPLMAD.Text;
            string pw = txtPLMPWD.Text;
            HttpServerConnection cnx = IomFactory.CreateHttpServerConnection(url, db, user, pw);
            Item login_result = cnx.Login();
            if (!login_result.isError())
            {
                inn = IomFactory.CreateInnovator(cnx);
                MessageBox.Show("Login OK!");
            }
        }
    }
}
