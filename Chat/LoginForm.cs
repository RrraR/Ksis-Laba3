using System;
using System.Windows.Forms;

namespace Chat;

public partial class LoginForm : Form
{
    string _userName = "";
    
    public string UserName
    {
        get { return _userName; }
    }
    public LoginForm()
    {
        InitializeComponent();
        //FormClosing += LoginForm_FormClosing;
        BntEnter.Click += BntEnter_Click;
    }

    private void BntEnter_Click(object sender, EventArgs e)
    {
        _userName = txtUsername.Text.Trim();
        if (string.IsNullOrEmpty(_userName))
        {
            MessageBox.Show("Please enter a username");
            return;
        }
        //FormClosing -= LoginForm_FormClosing;
        Close();
    }
    
}