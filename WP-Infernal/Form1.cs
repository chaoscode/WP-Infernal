using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_Infernal.Managers.Helper;
using WP_Infernal.Managers.WP;
using WP_Infernal.Models.REST;
using WP_Infernal.Models.WP;

namespace WP_Infernal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //HelperClass HlpMgr = new HelperClass();
            //treeView1.Nodes.Add(HlpMgr.testNode());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Create WP manager
            WPAPIManager WPMgr = new WPAPIManager(WebsiteBox.Text);

            // Get API data
            WPAPI APIList = WPMgr.getAPIdata();

            // Check for error
            if (APIList.restError.success == true)
                {
                // Output site information
                nameLabel.Text = "Name: " + APIList.name;
                homeLabel.Text = "Home URL: " + APIList.home;
                descriptionLabel.Text = "Site Description: " + APIList.description;

                // Display endpoints
                foreach (KeyValuePair<string, Route> ns in APIList.routes)
                {
                    // Fill in basic info screen
                    MainView.Nodes.Add(ns.Key);
                    MainView.SelectedNode = MainView.Nodes[MainView.GetNodeCount(false) - 1];

                    // Methods
                    if (ns.Value.methods != null)
                    {
                        foreach (string method in ns.Value.methods)
                        {
                            CallRestOutput testResponse = WPMgr.testEndPoint(ns.Key, method);

                            if (testResponse.statuscode == "OK")
                            {
                                // Green for 200, Red for anything else
                                MainView.SelectedNode.Nodes.Add(method).BackColor = Color.Green;
                            } else
                            {
                                // Green for 200, Red for anything else
                                MainView.SelectedNode.Nodes.Add(method).BackColor = Color.Red;
                            }
                            
                            
                        }
                    }

                    // LINKS
                    //if (ns.Value._links != null)
                    //{
                    //foreach (Self link in ns.Value._links.self)
                    //{
                    //MainView.SelectedNode.Nodes.Add(link.href);
                    //}
                    //}

                }
            }
            else
            {
                MessageBox.Show("Error: " + APIList.restError.error);
            }
        }
    }
}
