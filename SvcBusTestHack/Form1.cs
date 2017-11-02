using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace SvcBusTestHack
{
    public partial class Form1 : Form
    {

        //static string connectionString = "Endpoint=sb://sbnshackathon.servicebus.windows.net/;SharedAccessKeyName=sapSbnsHackQ;SharedAccessKey=DARLR3rzJ4+aTAjQ3AfhWOiVuhnDtZ7EMhkOnGQFoN4=;EntityPath=sbnshackathonqueue";
        public string connectionString = "Endpoint=sb://sbnshackathon.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=75K9GfshzaewfXxODMI9Usk4by3Y/h+qyPOk3/FkWls=";
        public string queueName = "sbnshackathonqueue";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            //var message = new BrokeredMessage("This is a test message!");

            List<StudentInfo> stud = new List<StudentInfo> {
                new StudentInfo { StudentID = Convert.ToInt16(txtStudID.Text), FirstName = txtFn.Text,LastName = txtLn.Text,Sex = Convert.ToChar(txtSex.Text),Address = txtAddress.Text,SchoolName = txtAddress.Text}
            };

            var json = JsonConvert.SerializeObject(new
            {
                StudentInformation = stud
            });

            var message = new BrokeredMessage(json);

            client.Send(message);

            client.Close();

            MessageBox.Show("Sent");

        }

        private void txtFillGrid_Click(object sender, EventArgs e)
        {
            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);

            client.OnMessage(msg => ProcessMessage(msg));
            
            client.Close();
            MessageBox.Show("Rcvd");
        }

        private void ProcessMessage(BrokeredMessage msg)
        {
            var text = msg.GetBody<String>();
        }
    }

    public partial class StudentInfo
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Sex { get; set; }
        public string Address { get; set; }
        public string SchoolName { get; set; }

    }

}
