using WindowsFormsApplication2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Code for the ping function from the Microsoft website
        private static PingReply Ping(string url, int timeout_ms)
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = ping.Send(url, timeout_ms);
                    return reply;
                }
                catch (Exception ex)
                {
                    return null;//returns null if you do not type in an IP Address
                }
            }
        }

        private void tmPing_Tick(object sender, EventArgs e)
        {
           foreach(ListViewItem item in lstIPAddress.Items) //you are referencing the items with the .items
           {
              PingReply reply = Ping(item.Text, 1000);
               //foreach is taking each item in the list and runs the whole forloop on each item or row of the list
               //item.text is the ip address or string that we stored in the popup box and stored on collumn 1 of the table
               //the ping function takes in the string with a timeout of 1000 ms.
               //returns the result of the ping and stores it in "reply"
              string txtResults;
               
               if (reply == null)
              {
                  txtResults = "Failed";
              }
              //The reason why we have this if statement here is because if you do not enter in an IP address, the application crashes.
              else
              {
                  txtResults = reply.Status.ToString();
              }

               ListViewItem.ListViewSubItem subItemstatus = item.SubItems[1];
               subItemstatus.Text = txtResults;
           }


           
        }

        private void cbEnablePing_CheckedChanged(object sender, EventArgs e)
        {
            tmPing.Enabled = cbEnablePing.Checked;
        }

        private static ListViewItem CreateListViewItem(string ipParameter)
        {
            ListViewItem item_ipParameter = new ListViewItem();
            item_ipParameter.Text=ipParameter;
            //item_ipParameter  is the entry in the IP Address field in column 0 or the first one
            
            
            ListViewItem.ListViewSubItem subItemStatus = new ListViewItem.ListViewSubItem();
            //subItemStatus is the status that comes up on the column 1 or the 2nd one
            subItemStatus.Text = "";
            item_ipParameter.SubItems.Add(subItemStatus);

            return item_ipParameter;
        }

        private void btnIPAddress_Click(object sender, EventArgs e)
        {
            string ipAddress;

            using(IPAdd ipAddressForm = new IPAdd())
            {
                DialogResult pickles = ipAddressForm.ShowDialog();
                if(pickles != DialogResult.OK)
                {
                    return;
                }
                ipAddress = ipAddressForm.IPAdder;
            }
            ListViewItem newIPitem = CreateListViewItem(ipAddress);
            lstIPAddress.Items.Add(newIPitem);

        }

        private void LoadIPAddresses(string[] loadIPAddresses)
        {
            lstIPAddress.Items.Clear();

            //Settings.Default.PingSettings PingSettings is actually what we named the first application setting field 
            foreach (string ipAddress in loadIPAddresses)
            //foreach is used because its an array
            {
                ListViewItem ipAddrssItem = CreateListViewItem(ipAddress);
                lstIPAddress.Items.Add(ipAddrssItem);
            }
        }

        private string[] GetIPAddrss()
        {
            string[] ipAddrsses = new string[lstIPAddress.Items.Count];
            for(int ipAddrssIndex= 0; ipAddrssIndex < lstIPAddress.Items.Count; ipAddrssIndex++ )
            //for loop...takes variable ipAddrssIndex and starts at the first value which is 0
            //ipAddrssIndex is less than lstIPAddress.Items.Count then just increase the count by 1 and move up to the next value
            {
               ipAddrsses[ipAddrssIndex] = lstIPAddress.Items[ipAddrssIndex].Text;
                
            }
            return ipAddrsses;
            //here we are referencing the ipAddrsses Array, we don't need the [] because we are returning
            //the whole array the brackets [4] just return one entry in this case the 5th entry     
        
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           if(Settings.Default.PingSettings == null)
            {
                return;
            }
            LoadIPAddresses(Settings.Default.PingSettings);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.PingSettings = GetIPAddrss();
            Settings.Default.Save();
        }
    }
}
