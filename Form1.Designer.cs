partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.TextBox txtPrivateKey;
    private System.Windows.Forms.TextBox txtPublicKey;
    private System.Windows.Forms.TextBox txtSignature;
    private System.Windows.Forms.Button btnGenerateKeys;
    private System.Windows.Forms.Button btnSignMessage;
    private System.Windows.Forms.Button btnVerifySignature;
    private System.Windows.Forms.Label lblResult;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        txtUsername = new TextBox();
        txtMessage = new TextBox();
        txtPrivateKey = new TextBox();
        txtPublicKey = new TextBox();
        txtSignature = new TextBox();
        btnGenerateKeys = new Button();
        btnSignMessage = new Button();
        btnVerifySignature = new Button();
        lblResult = new Label();
        SuspendLayout();
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(44, 19);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(176, 23);
        txtUsername.TabIndex = 0;
        txtUsername.Text = "Username";
        // 
        // txtMessage
        // 
        txtMessage.Location = new Point(44, 56);
        txtMessage.Name = "txtMessage";
        txtMessage.Size = new Size(176, 23);
        txtMessage.TabIndex = 1;
        txtMessage.Text = "Message";
        // 
        // txtPrivateKey
        // 
        txtPrivateKey.Location = new Point(44, 94);
        txtPrivateKey.Multiline = true;
        txtPrivateKey.Name = "txtPrivateKey";
        txtPrivateKey.Size = new Size(350, 47);
        txtPrivateKey.TabIndex = 2;
        txtPrivateKey.Text = "Private Key";
        // 
        // txtPublicKey
        // 
        txtPublicKey.Location = new Point(44, 150);
        txtPublicKey.Multiline = true;
        txtPublicKey.Name = "txtPublicKey";
        txtPublicKey.Size = new Size(350, 47);
        txtPublicKey.TabIndex = 3;
        txtPublicKey.Text = "Public Key";
        // 
        // txtSignature
        // 
        txtSignature.Location = new Point(44, 206);
        txtSignature.Multiline = true;
        txtSignature.Name = "txtSignature";
        txtSignature.Size = new Size(350, 47);
        txtSignature.TabIndex = 4;
        txtSignature.Text = "Signature";
        // 
        // btnGenerateKeys
        // 
        btnGenerateKeys.BackColor = Color.FromArgb(255, 192, 128);
        btnGenerateKeys.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnGenerateKeys.ForeColor = SystemColors.ActiveCaptionText;
        btnGenerateKeys.Location = new Point(411, 19);
        btnGenerateKeys.Name = "btnGenerateKeys";
        btnGenerateKeys.Size = new Size(131, 22);
        btnGenerateKeys.TabIndex = 5;
        btnGenerateKeys.Text = "Generate Keys";
        btnGenerateKeys.UseVisualStyleBackColor = false;
        btnGenerateKeys.Click += btnGenerateKeys_Click;
        // 
        // btnSignMessage
        // 
        btnSignMessage.BackColor = Color.FromArgb(192, 192, 255);
        btnSignMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSignMessage.Location = new Point(411, 56);
        btnSignMessage.Name = "btnSignMessage";
        btnSignMessage.Size = new Size(131, 22);
        btnSignMessage.TabIndex = 6;
        btnSignMessage.Text = "Sign Message";
        btnSignMessage.UseVisualStyleBackColor = false;
        btnSignMessage.Click += btnSignMessage_Click;
        // 
        // btnVerifySignature
        // 
        btnVerifySignature.BackColor = Color.FromArgb(192, 255, 192);
        btnVerifySignature.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnVerifySignature.Location = new Point(411, 94);
        btnVerifySignature.Name = "btnVerifySignature";
        btnVerifySignature.Size = new Size(131, 22);
        btnVerifySignature.TabIndex = 7;
        btnVerifySignature.Text = "Verify Signature";
        btnVerifySignature.UseVisualStyleBackColor = false;
        btnVerifySignature.Click += btnVerifySignature_Click;
        // 
        // lblResult
        // 
        lblResult.Location = new Point(44, 262);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(350, 22);
        lblResult.TabIndex = 8;
        lblResult.Text = "Result";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(560, 300);
        Controls.Add(lblResult);
        Controls.Add(btnVerifySignature);
        Controls.Add(btnSignMessage);
        Controls.Add(btnGenerateKeys);
        Controls.Add(txtSignature);
        Controls.Add(txtPublicKey);
        Controls.Add(txtPrivateKey);
        Controls.Add(txtMessage);
        Controls.Add(txtUsername);
        DoubleBuffered = true;
        Name = "MainForm";
        Text = "Digital Signature Demo";
        ResumeLayout(false);
        PerformLayout();
    }
}
