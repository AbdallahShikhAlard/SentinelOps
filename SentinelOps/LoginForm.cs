using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentinelOps
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // ── Connect button clicked ────────────────────────────────────────────
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            string serverUrl = txtServerUrl.Text.Trim();
            string clientId = txtClientId.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(serverUrl) || string.IsNullOrEmpty(clientId))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show loading state
            btnConnect.Enabled = false;
            btnConnect.Text = "Connecting...";
            lblStatus.Text = "Testing connection...";
            lblStatus.ForeColor = System.Drawing.Color.Orange;

            //bool connected = await TestConnectionAsync(serverUrl);
            bool connected = true;


            if (connected)
            {
                // Save settings for this session
                AppSession.ServerUrl = serverUrl;
                AppSession.ClientId = clientId;

                // Open main form and close login
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                lblStatus.Text = "Could not reach the server. Check the URL.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                btnConnect.Enabled = true;
                btnConnect.Text = "Connect";
            }
        }

        // ── Ping the backend /health endpoint ────────────────────────────────
        private async Task<bool> TestConnectionAsync(string serverUrl)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(5);

                HttpResponseMessage response =
                    await client.GetAsync(serverUrl.TrimEnd('/') + "/health");

                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}