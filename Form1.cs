using System;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private UserRepository userRepository;
    private RsaService rsaService;

    public MainForm()
    {
        InitializeComponent();

        string connString = "Server=localhost;Database=DigitalSignatureDB;Uid=root;Pwd=ilovecheesecake_13;";
        userRepository = new UserRepository(connString);
        rsaService = new RsaService();
    }

    private void btnGenerateKeys_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;

        // Generate keys
        var (privateKey, publicKey) = rsaService.GenerateKeys();

        // Store public key in the database
        userRepository.StorePublicKey(username, publicKey);

        txtPrivateKey.Text = privateKey;
        txtPublicKey.Text = publicKey;

        MessageBox.Show("Keys generated and public key stored.");
    }

    private void btnSignMessage_Click(object sender, EventArgs e)
    {
        string privateKey = txtPrivateKey.Text;
        string message = txtMessage.Text;

        // Sign the message
        string signature = rsaService.SignData(privateKey, message);

        txtSignature.Text = signature;

        MessageBox.Show("Message signed.");
    }

    private void btnVerifySignature_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string message = txtMessage.Text;
        string signature = txtSignature.Text;

        // Retrieve the public key from the database
        string publicKey = userRepository.RetrievePublicKey(username);

        // Verify the signature
        bool isVerified = rsaService.VerifySignature(publicKey, message, signature);

        lblResult.Text = "Signature Verified: " + isVerified;
    }
}
