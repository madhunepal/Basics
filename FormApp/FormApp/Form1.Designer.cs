namespace FormApp
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_click(object sender, EventArgs e)
        {
            int a = 15, b = 15;
            a = a - 5 * 10;
            MessageBox.Show(a.ToString());
        }

        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
        }

        #endregion
    }
}

