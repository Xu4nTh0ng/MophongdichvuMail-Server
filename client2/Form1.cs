
using SmtpServer;
using SmtpServer.ComponentModel;
namespace client2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void send_button_Click(object sender, EventArgs e)
        {
            var options = new SmtpServerOptionsBuilder()
            .ServerName("localhost")
            .Port(25, 587)
            .Build();

            var serviceProvider = new ServiceProvider();
            serviceProvider.Add(new SampleMessageStore());
            serviceProvider.Add(new SampleUserAuthenticator());


            var smtpServer = new SmtpServer.SmtpServer(options, serviceProvider);
            await smtpServer.StartAsync(CancellationToken.None);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preview_richtextbox.Text = SampleMessageStore.message2.Subject;
        }
    }

}