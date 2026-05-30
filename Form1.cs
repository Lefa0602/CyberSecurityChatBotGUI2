using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CyberSecurityChatbotGUI_2
{
    
    public partial class Form1 : Form
    {
        string userName = "";
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Stores and formats user input
            string userInput = txtInput.Text.ToLower().Trim();
            


            // Show user message
            txtChat.AppendText("You: " + userInput + "\n");

            string response = "";
            // Memory feature: store user name
            if (userInput.Contains("my name is"))
            {
                userName = userInput.Replace("my name is", "").Trim();
                response = "Nice to meet you " + userName;
            }
            else if (userInput.Contains("hello"))
            {
                // CyberSecurity awareness responses
                if (userName != "")
                {
                    response = "Welcome back " + userName;
                }
                else
                {
                    response = "Hello! What is your name?";
                }
            }
            // Sentiment detection responses
            else if (userInput.Contains("worried"))
            {
                response = "It's okay to feel worried. Staying informed helps you stay safe online.";
            }
            else if (userInput.Contains("scared"))
            {
                response = "Cyber threats can be scary, but being cautious and informed is the best protection.";
            }
            else if (userInput.Contains("curious"))
            {
                response = "Curiosity is great! Learning about cybersecurity helps protect you online.";
            }
            else if (userInput.Contains("phishing"))
            {
                int choice = random.Next(3);
                if (choice == 0)
                {
                    response = "Phishing is a scam where attackers trick you into giving personal information.";
                }
                else if (choice == 1)
                {
                    response = "Be careful of suspicious emails and fake websites pretending to be trusted companies.";
                }
                else
                {
                    response = "Never click unkown links or share passwords through suspicious messages.";
                }
            }
            else if (userInput.Contains("password"))
            {
                response = "Use strong passwords with letters, numbers, and symbols.";
            }
            else if (userInput.Contains("scam"))
            {
                response = "Online scams try to trick people into sending money or personal information.";
            }
            else if (userInput.Contains("link"))
            {
                response = "Avoid clicking suspicious links.";
            }
            else
            {
                response = "I don't understand. Try asking about cybersecurity.";
            }
                

            txtChat.AppendText("Bot: " + response + "\n\n");

            // Show bot response
            txtChat.AppendText("Bot: " + response + "\n\n");

            // Clear input
            txtInput.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtChat.AppendText("====================================\n");
            txtChat.AppendText(" CYBERSECURITY AWARENESS BOT\n");
            txtChat.AppendText("====================================\n\n");

            txtChat.AppendText("Bot: Welcome! Ask me about cybersecurity.\n\n");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
