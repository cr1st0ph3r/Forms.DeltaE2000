namespace Forms.DeltaE2000
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Color cA = System.Drawing.ColorTranslator.FromHtml("#fcba03");
            pnColor1.BackColor = cA;
            Color cB = System.Drawing.ColorTranslator.FromHtml("#ecbc20");
            pnColor2.BackColor = cB;

            var distance = Delta.DeltaE2000(cA,cB);

            txtResult.Text = "Distance: "+distance.ToString();

        }
 
        
      
    }
}