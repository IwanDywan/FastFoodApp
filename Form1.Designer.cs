
namespace Restauracja_Fast_Food
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonReserv = new System.Windows.Forms.Button();
            this.buttonContact = new System.Windows.Forms.Button();
            this.buttonDrinks = new System.Windows.Forms.Button();
            this.buttonFood = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelCloseApp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Maroon;
            this.panelLeft.Controls.Add(this.panelSlide);
            this.panelLeft.Controls.Add(this.buttonAbout);
            this.panelLeft.Controls.Add(this.buttonReserv);
            this.panelLeft.Controls.Add(this.buttonContact);
            this.panelLeft.Controls.Add(this.buttonDrinks);
            this.panelLeft.Controls.Add(this.buttonFood);
            this.panelLeft.Controls.Add(this.buttonHome);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 727);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.DarkOrange;
            this.panelSlide.Location = new System.Drawing.Point(3, 100);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 70);
            this.panelSlide.TabIndex = 7;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Red;
            this.buttonAbout.Location = new System.Drawing.Point(12, 480);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(188, 70);
            this.buttonAbout.TabIndex = 6;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonReserv
            // 
            this.buttonReserv.BackColor = System.Drawing.Color.Red;
            this.buttonReserv.Location = new System.Drawing.Point(12, 404);
            this.buttonReserv.Name = "buttonReserv";
            this.buttonReserv.Size = new System.Drawing.Size(188, 70);
            this.buttonReserv.TabIndex = 5;
            this.buttonReserv.Text = "Reservations";
            this.buttonReserv.UseVisualStyleBackColor = false;
            this.buttonReserv.Click += new System.EventHandler(this.buttonReserv_Click);
            // 
            // buttonContact
            // 
            this.buttonContact.BackColor = System.Drawing.Color.Red;
            this.buttonContact.Location = new System.Drawing.Point(12, 328);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Size = new System.Drawing.Size(188, 70);
            this.buttonContact.TabIndex = 4;
            this.buttonContact.Text = "Contact";
            this.buttonContact.UseVisualStyleBackColor = false;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
            // 
            // buttonDrinks
            // 
            this.buttonDrinks.BackColor = System.Drawing.Color.Red;
            this.buttonDrinks.Location = new System.Drawing.Point(12, 252);
            this.buttonDrinks.Name = "buttonDrinks";
            this.buttonDrinks.Size = new System.Drawing.Size(188, 70);
            this.buttonDrinks.TabIndex = 3;
            this.buttonDrinks.Text = "Drinks";
            this.buttonDrinks.UseVisualStyleBackColor = false;
            this.buttonDrinks.Click += new System.EventHandler(this.buttonDrinks_Click);
            // 
            // buttonFood
            // 
            this.buttonFood.BackColor = System.Drawing.Color.Red;
            this.buttonFood.Location = new System.Drawing.Point(12, 176);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(188, 70);
            this.buttonFood.TabIndex = 2;
            this.buttonFood.Text = "Food";
            this.buttonFood.UseVisualStyleBackColor = false;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Red;
            this.buttonHome.Location = new System.Drawing.Point(12, 100);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(188, 70);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(93, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fast";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTop.Controls.Add(this.labelCloseApp);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(200, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1133, 77);
            this.panelTop.TabIndex = 1;
            // 
            // labelCloseApp
            // 
            this.labelCloseApp.AutoSize = true;
            this.labelCloseApp.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCloseApp.Location = new System.Drawing.Point(1088, 20);
            this.labelCloseApp.Name = "labelCloseApp";
            this.labelCloseApp.Size = new System.Drawing.Size(33, 32);
            this.labelCloseApp.TabIndex = 0;
            this.labelCloseApp.Text = "X";
            this.labelCloseApp.Click += new System.EventHandler(this.labelCloseApp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(560, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(471, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fast";
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(200, 77);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1133, 650);
            this.panelCenter.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button buttonDrinks;
        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReserv;
        private System.Windows.Forms.Button buttonContact;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCloseApp;
        private System.Windows.Forms.Panel panelSlide;
    }
}

