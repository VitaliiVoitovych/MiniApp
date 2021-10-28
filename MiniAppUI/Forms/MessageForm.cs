namespace MiniAppUI.Forms
{
    public partial class MessageForm : EntityBaseForm
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(string text, string caption) : this()
        {
            titleLbl.Text = caption;
            mainTextLbl.Text = text;
        }
    }
}
