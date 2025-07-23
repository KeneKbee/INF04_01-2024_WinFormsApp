namespace Egzamin
{
    partial class Passports
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passports));
            numberLabel = new Label();
            numberTextBox = new TextBox();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            surnameTextBox = new TextBox();
            surnameLabel = new Label();
            eyeColorGroupBox = new GroupBox();
            beerEyesRadio = new RadioButton();
            greenEyesRadio = new RadioButton();
            blueEyesRadio = new RadioButton();
            picturePictureBox = new PictureBox();
            fingerprintPictureBox = new PictureBox();
            submitButton = new Button();
            eyeColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fingerprintPictureBox).BeginInit();
            SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Microsoft Sans Serif", 9F);
            numberLabel.Location = new Point(36, 39);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(45, 15);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "Numer";
            // 
            // numberTextBox
            // 
            numberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numberTextBox.BackColor = Color.Azure;
            numberTextBox.Font = new Font("Microsoft Sans Serif", 9F);
            numberTextBox.Location = new Point(136, 33);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(197, 21);
            numberTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = Color.Azure;
            nameTextBox.Font = new Font("Microsoft Sans Serif", 9F);
            nameTextBox.Location = new Point(136, 68);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(197, 21);
            nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft Sans Serif", 9F);
            nameLabel.Location = new Point(36, 74);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(31, 15);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Imię";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            surnameTextBox.BackColor = Color.Azure;
            surnameTextBox.Font = new Font("Microsoft Sans Serif", 9F);
            surnameTextBox.Location = new Point(136, 101);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(197, 21);
            surnameTextBox.TabIndex = 5;
            // 
            // surnameLabel
            // 
            surnameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Microsoft Sans Serif", 9F);
            surnameLabel.Location = new Point(36, 107);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(60, 15);
            surnameLabel.TabIndex = 4;
            surnameLabel.Text = "Nazwisko";
            // 
            // eyeColorGroupBox
            // 
            eyeColorGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eyeColorGroupBox.Controls.Add(beerEyesRadio);
            eyeColorGroupBox.Controls.Add(greenEyesRadio);
            eyeColorGroupBox.Controls.Add(blueEyesRadio);
            eyeColorGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            eyeColorGroupBox.Location = new Point(36, 162);
            eyeColorGroupBox.Name = "eyeColorGroupBox";
            eyeColorGroupBox.Size = new Size(297, 111);
            eyeColorGroupBox.TabIndex = 6;
            eyeColorGroupBox.TabStop = false;
            eyeColorGroupBox.Text = "Kolor oczu";
            // 
            // beerEyesRadio
            // 
            beerEyesRadio.AutoSize = true;
            beerEyesRadio.Location = new Point(24, 72);
            beerEyesRadio.Name = "beerEyesRadio";
            beerEyesRadio.Size = new Size(57, 19);
            beerEyesRadio.TabIndex = 2;
            beerEyesRadio.Text = "piwne";
            beerEyesRadio.UseVisualStyleBackColor = true;
            // 
            // greenEyesRadio
            // 
            greenEyesRadio.AutoSize = true;
            greenEyesRadio.Location = new Point(24, 47);
            greenEyesRadio.Name = "greenEyesRadio";
            greenEyesRadio.Size = new Size(62, 19);
            greenEyesRadio.TabIndex = 1;
            greenEyesRadio.Text = "zielone";
            greenEyesRadio.UseVisualStyleBackColor = true;
            // 
            // blueEyesRadio
            // 
            blueEyesRadio.AutoSize = true;
            blueEyesRadio.Checked = true;
            blueEyesRadio.Location = new Point(24, 22);
            blueEyesRadio.Name = "blueEyesRadio";
            blueEyesRadio.Size = new Size(77, 19);
            blueEyesRadio.TabIndex = 0;
            blueEyesRadio.TabStop = true;
            blueEyesRadio.Text = "niebieskie";
            blueEyesRadio.UseVisualStyleBackColor = true;
            // 
            // picturePictureBox
            // 
            picturePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picturePictureBox.BackgroundImage = (Image)resources.GetObject("picturePictureBox.BackgroundImage");
            picturePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            picturePictureBox.InitialImage = null;
            picturePictureBox.Location = new Point(381, 33);
            picturePictureBox.Name = "picturePictureBox";
            picturePictureBox.Size = new Size(180, 210);
            picturePictureBox.TabIndex = 7;
            picturePictureBox.TabStop = false;
            // 
            // fingerprintPictureBox
            // 
            fingerprintPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fingerprintPictureBox.BackgroundImage = (Image)resources.GetObject("fingerprintPictureBox.BackgroundImage");
            fingerprintPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            fingerprintPictureBox.Location = new Point(601, 33);
            fingerprintPictureBox.Name = "fingerprintPictureBox";
            fingerprintPictureBox.Size = new Size(180, 210);
            fingerprintPictureBox.TabIndex = 8;
            fingerprintPictureBox.TabStop = false;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            submitButton.BackColor = Color.Azure;
            submitButton.Location = new Point(455, 264);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(244, 38);
            submitButton.TabIndex = 9;
            submitButton.Text = "OK";
            submitButton.UseVisualStyleBackColor = false;
            // 
            // Passports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(795, 314);
            Controls.Add(submitButton);
            Controls.Add(fingerprintPictureBox);
            Controls.Add(picturePictureBox);
            Controls.Add(eyeColorGroupBox);
            Controls.Add(surnameTextBox);
            Controls.Add(surnameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(numberTextBox);
            Controls.Add(numberLabel);
            Name = "Passports";
            Text = "Wprowadzenie danych do paszportu. Wykonał: 0000000000000";
            eyeColorGroupBox.ResumeLayout(false);
            eyeColorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fingerprintPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberLabel;
        private TextBox numberTextBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox surnameTextBox;
        private Label surnameLabel;
        private GroupBox eyeColorGroupBox;
        private PictureBox picturePictureBox;
        private PictureBox fingerprintPictureBox;
        private Button submitButton;
        private RadioButton beerEyesRadio;
        private RadioButton greenEyesRadio;
        private RadioButton blueEyesRadio;
    }
}
